/// ---------------------------------------------
/// Ultimate Character Controller
/// Copyright (c) Opsive. All Rights Reserved.
/// https://www.opsive.com
/// ---------------------------------------------

using UnityEngine;
using Opsive.UltimateCharacterController.Character;
using Opsive.UltimateCharacterController.Character.Abilities;
using Opsive.UltimateCharacterController.Events;
using Opsive.UltimateCharacterController.Game;
using Opsive.UltimateCharacterController.Input;
using Opsive.UltimateCharacterController.Utility;

namespace Opsive.UltimateCharacterController.AddOns.Swimming
{
    /// <summary>
    /// The Swim ability will allow the character to traverse through water and is activated on collision with water layer triggers.
    /// </summary>
    [DefaultAbilityIndex(301)]
    [DefaultUseRootMotionPosition(AbilityBoolOverride.True)]
    [DefaultObjectDetection(ObjectDetectionMode.Trigger)]
    [DefaultState("Swim")]
    public class Swim : DetectObjectAbilityBase
    {
        /// <summary>
        /// Specifies the method for detecting the water height.
        /// </summary>
        public enum WaterHeightDetection
        {
            Collider,   // Detect the water height based on the collider above the character.
            Custom      // A custom water height can be set with the SetWaterHeight method.
        };

        [Tooltip("The water depth that the character can start to swim at.")]
        [SerializeField] protected float m_StartSwimDepth = 1.6f;
        [Tooltip("The water depth that the character should swim and the surface at.")]
        [SerializeField] protected float m_SurfaceSwimDepth = 1.35f;
        [Tooltip("Modifies the default height that the character will swim on the surface at.")]
        [SerializeField] protected float m_SurfaceHeightAdjustment = 0f;
        [Tooltip("Can the character swim underwater?")]
        [SerializeField] protected bool m_CanSwimUnderwater = true;
        [Tooltip("Specifies the camera pitch that the character will transition from a surface swim to underwater swim.")]
        [SerializeField] protected float m_StartUnderwaterSwimPitch = 50f;
        [Tooltip("The minimum surface depth that the character can swim underwater.")]
        [SerializeField] protected float m_MinUnderwaterSwimDepth = 2f;
        [Tooltip("The button mapping to start swimming underwater. An empty value will prevent the mapping from being used.")]
        [SerializeField] protected string m_StartUnderwaterSwimName = "Action";
        [Tooltip("The amount of bouyancy that should be applied to the character while on the surface.")]
        [SerializeField] protected float m_SurfaceBuoyancyAmount = 0.05f;
        [Tooltip("The amount of bouyancy that should be applied to the character while underwater.")]
        [SerializeField] protected float m_UnderwaterBuoyancyAmount = 0.01f;
        [Tooltip("The percentage that the gravity force is retained each frame after the character enters the water.")]
        [Range(0, 1)] [SerializeField] protected float m_RetainedGravityAmount = 0.8f;
        [Tooltip("Set to 'Collider' to detected the water height based on the collider, 'Custom' for custom water heights")]
        [SerializeField] protected WaterHeightDetection m_WaterHeightDetectionMethod;
        [Tooltip("The breath attribute that should be modified when the character is underwater.")]
        [HideInInspector] [SerializeField] protected Traits.AttributeModifier m_BreathModifier = new Traits.AttributeModifier();
        [Tooltip("Effect that should play when the character enters the water from the air.")]
        [SerializeField] protected WaterEffectVelocity m_EntranceSplash;
        [Tooltip("Effect that should play when the character is swimming on the surface.")]
        [SerializeField] protected WaterEffectEventDistance[] m_SurfaceSwimSplash;
        [Tooltip("Effect that should play when the character is swimming underwater.")]
        [SerializeField] protected WaterEffect m_UnderwaterBubbles;
        [Tooltip("The state that should activate when the character is underwater.")]
        [SerializeField] protected string m_UnderwaterStateName = "Underwater";

        public float StartSwimDepth { get { return m_StartSwimDepth; } set { m_StartSwimDepth = value; } }
        public float SurfaceSwimDepth { get { return m_SurfaceSwimDepth; } set { m_SurfaceSwimDepth = value; } }
        public float SurfaceHeightAdjustment { get { return m_SurfaceHeightAdjustment; } set { m_SurfaceHeightAdjustment = value; } }
        public bool CanSwimUnderwater { get { return m_CanSwimUnderwater; } set { m_CanSwimUnderwater = value; } }
        public float StartUnderwaterSwimPitch { get { return m_StartUnderwaterSwimPitch; } set { m_StartUnderwaterSwimPitch = value; } }
        public float MinUnderwaterSwimDepth { get { return m_MinUnderwaterSwimDepth; } set { m_MinUnderwaterSwimDepth = value; } }
        public float SurfaceBuoyancyAmount { get { return m_SurfaceBuoyancyAmount; } set { m_SurfaceBuoyancyAmount = value; } }
        public float UnderwaterBuoyancyAmount { get { return m_UnderwaterBuoyancyAmount; } set { m_UnderwaterBuoyancyAmount = value; } }
        public float RetainedGravityAmount { get { return m_RetainedGravityAmount; } set { m_RetainedGravityAmount = value; } }
        public WaterHeightDetection WaterHeightDetectionMethod { get { return m_WaterHeightDetectionMethod; } set { m_WaterHeightDetectionMethod = value; } }
        public Traits.AttributeModifier BreathModifier { get { return m_BreathModifier; } set { m_BreathModifier = value; } }
        public string UnderwaterStateName { get { return m_UnderwaterStateName; } set { m_UnderwaterStateName = value; } }

        private UltimateCharacterLocomotionHandler m_Handler;
        private Transform m_Neck;
        private ActiveInputEvent m_UnderwaterSwimInput;
        private BoxCollider m_WaterCollider;

        private bool m_StartUseGravity;
        private bool m_StartStickToGround;
        private int m_DiveDeactivated;
        private float m_WaterSurfaceVerticalPosition;
        private float m_WaterDepth;
        private bool m_TransitionToUnderwaterSwim;

        /// <summary>
        /// Specifies the current swim state that the character is in.
        /// </summary>
        private enum SwimStates { 
            EnterWaterFromAir,  // The character entered the water from the air.
            SurfaceSwim,        // The character is swimming on the surface.
            UnderwaterSwim,     // The character is swimming underwater.
            ExitWaterMoving,    // The character is exiting the water while moving.
            ExitWaterIdle       // The character is exiting the water while idle.
        };
        private SwimStates m_SwimState;
        private SwimStates SwimState { get { return m_SwimState; }
            set {
                if (m_SwimState == value) {
                    return;
                }

                if (m_SwimState == SwimStates.UnderwaterSwim && !string.IsNullOrEmpty(m_UnderwaterStateName)) {
                    StateSystem.StateManager.SetState(m_GameObject, m_UnderwaterStateName, false);
                }

                m_SwimState = value;
                SetAbilityIntDataParameter((int)m_SwimState);
                if (m_SwimState == SwimStates.SurfaceSwim) {
                    EnableDisableBreathModifier(false);
                    if (m_UnderwaterBubbles != null) {
                        m_UnderwaterBubbles.Stop();
                    }
                } else if (m_SwimState == SwimStates.UnderwaterSwim) {
                    m_TransitionToUnderwaterSwim = true;
                    EnableDisableBreathModifier(true);
                    if (!string.IsNullOrEmpty(m_UnderwaterStateName)) {
                        StateSystem.StateManager.SetState(m_GameObject, m_UnderwaterStateName, true);
                    }
                } else if (m_SwimState == SwimStates.ExitWaterMoving || m_SwimState == SwimStates.ExitWaterIdle) {
                    m_CharacterLocomotion.UseGravity = m_StartUseGravity;
                    m_CharacterLocomotion.StickToGround = m_StartStickToGround;
                    if (m_SwimState == SwimStates.ExitWaterIdle && !string.IsNullOrEmpty(m_State)) {
                        // End the state early so the exit animation will use the correct collisions.
                        StateSystem.StateManager.SetState(m_GameObject, m_State, false);
                    }
                }
            }
        }

        public override int AbilityIntData { get { return (int)m_SwimState; } }
        public override float AbilityFloatData { get { return m_LookSource.Pitch * (m_CharacterLocomotion.RawInputVector.y >= 0 ? 1 : -1); } }
        public BoxCollider WaterCollider { get { return m_WaterCollider; } }

        /// <summary>
        /// Initialize the default values.
        /// </summary>
        public override void Awake()
        {
            base.Awake();

            var animator = m_GameObject.GetCachedComponent<Animator>();
            if (animator != null) {
                m_Neck = animator.GetBoneTransform(HumanBodyBones.Neck);
            }
            if (m_BreathModifier != null) {
                m_BreathModifier.Initialize(m_GameObject);
            }
            if (!string.IsNullOrEmpty(m_StartUnderwaterSwimName)) {
                m_Handler = m_GameObject.GetCachedComponent<UltimateCharacterLocomotionHandler>();
                if (m_Handler != null) {
                    m_UnderwaterSwimInput = ObjectPool.Get<ActiveInputEvent>();
                    m_UnderwaterSwimInput.Initialize(ActiveInputEvent.Type.ButtonDown, m_StartUnderwaterSwimName, "OnSwimAbilityStartUnderwaterSwimInput");
                    m_Handler.RegisterInputEvent(m_UnderwaterSwimInput);
                }
                EventHandler.RegisterEvent(m_GameObject, "OnSwimAbilityStartUnderwaterSwimInput", OnStartUnderwaterSwimInput);
            }

            // The underwater bubbles should continue to play until they are stopped.
            if (m_UnderwaterBubbles != null) {
                m_UnderwaterBubbles.Continuous = true;
            }

            EventHandler.RegisterEvent(m_GameObject, "OnAnimatorSwimEnteredWater", OnEnteredWater);
            EventHandler.RegisterEvent(m_GameObject, "OnAnimatorSwimStartMovingExit", OnStartMovingExit);
            EventHandler.RegisterEvent(m_GameObject, "OnAnimatorSwimExitedWater", OnExitedWater);
            EventHandler.RegisterEvent<Ability, bool>(m_GameObject, "OnCharacterAbilityActive", OnAbilityActive);

            if (m_SurfaceSwimSplash != null) {
                for (int i = 0; i < m_SurfaceSwimSplash.Length; ++i) {
                    m_SurfaceSwimSplash[i].Initialize(this);
                    EventHandler.RegisterEvent(m_GameObject, m_SurfaceSwimSplash[i].EventName, m_SurfaceSwimSplash[i].OnEvent);
                }
            }
        }

        /// <summary>
        /// Called when the ablity is tried to be started. If false is returned then the ability will not be started.
        /// </summary>
        /// <returns>True if the ability can be started.</returns>
        public override bool CanStartAbility()
        {
            if (!base.CanStartAbility() || m_DetectedTriggerObjectsCount == 0) {
                return false;
            }

            m_WaterCollider = m_DetectedTriggerObjects[0].GetCachedComponent<BoxCollider>();
            if (m_WaterCollider == null) {
                Debug.LogWarning("Unable to start the Swim ability. The water collider must have a box collider.");
                return false;
            }

            // The swim ability can start if the character is in deep enough water or is horizontal and is in shallow water. The latter case will happen
            // when the character dives in.
            float neckWaterDepth;
            var waterDepth = GetDepthInWater(false);
            return waterDepth >= m_StartSwimDepth || 
                    (!m_CharacterLocomotion.Grounded && waterDepth - (neckWaterDepth = GetDepthInWater(true)) < m_CharacterLocomotion.Radius && neckWaterDepth >= m_SurfaceSwimDepth);
        }

        /// <summary>
        /// Sets the local y value of the water position.
        /// </summary>
        /// <param name="verticalPosition">The vertical position to set the water surface level to.</param>
        public void SetWaterSurfacePosition(float verticalPosition)
        {
            m_WaterSurfaceVerticalPosition = verticalPosition;
        }

        /// <summary>
        /// The ability has started.
        /// </summary>
        protected override void AbilityStarted()
        {
            base.AbilityStarted();

            m_TransitionToUnderwaterSwim = false;
            if (m_CharacterLocomotion.Grounded) {
                SwimState = SwimStates.SurfaceSwim;
            } else if (GetDepthInWater(true) > m_SurfaceSwimDepth) {
                SwimState = SwimStates.UnderwaterSwim;
            } else {
                SwimState = SwimStates.EnterWaterFromAir;
            }

            // The character won't start to play a swimming animation until the water is at a specified depth.
            m_StartUseGravity = m_CharacterLocomotion.UseGravity;
            m_StartStickToGround = m_CharacterLocomotion.StickToGround;
            m_CharacterLocomotion.StickToGround = m_CharacterLocomotion.UseGravity = false;

            // Play a splashing animation if the character entered the water from the air. Do not play if the character is already underwater or the dive ability recently ended.
            if (m_SwimState != SwimStates.UnderwaterSwim && m_EntranceSplash != null && Mathf.Abs(m_CharacterLocomotion.LocalLocomotionVelocity.y) > m_EntranceSplash.MinVelocity &&
                GetDepthInWater(true) < m_StartSwimDepth && Time.frameCount > m_DiveDeactivated + 1) {
                m_EntranceSplash.Play(m_Transform.TransformPoint(new Vector3(0, GetDepthInWater(false) - m_CharacterLocomotion.SkinWidth, 0)));
            }
        }

        /// <summary>
        /// The character has entered the water from a fall.
        /// </summary>
        private void OnEnteredWater()
        {
            if (GetDepthInWater(true) > m_SurfaceSwimDepth) {
                SwimState = SwimStates.UnderwaterSwim;
            } else {
                SwimState = SwimStates.SurfaceSwim;
            }
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
        /// Enables or disables the breath modifier.
        /// </summary>
        /// <param name="enable">Should the breath modifier be enabled?</param>
        private void EnableDisableBreathModifier(bool enable)
        {
            if (m_BreathModifier != null) {
                m_BreathModifier.EnableModifier(enable);
            }
        }

        /// <summary>
        /// The character should start to swim underwater.
        /// </summary>
        private void OnStartUnderwaterSwimInput()
        {
            if (m_SwimState != SwimStates.SurfaceSwim) {
                return;
            }

            m_TransitionToUnderwaterSwim = true;
        }

        /// <summary>
        /// Updates the ability.
        /// </summary>
        public override void Update()
        {
            base.Update();

            // Prevent any input when the character is exiting.
            if (m_SwimState == SwimStates.ExitWaterMoving || m_SwimState == SwimStates.ExitWaterIdle) {
                m_CharacterLocomotion.InputVector = Vector3.zero;
                return;
            }

            m_WaterDepth = GetDepthInWater(false);
            // The character can exit the water while moving or while idle. When the character is moving the collider is more horizontal than vertical so the ground must be closer when the character
            // is idle versus moving. When the character is idle they will exit the swim ability when the character is able to stand on the surface.
            if (m_WaterDepth < m_SurfaceSwimDepth && m_CharacterLocomotion.Moving && m_CharacterLocomotion.Grounded && m_CharacterLocomotion.LocalVelocity.z > 0 &&
                Vector3.Angle(m_CharacterLocomotion.Up, m_CharacterLocomotion.GroundRaycastHit.normal) <= m_CharacterLocomotion.SlopeLimit + m_CharacterLocomotion.SlopeLimitSpacing &&
                Physics.Raycast(m_Transform.position + m_WaterDepth * m_CharacterLocomotion.Up, -m_CharacterLocomotion.Up, m_SurfaceSwimDepth + m_CharacterLocomotion.Radius - 
                (m_CharacterLocomotion.SkinWidth * 2) - m_CharacterLocomotion.ColliderSpacing, m_CharacterLayerManager.SolidObjectLayers, QueryTriggerInteraction.Ignore)) {
                SwimState = SwimStates.ExitWaterMoving;
            } else if (m_SwimState == SwimStates.SurfaceSwim && (!m_CharacterLocomotion.Moving || m_CharacterLocomotion.LocalVelocity.z < 0) && m_WaterDepth < m_StartSwimDepth && 
                                Physics.Raycast(m_Transform.position + m_WaterDepth * m_CharacterLocomotion.Up, -m_CharacterLocomotion.Up, m_StartSwimDepth, m_CharacterLayerManager.SolidObjectLayers, QueryTriggerInteraction.Ignore)) {
                SwimState = SwimStates.ExitWaterIdle;
            } else {
                // The character can swim underwater if the water is deep enough.
                if (m_SwimState != SwimStates.UnderwaterSwim) {
                    if (m_SwimState == SwimStates.SurfaceSwim && m_CanSwimUnderwater && (m_CharacterLocomotion.Moving && m_LookSource.Pitch > m_StartUnderwaterSwimPitch || m_TransitionToUnderwaterSwim)) {
                        // Don't swim underwater if there isn't enough room.
                        if (!m_CharacterLocomotion.SingleCast(-m_CharacterLocomotion.Up * m_MinUnderwaterSwimDepth, Vector3.zero, m_CharacterLayerManager.SolidObjectLayers, ref m_RaycastResult)) {
                            SwimState = SwimStates.UnderwaterSwim;
                        }
                    } else if (m_WaterDepth > m_MinUnderwaterSwimDepth) {
                        SwimState = SwimStates.UnderwaterSwim;
                    }
                }

                // Swim on the surface if the character is near the surface.
                if (m_TransitionToUnderwaterSwim && m_WaterDepth >= m_SurfaceSwimDepth) {
                    m_TransitionToUnderwaterSwim = false;
                    if (m_UnderwaterBubbles != null && !m_UnderwaterBubbles.IsPlaying) {
                        m_UnderwaterBubbles.Play();
                    }
                } else if (!m_TransitionToUnderwaterSwim && m_WaterDepth < m_SurfaceSwimDepth && m_SwimState != SwimStates.SurfaceSwim) {
                    SwimState = SwimStates.SurfaceSwim;
                }
            }
        }

        /// <summary>
        /// Returns the depth of the water.
        /// </summary>
        /// <param name="useNeck">Should the character's neck be used when determining the position?</param>
        /// <returns>The depth of the water.</returns>
        public float GetDepthInWater(bool useNeck)
        {
            return GetDepthInWater(useNeck ? m_Neck : m_Transform);
        }

        /// <summary>
        /// Returns the depth of the water.
        /// </summary>
        /// <param name="location">The location to get the depth of.</param>
        /// <returns>The depth of the water.</returns>
        public float GetDepthInWater(Transform location)
        {
            if (m_WaterCollider == null) {
                return 0;
            }

            if (m_WaterHeightDetectionMethod == WaterHeightDetection.Collider) {
                m_WaterSurfaceVerticalPosition = m_WaterCollider.transform.TransformPoint(m_WaterCollider.center + m_WaterCollider.size / 2).y;
            }

            return MathUtility.InverseTransformPoint(location.position, m_WaterCollider.transform.rotation, m_WaterSurfaceVerticalPosition * Vector3.up).y;
        }

        /// <summary>
        /// Update the ability's Animator parameters.
        /// </summary>
        public override void UpdateAnimator()
        {
            // The character will move underwater based on the float data. The character should move towards the camera when moving backwards.
            SetAbilityFloatDataParameter(AbilityFloatData);
        }

        /// <summary>
        /// Update the controller's position values.
        /// </summary>
        public override void UpdatePosition()
        {
            // Reduce the gravity when the character enters the water. This is a similar idea to the buoyancy force within the Swim ability.
            m_CharacterLocomotion.GravityAmount *= m_RetainedGravityAmount;

            m_CharacterLocomotion.AbilityMotor = Vector3.zero;
            if (m_SwimState == SwimStates.SurfaceSwim || m_SwimState == SwimStates.UnderwaterSwim) {
                ApplyBouyancy();
            }
        }

        /// <summary>
        /// Applies bouyancy to the character.
        /// </summary>
        private void ApplyBouyancy()
        {
            if (m_SwimState == SwimStates.SurfaceSwim) {
                // Move with the water surface. Move the character down immediately, but add a delta time for moving up to act as buoyancy.
                var adjustment = GetDepthInWater(true) + m_SurfaceHeightAdjustment;
                if (adjustment > 0) {
                    adjustment *= m_SurfaceBuoyancyAmount * m_CharacterLocomotion.TimeScale * Time.timeScale;
                }
                m_CharacterLocomotion.AbilityMotor = adjustment * m_CharacterLocomotion.Up;
            } else if (!m_CharacterLocomotion.Moving) {
                // Character is underwater - apply a slight buoyancy.
               m_CharacterLocomotion.AbilityMotor = m_UnderwaterBuoyancyAmount * m_CharacterLocomotion.TimeScale * Time.timeScale * m_CharacterLocomotion.Up;
            }
        }

        /// <summary>
        /// The character has exited a trigger.
        /// </summary>
        /// <param name="other">The trigger collider that the character exited.</param>
        public override void OnTriggerExit(Collider other)
        {
            base.OnTriggerExit(other);

            // Stop the ability when the character is no longer in a water trigger.
            if (other.gameObject.layer == Game.LayerManager.Water) {
                if (m_DetectedTriggerObjectsCount == 0) {
                    StopAbility();
                    return;
                }

                m_WaterCollider = m_DetectedTriggerObjects[0].GetCachedComponent<BoxCollider>();
                if (m_WaterCollider == null) {
                    StopAbility();
                    return;
                }
            }
        }

        /// <summary>
        /// The exit out animation has stopped the ability.
        /// </summary>
        private void OnStartMovingExit()
        {
             if (!string.IsNullOrEmpty(m_State)) {
                // End the state early so the exit animation will use the correct collisions.
                StateSystem.StateManager.SetState(m_GameObject, m_State, false);
            }
        }

        /// <summary>
        /// The exit out animation has stopped the ability.
        /// </summary>
        private void OnExitedWater()
        {
			StopAbility();
        }

        /// <summary>
        /// The ability has stopped running.
        /// </summary>
        /// <param name="force">Was the ability force stopped?</param>
        protected override void AbilityStopped(bool force)
        {
            m_WaterCollider = null;
            m_CharacterLocomotion.AbilityMotor = Vector3.zero;
            m_CharacterLocomotion.UseGravity = m_StartUseGravity;
            m_CharacterLocomotion.StickToGround = m_StartStickToGround;
            EnableDisableBreathModifier(false);
            if (m_UnderwaterBubbles != null) {
                m_UnderwaterBubbles.Stop();
            }
            if (!string.IsNullOrEmpty(m_UnderwaterStateName)) {
                StateSystem.StateManager.SetState(m_GameObject, m_UnderwaterStateName, false);
            }

            base.AbilityStopped(force);
        }

        /// <summary>
        /// The character's ability has been started or stopped.
        /// </summary>
        /// <param name="ability">The ability which was started or stopped.</param>
        /// <param name="active">True if the ability was started, false if it was stopped.</param>
        private void OnAbilityActive(Ability ability, bool active)
        {
            if (active || !(ability is Dive)) {
                return;
            }

            m_DiveDeactivated = Time.frameCount;
        }

        /// <summary>
        /// The character has been destroyed.
        /// </summary>
		public override void OnDestroy()
        {
            base.OnDestroy();

            if (m_UnderwaterSwimInput != null) {
                m_Handler.UnregisterInputEvent(m_UnderwaterSwimInput);
                ObjectPool.Return(m_UnderwaterSwimInput);
            }
            
            EventHandler.UnregisterEvent(m_GameObject, "OnAnimatorSwimEnteredWater", OnEnteredWater);
            EventHandler.UnregisterEvent(m_GameObject, "OnAnimatorSwimStartMovingExit", OnStartMovingExit);
            EventHandler.UnregisterEvent(m_GameObject, "OnAnimatorSwimExitedWater", OnExitedWater);
            EventHandler.UnregisterEvent(m_GameObject, "OnSwimAbilityStartUnderwaterSwimInput", OnStartUnderwaterSwimInput);

            if (m_SurfaceSwimSplash != null) {
                for (int i = 0; i < m_SurfaceSwimSplash.Length; ++i) {
                    EventHandler.UnregisterEvent(m_GameObject, m_SurfaceSwimSplash[i].EventName, m_SurfaceSwimSplash[i].OnEvent);
                }
            }
        }
    }
}
