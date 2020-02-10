/// ---------------------------------------------
/// Ultimate Character Controller
/// Copyright (c) Opsive. All Rights Reserved.
/// https://www.opsive.com
/// ---------------------------------------------

using UnityEngine;
using Opsive.UltimateCharacterController.Character.Abilities;
using Opsive.UltimateCharacterController.Events;

namespace Opsive.UltimateCharacterController.AddOns.Swimming
{
    /// <summary>
    /// The Climb From Water ability allows the character to climb out of the water onto a horizontal platform.
    /// </summary>
    [DefaultAbilityIndex(303)]
    [DefaultStartType(AbilityStartType.ButtonDown)]
    [DefaultInputName("Jump")]
    [DefaultAllowRotationalInput(false)]
    [DefaultAllowPositionalInput(false)]
    [DefaultUseRootMotionPosition(AbilityBoolOverride.True)]
    [DefaultDetectHorizontalCollisions(AbilityBoolOverride.False)]
    [DefaultDetectVerticalCollisions(AbilityBoolOverride.False)]
    [DefaultUseGravity(AbilityBoolOverride.False)]
    [DefaultUseLookDirection(false)]
    [DefaultCastOffset(0, 0, 0)]
    [DefaultEquippedSlots(0)]
    public class ClimbFromWater : DetectObjectAbilityBase
    {
        [Tooltip("The maximum water depth that the character can climb from.")]
        [SerializeField] protected float m_MaxWaterDepth = 0.25f;
        [Tooltip("The offset that the character should start climbing from.")]
        [SerializeField] protected Vector3 m_ClimbOffset = new Vector3(0, -1.6f, -0.25f);
        [Tooltip("The speed that the character should move towards the target when getting into position.")]
        [SerializeField] protected float m_MoveToPositionSpeed = 0.05f;

        public float MaxWaterDepth { get { return m_MaxWaterDepth; } set { m_MaxWaterDepth = value; } }
        public Vector3 ClimbOffset { get { return m_ClimbOffset; } set { m_ClimbOffset = value; } }
        public float MoveToPositionSpeed { get { return m_MoveToPositionSpeed; } set { m_MoveToPositionSpeed = value; } }

        private Swim m_SwimAbility;
        private Vector3 m_DetectedObjectNormal;
        private Vector3 m_TopClimbPosition;
        private bool m_InPosition;
        private bool m_Moving;

        public override int AbilityIntData { get { return m_Moving ? 1 : 0; } }

        /// <summary>
        /// Initialize the default values.
        /// </summary>
        public override void Awake()
        {
            base.Awake();

            m_SwimAbility = m_CharacterLocomotion.GetAbility<Swim>();
            if (m_SwimAbility == null) {
                Debug.LogError("Error: The Swim ability must be added in order for the character to be able to climb from the water.");
                Enabled = false;
                return;
            }

            EventHandler.RegisterEvent(m_GameObject, "OnAnimatorClimbComplete", OnClimbComplete);
        }

        /// <summary>
        /// Can the ability be started?
        /// </summary>
        /// <returns>True if the ability can be started.</returns>
        public override bool CanStartAbility()
        {
            if (!m_SwimAbility.IsActive || m_SwimAbility.GetDepthInWater(true) > m_MaxWaterDepth) {
                return false;
            }

            // An attribute may prevent the ability from starting.
            if (!base.CanStartAbility()) {
                return false;
            }

            return true;
        }

        /// <summary>
        /// The ability has started.
        /// </summary>
        protected override void AbilityStarted()
        {
            base.AbilityStarted();

            m_CharacterLocomotion.SingleCast(m_Transform.forward, Vector3.zero, m_CharacterLayerManager.SolidObjectLayers, ref m_RaycastResult);
            m_DetectedObjectNormal = Vector3.ProjectOnPlane(m_RaycastResult.normal, m_CharacterLocomotion.Up).normalized;

            // The character should be positioned relative to the top of the hit object.
            var closestPoint = m_RaycastResult.collider.ClosestPointOnBounds(m_Transform.position);
            var localClosestPoint = m_RaycastResult.transform.InverseTransformPoint(closestPoint);
            var localMaxBounds = m_RaycastResult.transform.InverseTransformPoint(m_RaycastResult.collider.bounds.max);
            localClosestPoint.y = localMaxBounds.y;
            m_TopClimbPosition = m_RaycastResult.transform.TransformPoint(localClosestPoint);

            m_InPosition = false;
            m_Moving = m_CharacterLocomotion.Moving;
        }

        /// <summary>
        /// Called when another ability is attempting to start and the current ability is active.
        /// Returns true or false depending on if the new ability should be blocked from starting.
        /// </summary>
        /// <param name="startingAbility">The ability that is starting.</param>
        /// <returns>True if the ability should be blocked.</returns>
        public override bool ShouldBlockAbilityStart(Ability startingAbility)
        {
            return startingAbility is HeightChange;
        }

        /// <summary>
        /// Called when the current ability is attempting to start and another ability is active.
        /// Returns true or false depending on if the active ability should be stopped.
        /// </summary>
        /// <param name="activeAbility">The ability that is currently active.</param>
        /// <returns>True if the ability should be stopped.</returns>
        public override bool ShouldStopActiveAbility(Ability activeAbility)
        {
            return activeAbility is HeightChange;
        }

        /// <summary>
        /// Update the controller's rotation values.
        /// </summary>
        public override void UpdateRotation()
        {
            // Keep the character facing the object that they are climbing out on.
            var localLookDirection = m_Transform.InverseTransformDirection(-m_DetectedObjectNormal);
            localLookDirection.y = 0;
            var deltaRotation = m_CharacterLocomotion.DeltaRotation;
            deltaRotation.y = Utility.MathUtility.ClampInnerAngle(Quaternion.LookRotation(localLookDirection.normalized, m_CharacterLocomotion.Up).eulerAngles.y);
            m_CharacterLocomotion.DeltaRotation = deltaRotation;
        }

        /// <summary>
        /// Update the controller's position values.
        /// </summary>
        public override void UpdatePosition()
        {
            if (m_InPosition) {
                return;
            }

            // Move the character into the starting position. The animation will put up as soon as the character is in position.
            var direction = Utility.MathUtility.TransformPoint(m_TopClimbPosition, m_Transform.rotation, m_ClimbOffset) - m_Transform.position;
            m_CharacterLocomotion.AbilityMotor = Vector3.MoveTowards(Vector3.zero, direction, m_MoveToPositionSpeed * m_CharacterLocomotion.TimeScale * Time.timeScale);

            if (direction.magnitude < 0.01f) {
                m_CharacterLocomotion.AbilityMotor = Vector3.zero;
                m_InPosition = true;
                m_CharacterLocomotion.UpdateAbilityAnimatorParameters();
            }
        }

        /// <summary>
        /// The climb animation has completed.
        /// </summary>
        private void OnClimbComplete()
        {
            StopAbility();
        }

        /// <summary>
        /// The ability has stopped running.
        /// </summary>
        /// <param name="force">Was the ability force stopped?</param>
        protected override void AbilityStopped(bool force)
        {
            base.AbilityStopped(force);

            m_CharacterLocomotion.AbilityMotor = Vector3.zero;
        }

        /// <summary>
        /// The character has been destroyed.
        /// </summary>
        public override void OnDestroy()
        {
            base.OnDestroy();

            EventHandler.UnregisterEvent(m_GameObject, "OnAnimatorClimbComplete", OnClimbComplete);
        }
    }
}