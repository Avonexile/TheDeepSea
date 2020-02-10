using UnityEngine;
using UnityEditor;
using UnityEditor.Animations;
using Opsive.UltimateCharacterController.Editor.Utility;

namespace Opsive.UltimateCharacterController.Editor.Inspectors.Character.Abilities
{
	/// <summary>
	/// Draws a custom inspector for the ClimbFromWater Ability.
	/// </summary>
	[InspectorDrawer(typeof(Opsive.UltimateCharacterController.AddOns.Swimming.ClimbFromWater))]
	public class ClimbFromWaterInspectorDrawer : AbilityInspectorDrawer
	{
		// ------------------------------------------- Start Generated Code -------------------------------------------
		// ------- Do NOT make any changes below. Changes will be removed when the animator is generated again. -------
		// ------------------------------------------------------------------------------------------------------------

		/// <summary>
		/// Returns true if the ability can build to the animator.
		/// </summary>
		public override bool CanBuildAnimator { get { return true; } }

		/// <summary>
		/// An editor only method which can add the abilities states/transitions to the animator.
		/// </summary>
		/// <param name="animatorController">The Animator Controller to add the states to.</param>
		/// <param name="firstPersonAnimatorController">The first person Animator Controller to add the states to.</param>
		public override void BuildAnimator(AnimatorController animatorController, AnimatorController firstPersonAnimatorController)
		{
			var baseStateMachine1092386802 = animatorController.layers[0].stateMachine;

			// The state machine should start fresh.
			for (int i = 0; i < animatorController.layers.Length; ++i) {
				for (int j = 0; j < baseStateMachine1092386802.stateMachines.Length; ++j) {
					if (baseStateMachine1092386802.stateMachines[j].stateMachine.name == "Climb From Water") {
						baseStateMachine1092386802.RemoveStateMachine(baseStateMachine1092386802.stateMachines[j].stateMachine);
						break;
					}
				}
			}

			// AnimationClip references.
			var swimClimbFromWaterMovingAnimationClip23588Path = AssetDatabase.GUIDToAssetPath("0a3989f9b05f2eb4e97f108cb17cf1c1"); 
			var swimClimbFromWaterMovingAnimationClip23588 = AnimatorBuilder.GetAnimationClip(swimClimbFromWaterMovingAnimationClip23588Path, "SwimClimbFromWaterMoving");
			var swimClimbFromWaterIdleAnimationClip23586Path = AssetDatabase.GUIDToAssetPath("0a3989f9b05f2eb4e97f108cb17cf1c1"); 
			var swimClimbFromWaterIdleAnimationClip23586 = AnimatorBuilder.GetAnimationClip(swimClimbFromWaterIdleAnimationClip23586Path, "SwimClimbFromWaterIdle");

			// State Machine.
			var climbFromWaterAnimatorStateMachine32754 = baseStateMachine1092386802.AddStateMachine("Climb From Water", new Vector3(624f, 12f, 0f));

			// States.
			var climbFromWaterMovingAnimatorState33590 = climbFromWaterAnimatorStateMachine32754.AddState("Climb From Water Moving", new Vector3(384f, 72f, 0f));
			climbFromWaterMovingAnimatorState33590.motion = swimClimbFromWaterMovingAnimationClip23588;
			climbFromWaterMovingAnimatorState33590.cycleOffset = 0f;
			climbFromWaterMovingAnimatorState33590.cycleOffsetParameterActive = false;
			climbFromWaterMovingAnimatorState33590.iKOnFeet = true;
			climbFromWaterMovingAnimatorState33590.mirror = false;
			climbFromWaterMovingAnimatorState33590.mirrorParameterActive = false;
			climbFromWaterMovingAnimatorState33590.speed = 2f;
			climbFromWaterMovingAnimatorState33590.speedParameterActive = false;
			climbFromWaterMovingAnimatorState33590.writeDefaultValues = true;

			var climbFromWaterIdleAnimatorState33592 = climbFromWaterAnimatorStateMachine32754.AddState("Climb From Water Idle", new Vector3(384f, 12f, 0f));
			climbFromWaterIdleAnimatorState33592.motion = swimClimbFromWaterIdleAnimationClip23586;
			climbFromWaterIdleAnimatorState33592.cycleOffset = 0f;
			climbFromWaterIdleAnimatorState33592.cycleOffsetParameterActive = false;
			climbFromWaterIdleAnimatorState33592.iKOnFeet = true;
			climbFromWaterIdleAnimatorState33592.mirror = false;
			climbFromWaterIdleAnimatorState33592.mirrorParameterActive = false;
			climbFromWaterIdleAnimatorState33592.speed = 2f;
			climbFromWaterIdleAnimatorState33592.speedParameterActive = false;
			climbFromWaterIdleAnimatorState33592.writeDefaultValues = true;

			// State Transitions.
			var animatorStateTransition34882 = climbFromWaterMovingAnimatorState33590.AddExitTransition();
			animatorStateTransition34882.canTransitionToSelf = true;
			animatorStateTransition34882.duration = 0.25f;
			animatorStateTransition34882.exitTime = 0.9f;
			animatorStateTransition34882.hasExitTime = false;
			animatorStateTransition34882.hasFixedDuration = true;
			animatorStateTransition34882.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition34882.offset = 0f;
			animatorStateTransition34882.orderedInterruption = true;
			animatorStateTransition34882.isExit = true;
			animatorStateTransition34882.mute = false;
			animatorStateTransition34882.solo = false;
			animatorStateTransition34882.AddCondition(AnimatorConditionMode.NotEqual, 303f, "AbilityIndex");

			var animatorStateTransition34884 = climbFromWaterIdleAnimatorState33592.AddExitTransition();
			animatorStateTransition34884.canTransitionToSelf = true;
			animatorStateTransition34884.duration = 0.25f;
			animatorStateTransition34884.exitTime = 0.9f;
			animatorStateTransition34884.hasExitTime = false;
			animatorStateTransition34884.hasFixedDuration = true;
			animatorStateTransition34884.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition34884.offset = 0f;
			animatorStateTransition34884.orderedInterruption = true;
			animatorStateTransition34884.isExit = true;
			animatorStateTransition34884.mute = false;
			animatorStateTransition34884.solo = false;
			animatorStateTransition34884.AddCondition(AnimatorConditionMode.NotEqual, 303f, "AbilityIndex");

			// State Machine Defaults.
			climbFromWaterAnimatorStateMachine32754.anyStatePosition = new Vector3(-96f, 36f, 0f);
			climbFromWaterAnimatorStateMachine32754.defaultState = climbFromWaterMovingAnimatorState33590;
			climbFromWaterAnimatorStateMachine32754.entryPosition = new Vector3(-96f, -36f, 0f);
			climbFromWaterAnimatorStateMachine32754.exitPosition = new Vector3(876f, 36f, 0f);
			climbFromWaterAnimatorStateMachine32754.parentStateMachinePosition = new Vector3(864f, -60f, 0f);


			// State Machine Transitions.
			var animatorStateTransition33300 = baseStateMachine1092386802.AddAnyStateTransition(climbFromWaterMovingAnimatorState33590);
			animatorStateTransition33300.canTransitionToSelf = false;
			animatorStateTransition33300.duration = 0.05f;
			animatorStateTransition33300.exitTime = 0.75f;
			animatorStateTransition33300.hasExitTime = false;
			animatorStateTransition33300.hasFixedDuration = true;
			animatorStateTransition33300.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition33300.offset = 0f;
			animatorStateTransition33300.orderedInterruption = true;
			animatorStateTransition33300.isExit = false;
			animatorStateTransition33300.mute = false;
			animatorStateTransition33300.solo = false;
			animatorStateTransition33300.AddCondition(AnimatorConditionMode.If, 0f, "AbilityChange");
			animatorStateTransition33300.AddCondition(AnimatorConditionMode.Equals, 303f, "AbilityIndex");
			animatorStateTransition33300.AddCondition(AnimatorConditionMode.Equals, 1f, "AbilityIntData");

			var animatorStateTransition33302 = baseStateMachine1092386802.AddAnyStateTransition(climbFromWaterIdleAnimatorState33592);
			animatorStateTransition33302.canTransitionToSelf = false;
			animatorStateTransition33302.duration = 0.05f;
			animatorStateTransition33302.exitTime = 0.75f;
			animatorStateTransition33302.hasExitTime = false;
			animatorStateTransition33302.hasFixedDuration = true;
			animatorStateTransition33302.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition33302.offset = 0f;
			animatorStateTransition33302.orderedInterruption = true;
			animatorStateTransition33302.isExit = false;
			animatorStateTransition33302.mute = false;
			animatorStateTransition33302.solo = false;
			animatorStateTransition33302.AddCondition(AnimatorConditionMode.If, 0f, "AbilityChange");
			animatorStateTransition33302.AddCondition(AnimatorConditionMode.Equals, 303f, "AbilityIndex");
			animatorStateTransition33302.AddCondition(AnimatorConditionMode.Equals, 0f, "AbilityIntData");
		}
	}
}
