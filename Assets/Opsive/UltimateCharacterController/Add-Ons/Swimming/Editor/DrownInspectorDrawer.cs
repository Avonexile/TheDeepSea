using UnityEngine;
using UnityEditor;
using UnityEditor.Animations;
using Opsive.UltimateCharacterController.Editor.Utility;

namespace Opsive.UltimateCharacterController.Editor.Inspectors.Character.Abilities
{
	/// <summary>
	/// Draws a custom inspector for the Drown Ability.
	/// </summary>
	[InspectorDrawer(typeof(Opsive.UltimateCharacterController.AddOns.Swimming.Drown))]
	public class DrownInspectorDrawer : AbilityInspectorDrawer
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
			var baseStateMachine1215070196 = animatorController.layers[0].stateMachine;

			// The state machine should start fresh.
			for (int i = 0; i < animatorController.layers.Length; ++i) {
				for (int j = 0; j < baseStateMachine1215070196.stateMachines.Length; ++j) {
					if (baseStateMachine1215070196.stateMachines[j].stateMachine.name == "Drown") {
						baseStateMachine1215070196.RemoveStateMachine(baseStateMachine1215070196.stateMachines[j].stateMachine);
						break;
					}
				}
			}

			// AnimationClip references.
			var drowningAnimationClip26832Path = AssetDatabase.GUIDToAssetPath("6e27b67dcdb0ced43a37b38895376787"); 
			var drowningAnimationClip26832 = AnimatorBuilder.GetAnimationClip(drowningAnimationClip26832Path, "Drowning");

			// State Machine.
			var drownAnimatorStateMachine32756 = baseStateMachine1215070196.AddStateMachine("Drown", new Vector3(624f, 156f, 0f));

			// States.
			var drownAnimatorState33586 = drownAnimatorStateMachine32756.AddState("Drown", new Vector3(413.599f, 57.65604f, 0f));
			drownAnimatorState33586.motion = drowningAnimationClip26832;
			drownAnimatorState33586.cycleOffset = 0f;
			drownAnimatorState33586.cycleOffsetParameterActive = false;
			drownAnimatorState33586.iKOnFeet = false;
			drownAnimatorState33586.mirror = false;
			drownAnimatorState33586.mirrorParameterActive = false;
			drownAnimatorState33586.speed = 1f;
			drownAnimatorState33586.speedParameterActive = false;
			drownAnimatorState33586.writeDefaultValues = true;

			// State Transitions.
			var animatorStateTransition34886 = drownAnimatorState33586.AddExitTransition();
			animatorStateTransition34886.canTransitionToSelf = true;
			animatorStateTransition34886.duration = 0.25f;
			animatorStateTransition34886.exitTime = 0.75f;
			animatorStateTransition34886.hasExitTime = false;
			animatorStateTransition34886.hasFixedDuration = true;
			animatorStateTransition34886.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition34886.offset = 0f;
			animatorStateTransition34886.orderedInterruption = true;
			animatorStateTransition34886.isExit = true;
			animatorStateTransition34886.mute = false;
			animatorStateTransition34886.solo = false;
			animatorStateTransition34886.AddCondition(AnimatorConditionMode.NotEqual, 304f, "AbilityIndex");

			// State Machine Defaults.
			drownAnimatorStateMachine32756.anyStatePosition = new Vector3(50f, 20f, 0f);
			drownAnimatorStateMachine32756.defaultState = drownAnimatorState33586;
			drownAnimatorStateMachine32756.entryPosition = new Vector3(50f, 120f, 0f);
			drownAnimatorStateMachine32756.exitPosition = new Vector3(800f, 120f, 0f);
			drownAnimatorStateMachine32756.parentStateMachinePosition = new Vector3(800f, 20f, 0f);


			// State Machine Transitions.
			var animatorStateTransition33296 = baseStateMachine1215070196.AddAnyStateTransition(drownAnimatorState33586);
			animatorStateTransition33296.canTransitionToSelf = true;
			animatorStateTransition33296.duration = 0.25f;
			animatorStateTransition33296.exitTime = 0.75f;
			animatorStateTransition33296.hasExitTime = false;
			animatorStateTransition33296.hasFixedDuration = true;
			animatorStateTransition33296.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition33296.offset = 0f;
			animatorStateTransition33296.orderedInterruption = true;
			animatorStateTransition33296.isExit = false;
			animatorStateTransition33296.mute = false;
			animatorStateTransition33296.solo = false;
			animatorStateTransition33296.AddCondition(AnimatorConditionMode.If, 0f, "AbilityChange");
			animatorStateTransition33296.AddCondition(AnimatorConditionMode.Equals, 304f, "AbilityIndex");
		}
	}
}
