using UnityEngine;
using UnityEditor;
using UnityEditor.Animations;
using Opsive.UltimateCharacterController.Editor.Utility;

namespace Opsive.UltimateCharacterController.Editor.Inspectors.Character.Abilities
{
	/// <summary>
	/// Draws a custom inspector for the Dive Ability.
	/// </summary>
	[InspectorDrawer(typeof(Opsive.UltimateCharacterController.AddOns.Swimming.Dive))]
	public class DiveInspectorDrawer : AbilityInspectorDrawer
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
			var baseStateMachine1306296304 = animatorController.layers[0].stateMachine;

			// The state machine should start fresh.
			for (int i = 0; i < animatorController.layers.Length; ++i) {
				for (int j = 0; j < baseStateMachine1306296304.stateMachines.Length; ++j) {
					if (baseStateMachine1306296304.stateMachines[j].stateMachine.name == "Dive") {
						baseStateMachine1306296304.RemoveStateMachine(baseStateMachine1306296304.stateMachines[j].stateMachine);
						break;
					}
				}
			}

			// AnimationClip references.
			var shallowDiveStartAnimationClip14732Path = AssetDatabase.GUIDToAssetPath("a4bd809109678b74d89a0d193252fdb5"); 
			var shallowDiveStartAnimationClip14732 = AnimatorBuilder.GetAnimationClip(shallowDiveStartAnimationClip14732Path, "ShallowDiveStart");
			var shallowDiveEnterWaterAnimationClip14728Path = AssetDatabase.GUIDToAssetPath("a4bd809109678b74d89a0d193252fdb5"); 
			var shallowDiveEnterWaterAnimationClip14728 = AnimatorBuilder.GetAnimationClip(shallowDiveEnterWaterAnimationClip14728Path, "ShallowDiveEnterWater");
			var shallowDiveEndAnimationClip14726Path = AssetDatabase.GUIDToAssetPath("a4bd809109678b74d89a0d193252fdb5"); 
			var shallowDiveEndAnimationClip14726 = AnimatorBuilder.GetAnimationClip(shallowDiveEndAnimationClip14726Path, "ShallowDiveEnd");
			var shallowDiveFallAnimationClip14730Path = AssetDatabase.GUIDToAssetPath("a4bd809109678b74d89a0d193252fdb5"); 
			var shallowDiveFallAnimationClip14730 = AnimatorBuilder.GetAnimationClip(shallowDiveFallAnimationClip14730Path, "ShallowDiveFall");
			var highDiveEndAnimationClip29498Path = AssetDatabase.GUIDToAssetPath("5203dd6ff2f0f4742a81f21778d48d5e"); 
			var highDiveEndAnimationClip29498 = AnimatorBuilder.GetAnimationClip(highDiveEndAnimationClip29498Path, "HighDiveEnd");
			var highDiveEnterWaterAnimationClip29500Path = AssetDatabase.GUIDToAssetPath("5203dd6ff2f0f4742a81f21778d48d5e"); 
			var highDiveEnterWaterAnimationClip29500 = AnimatorBuilder.GetAnimationClip(highDiveEnterWaterAnimationClip29500Path, "HighDiveEnterWater");
			var highDiveStartAnimationClip29504Path = AssetDatabase.GUIDToAssetPath("5203dd6ff2f0f4742a81f21778d48d5e"); 
			var highDiveStartAnimationClip29504 = AnimatorBuilder.GetAnimationClip(highDiveStartAnimationClip29504Path, "HighDiveStart");
			var highDiveFallAnimationClip29502Path = AssetDatabase.GUIDToAssetPath("5203dd6ff2f0f4742a81f21778d48d5e"); 
			var highDiveFallAnimationClip29502 = AnimatorBuilder.GetAnimationClip(highDiveFallAnimationClip29502Path, "HighDiveFall");

			// State Machine.
			var diveAnimatorStateMachine32752 = baseStateMachine1306296304.AddStateMachine("Dive", new Vector3(624f, 60f, 0f));

			// State Machine.
			var shallowDiveAnimatorStateMachine34846 = diveAnimatorStateMachine32752.AddStateMachine("Shallow Dive", new Vector3(384f, 0f, 0f));

			// States.
			var diveStartAnimatorState33580 = shallowDiveAnimatorStateMachine34846.AddState("Dive Start", new Vector3(504f, -168f, 0f));
			diveStartAnimatorState33580.motion = shallowDiveStartAnimationClip14732;
			diveStartAnimatorState33580.cycleOffset = 0f;
			diveStartAnimatorState33580.cycleOffsetParameterActive = false;
			diveStartAnimatorState33580.iKOnFeet = false;
			diveStartAnimatorState33580.mirror = false;
			diveStartAnimatorState33580.mirrorParameterActive = false;
			diveStartAnimatorState33580.speed = 3f;
			diveStartAnimatorState33580.speedParameterActive = false;
			diveStartAnimatorState33580.writeDefaultValues = true;

			var enterWaterAnimatorState34850 = shallowDiveAnimatorStateMachine34846.AddState("Enter Water", new Vector3(504f, 36f, 0f));
			enterWaterAnimatorState34850.motion = shallowDiveEnterWaterAnimationClip14728;
			enterWaterAnimatorState34850.cycleOffset = 0f;
			enterWaterAnimatorState34850.cycleOffsetParameterActive = false;
			enterWaterAnimatorState34850.iKOnFeet = false;
			enterWaterAnimatorState34850.mirror = false;
			enterWaterAnimatorState34850.mirrorParameterActive = false;
			enterWaterAnimatorState34850.speed = 1f;
			enterWaterAnimatorState34850.speedParameterActive = false;
			enterWaterAnimatorState34850.writeDefaultValues = true;

			var endAnimatorState34852 = shallowDiveAnimatorStateMachine34846.AddState("End", new Vector3(852f, 36f, 0f));
			endAnimatorState34852.motion = shallowDiveEndAnimationClip14726;
			endAnimatorState34852.cycleOffset = 0f;
			endAnimatorState34852.cycleOffsetParameterActive = false;
			endAnimatorState34852.iKOnFeet = false;
			endAnimatorState34852.mirror = false;
			endAnimatorState34852.mirrorParameterActive = false;
			endAnimatorState34852.speed = 0.5f;
			endAnimatorState34852.speedParameterActive = false;
			endAnimatorState34852.writeDefaultValues = true;

			var diveFallAnimatorState34854 = shallowDiveAnimatorStateMachine34846.AddState("Dive Fall", new Vector3(744f, -72f, 0f));
			diveFallAnimatorState34854.motion = shallowDiveFallAnimationClip14730;
			diveFallAnimatorState34854.cycleOffset = 0f;
			diveFallAnimatorState34854.cycleOffsetParameterActive = false;
			diveFallAnimatorState34854.iKOnFeet = false;
			diveFallAnimatorState34854.mirror = false;
			diveFallAnimatorState34854.mirrorParameterActive = false;
			diveFallAnimatorState34854.speed = 1f;
			diveFallAnimatorState34854.speedParameterActive = false;
			diveFallAnimatorState34854.writeDefaultValues = true;

			// State Transitions.
			var animatorStateTransition34856 = diveStartAnimatorState33580.AddTransition(enterWaterAnimatorState34850);
			animatorStateTransition34856.canTransitionToSelf = true;
			animatorStateTransition34856.duration = 0.25f;
			animatorStateTransition34856.exitTime = 0.8f;
			animatorStateTransition34856.hasExitTime = true;
			animatorStateTransition34856.hasFixedDuration = true;
			animatorStateTransition34856.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition34856.offset = 0f;
			animatorStateTransition34856.orderedInterruption = true;
			animatorStateTransition34856.isExit = false;
			animatorStateTransition34856.mute = false;
			animatorStateTransition34856.solo = false;
			animatorStateTransition34856.AddCondition(AnimatorConditionMode.Equals, 2f, "AbilityIntData");

			var animatorStateTransition34858 = diveStartAnimatorState33580.AddTransition(diveFallAnimatorState34854);
			animatorStateTransition34858.canTransitionToSelf = true;
			animatorStateTransition34858.duration = 0.25f;
			animatorStateTransition34858.exitTime = 0.8f;
			animatorStateTransition34858.hasExitTime = true;
			animatorStateTransition34858.hasFixedDuration = true;
			animatorStateTransition34858.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition34858.offset = 0f;
			animatorStateTransition34858.orderedInterruption = true;
			animatorStateTransition34858.isExit = false;
			animatorStateTransition34858.mute = false;
			animatorStateTransition34858.solo = false;
			animatorStateTransition34858.AddCondition(AnimatorConditionMode.NotEqual, 2f, "AbilityIntData");

			var animatorStateTransition34860 = enterWaterAnimatorState34850.AddTransition(endAnimatorState34852);
			animatorStateTransition34860.canTransitionToSelf = true;
			animatorStateTransition34860.duration = 0.05f;
			animatorStateTransition34860.exitTime = 0.9f;
			animatorStateTransition34860.hasExitTime = true;
			animatorStateTransition34860.hasFixedDuration = true;
			animatorStateTransition34860.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition34860.offset = 0f;
			animatorStateTransition34860.orderedInterruption = true;
			animatorStateTransition34860.isExit = false;
			animatorStateTransition34860.mute = false;
			animatorStateTransition34860.solo = false;

			var animatorStateTransition34862 = endAnimatorState34852.AddExitTransition();
			animatorStateTransition34862.canTransitionToSelf = true;
			animatorStateTransition34862.duration = 0.15f;
			animatorStateTransition34862.exitTime = 0.8f;
			animatorStateTransition34862.hasExitTime = true;
			animatorStateTransition34862.hasFixedDuration = true;
			animatorStateTransition34862.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition34862.offset = 0f;
			animatorStateTransition34862.orderedInterruption = true;
			animatorStateTransition34862.isExit = true;
			animatorStateTransition34862.mute = false;
			animatorStateTransition34862.solo = false;
			animatorStateTransition34862.AddCondition(AnimatorConditionMode.NotEqual, 302f, "AbilityIndex");

			var animatorStateTransition34864 = diveFallAnimatorState34854.AddTransition(enterWaterAnimatorState34850);
			animatorStateTransition34864.canTransitionToSelf = true;
			animatorStateTransition34864.duration = 0.015f;
			animatorStateTransition34864.exitTime = 0.4000001f;
			animatorStateTransition34864.hasExitTime = false;
			animatorStateTransition34864.hasFixedDuration = true;
			animatorStateTransition34864.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition34864.offset = 0f;
			animatorStateTransition34864.orderedInterruption = true;
			animatorStateTransition34864.isExit = false;
			animatorStateTransition34864.mute = false;
			animatorStateTransition34864.solo = false;
			animatorStateTransition34864.AddCondition(AnimatorConditionMode.Equals, 2f, "AbilityIntData");

			// State Machine Defaults.
			shallowDiveAnimatorStateMachine34846.anyStatePosition = new Vector3(36f, 48f, 0f);
			shallowDiveAnimatorStateMachine34846.defaultState = diveStartAnimatorState33580;
			shallowDiveAnimatorStateMachine34846.entryPosition = new Vector3(48f, -48f, 0f);
			shallowDiveAnimatorStateMachine34846.exitPosition = new Vector3(1116f, 48f, 0f);
			shallowDiveAnimatorStateMachine34846.parentStateMachinePosition = new Vector3(1104f, -48f, 0f);

			// State Machine.
			var highDiveAnimatorStateMachine34848 = diveAnimatorStateMachine32752.AddStateMachine("High Dive", new Vector3(384f, 72f, 0f));

			// States.
			var endAnimatorState34866 = highDiveAnimatorStateMachine34848.AddState("End", new Vector3(564f, 204f, 0f));
			endAnimatorState34866.motion = highDiveEndAnimationClip29498;
			endAnimatorState34866.cycleOffset = 0f;
			endAnimatorState34866.cycleOffsetParameterActive = false;
			endAnimatorState34866.iKOnFeet = false;
			endAnimatorState34866.mirror = false;
			endAnimatorState34866.mirrorParameterActive = false;
			endAnimatorState34866.speed = 0.5f;
			endAnimatorState34866.speedParameterActive = false;
			endAnimatorState34866.writeDefaultValues = true;

			var enterWaterAnimatorState34868 = highDiveAnimatorStateMachine34848.AddState("Enter Water", new Vector3(264f, 204f, 0f));
			enterWaterAnimatorState34868.motion = highDiveEnterWaterAnimationClip29500;
			enterWaterAnimatorState34868.cycleOffset = 0f;
			enterWaterAnimatorState34868.cycleOffsetParameterActive = false;
			enterWaterAnimatorState34868.iKOnFeet = false;
			enterWaterAnimatorState34868.mirror = false;
			enterWaterAnimatorState34868.mirrorParameterActive = false;
			enterWaterAnimatorState34868.speed = 1f;
			enterWaterAnimatorState34868.speedParameterActive = false;
			enterWaterAnimatorState34868.writeDefaultValues = true;

			var diveStartAnimatorState33582 = highDiveAnimatorStateMachine34848.AddState("Dive Start", new Vector3(264f, 0f, 0f));
			diveStartAnimatorState33582.motion = highDiveStartAnimationClip29504;
			diveStartAnimatorState33582.cycleOffset = 0f;
			diveStartAnimatorState33582.cycleOffsetParameterActive = false;
			diveStartAnimatorState33582.iKOnFeet = false;
			diveStartAnimatorState33582.mirror = false;
			diveStartAnimatorState33582.mirrorParameterActive = false;
			diveStartAnimatorState33582.speed = 3f;
			diveStartAnimatorState33582.speedParameterActive = false;
			diveStartAnimatorState33582.writeDefaultValues = true;

			var diveFallAnimatorState34870 = highDiveAnimatorStateMachine34848.AddState("Dive Fall", new Vector3(384f, 96f, 0f));
			diveFallAnimatorState34870.motion = highDiveFallAnimationClip29502;
			diveFallAnimatorState34870.cycleOffset = 0f;
			diveFallAnimatorState34870.cycleOffsetParameterActive = false;
			diveFallAnimatorState34870.iKOnFeet = false;
			diveFallAnimatorState34870.mirror = false;
			diveFallAnimatorState34870.mirrorParameterActive = false;
			diveFallAnimatorState34870.speed = 1f;
			diveFallAnimatorState34870.speedParameterActive = false;
			diveFallAnimatorState34870.writeDefaultValues = true;

			// State Transitions.
			var animatorStateTransition34872 = endAnimatorState34866.AddExitTransition();
			animatorStateTransition34872.canTransitionToSelf = true;
			animatorStateTransition34872.duration = 0.15f;
			animatorStateTransition34872.exitTime = 0.8f;
			animatorStateTransition34872.hasExitTime = false;
			animatorStateTransition34872.hasFixedDuration = true;
			animatorStateTransition34872.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition34872.offset = 0f;
			animatorStateTransition34872.orderedInterruption = true;
			animatorStateTransition34872.isExit = true;
			animatorStateTransition34872.mute = false;
			animatorStateTransition34872.solo = false;
			animatorStateTransition34872.AddCondition(AnimatorConditionMode.NotEqual, 302f, "AbilityIndex");

			var animatorStateTransition34874 = enterWaterAnimatorState34868.AddTransition(endAnimatorState34866);
			animatorStateTransition34874.canTransitionToSelf = true;
			animatorStateTransition34874.duration = 0.05f;
			animatorStateTransition34874.exitTime = 0.9f;
			animatorStateTransition34874.hasExitTime = true;
			animatorStateTransition34874.hasFixedDuration = true;
			animatorStateTransition34874.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition34874.offset = 0f;
			animatorStateTransition34874.orderedInterruption = true;
			animatorStateTransition34874.isExit = false;
			animatorStateTransition34874.mute = false;
			animatorStateTransition34874.solo = false;

			var animatorStateTransition34876 = diveStartAnimatorState33582.AddTransition(enterWaterAnimatorState34868);
			animatorStateTransition34876.canTransitionToSelf = true;
			animatorStateTransition34876.duration = 0.25f;
			animatorStateTransition34876.exitTime = 0.8f;
			animatorStateTransition34876.hasExitTime = true;
			animatorStateTransition34876.hasFixedDuration = true;
			animatorStateTransition34876.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition34876.offset = 0f;
			animatorStateTransition34876.orderedInterruption = true;
			animatorStateTransition34876.isExit = false;
			animatorStateTransition34876.mute = false;
			animatorStateTransition34876.solo = false;
			animatorStateTransition34876.AddCondition(AnimatorConditionMode.Equals, 2f, "AbilityIntData");

			var animatorStateTransition34878 = diveStartAnimatorState33582.AddTransition(diveFallAnimatorState34870);
			animatorStateTransition34878.canTransitionToSelf = true;
			animatorStateTransition34878.duration = 0.5f;
			animatorStateTransition34878.exitTime = 0.8f;
			animatorStateTransition34878.hasExitTime = true;
			animatorStateTransition34878.hasFixedDuration = true;
			animatorStateTransition34878.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition34878.offset = 0f;
			animatorStateTransition34878.orderedInterruption = true;
			animatorStateTransition34878.isExit = false;
			animatorStateTransition34878.mute = false;
			animatorStateTransition34878.solo = false;
			animatorStateTransition34878.AddCondition(AnimatorConditionMode.NotEqual, 2f, "AbilityIntData");

			var animatorStateTransition34880 = diveFallAnimatorState34870.AddTransition(enterWaterAnimatorState34868);
			animatorStateTransition34880.canTransitionToSelf = true;
			animatorStateTransition34880.duration = 0.015f;
			animatorStateTransition34880.exitTime = 0.75f;
			animatorStateTransition34880.hasExitTime = false;
			animatorStateTransition34880.hasFixedDuration = true;
			animatorStateTransition34880.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition34880.offset = 0f;
			animatorStateTransition34880.orderedInterruption = true;
			animatorStateTransition34880.isExit = false;
			animatorStateTransition34880.mute = false;
			animatorStateTransition34880.solo = false;
			animatorStateTransition34880.AddCondition(AnimatorConditionMode.Equals, 2f, "AbilityIntData");

			// State Machine Defaults.
			highDiveAnimatorStateMachine34848.anyStatePosition = new Vector3(36f, 168f, 0f);
			highDiveAnimatorStateMachine34848.defaultState = diveStartAnimatorState33582;
			highDiveAnimatorStateMachine34848.entryPosition = new Vector3(36f, 84f, 0f);
			highDiveAnimatorStateMachine34848.exitPosition = new Vector3(888f, 168f, 0f);
			highDiveAnimatorStateMachine34848.parentStateMachinePosition = new Vector3(864f, 108f, 0f);

			// State Machine Defaults.
			diveAnimatorStateMachine32752.anyStatePosition = new Vector3(50f, 20f, 0f);
			diveAnimatorStateMachine32752.defaultState = diveStartAnimatorState33580;
			diveAnimatorStateMachine32752.entryPosition = new Vector3(50f, 120f, 0f);
			diveAnimatorStateMachine32752.exitPosition = new Vector3(800f, 120f, 0f);
			diveAnimatorStateMachine32752.parentStateMachinePosition = new Vector3(800f, 20f, 0f);


			// State Machine Transitions.
			var animatorStateTransition33290 = baseStateMachine1306296304.AddAnyStateTransition(diveStartAnimatorState33580);
			animatorStateTransition33290.canTransitionToSelf = false;
			animatorStateTransition33290.duration = 0.15f;
			animatorStateTransition33290.exitTime = 0.75f;
			animatorStateTransition33290.hasExitTime = false;
			animatorStateTransition33290.hasFixedDuration = true;
			animatorStateTransition33290.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition33290.offset = 0f;
			animatorStateTransition33290.orderedInterruption = true;
			animatorStateTransition33290.isExit = false;
			animatorStateTransition33290.mute = false;
			animatorStateTransition33290.solo = false;
			animatorStateTransition33290.AddCondition(AnimatorConditionMode.If, 0f, "AbilityChange");
			animatorStateTransition33290.AddCondition(AnimatorConditionMode.Equals, 302f, "AbilityIndex");
			animatorStateTransition33290.AddCondition(AnimatorConditionMode.NotEqual, 1f, "AbilityIntData");
			animatorStateTransition33290.AddCondition(AnimatorConditionMode.IfNot, 0f, "Moving");

			var animatorStateTransition33292 = baseStateMachine1306296304.AddAnyStateTransition(diveStartAnimatorState33582);
			animatorStateTransition33292.canTransitionToSelf = false;
			animatorStateTransition33292.duration = 0.15f;
			animatorStateTransition33292.exitTime = 0.75f;
			animatorStateTransition33292.hasExitTime = false;
			animatorStateTransition33292.hasFixedDuration = true;
			animatorStateTransition33292.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition33292.offset = 0f;
			animatorStateTransition33292.orderedInterruption = true;
			animatorStateTransition33292.isExit = false;
			animatorStateTransition33292.mute = false;
			animatorStateTransition33292.solo = false;
			animatorStateTransition33292.AddCondition(AnimatorConditionMode.If, 0f, "AbilityChange");
			animatorStateTransition33292.AddCondition(AnimatorConditionMode.Equals, 302f, "AbilityIndex");
			animatorStateTransition33292.AddCondition(AnimatorConditionMode.Equals, 1f, "AbilityIntData");
			animatorStateTransition33292.AddCondition(AnimatorConditionMode.IfNot, 0f, "Moving");

			var animatorStateTransition33304 = baseStateMachine1306296304.AddAnyStateTransition(diveStartAnimatorState33582);
			animatorStateTransition33304.canTransitionToSelf = false;
			animatorStateTransition33304.duration = 0.1f;
			animatorStateTransition33304.exitTime = 0.75f;
			animatorStateTransition33304.hasExitTime = false;
			animatorStateTransition33304.hasFixedDuration = true;
			animatorStateTransition33304.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition33304.offset = 0.5f;
			animatorStateTransition33304.orderedInterruption = true;
			animatorStateTransition33304.isExit = false;
			animatorStateTransition33304.mute = false;
			animatorStateTransition33304.solo = false;
			animatorStateTransition33304.AddCondition(AnimatorConditionMode.If, 0f, "AbilityChange");
			animatorStateTransition33304.AddCondition(AnimatorConditionMode.Equals, 302f, "AbilityIndex");
			animatorStateTransition33304.AddCondition(AnimatorConditionMode.Equals, 1f, "AbilityIntData");
			animatorStateTransition33304.AddCondition(AnimatorConditionMode.If, 0f, "Moving");

			var animatorStateTransition33306 = baseStateMachine1306296304.AddAnyStateTransition(diveStartAnimatorState33580);
			animatorStateTransition33306.canTransitionToSelf = false;
			animatorStateTransition33306.duration = 0.15f;
			animatorStateTransition33306.exitTime = 0.75f;
			animatorStateTransition33306.hasExitTime = false;
			animatorStateTransition33306.hasFixedDuration = true;
			animatorStateTransition33306.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition33306.offset = 0.5f;
			animatorStateTransition33306.orderedInterruption = true;
			animatorStateTransition33306.isExit = false;
			animatorStateTransition33306.mute = false;
			animatorStateTransition33306.solo = false;
			animatorStateTransition33306.AddCondition(AnimatorConditionMode.If, 0f, "AbilityChange");
			animatorStateTransition33306.AddCondition(AnimatorConditionMode.Equals, 302f, "AbilityIndex");
			animatorStateTransition33306.AddCondition(AnimatorConditionMode.NotEqual, 1f, "AbilityIntData");
			animatorStateTransition33306.AddCondition(AnimatorConditionMode.If, 0f, "Moving");
		}
	}
}
