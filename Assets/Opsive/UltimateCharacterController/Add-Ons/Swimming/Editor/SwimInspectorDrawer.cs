using UnityEngine;
using UnityEditor;
using UnityEditor.Animations;
using Opsive.UltimateCharacterController.Editor.Utility;
using Opsive.UltimateCharacterController.Editor.Inspectors.Utility;
using Opsive.UltimateCharacterController.Traits;
using Opsive.UltimateCharacterController.AddOns.Swimming;

namespace Opsive.UltimateCharacterController.Editor.Inspectors.Character.Abilities
{
	/// <summary>
	/// Draws a custom inspector for the Swim Ability.
	/// </summary>
	[InspectorDrawer(typeof(Swim))]
	public class SwimInspectorDrawer : DetectObjectAbilityBaseInspectorDrawer
    {
        /// <summary>
        /// Draws the fields related to the inspector drawer.
        /// </summary>
        /// <param name="target">The object that is being drawn.</param>
        /// <param name="parent">The Unity Object that the object belongs to.</param>
        protected override void DrawInspectorDrawerFields(object target, Object parent)
        {
            base.DrawInspectorDrawerFields(target, parent);

            InspectorUtility.DrawAttributeModifier(parent, (parent as Component).GetComponent<AttributeManager>(), (target as Swim).BreathModifier, "Breath Attribute");
        }

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
			var baseStateMachine1333559278 = animatorController.layers[0].stateMachine;

			// The state machine should start fresh.
			for (int i = 0; i < animatorController.layers.Length; ++i) {
				for (int j = 0; j < baseStateMachine1333559278.stateMachines.Length; ++j) {
					if (baseStateMachine1333559278.stateMachines[j].stateMachine.name == "Swim") {
						baseStateMachine1333559278.RemoveStateMachine(baseStateMachine1333559278.stateMachines[j].stateMachine);
						break;
					}
				}
			}

			// AnimationClip references.
			var fallInWaterAnimationClip23146Path = AssetDatabase.GUIDToAssetPath("5417f5795beed3748a4a339e448541f9"); 
			var fallInWaterAnimationClip23146 = AnimatorBuilder.GetAnimationClip(fallInWaterAnimationClip23146Path, "FallInWater");
			var surfaceSwimIdleAnimationClip22104Path = AssetDatabase.GUIDToAssetPath("49a950985203bcd47b45a342dd66617e"); 
			var surfaceSwimIdleAnimationClip22104 = AnimatorBuilder.GetAnimationClip(surfaceSwimIdleAnimationClip22104Path, "SurfaceSwimIdle");
			var surfacePowerSwimBwdAnimationClip28798Path = AssetDatabase.GUIDToAssetPath("656232ee21ea0ff41abf60f04e64858c"); 
			var surfacePowerSwimBwdAnimationClip28798 = AnimatorBuilder.GetAnimationClip(surfacePowerSwimBwdAnimationClip28798Path, "SurfacePowerSwimBwd");
			var surfaceSwimBwdAnimationClip15316Path = AssetDatabase.GUIDToAssetPath("1c6fd722260a32f49b477f2ec339ab20"); 
			var surfaceSwimBwdAnimationClip15316 = AnimatorBuilder.GetAnimationClip(surfaceSwimBwdAnimationClip15316Path, "SurfaceSwimBwd");
			var surfacePowerSwimStrafeAnimationClip13776Path = AssetDatabase.GUIDToAssetPath("bb557eb0c7ebd964b9909d247bf877d3"); 
			var surfacePowerSwimStrafeAnimationClip13776 = AnimatorBuilder.GetAnimationClip(surfacePowerSwimStrafeAnimationClip13776Path, "SurfacePowerSwimStrafe");
			var surfaceSwimStrafeAnimationClip18612Path = AssetDatabase.GUIDToAssetPath("8469ba753dfb3ce4fabe0bab48e638d0"); 
			var surfaceSwimStrafeAnimationClip18612 = AnimatorBuilder.GetAnimationClip(surfaceSwimStrafeAnimationClip18612Path, "SurfaceSwimStrafe");
			var surfaceSwimFwdAnimationClip27484Path = AssetDatabase.GUIDToAssetPath("34888dbddbf44204cb7ce3d920c28fc6"); 
			var surfaceSwimFwdAnimationClip27484 = AnimatorBuilder.GetAnimationClip(surfaceSwimFwdAnimationClip27484Path, "SurfaceSwimFwd");
			var surfacePowerSwimFwdAnimationClip16378Path = AssetDatabase.GUIDToAssetPath("60ee98433976c904fa0f81f9698a3f57"); 
			var surfacePowerSwimFwdAnimationClip16378 = AnimatorBuilder.GetAnimationClip(surfacePowerSwimFwdAnimationClip16378Path, "SurfacePowerSwimFwd");
			var underwaterSwimBwdAnimationClip20512Path = AssetDatabase.GUIDToAssetPath("18ed38574f4ad754c911778975d2963b"); 
			var underwaterSwimBwdAnimationClip20512 = AnimatorBuilder.GetAnimationClip(underwaterSwimBwdAnimationClip20512Path, "UnderwaterSwimBwd");
			var underwaterKickStrafeAnimationClip14790Path = AssetDatabase.GUIDToAssetPath("44eb2f91ce4dd134ca5df47dad8e2128"); 
			var underwaterKickStrafeAnimationClip14790 = AnimatorBuilder.GetAnimationClip(underwaterKickStrafeAnimationClip14790Path, "UnderwaterKickStrafe");
			var underwaterStrokeStrafeAnimationClip21252Path = AssetDatabase.GUIDToAssetPath("1b3960f74d07e0342b8a63b4bb757ca4"); 
			var underwaterStrokeStrafeAnimationClip21252 = AnimatorBuilder.GetAnimationClip(underwaterStrokeStrafeAnimationClip21252Path, "UnderwaterStrokeStrafe");
			var underwaterIdleUpAnimationClip13724Path = AssetDatabase.GUIDToAssetPath("04bb0ea0103e9534d99025bd9c28c33e"); 
			var underwaterIdleUpAnimationClip13724 = AnimatorBuilder.GetAnimationClip(underwaterIdleUpAnimationClip13724Path, "UnderwaterIdleUp");
			var underwaterIdleFwdAnimationClip17982Path = AssetDatabase.GUIDToAssetPath("99c8c8d422f251a48b0dcdae23379ed3"); 
			var underwaterIdleFwdAnimationClip17982 = AnimatorBuilder.GetAnimationClip(underwaterIdleFwdAnimationClip17982Path, "UnderwaterIdleFwd");
			var underwaterIdleDownAnimationClip24262Path = AssetDatabase.GUIDToAssetPath("a55727babd23dbf4c8e77812456885df"); 
			var underwaterIdleDownAnimationClip24262 = AnimatorBuilder.GetAnimationClip(underwaterIdleDownAnimationClip24262Path, "UnderwaterIdleDown");
			var underwaterStrokeUpAnimationClip29760Path = AssetDatabase.GUIDToAssetPath("d8bd72cf843e70642bf0ea85025013ba"); 
			var underwaterStrokeUpAnimationClip29760 = AnimatorBuilder.GetAnimationClip(underwaterStrokeUpAnimationClip29760Path, "UnderwaterStrokeUp");
			var underwaterStrokeFwdAnimationClip21850Path = AssetDatabase.GUIDToAssetPath("eaa27658d6a72d14ca7f62229295b62d"); 
			var underwaterStrokeFwdAnimationClip21850 = AnimatorBuilder.GetAnimationClip(underwaterStrokeFwdAnimationClip21850Path, "UnderwaterStrokeFwd");
			var underwaterStrokeDownAnimationClip27064Path = AssetDatabase.GUIDToAssetPath("52fcf2bd8220b464d8498e0642c27250"); 
			var underwaterStrokeDownAnimationClip27064 = AnimatorBuilder.GetAnimationClip(underwaterStrokeDownAnimationClip27064Path, "UnderwaterStrokeDown");
			var underwaterKickUpAnimationClip26738Path = AssetDatabase.GUIDToAssetPath("426dee5db36de4944860bae40dc080a5"); 
			var underwaterKickUpAnimationClip26738 = AnimatorBuilder.GetAnimationClip(underwaterKickUpAnimationClip26738Path, "UnderwaterKickUp");
			var underwaterKickFwdAnimationClip26564Path = AssetDatabase.GUIDToAssetPath("274cdf2dc4e78834c813439bb16217ee"); 
			var underwaterKickFwdAnimationClip26564 = AnimatorBuilder.GetAnimationClip(underwaterKickFwdAnimationClip26564Path, "UnderwaterKickFwd");
			var underwaterKickDownAnimationClip19432Path = AssetDatabase.GUIDToAssetPath("0c15d136a6ed78940adfecd9eb19afb4"); 
			var underwaterKickDownAnimationClip19432 = AnimatorBuilder.GetAnimationClip(underwaterKickDownAnimationClip19432Path, "UnderwaterKickDown");
			var diveFromSurfaceAnimationClip23020Path = AssetDatabase.GUIDToAssetPath("c49a2659f0fec5d4898d185c3fc51a99"); 
			var diveFromSurfaceAnimationClip23020 = AnimatorBuilder.GetAnimationClip(diveFromSurfaceAnimationClip23020Path, "DiveFromSurface");
			var swimExitWaterAnimationClip26020Path = AssetDatabase.GUIDToAssetPath("4805feacf83e71f4d85fb6721373364b"); 
			var swimExitWaterAnimationClip26020 = AnimatorBuilder.GetAnimationClip(swimExitWaterAnimationClip26020Path, "SwimExitWater");
			var surfaceSwimToIdleAnimationClip24250Path = AssetDatabase.GUIDToAssetPath("59e074ba83e4ebf49bb6bbafee759137"); 
			var surfaceSwimToIdleAnimationClip24250 = AnimatorBuilder.GetAnimationClip(surfaceSwimToIdleAnimationClip24250Path, "SurfaceSwimToIdle");
			var underwaterKickStrafeItemAnimationClip17924Path = AssetDatabase.GUIDToAssetPath("5f368fc40f45b2345804854b74fd0cd4"); 
			var underwaterKickStrafeItemAnimationClip17924 = AnimatorBuilder.GetAnimationClip(underwaterKickStrafeItemAnimationClip17924Path, "UnderwaterKickStrafeItem");
			var underwaterKickUpItemAnimationClip17908Path = AssetDatabase.GUIDToAssetPath("69e64cc4f5df8f84c9582fbd387e3e2e"); 
			var underwaterKickUpItemAnimationClip17908 = AnimatorBuilder.GetAnimationClip(underwaterKickUpItemAnimationClip17908Path, "UnderwaterKickUpItem");
			var underwaterKickFwdItemAnimationClip15398Path = AssetDatabase.GUIDToAssetPath("a71cf04290562e84ebdca18bbd6e5a48"); 
			var underwaterKickFwdItemAnimationClip15398 = AnimatorBuilder.GetAnimationClip(underwaterKickFwdItemAnimationClip15398Path, "UnderwaterKickFwdItem");
			var underwaterKickDownItemAnimationClip19470Path = AssetDatabase.GUIDToAssetPath("57055f367494de04b89898a2d6ab299f"); 
			var underwaterKickDownItemAnimationClip19470 = AnimatorBuilder.GetAnimationClip(underwaterKickDownItemAnimationClip19470Path, "UnderwaterKickDownItem");
			var surfaceSwimFwdItemAnimationClip25482Path = AssetDatabase.GUIDToAssetPath("ae8a2c1cd552082458a39cdd3e9eaf31"); 
			var surfaceSwimFwdItemAnimationClip25482 = AnimatorBuilder.GetAnimationClip(surfaceSwimFwdItemAnimationClip25482Path, "SurfaceSwimFwdItem");

			// State Machine.
			var swimAnimatorStateMachine32750 = baseStateMachine1333559278.AddStateMachine("Swim", new Vector3(624f, 108f, 0f));

			// States.
			var fallInWaterAnimatorState33574 = swimAnimatorStateMachine32750.AddState("Fall In Water", new Vector3(144f, 48f, 0f));
			fallInWaterAnimatorState33574.motion = fallInWaterAnimationClip23146;
			fallInWaterAnimatorState33574.cycleOffset = 0f;
			fallInWaterAnimatorState33574.cycleOffsetParameterActive = false;
			fallInWaterAnimatorState33574.iKOnFeet = false;
			fallInWaterAnimatorState33574.mirror = false;
			fallInWaterAnimatorState33574.mirrorParameterActive = false;
			fallInWaterAnimatorState33574.speed = 1.5f;
			fallInWaterAnimatorState33574.speedParameterActive = false;
			fallInWaterAnimatorState33574.writeDefaultValues = true;

			var surfaceIdleAnimatorState33576 = swimAnimatorStateMachine32750.AddState("Surface Idle", new Vector3(384f, -336f, 0f));
			surfaceIdleAnimatorState33576.motion = surfaceSwimIdleAnimationClip22104;
			surfaceIdleAnimatorState33576.cycleOffset = 0f;
			surfaceIdleAnimatorState33576.cycleOffsetParameterActive = false;
			surfaceIdleAnimatorState33576.iKOnFeet = false;
			surfaceIdleAnimatorState33576.mirror = false;
			surfaceIdleAnimatorState33576.mirrorParameterActive = false;
			surfaceIdleAnimatorState33576.speed = 1f;
			surfaceIdleAnimatorState33576.speedParameterActive = false;
			surfaceIdleAnimatorState33576.writeDefaultValues = true;

			var surfaceSwimAnimatorState33584 = swimAnimatorStateMachine32750.AddState("Surface Swim", new Vector3(264f, -204f, 0f));
			var surfaceSwimAnimatorState33584blendTreeBlendTree34782 = new BlendTree();
			AssetDatabase.AddObjectToAsset(surfaceSwimAnimatorState33584blendTreeBlendTree34782, animatorController);
			surfaceSwimAnimatorState33584blendTreeBlendTree34782.hideFlags = HideFlags.HideInHierarchy;
			surfaceSwimAnimatorState33584blendTreeBlendTree34782.blendParameter = "HorizontalMovement";
			surfaceSwimAnimatorState33584blendTreeBlendTree34782.blendParameterY = "ForwardMovement";
			surfaceSwimAnimatorState33584blendTreeBlendTree34782.blendType = BlendTreeType.FreeformCartesian2D;
			surfaceSwimAnimatorState33584blendTreeBlendTree34782.maxThreshold = 8f;
			surfaceSwimAnimatorState33584blendTreeBlendTree34782.minThreshold = 0f;
			surfaceSwimAnimatorState33584blendTreeBlendTree34782.name = "Blend Tree";
			surfaceSwimAnimatorState33584blendTreeBlendTree34782.useAutomaticThresholds = false;
			var surfaceSwimAnimatorState33584blendTreeBlendTree34782Child0 =  new ChildMotion();
			surfaceSwimAnimatorState33584blendTreeBlendTree34782Child0.motion = surfacePowerSwimBwdAnimationClip28798;
			surfaceSwimAnimatorState33584blendTreeBlendTree34782Child0.cycleOffset = 0f;
			surfaceSwimAnimatorState33584blendTreeBlendTree34782Child0.directBlendParameter = "HorizontalMovement";
			surfaceSwimAnimatorState33584blendTreeBlendTree34782Child0.mirror = false;
			surfaceSwimAnimatorState33584blendTreeBlendTree34782Child0.position = new Vector2(0f, -2f);
			surfaceSwimAnimatorState33584blendTreeBlendTree34782Child0.threshold = 0f;
			surfaceSwimAnimatorState33584blendTreeBlendTree34782Child0.timeScale = 1.25f;
			var surfaceSwimAnimatorState33584blendTreeBlendTree34782Child1 =  new ChildMotion();
			surfaceSwimAnimatorState33584blendTreeBlendTree34782Child1.motion = surfaceSwimBwdAnimationClip15316;
			surfaceSwimAnimatorState33584blendTreeBlendTree34782Child1.cycleOffset = 0f;
			surfaceSwimAnimatorState33584blendTreeBlendTree34782Child1.directBlendParameter = "HorizontalMovement";
			surfaceSwimAnimatorState33584blendTreeBlendTree34782Child1.mirror = false;
			surfaceSwimAnimatorState33584blendTreeBlendTree34782Child1.position = new Vector2(0f, -1f);
			surfaceSwimAnimatorState33584blendTreeBlendTree34782Child1.threshold = 1f;
			surfaceSwimAnimatorState33584blendTreeBlendTree34782Child1.timeScale = 1f;
			var surfaceSwimAnimatorState33584blendTreeBlendTree34782Child2 =  new ChildMotion();
			surfaceSwimAnimatorState33584blendTreeBlendTree34782Child2.motion = surfacePowerSwimStrafeAnimationClip13776;
			surfaceSwimAnimatorState33584blendTreeBlendTree34782Child2.cycleOffset = 0f;
			surfaceSwimAnimatorState33584blendTreeBlendTree34782Child2.directBlendParameter = "HorizontalMovement";
			surfaceSwimAnimatorState33584blendTreeBlendTree34782Child2.mirror = false;
			surfaceSwimAnimatorState33584blendTreeBlendTree34782Child2.position = new Vector2(-2f, 0f);
			surfaceSwimAnimatorState33584blendTreeBlendTree34782Child2.threshold = 2f;
			surfaceSwimAnimatorState33584blendTreeBlendTree34782Child2.timeScale = 1.25f;
			var surfaceSwimAnimatorState33584blendTreeBlendTree34782Child3 =  new ChildMotion();
			surfaceSwimAnimatorState33584blendTreeBlendTree34782Child3.motion = surfaceSwimStrafeAnimationClip18612;
			surfaceSwimAnimatorState33584blendTreeBlendTree34782Child3.cycleOffset = 0f;
			surfaceSwimAnimatorState33584blendTreeBlendTree34782Child3.directBlendParameter = "HorizontalMovement";
			surfaceSwimAnimatorState33584blendTreeBlendTree34782Child3.mirror = false;
			surfaceSwimAnimatorState33584blendTreeBlendTree34782Child3.position = new Vector2(-1f, 0f);
			surfaceSwimAnimatorState33584blendTreeBlendTree34782Child3.threshold = 3f;
			surfaceSwimAnimatorState33584blendTreeBlendTree34782Child3.timeScale = 1f;
			var surfaceSwimAnimatorState33584blendTreeBlendTree34782Child4 =  new ChildMotion();
			surfaceSwimAnimatorState33584blendTreeBlendTree34782Child4.motion = surfaceSwimIdleAnimationClip22104;
			surfaceSwimAnimatorState33584blendTreeBlendTree34782Child4.cycleOffset = 0f;
			surfaceSwimAnimatorState33584blendTreeBlendTree34782Child4.directBlendParameter = "HorizontalMovement";
			surfaceSwimAnimatorState33584blendTreeBlendTree34782Child4.mirror = false;
			surfaceSwimAnimatorState33584blendTreeBlendTree34782Child4.position = new Vector2(0f, 0f);
			surfaceSwimAnimatorState33584blendTreeBlendTree34782Child4.threshold = 4f;
			surfaceSwimAnimatorState33584blendTreeBlendTree34782Child4.timeScale = 1f;
			var surfaceSwimAnimatorState33584blendTreeBlendTree34782Child5 =  new ChildMotion();
			surfaceSwimAnimatorState33584blendTreeBlendTree34782Child5.motion = surfaceSwimStrafeAnimationClip18612;
			surfaceSwimAnimatorState33584blendTreeBlendTree34782Child5.cycleOffset = 0.5f;
			surfaceSwimAnimatorState33584blendTreeBlendTree34782Child5.directBlendParameter = "HorizontalMovement";
			surfaceSwimAnimatorState33584blendTreeBlendTree34782Child5.mirror = true;
			surfaceSwimAnimatorState33584blendTreeBlendTree34782Child5.position = new Vector2(1f, 0f);
			surfaceSwimAnimatorState33584blendTreeBlendTree34782Child5.threshold = 5f;
			surfaceSwimAnimatorState33584blendTreeBlendTree34782Child5.timeScale = 1f;
			var surfaceSwimAnimatorState33584blendTreeBlendTree34782Child6 =  new ChildMotion();
			surfaceSwimAnimatorState33584blendTreeBlendTree34782Child6.motion = surfacePowerSwimStrafeAnimationClip13776;
			surfaceSwimAnimatorState33584blendTreeBlendTree34782Child6.cycleOffset = 0.5f;
			surfaceSwimAnimatorState33584blendTreeBlendTree34782Child6.directBlendParameter = "HorizontalMovement";
			surfaceSwimAnimatorState33584blendTreeBlendTree34782Child6.mirror = true;
			surfaceSwimAnimatorState33584blendTreeBlendTree34782Child6.position = new Vector2(2f, 0f);
			surfaceSwimAnimatorState33584blendTreeBlendTree34782Child6.threshold = 6f;
			surfaceSwimAnimatorState33584blendTreeBlendTree34782Child6.timeScale = 1.25f;
			var surfaceSwimAnimatorState33584blendTreeBlendTree34782Child7 =  new ChildMotion();
			surfaceSwimAnimatorState33584blendTreeBlendTree34782Child7.motion = surfaceSwimFwdAnimationClip27484;
			surfaceSwimAnimatorState33584blendTreeBlendTree34782Child7.cycleOffset = 0f;
			surfaceSwimAnimatorState33584blendTreeBlendTree34782Child7.directBlendParameter = "HorizontalMovement";
			surfaceSwimAnimatorState33584blendTreeBlendTree34782Child7.mirror = false;
			surfaceSwimAnimatorState33584blendTreeBlendTree34782Child7.position = new Vector2(0f, 1f);
			surfaceSwimAnimatorState33584blendTreeBlendTree34782Child7.threshold = 7f;
			surfaceSwimAnimatorState33584blendTreeBlendTree34782Child7.timeScale = 1f;
			var surfaceSwimAnimatorState33584blendTreeBlendTree34782Child8 =  new ChildMotion();
			surfaceSwimAnimatorState33584blendTreeBlendTree34782Child8.motion = surfacePowerSwimFwdAnimationClip16378;
			surfaceSwimAnimatorState33584blendTreeBlendTree34782Child8.cycleOffset = 0f;
			surfaceSwimAnimatorState33584blendTreeBlendTree34782Child8.directBlendParameter = "HorizontalMovement";
			surfaceSwimAnimatorState33584blendTreeBlendTree34782Child8.mirror = false;
			surfaceSwimAnimatorState33584blendTreeBlendTree34782Child8.position = new Vector2(0f, 2f);
			surfaceSwimAnimatorState33584blendTreeBlendTree34782Child8.threshold = 8f;
			surfaceSwimAnimatorState33584blendTreeBlendTree34782Child8.timeScale = 1.25f;
			surfaceSwimAnimatorState33584blendTreeBlendTree34782.children = new ChildMotion[] {
				surfaceSwimAnimatorState33584blendTreeBlendTree34782Child0,
				surfaceSwimAnimatorState33584blendTreeBlendTree34782Child1,
				surfaceSwimAnimatorState33584blendTreeBlendTree34782Child2,
				surfaceSwimAnimatorState33584blendTreeBlendTree34782Child3,
				surfaceSwimAnimatorState33584blendTreeBlendTree34782Child4,
				surfaceSwimAnimatorState33584blendTreeBlendTree34782Child5,
				surfaceSwimAnimatorState33584blendTreeBlendTree34782Child6,
				surfaceSwimAnimatorState33584blendTreeBlendTree34782Child7,
				surfaceSwimAnimatorState33584blendTreeBlendTree34782Child8
			};
			surfaceSwimAnimatorState33584.motion = surfaceSwimAnimatorState33584blendTreeBlendTree34782;
			surfaceSwimAnimatorState33584.cycleOffset = 0f;
			surfaceSwimAnimatorState33584.cycleOffsetParameterActive = false;
			surfaceSwimAnimatorState33584.iKOnFeet = false;
			surfaceSwimAnimatorState33584.mirror = false;
			surfaceSwimAnimatorState33584.mirrorParameterActive = false;
			surfaceSwimAnimatorState33584.speed = 1f;
			surfaceSwimAnimatorState33584.speedParameterActive = false;
			surfaceSwimAnimatorState33584.writeDefaultValues = true;

			var underwaterSwimAnimatorState33578 = swimAnimatorStateMachine32750.AddState("Underwater Swim", new Vector3(264f, 276f, 0f));
			var underwaterSwimAnimatorState33578blendTreeBlendTree34798 = new BlendTree();
			AssetDatabase.AddObjectToAsset(underwaterSwimAnimatorState33578blendTreeBlendTree34798, animatorController);
			underwaterSwimAnimatorState33578blendTreeBlendTree34798.hideFlags = HideFlags.HideInHierarchy;
			underwaterSwimAnimatorState33578blendTreeBlendTree34798.blendParameter = "HorizontalMovement";
			underwaterSwimAnimatorState33578blendTreeBlendTree34798.blendParameterY = "ForwardMovement";
			underwaterSwimAnimatorState33578blendTreeBlendTree34798.blendType = BlendTreeType.FreeformCartesian2D;
			underwaterSwimAnimatorState33578blendTreeBlendTree34798.maxThreshold = 90f;
			underwaterSwimAnimatorState33578blendTreeBlendTree34798.minThreshold = -90f;
			underwaterSwimAnimatorState33578blendTreeBlendTree34798.name = "Blend Tree";
			underwaterSwimAnimatorState33578blendTreeBlendTree34798.useAutomaticThresholds = true;
			var underwaterSwimAnimatorState33578blendTreeBlendTree34798Child0 =  new ChildMotion();
			underwaterSwimAnimatorState33578blendTreeBlendTree34798Child0.motion = underwaterSwimBwdAnimationClip20512;
			underwaterSwimAnimatorState33578blendTreeBlendTree34798Child0.cycleOffset = 0f;
			underwaterSwimAnimatorState33578blendTreeBlendTree34798Child0.directBlendParameter = "HorizontalMovement";
			underwaterSwimAnimatorState33578blendTreeBlendTree34798Child0.mirror = false;
			underwaterSwimAnimatorState33578blendTreeBlendTree34798Child0.position = new Vector2(0f, -2f);
			underwaterSwimAnimatorState33578blendTreeBlendTree34798Child0.threshold = -90f;
			underwaterSwimAnimatorState33578blendTreeBlendTree34798Child0.timeScale = 1.5f;
			var underwaterSwimAnimatorState33578blendTreeBlendTree34798Child1 =  new ChildMotion();
			underwaterSwimAnimatorState33578blendTreeBlendTree34798Child1.motion = underwaterSwimBwdAnimationClip20512;
			underwaterSwimAnimatorState33578blendTreeBlendTree34798Child1.cycleOffset = 0f;
			underwaterSwimAnimatorState33578blendTreeBlendTree34798Child1.directBlendParameter = "HorizontalMovement";
			underwaterSwimAnimatorState33578blendTreeBlendTree34798Child1.mirror = false;
			underwaterSwimAnimatorState33578blendTreeBlendTree34798Child1.position = new Vector2(0f, -1f);
			underwaterSwimAnimatorState33578blendTreeBlendTree34798Child1.threshold = -67.5f;
			underwaterSwimAnimatorState33578blendTreeBlendTree34798Child1.timeScale = 1f;
			var underwaterSwimAnimatorState33578blendTreeBlendTree34798Child2 =  new ChildMotion();
			underwaterSwimAnimatorState33578blendTreeBlendTree34798Child2.motion = underwaterKickStrafeAnimationClip14790;
			underwaterSwimAnimatorState33578blendTreeBlendTree34798Child2.cycleOffset = 0f;
			underwaterSwimAnimatorState33578blendTreeBlendTree34798Child2.directBlendParameter = "HorizontalMovement";
			underwaterSwimAnimatorState33578blendTreeBlendTree34798Child2.mirror = false;
			underwaterSwimAnimatorState33578blendTreeBlendTree34798Child2.position = new Vector2(-2f, 0f);
			underwaterSwimAnimatorState33578blendTreeBlendTree34798Child2.threshold = -45f;
			underwaterSwimAnimatorState33578blendTreeBlendTree34798Child2.timeScale = 1.5f;
			var underwaterSwimAnimatorState33578blendTreeBlendTree34798Child3 =  new ChildMotion();
			underwaterSwimAnimatorState33578blendTreeBlendTree34798Child3.motion = underwaterStrokeStrafeAnimationClip21252;
			underwaterSwimAnimatorState33578blendTreeBlendTree34798Child3.cycleOffset = 0f;
			underwaterSwimAnimatorState33578blendTreeBlendTree34798Child3.directBlendParameter = "HorizontalMovement";
			underwaterSwimAnimatorState33578blendTreeBlendTree34798Child3.mirror = false;
			underwaterSwimAnimatorState33578blendTreeBlendTree34798Child3.position = new Vector2(-1f, 0f);
			underwaterSwimAnimatorState33578blendTreeBlendTree34798Child3.threshold = -22.5f;
			underwaterSwimAnimatorState33578blendTreeBlendTree34798Child3.timeScale = 1f;
			var underwaterSwimAnimatorState33578blendTreeBlendTree34798Child4 =  new ChildMotion();
			underwaterSwimAnimatorState33578blendTreeBlendTree34798Child4.motion = underwaterStrokeStrafeAnimationClip21252;
			underwaterSwimAnimatorState33578blendTreeBlendTree34798Child4.cycleOffset = 0.5f;
			underwaterSwimAnimatorState33578blendTreeBlendTree34798Child4.directBlendParameter = "HorizontalMovement";
			underwaterSwimAnimatorState33578blendTreeBlendTree34798Child4.mirror = true;
			underwaterSwimAnimatorState33578blendTreeBlendTree34798Child4.position = new Vector2(1f, 0f);
			underwaterSwimAnimatorState33578blendTreeBlendTree34798Child4.threshold = 0f;
			underwaterSwimAnimatorState33578blendTreeBlendTree34798Child4.timeScale = 1f;
			var underwaterSwimAnimatorState33578blendTreeBlendTree34798Child5 =  new ChildMotion();
			underwaterSwimAnimatorState33578blendTreeBlendTree34798Child5.motion = underwaterKickStrafeAnimationClip14790;
			underwaterSwimAnimatorState33578blendTreeBlendTree34798Child5.cycleOffset = 0.5f;
			underwaterSwimAnimatorState33578blendTreeBlendTree34798Child5.directBlendParameter = "HorizontalMovement";
			underwaterSwimAnimatorState33578blendTreeBlendTree34798Child5.mirror = true;
			underwaterSwimAnimatorState33578blendTreeBlendTree34798Child5.position = new Vector2(2f, 0f);
			underwaterSwimAnimatorState33578blendTreeBlendTree34798Child5.threshold = 22.5f;
			underwaterSwimAnimatorState33578blendTreeBlendTree34798Child5.timeScale = 1.5f;
			var underwaterSwimAnimatorState33578blendTreeBlendTree34798blendTreeBlendTree34800 = new BlendTree();
			AssetDatabase.AddObjectToAsset(underwaterSwimAnimatorState33578blendTreeBlendTree34798blendTreeBlendTree34800, animatorController);
			underwaterSwimAnimatorState33578blendTreeBlendTree34798blendTreeBlendTree34800.hideFlags = HideFlags.HideInHierarchy;
			underwaterSwimAnimatorState33578blendTreeBlendTree34798blendTreeBlendTree34800.blendParameter = "AbilityFloatData";
			underwaterSwimAnimatorState33578blendTreeBlendTree34798blendTreeBlendTree34800.blendParameterY = "Blend";
			underwaterSwimAnimatorState33578blendTreeBlendTree34798blendTreeBlendTree34800.blendType = BlendTreeType.Simple1D;
			underwaterSwimAnimatorState33578blendTreeBlendTree34798blendTreeBlendTree34800.maxThreshold = 90f;
			underwaterSwimAnimatorState33578blendTreeBlendTree34798blendTreeBlendTree34800.minThreshold = -90f;
			underwaterSwimAnimatorState33578blendTreeBlendTree34798blendTreeBlendTree34800.name = "BlendTree";
			underwaterSwimAnimatorState33578blendTreeBlendTree34798blendTreeBlendTree34800.useAutomaticThresholds = false;
			var underwaterSwimAnimatorState33578blendTreeBlendTree34798blendTreeBlendTree34800Child0 =  new ChildMotion();
			underwaterSwimAnimatorState33578blendTreeBlendTree34798blendTreeBlendTree34800Child0.motion = underwaterIdleUpAnimationClip13724;
			underwaterSwimAnimatorState33578blendTreeBlendTree34798blendTreeBlendTree34800Child0.cycleOffset = 0f;
			underwaterSwimAnimatorState33578blendTreeBlendTree34798blendTreeBlendTree34800Child0.directBlendParameter = "HorizontalMovement";
			underwaterSwimAnimatorState33578blendTreeBlendTree34798blendTreeBlendTree34800Child0.mirror = false;
			underwaterSwimAnimatorState33578blendTreeBlendTree34798blendTreeBlendTree34800Child0.position = new Vector2(0f, 0f);
			underwaterSwimAnimatorState33578blendTreeBlendTree34798blendTreeBlendTree34800Child0.threshold = -90f;
			underwaterSwimAnimatorState33578blendTreeBlendTree34798blendTreeBlendTree34800Child0.timeScale = 1f;
			var underwaterSwimAnimatorState33578blendTreeBlendTree34798blendTreeBlendTree34800Child1 =  new ChildMotion();
			underwaterSwimAnimatorState33578blendTreeBlendTree34798blendTreeBlendTree34800Child1.motion = underwaterIdleFwdAnimationClip17982;
			underwaterSwimAnimatorState33578blendTreeBlendTree34798blendTreeBlendTree34800Child1.cycleOffset = 0f;
			underwaterSwimAnimatorState33578blendTreeBlendTree34798blendTreeBlendTree34800Child1.directBlendParameter = "HorizontalMovement";
			underwaterSwimAnimatorState33578blendTreeBlendTree34798blendTreeBlendTree34800Child1.mirror = false;
			underwaterSwimAnimatorState33578blendTreeBlendTree34798blendTreeBlendTree34800Child1.position = new Vector2(0f, 0f);
			underwaterSwimAnimatorState33578blendTreeBlendTree34798blendTreeBlendTree34800Child1.threshold = 0f;
			underwaterSwimAnimatorState33578blendTreeBlendTree34798blendTreeBlendTree34800Child1.timeScale = 1f;
			var underwaterSwimAnimatorState33578blendTreeBlendTree34798blendTreeBlendTree34800Child2 =  new ChildMotion();
			underwaterSwimAnimatorState33578blendTreeBlendTree34798blendTreeBlendTree34800Child2.motion = underwaterIdleDownAnimationClip24262;
			underwaterSwimAnimatorState33578blendTreeBlendTree34798blendTreeBlendTree34800Child2.cycleOffset = 0f;
			underwaterSwimAnimatorState33578blendTreeBlendTree34798blendTreeBlendTree34800Child2.directBlendParameter = "HorizontalMovement";
			underwaterSwimAnimatorState33578blendTreeBlendTree34798blendTreeBlendTree34800Child2.mirror = false;
			underwaterSwimAnimatorState33578blendTreeBlendTree34798blendTreeBlendTree34800Child2.position = new Vector2(0f, 0f);
			underwaterSwimAnimatorState33578blendTreeBlendTree34798blendTreeBlendTree34800Child2.threshold = 90f;
			underwaterSwimAnimatorState33578blendTreeBlendTree34798blendTreeBlendTree34800Child2.timeScale = 1f;
			underwaterSwimAnimatorState33578blendTreeBlendTree34798blendTreeBlendTree34800.children = new ChildMotion[] {
				underwaterSwimAnimatorState33578blendTreeBlendTree34798blendTreeBlendTree34800Child0,
				underwaterSwimAnimatorState33578blendTreeBlendTree34798blendTreeBlendTree34800Child1,
				underwaterSwimAnimatorState33578blendTreeBlendTree34798blendTreeBlendTree34800Child2
			};
			var underwaterSwimAnimatorState33578blendTreeBlendTree34798Child6 =  new ChildMotion();
			underwaterSwimAnimatorState33578blendTreeBlendTree34798Child6.motion = underwaterSwimAnimatorState33578blendTreeBlendTree34798blendTreeBlendTree34800;
			underwaterSwimAnimatorState33578blendTreeBlendTree34798Child6.cycleOffset = 0f;
			underwaterSwimAnimatorState33578blendTreeBlendTree34798Child6.directBlendParameter = "HorizontalMovement";
			underwaterSwimAnimatorState33578blendTreeBlendTree34798Child6.mirror = false;
			underwaterSwimAnimatorState33578blendTreeBlendTree34798Child6.position = new Vector2(0f, 0f);
			underwaterSwimAnimatorState33578blendTreeBlendTree34798Child6.threshold = 45f;
			underwaterSwimAnimatorState33578blendTreeBlendTree34798Child6.timeScale = 1f;
			var underwaterSwimAnimatorState33578blendTreeBlendTree34798blendTreeBlendTree34802 = new BlendTree();
			AssetDatabase.AddObjectToAsset(underwaterSwimAnimatorState33578blendTreeBlendTree34798blendTreeBlendTree34802, animatorController);
			underwaterSwimAnimatorState33578blendTreeBlendTree34798blendTreeBlendTree34802.hideFlags = HideFlags.HideInHierarchy;
			underwaterSwimAnimatorState33578blendTreeBlendTree34798blendTreeBlendTree34802.blendParameter = "AbilityFloatData";
			underwaterSwimAnimatorState33578blendTreeBlendTree34798blendTreeBlendTree34802.blendParameterY = "Blend";
			underwaterSwimAnimatorState33578blendTreeBlendTree34798blendTreeBlendTree34802.blendType = BlendTreeType.Simple1D;
			underwaterSwimAnimatorState33578blendTreeBlendTree34798blendTreeBlendTree34802.maxThreshold = 90f;
			underwaterSwimAnimatorState33578blendTreeBlendTree34798blendTreeBlendTree34802.minThreshold = -90f;
			underwaterSwimAnimatorState33578blendTreeBlendTree34798blendTreeBlendTree34802.name = "BlendTree";
			underwaterSwimAnimatorState33578blendTreeBlendTree34798blendTreeBlendTree34802.useAutomaticThresholds = false;
			var underwaterSwimAnimatorState33578blendTreeBlendTree34798blendTreeBlendTree34802Child0 =  new ChildMotion();
			underwaterSwimAnimatorState33578blendTreeBlendTree34798blendTreeBlendTree34802Child0.motion = underwaterStrokeUpAnimationClip29760;
			underwaterSwimAnimatorState33578blendTreeBlendTree34798blendTreeBlendTree34802Child0.cycleOffset = 0f;
			underwaterSwimAnimatorState33578blendTreeBlendTree34798blendTreeBlendTree34802Child0.directBlendParameter = "HorizontalMovement";
			underwaterSwimAnimatorState33578blendTreeBlendTree34798blendTreeBlendTree34802Child0.mirror = false;
			underwaterSwimAnimatorState33578blendTreeBlendTree34798blendTreeBlendTree34802Child0.position = new Vector2(0f, 0f);
			underwaterSwimAnimatorState33578blendTreeBlendTree34798blendTreeBlendTree34802Child0.threshold = -90f;
			underwaterSwimAnimatorState33578blendTreeBlendTree34798blendTreeBlendTree34802Child0.timeScale = 1f;
			var underwaterSwimAnimatorState33578blendTreeBlendTree34798blendTreeBlendTree34802Child1 =  new ChildMotion();
			underwaterSwimAnimatorState33578blendTreeBlendTree34798blendTreeBlendTree34802Child1.motion = underwaterStrokeFwdAnimationClip21850;
			underwaterSwimAnimatorState33578blendTreeBlendTree34798blendTreeBlendTree34802Child1.cycleOffset = 0f;
			underwaterSwimAnimatorState33578blendTreeBlendTree34798blendTreeBlendTree34802Child1.directBlendParameter = "HorizontalMovement";
			underwaterSwimAnimatorState33578blendTreeBlendTree34798blendTreeBlendTree34802Child1.mirror = false;
			underwaterSwimAnimatorState33578blendTreeBlendTree34798blendTreeBlendTree34802Child1.position = new Vector2(0f, 0f);
			underwaterSwimAnimatorState33578blendTreeBlendTree34798blendTreeBlendTree34802Child1.threshold = 0f;
			underwaterSwimAnimatorState33578blendTreeBlendTree34798blendTreeBlendTree34802Child1.timeScale = 1f;
			var underwaterSwimAnimatorState33578blendTreeBlendTree34798blendTreeBlendTree34802Child2 =  new ChildMotion();
			underwaterSwimAnimatorState33578blendTreeBlendTree34798blendTreeBlendTree34802Child2.motion = underwaterStrokeDownAnimationClip27064;
			underwaterSwimAnimatorState33578blendTreeBlendTree34798blendTreeBlendTree34802Child2.cycleOffset = 0f;
			underwaterSwimAnimatorState33578blendTreeBlendTree34798blendTreeBlendTree34802Child2.directBlendParameter = "HorizontalMovement";
			underwaterSwimAnimatorState33578blendTreeBlendTree34798blendTreeBlendTree34802Child2.mirror = false;
			underwaterSwimAnimatorState33578blendTreeBlendTree34798blendTreeBlendTree34802Child2.position = new Vector2(0f, 0f);
			underwaterSwimAnimatorState33578blendTreeBlendTree34798blendTreeBlendTree34802Child2.threshold = 90f;
			underwaterSwimAnimatorState33578blendTreeBlendTree34798blendTreeBlendTree34802Child2.timeScale = 1f;
			underwaterSwimAnimatorState33578blendTreeBlendTree34798blendTreeBlendTree34802.children = new ChildMotion[] {
				underwaterSwimAnimatorState33578blendTreeBlendTree34798blendTreeBlendTree34802Child0,
				underwaterSwimAnimatorState33578blendTreeBlendTree34798blendTreeBlendTree34802Child1,
				underwaterSwimAnimatorState33578blendTreeBlendTree34798blendTreeBlendTree34802Child2
			};
			var underwaterSwimAnimatorState33578blendTreeBlendTree34798Child7 =  new ChildMotion();
			underwaterSwimAnimatorState33578blendTreeBlendTree34798Child7.motion = underwaterSwimAnimatorState33578blendTreeBlendTree34798blendTreeBlendTree34802;
			underwaterSwimAnimatorState33578blendTreeBlendTree34798Child7.cycleOffset = 0f;
			underwaterSwimAnimatorState33578blendTreeBlendTree34798Child7.directBlendParameter = "HorizontalMovement";
			underwaterSwimAnimatorState33578blendTreeBlendTree34798Child7.mirror = false;
			underwaterSwimAnimatorState33578blendTreeBlendTree34798Child7.position = new Vector2(0f, 1f);
			underwaterSwimAnimatorState33578blendTreeBlendTree34798Child7.threshold = 67.5f;
			underwaterSwimAnimatorState33578blendTreeBlendTree34798Child7.timeScale = 1f;
			var underwaterSwimAnimatorState33578blendTreeBlendTree34798blendTreeBlendTree34804 = new BlendTree();
			AssetDatabase.AddObjectToAsset(underwaterSwimAnimatorState33578blendTreeBlendTree34798blendTreeBlendTree34804, animatorController);
			underwaterSwimAnimatorState33578blendTreeBlendTree34798blendTreeBlendTree34804.hideFlags = HideFlags.HideInHierarchy;
			underwaterSwimAnimatorState33578blendTreeBlendTree34798blendTreeBlendTree34804.blendParameter = "AbilityFloatData";
			underwaterSwimAnimatorState33578blendTreeBlendTree34798blendTreeBlendTree34804.blendParameterY = "Blend";
			underwaterSwimAnimatorState33578blendTreeBlendTree34798blendTreeBlendTree34804.blendType = BlendTreeType.Simple1D;
			underwaterSwimAnimatorState33578blendTreeBlendTree34798blendTreeBlendTree34804.maxThreshold = 90f;
			underwaterSwimAnimatorState33578blendTreeBlendTree34798blendTreeBlendTree34804.minThreshold = -90f;
			underwaterSwimAnimatorState33578blendTreeBlendTree34798blendTreeBlendTree34804.name = "BlendTree";
			underwaterSwimAnimatorState33578blendTreeBlendTree34798blendTreeBlendTree34804.useAutomaticThresholds = false;
			var underwaterSwimAnimatorState33578blendTreeBlendTree34798blendTreeBlendTree34804Child0 =  new ChildMotion();
			underwaterSwimAnimatorState33578blendTreeBlendTree34798blendTreeBlendTree34804Child0.motion = underwaterKickUpAnimationClip26738;
			underwaterSwimAnimatorState33578blendTreeBlendTree34798blendTreeBlendTree34804Child0.cycleOffset = 0f;
			underwaterSwimAnimatorState33578blendTreeBlendTree34798blendTreeBlendTree34804Child0.directBlendParameter = "HorizontalMovement";
			underwaterSwimAnimatorState33578blendTreeBlendTree34798blendTreeBlendTree34804Child0.mirror = false;
			underwaterSwimAnimatorState33578blendTreeBlendTree34798blendTreeBlendTree34804Child0.position = new Vector2(0f, 0f);
			underwaterSwimAnimatorState33578blendTreeBlendTree34798blendTreeBlendTree34804Child0.threshold = -90f;
			underwaterSwimAnimatorState33578blendTreeBlendTree34798blendTreeBlendTree34804Child0.timeScale = 1.5f;
			var underwaterSwimAnimatorState33578blendTreeBlendTree34798blendTreeBlendTree34804Child1 =  new ChildMotion();
			underwaterSwimAnimatorState33578blendTreeBlendTree34798blendTreeBlendTree34804Child1.motion = underwaterKickFwdAnimationClip26564;
			underwaterSwimAnimatorState33578blendTreeBlendTree34798blendTreeBlendTree34804Child1.cycleOffset = 0f;
			underwaterSwimAnimatorState33578blendTreeBlendTree34798blendTreeBlendTree34804Child1.directBlendParameter = "HorizontalMovement";
			underwaterSwimAnimatorState33578blendTreeBlendTree34798blendTreeBlendTree34804Child1.mirror = false;
			underwaterSwimAnimatorState33578blendTreeBlendTree34798blendTreeBlendTree34804Child1.position = new Vector2(0f, 0f);
			underwaterSwimAnimatorState33578blendTreeBlendTree34798blendTreeBlendTree34804Child1.threshold = 0f;
			underwaterSwimAnimatorState33578blendTreeBlendTree34798blendTreeBlendTree34804Child1.timeScale = 1.5f;
			var underwaterSwimAnimatorState33578blendTreeBlendTree34798blendTreeBlendTree34804Child2 =  new ChildMotion();
			underwaterSwimAnimatorState33578blendTreeBlendTree34798blendTreeBlendTree34804Child2.motion = underwaterKickDownAnimationClip19432;
			underwaterSwimAnimatorState33578blendTreeBlendTree34798blendTreeBlendTree34804Child2.cycleOffset = 0f;
			underwaterSwimAnimatorState33578blendTreeBlendTree34798blendTreeBlendTree34804Child2.directBlendParameter = "HorizontalMovement";
			underwaterSwimAnimatorState33578blendTreeBlendTree34798blendTreeBlendTree34804Child2.mirror = false;
			underwaterSwimAnimatorState33578blendTreeBlendTree34798blendTreeBlendTree34804Child2.position = new Vector2(0f, 0f);
			underwaterSwimAnimatorState33578blendTreeBlendTree34798blendTreeBlendTree34804Child2.threshold = 90f;
			underwaterSwimAnimatorState33578blendTreeBlendTree34798blendTreeBlendTree34804Child2.timeScale = 1.5f;
			underwaterSwimAnimatorState33578blendTreeBlendTree34798blendTreeBlendTree34804.children = new ChildMotion[] {
				underwaterSwimAnimatorState33578blendTreeBlendTree34798blendTreeBlendTree34804Child0,
				underwaterSwimAnimatorState33578blendTreeBlendTree34798blendTreeBlendTree34804Child1,
				underwaterSwimAnimatorState33578blendTreeBlendTree34798blendTreeBlendTree34804Child2
			};
			var underwaterSwimAnimatorState33578blendTreeBlendTree34798Child8 =  new ChildMotion();
			underwaterSwimAnimatorState33578blendTreeBlendTree34798Child8.motion = underwaterSwimAnimatorState33578blendTreeBlendTree34798blendTreeBlendTree34804;
			underwaterSwimAnimatorState33578blendTreeBlendTree34798Child8.cycleOffset = 0f;
			underwaterSwimAnimatorState33578blendTreeBlendTree34798Child8.directBlendParameter = "HorizontalMovement";
			underwaterSwimAnimatorState33578blendTreeBlendTree34798Child8.mirror = false;
			underwaterSwimAnimatorState33578blendTreeBlendTree34798Child8.position = new Vector2(0f, 2f);
			underwaterSwimAnimatorState33578blendTreeBlendTree34798Child8.threshold = 90f;
			underwaterSwimAnimatorState33578blendTreeBlendTree34798Child8.timeScale = 1f;
			underwaterSwimAnimatorState33578blendTreeBlendTree34798.children = new ChildMotion[] {
				underwaterSwimAnimatorState33578blendTreeBlendTree34798Child0,
				underwaterSwimAnimatorState33578blendTreeBlendTree34798Child1,
				underwaterSwimAnimatorState33578blendTreeBlendTree34798Child2,
				underwaterSwimAnimatorState33578blendTreeBlendTree34798Child3,
				underwaterSwimAnimatorState33578blendTreeBlendTree34798Child4,
				underwaterSwimAnimatorState33578blendTreeBlendTree34798Child5,
				underwaterSwimAnimatorState33578blendTreeBlendTree34798Child6,
				underwaterSwimAnimatorState33578blendTreeBlendTree34798Child7,
				underwaterSwimAnimatorState33578blendTreeBlendTree34798Child8
			};
			underwaterSwimAnimatorState33578.motion = underwaterSwimAnimatorState33578blendTreeBlendTree34798;
			underwaterSwimAnimatorState33578.cycleOffset = 0f;
			underwaterSwimAnimatorState33578.cycleOffsetParameterActive = false;
			underwaterSwimAnimatorState33578.iKOnFeet = true;
			underwaterSwimAnimatorState33578.mirror = false;
			underwaterSwimAnimatorState33578.mirrorParameterActive = false;
			underwaterSwimAnimatorState33578.speed = 1f;
			underwaterSwimAnimatorState33578.speedParameterActive = false;
			underwaterSwimAnimatorState33578.writeDefaultValues = true;

			var diveFromSurfaceAnimatorState34736 = swimAnimatorStateMachine32750.AddState("Dive From Surface", new Vector3(432f, 48f, 0f));
			diveFromSurfaceAnimatorState34736.motion = diveFromSurfaceAnimationClip23020;
			diveFromSurfaceAnimatorState34736.cycleOffset = 0f;
			diveFromSurfaceAnimatorState34736.cycleOffsetParameterActive = false;
			diveFromSurfaceAnimatorState34736.iKOnFeet = false;
			diveFromSurfaceAnimatorState34736.mirror = false;
			diveFromSurfaceAnimatorState34736.mirrorParameterActive = false;
			diveFromSurfaceAnimatorState34736.speed = 1.5f;
			diveFromSurfaceAnimatorState34736.speedParameterActive = false;
			diveFromSurfaceAnimatorState34736.writeDefaultValues = true;

			var exitWaterMovingAnimatorState34738 = swimAnimatorStateMachine32750.AddState("Exit Water Moving", new Vector3(744f, 12f, 0f));
			exitWaterMovingAnimatorState34738.motion = swimExitWaterAnimationClip26020;
			exitWaterMovingAnimatorState34738.cycleOffset = 0f;
			exitWaterMovingAnimatorState34738.cycleOffsetParameterActive = false;
			exitWaterMovingAnimatorState34738.iKOnFeet = false;
			exitWaterMovingAnimatorState34738.mirror = false;
			exitWaterMovingAnimatorState34738.mirrorParameterActive = false;
			exitWaterMovingAnimatorState34738.speed = 1.5f;
			exitWaterMovingAnimatorState34738.speedParameterActive = false;
			exitWaterMovingAnimatorState34738.writeDefaultValues = true;

			var exitWaterIdleAnimatorState34740 = swimAnimatorStateMachine32750.AddState("Exit Water Idle", new Vector3(744f, -48f, 0f));
			exitWaterIdleAnimatorState34740.motion = surfaceSwimToIdleAnimationClip24250;
			exitWaterIdleAnimatorState34740.cycleOffset = 0f;
			exitWaterIdleAnimatorState34740.cycleOffsetParameterActive = false;
			exitWaterIdleAnimatorState34740.iKOnFeet = false;
			exitWaterIdleAnimatorState34740.mirror = false;
			exitWaterIdleAnimatorState34740.mirrorParameterActive = false;
			exitWaterIdleAnimatorState34740.speed = 1.5f;
			exitWaterIdleAnimatorState34740.speedParameterActive = false;
			exitWaterIdleAnimatorState34740.writeDefaultValues = true;

			var underwaterSwimItemAnimatorState33588 = swimAnimatorStateMachine32750.AddState("Underwater Swim Item", new Vector3(504f, 276f, 0f));
			var underwaterSwimItemAnimatorState33588blendTreeBlendTree34826 = new BlendTree();
			AssetDatabase.AddObjectToAsset(underwaterSwimItemAnimatorState33588blendTreeBlendTree34826, animatorController);
			underwaterSwimItemAnimatorState33588blendTreeBlendTree34826.hideFlags = HideFlags.HideInHierarchy;
			underwaterSwimItemAnimatorState33588blendTreeBlendTree34826.blendParameter = "HorizontalMovement";
			underwaterSwimItemAnimatorState33588blendTreeBlendTree34826.blendParameterY = "ForwardMovement";
			underwaterSwimItemAnimatorState33588blendTreeBlendTree34826.blendType = BlendTreeType.FreeformCartesian2D;
			underwaterSwimItemAnimatorState33588blendTreeBlendTree34826.maxThreshold = 360f;
			underwaterSwimItemAnimatorState33588blendTreeBlendTree34826.minThreshold = -90f;
			underwaterSwimItemAnimatorState33588blendTreeBlendTree34826.name = "Blend Tree";
			underwaterSwimItemAnimatorState33588blendTreeBlendTree34826.useAutomaticThresholds = false;
			var underwaterSwimItemAnimatorState33588blendTreeBlendTree34826Child0 =  new ChildMotion();
			underwaterSwimItemAnimatorState33588blendTreeBlendTree34826Child0.motion = underwaterSwimBwdAnimationClip20512;
			underwaterSwimItemAnimatorState33588blendTreeBlendTree34826Child0.cycleOffset = 0f;
			underwaterSwimItemAnimatorState33588blendTreeBlendTree34826Child0.directBlendParameter = "HorizontalMovement";
			underwaterSwimItemAnimatorState33588blendTreeBlendTree34826Child0.mirror = false;
			underwaterSwimItemAnimatorState33588blendTreeBlendTree34826Child0.position = new Vector2(0f, -1f);
			underwaterSwimItemAnimatorState33588blendTreeBlendTree34826Child0.threshold = -90f;
			underwaterSwimItemAnimatorState33588blendTreeBlendTree34826Child0.timeScale = 1.5f;
			var underwaterSwimItemAnimatorState33588blendTreeBlendTree34826Child1 =  new ChildMotion();
			underwaterSwimItemAnimatorState33588blendTreeBlendTree34826Child1.motion = underwaterKickStrafeItemAnimationClip17924;
			underwaterSwimItemAnimatorState33588blendTreeBlendTree34826Child1.cycleOffset = 0f;
			underwaterSwimItemAnimatorState33588blendTreeBlendTree34826Child1.directBlendParameter = "HorizontalMovement";
			underwaterSwimItemAnimatorState33588blendTreeBlendTree34826Child1.mirror = false;
			underwaterSwimItemAnimatorState33588blendTreeBlendTree34826Child1.position = new Vector2(-1f, 0f);
			underwaterSwimItemAnimatorState33588blendTreeBlendTree34826Child1.threshold = 0f;
			underwaterSwimItemAnimatorState33588blendTreeBlendTree34826Child1.timeScale = 1.5f;
			var underwaterSwimItemAnimatorState33588blendTreeBlendTree34826blendTreeBlendTree34828 = new BlendTree();
			AssetDatabase.AddObjectToAsset(underwaterSwimItemAnimatorState33588blendTreeBlendTree34826blendTreeBlendTree34828, animatorController);
			underwaterSwimItemAnimatorState33588blendTreeBlendTree34826blendTreeBlendTree34828.hideFlags = HideFlags.HideInHierarchy;
			underwaterSwimItemAnimatorState33588blendTreeBlendTree34826blendTreeBlendTree34828.blendParameter = "AbilityFloatData";
			underwaterSwimItemAnimatorState33588blendTreeBlendTree34826blendTreeBlendTree34828.blendParameterY = "Blend";
			underwaterSwimItemAnimatorState33588blendTreeBlendTree34826blendTreeBlendTree34828.blendType = BlendTreeType.Simple1D;
			underwaterSwimItemAnimatorState33588blendTreeBlendTree34826blendTreeBlendTree34828.maxThreshold = 90f;
			underwaterSwimItemAnimatorState33588blendTreeBlendTree34826blendTreeBlendTree34828.minThreshold = -90f;
			underwaterSwimItemAnimatorState33588blendTreeBlendTree34826blendTreeBlendTree34828.name = "BlendTree";
			underwaterSwimItemAnimatorState33588blendTreeBlendTree34826blendTreeBlendTree34828.useAutomaticThresholds = false;
			var underwaterSwimItemAnimatorState33588blendTreeBlendTree34826blendTreeBlendTree34828Child0 =  new ChildMotion();
			underwaterSwimItemAnimatorState33588blendTreeBlendTree34826blendTreeBlendTree34828Child0.motion = underwaterIdleUpAnimationClip13724;
			underwaterSwimItemAnimatorState33588blendTreeBlendTree34826blendTreeBlendTree34828Child0.cycleOffset = 0f;
			underwaterSwimItemAnimatorState33588blendTreeBlendTree34826blendTreeBlendTree34828Child0.directBlendParameter = "HorizontalMovement";
			underwaterSwimItemAnimatorState33588blendTreeBlendTree34826blendTreeBlendTree34828Child0.mirror = false;
			underwaterSwimItemAnimatorState33588blendTreeBlendTree34826blendTreeBlendTree34828Child0.position = new Vector2(0f, 0f);
			underwaterSwimItemAnimatorState33588blendTreeBlendTree34826blendTreeBlendTree34828Child0.threshold = -90f;
			underwaterSwimItemAnimatorState33588blendTreeBlendTree34826blendTreeBlendTree34828Child0.timeScale = 1f;
			var underwaterSwimItemAnimatorState33588blendTreeBlendTree34826blendTreeBlendTree34828Child1 =  new ChildMotion();
			underwaterSwimItemAnimatorState33588blendTreeBlendTree34826blendTreeBlendTree34828Child1.motion = underwaterIdleFwdAnimationClip17982;
			underwaterSwimItemAnimatorState33588blendTreeBlendTree34826blendTreeBlendTree34828Child1.cycleOffset = 0f;
			underwaterSwimItemAnimatorState33588blendTreeBlendTree34826blendTreeBlendTree34828Child1.directBlendParameter = "HorizontalMovement";
			underwaterSwimItemAnimatorState33588blendTreeBlendTree34826blendTreeBlendTree34828Child1.mirror = false;
			underwaterSwimItemAnimatorState33588blendTreeBlendTree34826blendTreeBlendTree34828Child1.position = new Vector2(0f, 0f);
			underwaterSwimItemAnimatorState33588blendTreeBlendTree34826blendTreeBlendTree34828Child1.threshold = 0f;
			underwaterSwimItemAnimatorState33588blendTreeBlendTree34826blendTreeBlendTree34828Child1.timeScale = 1f;
			var underwaterSwimItemAnimatorState33588blendTreeBlendTree34826blendTreeBlendTree34828Child2 =  new ChildMotion();
			underwaterSwimItemAnimatorState33588blendTreeBlendTree34826blendTreeBlendTree34828Child2.motion = underwaterIdleDownAnimationClip24262;
			underwaterSwimItemAnimatorState33588blendTreeBlendTree34826blendTreeBlendTree34828Child2.cycleOffset = 0f;
			underwaterSwimItemAnimatorState33588blendTreeBlendTree34826blendTreeBlendTree34828Child2.directBlendParameter = "HorizontalMovement";
			underwaterSwimItemAnimatorState33588blendTreeBlendTree34826blendTreeBlendTree34828Child2.mirror = false;
			underwaterSwimItemAnimatorState33588blendTreeBlendTree34826blendTreeBlendTree34828Child2.position = new Vector2(0f, 0f);
			underwaterSwimItemAnimatorState33588blendTreeBlendTree34826blendTreeBlendTree34828Child2.threshold = 90f;
			underwaterSwimItemAnimatorState33588blendTreeBlendTree34826blendTreeBlendTree34828Child2.timeScale = 1f;
			underwaterSwimItemAnimatorState33588blendTreeBlendTree34826blendTreeBlendTree34828.children = new ChildMotion[] {
				underwaterSwimItemAnimatorState33588blendTreeBlendTree34826blendTreeBlendTree34828Child0,
				underwaterSwimItemAnimatorState33588blendTreeBlendTree34826blendTreeBlendTree34828Child1,
				underwaterSwimItemAnimatorState33588blendTreeBlendTree34826blendTreeBlendTree34828Child2
			};
			var underwaterSwimItemAnimatorState33588blendTreeBlendTree34826Child2 =  new ChildMotion();
			underwaterSwimItemAnimatorState33588blendTreeBlendTree34826Child2.motion = underwaterSwimItemAnimatorState33588blendTreeBlendTree34826blendTreeBlendTree34828;
			underwaterSwimItemAnimatorState33588blendTreeBlendTree34826Child2.cycleOffset = 0f;
			underwaterSwimItemAnimatorState33588blendTreeBlendTree34826Child2.directBlendParameter = "HorizontalMovement";
			underwaterSwimItemAnimatorState33588blendTreeBlendTree34826Child2.mirror = false;
			underwaterSwimItemAnimatorState33588blendTreeBlendTree34826Child2.position = new Vector2(0f, 0f);
			underwaterSwimItemAnimatorState33588blendTreeBlendTree34826Child2.threshold = 180f;
			underwaterSwimItemAnimatorState33588blendTreeBlendTree34826Child2.timeScale = 1f;
			var underwaterSwimItemAnimatorState33588blendTreeBlendTree34826blendTreeBlendTree34830 = new BlendTree();
			AssetDatabase.AddObjectToAsset(underwaterSwimItemAnimatorState33588blendTreeBlendTree34826blendTreeBlendTree34830, animatorController);
			underwaterSwimItemAnimatorState33588blendTreeBlendTree34826blendTreeBlendTree34830.hideFlags = HideFlags.HideInHierarchy;
			underwaterSwimItemAnimatorState33588blendTreeBlendTree34826blendTreeBlendTree34830.blendParameter = "AbilityFloatData";
			underwaterSwimItemAnimatorState33588blendTreeBlendTree34826blendTreeBlendTree34830.blendParameterY = "Blend";
			underwaterSwimItemAnimatorState33588blendTreeBlendTree34826blendTreeBlendTree34830.blendType = BlendTreeType.Simple1D;
			underwaterSwimItemAnimatorState33588blendTreeBlendTree34826blendTreeBlendTree34830.maxThreshold = 90f;
			underwaterSwimItemAnimatorState33588blendTreeBlendTree34826blendTreeBlendTree34830.minThreshold = -90f;
			underwaterSwimItemAnimatorState33588blendTreeBlendTree34826blendTreeBlendTree34830.name = "BlendTree";
			underwaterSwimItemAnimatorState33588blendTreeBlendTree34826blendTreeBlendTree34830.useAutomaticThresholds = false;
			var underwaterSwimItemAnimatorState33588blendTreeBlendTree34826blendTreeBlendTree34830Child0 =  new ChildMotion();
			underwaterSwimItemAnimatorState33588blendTreeBlendTree34826blendTreeBlendTree34830Child0.motion = underwaterKickUpItemAnimationClip17908;
			underwaterSwimItemAnimatorState33588blendTreeBlendTree34826blendTreeBlendTree34830Child0.cycleOffset = 0f;
			underwaterSwimItemAnimatorState33588blendTreeBlendTree34826blendTreeBlendTree34830Child0.directBlendParameter = "HorizontalMovement";
			underwaterSwimItemAnimatorState33588blendTreeBlendTree34826blendTreeBlendTree34830Child0.mirror = false;
			underwaterSwimItemAnimatorState33588blendTreeBlendTree34826blendTreeBlendTree34830Child0.position = new Vector2(0f, 0f);
			underwaterSwimItemAnimatorState33588blendTreeBlendTree34826blendTreeBlendTree34830Child0.threshold = -90f;
			underwaterSwimItemAnimatorState33588blendTreeBlendTree34826blendTreeBlendTree34830Child0.timeScale = 1.5f;
			var underwaterSwimItemAnimatorState33588blendTreeBlendTree34826blendTreeBlendTree34830Child1 =  new ChildMotion();
			underwaterSwimItemAnimatorState33588blendTreeBlendTree34826blendTreeBlendTree34830Child1.motion = underwaterKickFwdItemAnimationClip15398;
			underwaterSwimItemAnimatorState33588blendTreeBlendTree34826blendTreeBlendTree34830Child1.cycleOffset = 0f;
			underwaterSwimItemAnimatorState33588blendTreeBlendTree34826blendTreeBlendTree34830Child1.directBlendParameter = "HorizontalMovement";
			underwaterSwimItemAnimatorState33588blendTreeBlendTree34826blendTreeBlendTree34830Child1.mirror = false;
			underwaterSwimItemAnimatorState33588blendTreeBlendTree34826blendTreeBlendTree34830Child1.position = new Vector2(0f, 0f);
			underwaterSwimItemAnimatorState33588blendTreeBlendTree34826blendTreeBlendTree34830Child1.threshold = 0f;
			underwaterSwimItemAnimatorState33588blendTreeBlendTree34826blendTreeBlendTree34830Child1.timeScale = 1.5f;
			var underwaterSwimItemAnimatorState33588blendTreeBlendTree34826blendTreeBlendTree34830Child2 =  new ChildMotion();
			underwaterSwimItemAnimatorState33588blendTreeBlendTree34826blendTreeBlendTree34830Child2.motion = underwaterKickDownItemAnimationClip19470;
			underwaterSwimItemAnimatorState33588blendTreeBlendTree34826blendTreeBlendTree34830Child2.cycleOffset = 0f;
			underwaterSwimItemAnimatorState33588blendTreeBlendTree34826blendTreeBlendTree34830Child2.directBlendParameter = "HorizontalMovement";
			underwaterSwimItemAnimatorState33588blendTreeBlendTree34826blendTreeBlendTree34830Child2.mirror = false;
			underwaterSwimItemAnimatorState33588blendTreeBlendTree34826blendTreeBlendTree34830Child2.position = new Vector2(0f, 0f);
			underwaterSwimItemAnimatorState33588blendTreeBlendTree34826blendTreeBlendTree34830Child2.threshold = 90f;
			underwaterSwimItemAnimatorState33588blendTreeBlendTree34826blendTreeBlendTree34830Child2.timeScale = 1.5f;
			underwaterSwimItemAnimatorState33588blendTreeBlendTree34826blendTreeBlendTree34830.children = new ChildMotion[] {
				underwaterSwimItemAnimatorState33588blendTreeBlendTree34826blendTreeBlendTree34830Child0,
				underwaterSwimItemAnimatorState33588blendTreeBlendTree34826blendTreeBlendTree34830Child1,
				underwaterSwimItemAnimatorState33588blendTreeBlendTree34826blendTreeBlendTree34830Child2
			};
			var underwaterSwimItemAnimatorState33588blendTreeBlendTree34826Child3 =  new ChildMotion();
			underwaterSwimItemAnimatorState33588blendTreeBlendTree34826Child3.motion = underwaterSwimItemAnimatorState33588blendTreeBlendTree34826blendTreeBlendTree34830;
			underwaterSwimItemAnimatorState33588blendTreeBlendTree34826Child3.cycleOffset = 0f;
			underwaterSwimItemAnimatorState33588blendTreeBlendTree34826Child3.directBlendParameter = "HorizontalMovement";
			underwaterSwimItemAnimatorState33588blendTreeBlendTree34826Child3.mirror = false;
			underwaterSwimItemAnimatorState33588blendTreeBlendTree34826Child3.position = new Vector2(0f, 1f);
			underwaterSwimItemAnimatorState33588blendTreeBlendTree34826Child3.threshold = 270f;
			underwaterSwimItemAnimatorState33588blendTreeBlendTree34826Child3.timeScale = 1f;
			var underwaterSwimItemAnimatorState33588blendTreeBlendTree34826Child4 =  new ChildMotion();
			underwaterSwimItemAnimatorState33588blendTreeBlendTree34826Child4.motion = underwaterKickStrafeItemAnimationClip17924;
			underwaterSwimItemAnimatorState33588blendTreeBlendTree34826Child4.cycleOffset = 0.5f;
			underwaterSwimItemAnimatorState33588blendTreeBlendTree34826Child4.directBlendParameter = "HorizontalMovement";
			underwaterSwimItemAnimatorState33588blendTreeBlendTree34826Child4.mirror = true;
			underwaterSwimItemAnimatorState33588blendTreeBlendTree34826Child4.position = new Vector2(1f, 0f);
			underwaterSwimItemAnimatorState33588blendTreeBlendTree34826Child4.threshold = 360f;
			underwaterSwimItemAnimatorState33588blendTreeBlendTree34826Child4.timeScale = 1.5f;
			underwaterSwimItemAnimatorState33588blendTreeBlendTree34826.children = new ChildMotion[] {
				underwaterSwimItemAnimatorState33588blendTreeBlendTree34826Child0,
				underwaterSwimItemAnimatorState33588blendTreeBlendTree34826Child1,
				underwaterSwimItemAnimatorState33588blendTreeBlendTree34826Child2,
				underwaterSwimItemAnimatorState33588blendTreeBlendTree34826Child3,
				underwaterSwimItemAnimatorState33588blendTreeBlendTree34826Child4
			};
			underwaterSwimItemAnimatorState33588.motion = underwaterSwimItemAnimatorState33588blendTreeBlendTree34826;
			underwaterSwimItemAnimatorState33588.cycleOffset = 0f;
			underwaterSwimItemAnimatorState33588.cycleOffsetParameterActive = false;
			underwaterSwimItemAnimatorState33588.iKOnFeet = false;
			underwaterSwimItemAnimatorState33588.mirror = false;
			underwaterSwimItemAnimatorState33588.mirrorParameterActive = false;
			underwaterSwimItemAnimatorState33588.speed = 1f;
			underwaterSwimItemAnimatorState33588.speedParameterActive = false;
			underwaterSwimItemAnimatorState33588.writeDefaultValues = true;

			var surfaceSwimItemAnimatorState33594 = swimAnimatorStateMachine32750.AddState("Surface Swim Item", new Vector3(504f, -204f, 0f));
			var surfaceSwimItemAnimatorState33594blendTreeBlendTree34844 = new BlendTree();
			AssetDatabase.AddObjectToAsset(surfaceSwimItemAnimatorState33594blendTreeBlendTree34844, animatorController);
			surfaceSwimItemAnimatorState33594blendTreeBlendTree34844.hideFlags = HideFlags.HideInHierarchy;
			surfaceSwimItemAnimatorState33594blendTreeBlendTree34844.blendParameter = "HorizontalMovement";
			surfaceSwimItemAnimatorState33594blendTreeBlendTree34844.blendParameterY = "ForwardMovement";
			surfaceSwimItemAnimatorState33594blendTreeBlendTree34844.blendType = BlendTreeType.FreeformCartesian2D;
			surfaceSwimItemAnimatorState33594blendTreeBlendTree34844.maxThreshold = 7f;
			surfaceSwimItemAnimatorState33594blendTreeBlendTree34844.minThreshold = 1f;
			surfaceSwimItemAnimatorState33594blendTreeBlendTree34844.name = "Blend Tree";
			surfaceSwimItemAnimatorState33594blendTreeBlendTree34844.useAutomaticThresholds = false;
			var surfaceSwimItemAnimatorState33594blendTreeBlendTree34844Child0 =  new ChildMotion();
			surfaceSwimItemAnimatorState33594blendTreeBlendTree34844Child0.motion = surfaceSwimBwdAnimationClip15316;
			surfaceSwimItemAnimatorState33594blendTreeBlendTree34844Child0.cycleOffset = 0f;
			surfaceSwimItemAnimatorState33594blendTreeBlendTree34844Child0.directBlendParameter = "HorizontalMovement";
			surfaceSwimItemAnimatorState33594blendTreeBlendTree34844Child0.mirror = false;
			surfaceSwimItemAnimatorState33594blendTreeBlendTree34844Child0.position = new Vector2(0f, -1f);
			surfaceSwimItemAnimatorState33594blendTreeBlendTree34844Child0.threshold = 1f;
			surfaceSwimItemAnimatorState33594blendTreeBlendTree34844Child0.timeScale = 1f;
			var surfaceSwimItemAnimatorState33594blendTreeBlendTree34844Child1 =  new ChildMotion();
			surfaceSwimItemAnimatorState33594blendTreeBlendTree34844Child1.motion = surfaceSwimStrafeAnimationClip18612;
			surfaceSwimItemAnimatorState33594blendTreeBlendTree34844Child1.cycleOffset = 0f;
			surfaceSwimItemAnimatorState33594blendTreeBlendTree34844Child1.directBlendParameter = "HorizontalMovement";
			surfaceSwimItemAnimatorState33594blendTreeBlendTree34844Child1.mirror = false;
			surfaceSwimItemAnimatorState33594blendTreeBlendTree34844Child1.position = new Vector2(-1f, 0f);
			surfaceSwimItemAnimatorState33594blendTreeBlendTree34844Child1.threshold = 3f;
			surfaceSwimItemAnimatorState33594blendTreeBlendTree34844Child1.timeScale = 1f;
			var surfaceSwimItemAnimatorState33594blendTreeBlendTree34844Child2 =  new ChildMotion();
			surfaceSwimItemAnimatorState33594blendTreeBlendTree34844Child2.motion = surfaceSwimIdleAnimationClip22104;
			surfaceSwimItemAnimatorState33594blendTreeBlendTree34844Child2.cycleOffset = 0f;
			surfaceSwimItemAnimatorState33594blendTreeBlendTree34844Child2.directBlendParameter = "HorizontalMovement";
			surfaceSwimItemAnimatorState33594blendTreeBlendTree34844Child2.mirror = false;
			surfaceSwimItemAnimatorState33594blendTreeBlendTree34844Child2.position = new Vector2(0f, 0f);
			surfaceSwimItemAnimatorState33594blendTreeBlendTree34844Child2.threshold = 4f;
			surfaceSwimItemAnimatorState33594blendTreeBlendTree34844Child2.timeScale = 1f;
			var surfaceSwimItemAnimatorState33594blendTreeBlendTree34844Child3 =  new ChildMotion();
			surfaceSwimItemAnimatorState33594blendTreeBlendTree34844Child3.motion = surfaceSwimStrafeAnimationClip18612;
			surfaceSwimItemAnimatorState33594blendTreeBlendTree34844Child3.cycleOffset = 0.5f;
			surfaceSwimItemAnimatorState33594blendTreeBlendTree34844Child3.directBlendParameter = "HorizontalMovement";
			surfaceSwimItemAnimatorState33594blendTreeBlendTree34844Child3.mirror = true;
			surfaceSwimItemAnimatorState33594blendTreeBlendTree34844Child3.position = new Vector2(1f, 0f);
			surfaceSwimItemAnimatorState33594blendTreeBlendTree34844Child3.threshold = 5f;
			surfaceSwimItemAnimatorState33594blendTreeBlendTree34844Child3.timeScale = 1f;
			var surfaceSwimItemAnimatorState33594blendTreeBlendTree34844Child4 =  new ChildMotion();
			surfaceSwimItemAnimatorState33594blendTreeBlendTree34844Child4.motion = surfaceSwimFwdItemAnimationClip25482;
			surfaceSwimItemAnimatorState33594blendTreeBlendTree34844Child4.cycleOffset = 0f;
			surfaceSwimItemAnimatorState33594blendTreeBlendTree34844Child4.directBlendParameter = "HorizontalMovement";
			surfaceSwimItemAnimatorState33594blendTreeBlendTree34844Child4.mirror = false;
			surfaceSwimItemAnimatorState33594blendTreeBlendTree34844Child4.position = new Vector2(0f, 1f);
			surfaceSwimItemAnimatorState33594blendTreeBlendTree34844Child4.threshold = 7f;
			surfaceSwimItemAnimatorState33594blendTreeBlendTree34844Child4.timeScale = 1f;
			surfaceSwimItemAnimatorState33594blendTreeBlendTree34844.children = new ChildMotion[] {
				surfaceSwimItemAnimatorState33594blendTreeBlendTree34844Child0,
				surfaceSwimItemAnimatorState33594blendTreeBlendTree34844Child1,
				surfaceSwimItemAnimatorState33594blendTreeBlendTree34844Child2,
				surfaceSwimItemAnimatorState33594blendTreeBlendTree34844Child3,
				surfaceSwimItemAnimatorState33594blendTreeBlendTree34844Child4
			};
			surfaceSwimItemAnimatorState33594.motion = surfaceSwimItemAnimatorState33594blendTreeBlendTree34844;
			surfaceSwimItemAnimatorState33594.cycleOffset = 0f;
			surfaceSwimItemAnimatorState33594.cycleOffsetParameterActive = false;
			surfaceSwimItemAnimatorState33594.iKOnFeet = false;
			surfaceSwimItemAnimatorState33594.mirror = false;
			surfaceSwimItemAnimatorState33594.mirrorParameterActive = false;
			surfaceSwimItemAnimatorState33594.speed = 1f;
			surfaceSwimItemAnimatorState33594.speedParameterActive = false;
			surfaceSwimItemAnimatorState33594.writeDefaultValues = true;

			// State Transitions.
			var animatorStateTransition34742 = fallInWaterAnimatorState33574.AddTransition(surfaceIdleAnimatorState33576);
			animatorStateTransition34742.canTransitionToSelf = true;
			animatorStateTransition34742.duration = 0.5f;
			animatorStateTransition34742.exitTime = 0.95f;
			animatorStateTransition34742.hasExitTime = true;
			animatorStateTransition34742.hasFixedDuration = true;
			animatorStateTransition34742.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition34742.offset = 0f;
			animatorStateTransition34742.orderedInterruption = true;
			animatorStateTransition34742.isExit = false;
			animatorStateTransition34742.mute = false;
			animatorStateTransition34742.solo = false;
			animatorStateTransition34742.AddCondition(AnimatorConditionMode.Less, 0.1f, "ForwardMovement");
			animatorStateTransition34742.AddCondition(AnimatorConditionMode.Equals, 1f, "AbilityIntData");

			var animatorStateTransition34744 = fallInWaterAnimatorState33574.AddTransition(surfaceSwimAnimatorState33584);
			animatorStateTransition34744.canTransitionToSelf = true;
			animatorStateTransition34744.duration = 0.25f;
			animatorStateTransition34744.exitTime = 0.8f;
			animatorStateTransition34744.hasExitTime = false;
			animatorStateTransition34744.hasFixedDuration = true;
			animatorStateTransition34744.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition34744.offset = 0f;
			animatorStateTransition34744.orderedInterruption = true;
			animatorStateTransition34744.isExit = false;
			animatorStateTransition34744.mute = false;
			animatorStateTransition34744.solo = false;
			animatorStateTransition34744.AddCondition(AnimatorConditionMode.Equals, 1f, "AbilityIntData");
			animatorStateTransition34744.AddCondition(AnimatorConditionMode.If, 0f, "Moving");
			animatorStateTransition34744.AddCondition(AnimatorConditionMode.Equals, 0f, "Slot0ItemID");

			var animatorStateTransition34746 = fallInWaterAnimatorState33574.AddExitTransition();
			animatorStateTransition34746.canTransitionToSelf = true;
			animatorStateTransition34746.duration = 0.25f;
			animatorStateTransition34746.exitTime = 0.8888889f;
			animatorStateTransition34746.hasExitTime = false;
			animatorStateTransition34746.hasFixedDuration = true;
			animatorStateTransition34746.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition34746.offset = 0f;
			animatorStateTransition34746.orderedInterruption = true;
			animatorStateTransition34746.isExit = true;
			animatorStateTransition34746.mute = false;
			animatorStateTransition34746.solo = false;
			animatorStateTransition34746.AddCondition(AnimatorConditionMode.NotEqual, 301f, "AbilityIndex");

			var animatorStateTransition34748 = fallInWaterAnimatorState33574.AddTransition(underwaterSwimAnimatorState33578);
			animatorStateTransition34748.canTransitionToSelf = true;
			animatorStateTransition34748.duration = 0.5f;
			animatorStateTransition34748.exitTime = 0.9f;
			animatorStateTransition34748.hasExitTime = true;
			animatorStateTransition34748.hasFixedDuration = true;
			animatorStateTransition34748.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition34748.offset = 0f;
			animatorStateTransition34748.orderedInterruption = true;
			animatorStateTransition34748.isExit = false;
			animatorStateTransition34748.mute = false;
			animatorStateTransition34748.solo = false;
			animatorStateTransition34748.AddCondition(AnimatorConditionMode.Equals, 2f, "AbilityIntData");
			animatorStateTransition34748.AddCondition(AnimatorConditionMode.Equals, 0f, "Slot0ItemID");
			animatorStateTransition34748.AddCondition(AnimatorConditionMode.IfNot, 0f, "Moving");

			var animatorStateTransition34750 = fallInWaterAnimatorState33574.AddTransition(underwaterSwimItemAnimatorState33588);
			animatorStateTransition34750.canTransitionToSelf = true;
			animatorStateTransition34750.duration = 0.25f;
			animatorStateTransition34750.exitTime = 0.8f;
			animatorStateTransition34750.hasExitTime = false;
			animatorStateTransition34750.hasFixedDuration = true;
			animatorStateTransition34750.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition34750.offset = 0f;
			animatorStateTransition34750.orderedInterruption = true;
			animatorStateTransition34750.isExit = false;
			animatorStateTransition34750.mute = false;
			animatorStateTransition34750.solo = false;
			animatorStateTransition34750.AddCondition(AnimatorConditionMode.Equals, 2f, "AbilityIntData");
			animatorStateTransition34750.AddCondition(AnimatorConditionMode.Greater, 0f, "Slot0ItemID");
			animatorStateTransition34750.AddCondition(AnimatorConditionMode.If, 0f, "Moving");

			var animatorStateTransition34752 = fallInWaterAnimatorState33574.AddTransition(underwaterSwimAnimatorState33578);
			animatorStateTransition34752.canTransitionToSelf = true;
			animatorStateTransition34752.duration = 0.25f;
			animatorStateTransition34752.exitTime = 0.8888889f;
			animatorStateTransition34752.hasExitTime = false;
			animatorStateTransition34752.hasFixedDuration = true;
			animatorStateTransition34752.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition34752.offset = 0f;
			animatorStateTransition34752.orderedInterruption = true;
			animatorStateTransition34752.isExit = false;
			animatorStateTransition34752.mute = false;
			animatorStateTransition34752.solo = false;
			animatorStateTransition34752.AddCondition(AnimatorConditionMode.Equals, 2f, "AbilityIntData");
			animatorStateTransition34752.AddCondition(AnimatorConditionMode.Equals, 0f, "Slot0ItemID");
			animatorStateTransition34752.AddCondition(AnimatorConditionMode.If, 0f, "Moving");

			var animatorStateTransition34754 = fallInWaterAnimatorState33574.AddTransition(underwaterSwimItemAnimatorState33588);
			animatorStateTransition34754.canTransitionToSelf = true;
			animatorStateTransition34754.duration = 0.5f;
			animatorStateTransition34754.exitTime = 0.9f;
			animatorStateTransition34754.hasExitTime = true;
			animatorStateTransition34754.hasFixedDuration = true;
			animatorStateTransition34754.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition34754.offset = 0f;
			animatorStateTransition34754.orderedInterruption = true;
			animatorStateTransition34754.isExit = false;
			animatorStateTransition34754.mute = false;
			animatorStateTransition34754.solo = false;
			animatorStateTransition34754.AddCondition(AnimatorConditionMode.Equals, 2f, "AbilityIntData");
			animatorStateTransition34754.AddCondition(AnimatorConditionMode.Greater, 0f, "Slot0ItemID");
			animatorStateTransition34754.AddCondition(AnimatorConditionMode.IfNot, 0f, "Moving");

			var animatorStateTransition34756 = fallInWaterAnimatorState33574.AddTransition(surfaceSwimItemAnimatorState33594);
			animatorStateTransition34756.canTransitionToSelf = true;
			animatorStateTransition34756.duration = 0.25f;
			animatorStateTransition34756.exitTime = 0.8888889f;
			animatorStateTransition34756.hasExitTime = false;
			animatorStateTransition34756.hasFixedDuration = true;
			animatorStateTransition34756.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition34756.offset = 0f;
			animatorStateTransition34756.orderedInterruption = true;
			animatorStateTransition34756.isExit = false;
			animatorStateTransition34756.mute = false;
			animatorStateTransition34756.solo = false;
			animatorStateTransition34756.AddCondition(AnimatorConditionMode.Equals, 1f, "AbilityIntData");
			animatorStateTransition34756.AddCondition(AnimatorConditionMode.If, 0f, "Moving");
			animatorStateTransition34756.AddCondition(AnimatorConditionMode.Greater, 0f, "Slot0ItemID");

			var animatorStateTransition34758 = surfaceIdleAnimatorState33576.AddTransition(surfaceSwimAnimatorState33584);
			animatorStateTransition34758.canTransitionToSelf = true;
			animatorStateTransition34758.duration = 0.4f;
			animatorStateTransition34758.exitTime = 0.75f;
			animatorStateTransition34758.hasExitTime = false;
			animatorStateTransition34758.hasFixedDuration = true;
			animatorStateTransition34758.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition34758.offset = 0f;
			animatorStateTransition34758.orderedInterruption = true;
			animatorStateTransition34758.isExit = false;
			animatorStateTransition34758.mute = false;
			animatorStateTransition34758.solo = false;
			animatorStateTransition34758.AddCondition(AnimatorConditionMode.Equals, 1f, "AbilityIntData");
			animatorStateTransition34758.AddCondition(AnimatorConditionMode.If, 0f, "Moving");
			animatorStateTransition34758.AddCondition(AnimatorConditionMode.Equals, 0f, "Slot0ItemID");

			var animatorStateTransition34760 = surfaceIdleAnimatorState33576.AddTransition(diveFromSurfaceAnimatorState34736);
			animatorStateTransition34760.canTransitionToSelf = true;
			animatorStateTransition34760.duration = 0.25f;
			animatorStateTransition34760.exitTime = 0.75f;
			animatorStateTransition34760.hasExitTime = false;
			animatorStateTransition34760.hasFixedDuration = true;
			animatorStateTransition34760.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition34760.offset = 0f;
			animatorStateTransition34760.orderedInterruption = true;
			animatorStateTransition34760.isExit = false;
			animatorStateTransition34760.mute = false;
			animatorStateTransition34760.solo = false;
			animatorStateTransition34760.AddCondition(AnimatorConditionMode.Equals, 2f, "AbilityIntData");

			var animatorStateTransition34762 = surfaceIdleAnimatorState33576.AddExitTransition();
			animatorStateTransition34762.canTransitionToSelf = true;
			animatorStateTransition34762.duration = 0.25f;
			animatorStateTransition34762.exitTime = 0.8f;
			animatorStateTransition34762.hasExitTime = false;
			animatorStateTransition34762.hasFixedDuration = true;
			animatorStateTransition34762.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition34762.offset = 0f;
			animatorStateTransition34762.orderedInterruption = true;
			animatorStateTransition34762.isExit = true;
			animatorStateTransition34762.mute = false;
			animatorStateTransition34762.solo = false;
			animatorStateTransition34762.AddCondition(AnimatorConditionMode.NotEqual, 301f, "AbilityIndex");

			var animatorStateTransition34764 = surfaceIdleAnimatorState33576.AddTransition(exitWaterIdleAnimatorState34740);
			animatorStateTransition34764.canTransitionToSelf = true;
			animatorStateTransition34764.duration = 0.15f;
			animatorStateTransition34764.exitTime = 0f;
			animatorStateTransition34764.hasExitTime = false;
			animatorStateTransition34764.hasFixedDuration = true;
			animatorStateTransition34764.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition34764.offset = 0f;
			animatorStateTransition34764.orderedInterruption = true;
			animatorStateTransition34764.isExit = false;
			animatorStateTransition34764.mute = false;
			animatorStateTransition34764.solo = false;
			animatorStateTransition34764.AddCondition(AnimatorConditionMode.Equals, 4f, "AbilityIntData");

			var animatorStateTransition34766 = surfaceIdleAnimatorState33576.AddTransition(exitWaterMovingAnimatorState34738);
			animatorStateTransition34766.canTransitionToSelf = true;
			animatorStateTransition34766.duration = 0.15f;
			animatorStateTransition34766.exitTime = 2.63155E-10f;
			animatorStateTransition34766.hasExitTime = false;
			animatorStateTransition34766.hasFixedDuration = true;
			animatorStateTransition34766.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition34766.offset = 0f;
			animatorStateTransition34766.orderedInterruption = true;
			animatorStateTransition34766.isExit = false;
			animatorStateTransition34766.mute = false;
			animatorStateTransition34766.solo = false;
			animatorStateTransition34766.AddCondition(AnimatorConditionMode.Equals, 3f, "AbilityIntData");

			var animatorStateTransition34768 = surfaceIdleAnimatorState33576.AddTransition(surfaceSwimItemAnimatorState33594);
			animatorStateTransition34768.canTransitionToSelf = true;
			animatorStateTransition34768.duration = 0.4f;
			animatorStateTransition34768.exitTime = 0.8f;
			animatorStateTransition34768.hasExitTime = false;
			animatorStateTransition34768.hasFixedDuration = true;
			animatorStateTransition34768.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition34768.offset = 0f;
			animatorStateTransition34768.orderedInterruption = true;
			animatorStateTransition34768.isExit = false;
			animatorStateTransition34768.mute = false;
			animatorStateTransition34768.solo = false;
			animatorStateTransition34768.AddCondition(AnimatorConditionMode.Equals, 1f, "AbilityIntData");
			animatorStateTransition34768.AddCondition(AnimatorConditionMode.If, 0f, "Moving");
			animatorStateTransition34768.AddCondition(AnimatorConditionMode.Greater, 0f, "Slot0ItemID");

			var animatorStateTransition34770 = surfaceSwimAnimatorState33584.AddTransition(exitWaterMovingAnimatorState34738);
			animatorStateTransition34770.canTransitionToSelf = true;
			animatorStateTransition34770.duration = 0.2259974f;
			animatorStateTransition34770.exitTime = 0.010637f;
			animatorStateTransition34770.hasExitTime = false;
			animatorStateTransition34770.hasFixedDuration = true;
			animatorStateTransition34770.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition34770.offset = 0f;
			animatorStateTransition34770.orderedInterruption = true;
			animatorStateTransition34770.isExit = false;
			animatorStateTransition34770.mute = false;
			animatorStateTransition34770.solo = false;
			animatorStateTransition34770.AddCondition(AnimatorConditionMode.Equals, 3f, "AbilityIntData");

			var animatorStateTransition34772 = surfaceSwimAnimatorState33584.AddTransition(exitWaterIdleAnimatorState34740);
			animatorStateTransition34772.canTransitionToSelf = true;
			animatorStateTransition34772.duration = 0.15f;
			animatorStateTransition34772.exitTime = 0f;
			animatorStateTransition34772.hasExitTime = false;
			animatorStateTransition34772.hasFixedDuration = true;
			animatorStateTransition34772.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition34772.offset = 0f;
			animatorStateTransition34772.orderedInterruption = true;
			animatorStateTransition34772.isExit = false;
			animatorStateTransition34772.mute = false;
			animatorStateTransition34772.solo = false;
			animatorStateTransition34772.AddCondition(AnimatorConditionMode.Equals, 4f, "AbilityIntData");

			var animatorStateTransition34774 = surfaceSwimAnimatorState33584.AddTransition(diveFromSurfaceAnimatorState34736);
			animatorStateTransition34774.canTransitionToSelf = true;
			animatorStateTransition34774.duration = 0.25f;
			animatorStateTransition34774.exitTime = 0.8f;
			animatorStateTransition34774.hasExitTime = false;
			animatorStateTransition34774.hasFixedDuration = true;
			animatorStateTransition34774.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition34774.offset = 0f;
			animatorStateTransition34774.orderedInterruption = true;
			animatorStateTransition34774.isExit = false;
			animatorStateTransition34774.mute = false;
			animatorStateTransition34774.solo = false;
			animatorStateTransition34774.AddCondition(AnimatorConditionMode.Equals, 2f, "AbilityIntData");

			var animatorStateTransition34776 = surfaceSwimAnimatorState33584.AddTransition(surfaceIdleAnimatorState33576);
			animatorStateTransition34776.canTransitionToSelf = true;
			animatorStateTransition34776.duration = 0.4f;
			animatorStateTransition34776.exitTime = 0.8f;
			animatorStateTransition34776.hasExitTime = false;
			animatorStateTransition34776.hasFixedDuration = true;
			animatorStateTransition34776.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition34776.offset = 0f;
			animatorStateTransition34776.orderedInterruption = true;
			animatorStateTransition34776.isExit = false;
			animatorStateTransition34776.mute = false;
			animatorStateTransition34776.solo = false;
			animatorStateTransition34776.AddCondition(AnimatorConditionMode.Equals, 1f, "AbilityIntData");
			animatorStateTransition34776.AddCondition(AnimatorConditionMode.IfNot, 0f, "Moving");

			var animatorStateTransition34778 = surfaceSwimAnimatorState33584.AddExitTransition();
			animatorStateTransition34778.canTransitionToSelf = true;
			animatorStateTransition34778.duration = 0.25f;
			animatorStateTransition34778.exitTime = 0.8f;
			animatorStateTransition34778.hasExitTime = false;
			animatorStateTransition34778.hasFixedDuration = true;
			animatorStateTransition34778.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition34778.offset = 0f;
			animatorStateTransition34778.orderedInterruption = true;
			animatorStateTransition34778.isExit = true;
			animatorStateTransition34778.mute = false;
			animatorStateTransition34778.solo = false;
			animatorStateTransition34778.AddCondition(AnimatorConditionMode.NotEqual, 301f, "AbilityIndex");

			var animatorStateTransition34780 = surfaceSwimAnimatorState33584.AddTransition(surfaceSwimItemAnimatorState33594);
			animatorStateTransition34780.canTransitionToSelf = true;
			animatorStateTransition34780.duration = 0.15f;
			animatorStateTransition34780.exitTime = 0.8f;
			animatorStateTransition34780.hasExitTime = false;
			animatorStateTransition34780.hasFixedDuration = true;
			animatorStateTransition34780.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition34780.offset = 0f;
			animatorStateTransition34780.orderedInterruption = true;
			animatorStateTransition34780.isExit = false;
			animatorStateTransition34780.mute = false;
			animatorStateTransition34780.solo = false;
			animatorStateTransition34780.AddCondition(AnimatorConditionMode.Equals, 1f, "AbilityIntData");
			animatorStateTransition34780.AddCondition(AnimatorConditionMode.Greater, 0f, "Slot0ItemID");

			var animatorStateTransition34784 = underwaterSwimAnimatorState33578.AddTransition(surfaceIdleAnimatorState33576);
			animatorStateTransition34784.canTransitionToSelf = true;
			animatorStateTransition34784.duration = 0.1f;
			animatorStateTransition34784.exitTime = 0.8f;
			animatorStateTransition34784.hasExitTime = false;
			animatorStateTransition34784.hasFixedDuration = true;
			animatorStateTransition34784.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition34784.offset = 0f;
			animatorStateTransition34784.orderedInterruption = true;
			animatorStateTransition34784.isExit = false;
			animatorStateTransition34784.mute = false;
			animatorStateTransition34784.solo = false;
			animatorStateTransition34784.AddCondition(AnimatorConditionMode.Equals, 1f, "AbilityIntData");
			animatorStateTransition34784.AddCondition(AnimatorConditionMode.IfNot, 0f, "Moving");

			var animatorStateTransition34786 = underwaterSwimAnimatorState33578.AddExitTransition();
			animatorStateTransition34786.canTransitionToSelf = true;
			animatorStateTransition34786.duration = 0.25f;
			animatorStateTransition34786.exitTime = 0.8f;
			animatorStateTransition34786.hasExitTime = false;
			animatorStateTransition34786.hasFixedDuration = true;
			animatorStateTransition34786.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition34786.offset = 0f;
			animatorStateTransition34786.orderedInterruption = true;
			animatorStateTransition34786.isExit = true;
			animatorStateTransition34786.mute = false;
			animatorStateTransition34786.solo = false;
			animatorStateTransition34786.AddCondition(AnimatorConditionMode.NotEqual, 301f, "AbilityIndex");

			var animatorStateTransition34788 = underwaterSwimAnimatorState33578.AddTransition(exitWaterMovingAnimatorState34738);
			animatorStateTransition34788.canTransitionToSelf = true;
			animatorStateTransition34788.duration = 0.2259974f;
			animatorStateTransition34788.exitTime = 0.01825405f;
			animatorStateTransition34788.hasExitTime = false;
			animatorStateTransition34788.hasFixedDuration = true;
			animatorStateTransition34788.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition34788.offset = 0f;
			animatorStateTransition34788.orderedInterruption = true;
			animatorStateTransition34788.isExit = false;
			animatorStateTransition34788.mute = false;
			animatorStateTransition34788.solo = false;
			animatorStateTransition34788.AddCondition(AnimatorConditionMode.Equals, 3f, "AbilityIntData");

			var animatorStateTransition34790 = underwaterSwimAnimatorState33578.AddTransition(surfaceSwimAnimatorState33584);
			animatorStateTransition34790.canTransitionToSelf = true;
			animatorStateTransition34790.duration = 0.1f;
			animatorStateTransition34790.exitTime = 0.8285714f;
			animatorStateTransition34790.hasExitTime = false;
			animatorStateTransition34790.hasFixedDuration = true;
			animatorStateTransition34790.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition34790.offset = 0f;
			animatorStateTransition34790.orderedInterruption = true;
			animatorStateTransition34790.isExit = false;
			animatorStateTransition34790.mute = false;
			animatorStateTransition34790.solo = false;
			animatorStateTransition34790.AddCondition(AnimatorConditionMode.Equals, 1f, "AbilityIntData");
			animatorStateTransition34790.AddCondition(AnimatorConditionMode.If, 0f, "Moving");
			animatorStateTransition34790.AddCondition(AnimatorConditionMode.Equals, 0f, "Slot0ItemID");

			var animatorStateTransition34792 = underwaterSwimAnimatorState33578.AddTransition(underwaterSwimItemAnimatorState33588);
			animatorStateTransition34792.canTransitionToSelf = true;
			animatorStateTransition34792.duration = 0.25f;
			animatorStateTransition34792.exitTime = 0.8285714f;
			animatorStateTransition34792.hasExitTime = false;
			animatorStateTransition34792.hasFixedDuration = true;
			animatorStateTransition34792.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition34792.offset = 0f;
			animatorStateTransition34792.orderedInterruption = true;
			animatorStateTransition34792.isExit = false;
			animatorStateTransition34792.mute = false;
			animatorStateTransition34792.solo = false;
			animatorStateTransition34792.AddCondition(AnimatorConditionMode.Equals, 2f, "AbilityIntData");
			animatorStateTransition34792.AddCondition(AnimatorConditionMode.Greater, 0f, "Slot0ItemID");

			var animatorStateTransition34794 = underwaterSwimAnimatorState33578.AddTransition(exitWaterIdleAnimatorState34740);
			animatorStateTransition34794.canTransitionToSelf = true;
			animatorStateTransition34794.duration = 0.15f;
			animatorStateTransition34794.exitTime = 0.8285714f;
			animatorStateTransition34794.hasExitTime = false;
			animatorStateTransition34794.hasFixedDuration = true;
			animatorStateTransition34794.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition34794.offset = 0f;
			animatorStateTransition34794.orderedInterruption = true;
			animatorStateTransition34794.isExit = false;
			animatorStateTransition34794.mute = false;
			animatorStateTransition34794.solo = false;
			animatorStateTransition34794.AddCondition(AnimatorConditionMode.Equals, 4f, "AbilityIntData");

			var animatorStateTransition34796 = underwaterSwimAnimatorState33578.AddTransition(surfaceSwimItemAnimatorState33594);
			animatorStateTransition34796.canTransitionToSelf = true;
			animatorStateTransition34796.duration = 0.1f;
			animatorStateTransition34796.exitTime = 0.8217822f;
			animatorStateTransition34796.hasExitTime = false;
			animatorStateTransition34796.hasFixedDuration = true;
			animatorStateTransition34796.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition34796.offset = 0f;
			animatorStateTransition34796.orderedInterruption = true;
			animatorStateTransition34796.isExit = false;
			animatorStateTransition34796.mute = false;
			animatorStateTransition34796.solo = false;
			animatorStateTransition34796.AddCondition(AnimatorConditionMode.Equals, 1f, "AbilityIntData");
			animatorStateTransition34796.AddCondition(AnimatorConditionMode.If, 0f, "Moving");
			animatorStateTransition34796.AddCondition(AnimatorConditionMode.Greater, 0f, "Slot0ItemID");

			var animatorStateTransition34806 = diveFromSurfaceAnimatorState34736.AddTransition(underwaterSwimAnimatorState33578);
			animatorStateTransition34806.canTransitionToSelf = true;
			animatorStateTransition34806.duration = 0.25f;
			animatorStateTransition34806.exitTime = 0.88f;
			animatorStateTransition34806.hasExitTime = true;
			animatorStateTransition34806.hasFixedDuration = true;
			animatorStateTransition34806.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition34806.offset = 0f;
			animatorStateTransition34806.orderedInterruption = true;
			animatorStateTransition34806.isExit = false;
			animatorStateTransition34806.mute = false;
			animatorStateTransition34806.solo = false;
			animatorStateTransition34806.AddCondition(AnimatorConditionMode.Equals, 0f, "Slot0ItemID");

			var animatorStateTransition34808 = diveFromSurfaceAnimatorState34736.AddTransition(underwaterSwimItemAnimatorState33588);
			animatorStateTransition34808.canTransitionToSelf = true;
			animatorStateTransition34808.duration = 0.25f;
			animatorStateTransition34808.exitTime = 0.88f;
			animatorStateTransition34808.hasExitTime = true;
			animatorStateTransition34808.hasFixedDuration = true;
			animatorStateTransition34808.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition34808.offset = 0f;
			animatorStateTransition34808.orderedInterruption = true;
			animatorStateTransition34808.isExit = false;
			animatorStateTransition34808.mute = false;
			animatorStateTransition34808.solo = false;
			animatorStateTransition34808.AddCondition(AnimatorConditionMode.Greater, 0f, "Slot0ItemID");

			var animatorStateTransition34810 = exitWaterMovingAnimatorState34738.AddExitTransition();
			animatorStateTransition34810.canTransitionToSelf = true;
			animatorStateTransition34810.duration = 0.15f;
			animatorStateTransition34810.exitTime = 0.85f;
			animatorStateTransition34810.hasExitTime = true;
			animatorStateTransition34810.hasFixedDuration = true;
			animatorStateTransition34810.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition34810.offset = 0f;
			animatorStateTransition34810.orderedInterruption = true;
			animatorStateTransition34810.isExit = true;
			animatorStateTransition34810.mute = false;
			animatorStateTransition34810.solo = false;
			animatorStateTransition34810.AddCondition(AnimatorConditionMode.NotEqual, 301f, "AbilityIndex");

			var animatorStateTransition34812 = exitWaterIdleAnimatorState34740.AddExitTransition();
			animatorStateTransition34812.canTransitionToSelf = true;
			animatorStateTransition34812.duration = 0.1f;
			animatorStateTransition34812.exitTime = 0.65f;
			animatorStateTransition34812.hasExitTime = false;
			animatorStateTransition34812.hasFixedDuration = true;
			animatorStateTransition34812.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition34812.offset = 0f;
			animatorStateTransition34812.orderedInterruption = true;
			animatorStateTransition34812.isExit = true;
			animatorStateTransition34812.mute = false;
			animatorStateTransition34812.solo = false;
			animatorStateTransition34812.AddCondition(AnimatorConditionMode.NotEqual, 301f, "AbilityIndex");

			var animatorStateTransition34814 = underwaterSwimItemAnimatorState33588.AddExitTransition();
			animatorStateTransition34814.canTransitionToSelf = true;
			animatorStateTransition34814.duration = 0.25f;
			animatorStateTransition34814.exitTime = 0.8090909f;
			animatorStateTransition34814.hasExitTime = false;
			animatorStateTransition34814.hasFixedDuration = true;
			animatorStateTransition34814.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition34814.offset = 0f;
			animatorStateTransition34814.orderedInterruption = true;
			animatorStateTransition34814.isExit = true;
			animatorStateTransition34814.mute = false;
			animatorStateTransition34814.solo = false;
			animatorStateTransition34814.AddCondition(AnimatorConditionMode.NotEqual, 301f, "AbilityIndex");

			var animatorStateTransition34816 = underwaterSwimItemAnimatorState33588.AddTransition(exitWaterMovingAnimatorState34738);
			animatorStateTransition34816.canTransitionToSelf = true;
			animatorStateTransition34816.duration = 0.2259974f;
			animatorStateTransition34816.exitTime = 0.8090909f;
			animatorStateTransition34816.hasExitTime = false;
			animatorStateTransition34816.hasFixedDuration = true;
			animatorStateTransition34816.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition34816.offset = 0f;
			animatorStateTransition34816.orderedInterruption = true;
			animatorStateTransition34816.isExit = false;
			animatorStateTransition34816.mute = false;
			animatorStateTransition34816.solo = false;
			animatorStateTransition34816.AddCondition(AnimatorConditionMode.Equals, 3f, "AbilityIntData");

			var animatorStateTransition34818 = underwaterSwimItemAnimatorState33588.AddTransition(surfaceIdleAnimatorState33576);
			animatorStateTransition34818.canTransitionToSelf = true;
			animatorStateTransition34818.duration = 0.1f;
			animatorStateTransition34818.exitTime = 0.8090909f;
			animatorStateTransition34818.hasExitTime = false;
			animatorStateTransition34818.hasFixedDuration = true;
			animatorStateTransition34818.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition34818.offset = 0f;
			animatorStateTransition34818.orderedInterruption = true;
			animatorStateTransition34818.isExit = false;
			animatorStateTransition34818.mute = false;
			animatorStateTransition34818.solo = false;
			animatorStateTransition34818.AddCondition(AnimatorConditionMode.Equals, 1f, "AbilityIntData");
			animatorStateTransition34818.AddCondition(AnimatorConditionMode.IfNot, 0f, "Moving");

			var animatorStateTransition34820 = underwaterSwimItemAnimatorState33588.AddTransition(surfaceSwimAnimatorState33584);
			animatorStateTransition34820.canTransitionToSelf = true;
			animatorStateTransition34820.duration = 0.1f;
			animatorStateTransition34820.exitTime = 0.8090909f;
			animatorStateTransition34820.hasExitTime = false;
			animatorStateTransition34820.hasFixedDuration = true;
			animatorStateTransition34820.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition34820.offset = 0f;
			animatorStateTransition34820.orderedInterruption = true;
			animatorStateTransition34820.isExit = false;
			animatorStateTransition34820.mute = false;
			animatorStateTransition34820.solo = false;
			animatorStateTransition34820.AddCondition(AnimatorConditionMode.Equals, 1f, "AbilityIntData");
			animatorStateTransition34820.AddCondition(AnimatorConditionMode.If, 0f, "Moving");
			animatorStateTransition34820.AddCondition(AnimatorConditionMode.Equals, 0f, "Slot0ItemID");

			var animatorStateTransition34822 = underwaterSwimItemAnimatorState33588.AddTransition(underwaterSwimAnimatorState33578);
			animatorStateTransition34822.canTransitionToSelf = true;
			animatorStateTransition34822.duration = 0.25f;
			animatorStateTransition34822.exitTime = 0.8090909f;
			animatorStateTransition34822.hasExitTime = false;
			animatorStateTransition34822.hasFixedDuration = true;
			animatorStateTransition34822.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition34822.offset = 0f;
			animatorStateTransition34822.orderedInterruption = true;
			animatorStateTransition34822.isExit = false;
			animatorStateTransition34822.mute = false;
			animatorStateTransition34822.solo = false;
			animatorStateTransition34822.AddCondition(AnimatorConditionMode.Equals, 2f, "AbilityIntData");
			animatorStateTransition34822.AddCondition(AnimatorConditionMode.Equals, 0f, "Slot0ItemID");

			var animatorStateTransition34824 = underwaterSwimItemAnimatorState33588.AddTransition(surfaceSwimItemAnimatorState33594);
			animatorStateTransition34824.canTransitionToSelf = true;
			animatorStateTransition34824.duration = 0.1f;
			animatorStateTransition34824.exitTime = 0.82f;
			animatorStateTransition34824.hasExitTime = false;
			animatorStateTransition34824.hasFixedDuration = true;
			animatorStateTransition34824.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition34824.offset = 0f;
			animatorStateTransition34824.orderedInterruption = true;
			animatorStateTransition34824.isExit = false;
			animatorStateTransition34824.mute = false;
			animatorStateTransition34824.solo = false;
			animatorStateTransition34824.AddCondition(AnimatorConditionMode.Equals, 1f, "AbilityIntData");
			animatorStateTransition34824.AddCondition(AnimatorConditionMode.If, 0f, "Moving");
			animatorStateTransition34824.AddCondition(AnimatorConditionMode.Greater, 0f, "Slot0ItemID");

			var animatorStateTransition34832 = surfaceSwimItemAnimatorState33594.AddTransition(exitWaterMovingAnimatorState34738);
			animatorStateTransition34832.canTransitionToSelf = true;
			animatorStateTransition34832.duration = 0.2259974f;
			animatorStateTransition34832.exitTime = 0.8f;
			animatorStateTransition34832.hasExitTime = false;
			animatorStateTransition34832.hasFixedDuration = true;
			animatorStateTransition34832.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition34832.offset = 0f;
			animatorStateTransition34832.orderedInterruption = true;
			animatorStateTransition34832.isExit = false;
			animatorStateTransition34832.mute = false;
			animatorStateTransition34832.solo = false;
			animatorStateTransition34832.AddCondition(AnimatorConditionMode.Equals, 3f, "AbilityIntData");

			var animatorStateTransition34834 = surfaceSwimItemAnimatorState33594.AddTransition(exitWaterIdleAnimatorState34740);
			animatorStateTransition34834.canTransitionToSelf = true;
			animatorStateTransition34834.duration = 0.15f;
			animatorStateTransition34834.exitTime = 0.8f;
			animatorStateTransition34834.hasExitTime = false;
			animatorStateTransition34834.hasFixedDuration = true;
			animatorStateTransition34834.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition34834.offset = 0f;
			animatorStateTransition34834.orderedInterruption = true;
			animatorStateTransition34834.isExit = false;
			animatorStateTransition34834.mute = false;
			animatorStateTransition34834.solo = false;
			animatorStateTransition34834.AddCondition(AnimatorConditionMode.Equals, 4f, "AbilityIntData");

			var animatorStateTransition34836 = surfaceSwimItemAnimatorState33594.AddTransition(surfaceIdleAnimatorState33576);
			animatorStateTransition34836.canTransitionToSelf = true;
			animatorStateTransition34836.duration = 0.4f;
			animatorStateTransition34836.exitTime = 0.8f;
			animatorStateTransition34836.hasExitTime = false;
			animatorStateTransition34836.hasFixedDuration = true;
			animatorStateTransition34836.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition34836.offset = 0f;
			animatorStateTransition34836.orderedInterruption = true;
			animatorStateTransition34836.isExit = false;
			animatorStateTransition34836.mute = false;
			animatorStateTransition34836.solo = false;
			animatorStateTransition34836.AddCondition(AnimatorConditionMode.Equals, 1f, "AbilityIntData");
			animatorStateTransition34836.AddCondition(AnimatorConditionMode.IfNot, 0f, "Moving");

			var animatorStateTransition34838 = surfaceSwimItemAnimatorState33594.AddTransition(diveFromSurfaceAnimatorState34736);
			animatorStateTransition34838.canTransitionToSelf = true;
			animatorStateTransition34838.duration = 0.25f;
			animatorStateTransition34838.exitTime = 0.8f;
			animatorStateTransition34838.hasExitTime = false;
			animatorStateTransition34838.hasFixedDuration = true;
			animatorStateTransition34838.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition34838.offset = 0f;
			animatorStateTransition34838.orderedInterruption = true;
			animatorStateTransition34838.isExit = false;
			animatorStateTransition34838.mute = false;
			animatorStateTransition34838.solo = false;
			animatorStateTransition34838.AddCondition(AnimatorConditionMode.Equals, 2f, "AbilityIntData");

			var animatorStateTransition34840 = surfaceSwimItemAnimatorState33594.AddExitTransition();
			animatorStateTransition34840.canTransitionToSelf = true;
			animatorStateTransition34840.duration = 0.25f;
			animatorStateTransition34840.exitTime = 0.8f;
			animatorStateTransition34840.hasExitTime = false;
			animatorStateTransition34840.hasFixedDuration = true;
			animatorStateTransition34840.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition34840.offset = 0f;
			animatorStateTransition34840.orderedInterruption = true;
			animatorStateTransition34840.isExit = true;
			animatorStateTransition34840.mute = false;
			animatorStateTransition34840.solo = false;
			animatorStateTransition34840.AddCondition(AnimatorConditionMode.NotEqual, 301f, "AbilityIndex");

			var animatorStateTransition34842 = surfaceSwimItemAnimatorState33594.AddTransition(surfaceSwimAnimatorState33584);
			animatorStateTransition34842.canTransitionToSelf = true;
			animatorStateTransition34842.duration = 0.15f;
			animatorStateTransition34842.exitTime = 0.8f;
			animatorStateTransition34842.hasExitTime = false;
			animatorStateTransition34842.hasFixedDuration = true;
			animatorStateTransition34842.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition34842.offset = 0f;
			animatorStateTransition34842.orderedInterruption = true;
			animatorStateTransition34842.isExit = false;
			animatorStateTransition34842.mute = false;
			animatorStateTransition34842.solo = false;
			animatorStateTransition34842.AddCondition(AnimatorConditionMode.Equals, 1f, "AbilityIntData");
			animatorStateTransition34842.AddCondition(AnimatorConditionMode.Equals, 0f, "Slot0ItemID");

			// State Machine Defaults.
			swimAnimatorStateMachine32750.anyStatePosition = new Vector3(-168f, 48f, 0f);
			swimAnimatorStateMachine32750.defaultState = surfaceIdleAnimatorState33576;
			swimAnimatorStateMachine32750.entryPosition = new Vector3(-204f, -36f, 0f);
			swimAnimatorStateMachine32750.exitPosition = new Vector3(1140f, 48f, 0f);
			swimAnimatorStateMachine32750.parentStateMachinePosition = new Vector3(1128f, -48f, 0f);


			// State Machine Transitions.
			var animatorStateTransition33284 = baseStateMachine1333559278.AddAnyStateTransition(fallInWaterAnimatorState33574);
			animatorStateTransition33284.canTransitionToSelf = false;
			animatorStateTransition33284.duration = 0.25f;
			animatorStateTransition33284.exitTime = 0.75f;
			animatorStateTransition33284.hasExitTime = false;
			animatorStateTransition33284.hasFixedDuration = true;
			animatorStateTransition33284.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition33284.offset = 0f;
			animatorStateTransition33284.orderedInterruption = true;
			animatorStateTransition33284.isExit = false;
			animatorStateTransition33284.mute = false;
			animatorStateTransition33284.solo = false;
			animatorStateTransition33284.AddCondition(AnimatorConditionMode.If, 0f, "AbilityChange");
			animatorStateTransition33284.AddCondition(AnimatorConditionMode.Equals, 301f, "AbilityIndex");
			animatorStateTransition33284.AddCondition(AnimatorConditionMode.Equals, 0f, "AbilityIntData");

			var animatorStateTransition33286 = baseStateMachine1333559278.AddAnyStateTransition(surfaceIdleAnimatorState33576);
			animatorStateTransition33286.canTransitionToSelf = false;
			animatorStateTransition33286.duration = 0.25f;
			animatorStateTransition33286.exitTime = 0.75f;
			animatorStateTransition33286.hasExitTime = false;
			animatorStateTransition33286.hasFixedDuration = true;
			animatorStateTransition33286.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition33286.offset = 0f;
			animatorStateTransition33286.orderedInterruption = true;
			animatorStateTransition33286.isExit = false;
			animatorStateTransition33286.mute = false;
			animatorStateTransition33286.solo = false;
			animatorStateTransition33286.AddCondition(AnimatorConditionMode.If, 0f, "AbilityChange");
			animatorStateTransition33286.AddCondition(AnimatorConditionMode.Equals, 301f, "AbilityIndex");
			animatorStateTransition33286.AddCondition(AnimatorConditionMode.Equals, 1f, "AbilityIntData");
			animatorStateTransition33286.AddCondition(AnimatorConditionMode.IfNot, 0f, "Moving");

			var animatorStateTransition33288 = baseStateMachine1333559278.AddAnyStateTransition(underwaterSwimAnimatorState33578);
			animatorStateTransition33288.canTransitionToSelf = false;
			animatorStateTransition33288.duration = 0.25f;
			animatorStateTransition33288.exitTime = 0.75f;
			animatorStateTransition33288.hasExitTime = false;
			animatorStateTransition33288.hasFixedDuration = true;
			animatorStateTransition33288.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition33288.offset = 0f;
			animatorStateTransition33288.orderedInterruption = true;
			animatorStateTransition33288.isExit = false;
			animatorStateTransition33288.mute = false;
			animatorStateTransition33288.solo = false;
			animatorStateTransition33288.AddCondition(AnimatorConditionMode.If, 0f, "AbilityChange");
			animatorStateTransition33288.AddCondition(AnimatorConditionMode.Equals, 301f, "AbilityIndex");
			animatorStateTransition33288.AddCondition(AnimatorConditionMode.Equals, 2f, "AbilityIntData");
			animatorStateTransition33288.AddCondition(AnimatorConditionMode.Equals, 0f, "Slot0ItemID");

			var animatorStateTransition33294 = baseStateMachine1333559278.AddAnyStateTransition(surfaceSwimAnimatorState33584);
			animatorStateTransition33294.canTransitionToSelf = false;
			animatorStateTransition33294.duration = 0.25f;
			animatorStateTransition33294.exitTime = 0.75f;
			animatorStateTransition33294.hasExitTime = false;
			animatorStateTransition33294.hasFixedDuration = true;
			animatorStateTransition33294.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition33294.offset = 0f;
			animatorStateTransition33294.orderedInterruption = true;
			animatorStateTransition33294.isExit = false;
			animatorStateTransition33294.mute = false;
			animatorStateTransition33294.solo = false;
			animatorStateTransition33294.AddCondition(AnimatorConditionMode.If, 0f, "AbilityChange");
			animatorStateTransition33294.AddCondition(AnimatorConditionMode.Equals, 301f, "AbilityIndex");
			animatorStateTransition33294.AddCondition(AnimatorConditionMode.Equals, 1f, "AbilityIntData");
			animatorStateTransition33294.AddCondition(AnimatorConditionMode.If, 0f, "Moving");
			animatorStateTransition33294.AddCondition(AnimatorConditionMode.Equals, 0f, "Slot0ItemID");

			var animatorStateTransition33298 = baseStateMachine1333559278.AddAnyStateTransition(underwaterSwimItemAnimatorState33588);
			animatorStateTransition33298.canTransitionToSelf = false;
			animatorStateTransition33298.duration = 0.25f;
			animatorStateTransition33298.exitTime = 0.75f;
			animatorStateTransition33298.hasExitTime = false;
			animatorStateTransition33298.hasFixedDuration = true;
			animatorStateTransition33298.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition33298.offset = 0f;
			animatorStateTransition33298.orderedInterruption = true;
			animatorStateTransition33298.isExit = false;
			animatorStateTransition33298.mute = false;
			animatorStateTransition33298.solo = false;
			animatorStateTransition33298.AddCondition(AnimatorConditionMode.If, 0f, "AbilityChange");
			animatorStateTransition33298.AddCondition(AnimatorConditionMode.Equals, 301f, "AbilityIndex");
			animatorStateTransition33298.AddCondition(AnimatorConditionMode.Equals, 2f, "AbilityIntData");
			animatorStateTransition33298.AddCondition(AnimatorConditionMode.Greater, 0f, "Slot0ItemID");

			var animatorStateTransition33308 = baseStateMachine1333559278.AddAnyStateTransition(surfaceSwimItemAnimatorState33594);
			animatorStateTransition33308.canTransitionToSelf = false;
			animatorStateTransition33308.duration = 0.25f;
			animatorStateTransition33308.exitTime = 0.75f;
			animatorStateTransition33308.hasExitTime = false;
			animatorStateTransition33308.hasFixedDuration = true;
			animatorStateTransition33308.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition33308.offset = 0f;
			animatorStateTransition33308.orderedInterruption = true;
			animatorStateTransition33308.isExit = false;
			animatorStateTransition33308.mute = false;
			animatorStateTransition33308.solo = false;
			animatorStateTransition33308.AddCondition(AnimatorConditionMode.If, 0f, "AbilityChange");
			animatorStateTransition33308.AddCondition(AnimatorConditionMode.Equals, 301f, "AbilityIndex");
			animatorStateTransition33308.AddCondition(AnimatorConditionMode.Equals, 1f, "AbilityIntData");
			animatorStateTransition33308.AddCondition(AnimatorConditionMode.If, 0f, "Moving");
			animatorStateTransition33308.AddCondition(AnimatorConditionMode.Greater, 0f, "Slot0ItemID");

			var baseStateMachine1227655302 = animatorController.layers[3].stateMachine;

			// The state machine should start fresh.
			for (int i = 0; i < animatorController.layers.Length; ++i) {
				for (int j = 0; j < baseStateMachine1227655302.stateMachines.Length; ++j) {
					if (baseStateMachine1227655302.stateMachines[j].stateMachine.name == "Trident") {
						baseStateMachine1227655302.RemoveStateMachine(baseStateMachine1227655302.stateMachines[j].stateMachine);
						break;
					}
				}
			}

			// AnimationClip references.
			var tridentAimBwdAnimationClip29402Path = AssetDatabase.GUIDToAssetPath("b52b8b4fd9045e640aefcd13a1ae0170"); 
			var tridentAimBwdAnimationClip29402 = AnimatorBuilder.GetAnimationClip(tridentAimBwdAnimationClip29402Path, "TridentAimBwd");
			var tridentAimStrafeAnimationClip18386Path = AssetDatabase.GUIDToAssetPath("3b23654596ddfed499a0c096c21cde62"); 
			var tridentAimStrafeAnimationClip18386 = AnimatorBuilder.GetAnimationClip(tridentAimStrafeAnimationClip18386Path, "TridentAimStrafe");
			var tridentAimAnimationClip20800Path = AssetDatabase.GUIDToAssetPath("7459c2971979759458a27b9871d48f71"); 
			var tridentAimAnimationClip20800 = AnimatorBuilder.GetAnimationClip(tridentAimAnimationClip20800Path, "TridentAim");
			var tridentAimLandAnimationClip16030Path = AssetDatabase.GUIDToAssetPath("2ead76e2020b8f044a5a00dbf8bb2de1"); 
			var tridentAimLandAnimationClip16030 = AnimatorBuilder.GetAnimationClip(tridentAimLandAnimationClip16030Path, "TridentAimLand");

			// State Machine.
			var tridentAnimatorStateMachine34950 = baseStateMachine1227655302.AddStateMachine("Trident", new Vector3(624f, 204f, 0f));

			// States.
			var aimWaterAnimatorState35352 = tridentAnimatorStateMachine34950.AddState("Aim Water", new Vector3(384f, 60f, 0f));
			var aimWaterAnimatorState35352blendTreeBlendTree35766 = new BlendTree();
			AssetDatabase.AddObjectToAsset(aimWaterAnimatorState35352blendTreeBlendTree35766, animatorController);
			aimWaterAnimatorState35352blendTreeBlendTree35766.hideFlags = HideFlags.HideInHierarchy;
			aimWaterAnimatorState35352blendTreeBlendTree35766.blendParameter = "HorizontalMovement";
			aimWaterAnimatorState35352blendTreeBlendTree35766.blendParameterY = "ForwardMovement";
			aimWaterAnimatorState35352blendTreeBlendTree35766.blendType = BlendTreeType.FreeformCartesian2D;
			aimWaterAnimatorState35352blendTreeBlendTree35766.maxThreshold = 1f;
			aimWaterAnimatorState35352blendTreeBlendTree35766.minThreshold = 0f;
			aimWaterAnimatorState35352blendTreeBlendTree35766.name = "Blend Tree";
			aimWaterAnimatorState35352blendTreeBlendTree35766.useAutomaticThresholds = true;
			var aimWaterAnimatorState35352blendTreeBlendTree35766Child0 =  new ChildMotion();
			aimWaterAnimatorState35352blendTreeBlendTree35766Child0.motion = tridentAimBwdAnimationClip29402;
			aimWaterAnimatorState35352blendTreeBlendTree35766Child0.cycleOffset = 0f;
			aimWaterAnimatorState35352blendTreeBlendTree35766Child0.directBlendParameter = "HorizontalMovement";
			aimWaterAnimatorState35352blendTreeBlendTree35766Child0.mirror = false;
			aimWaterAnimatorState35352blendTreeBlendTree35766Child0.position = new Vector2(0f, -1f);
			aimWaterAnimatorState35352blendTreeBlendTree35766Child0.threshold = 0f;
			aimWaterAnimatorState35352blendTreeBlendTree35766Child0.timeScale = 1f;
			var aimWaterAnimatorState35352blendTreeBlendTree35766Child1 =  new ChildMotion();
			aimWaterAnimatorState35352blendTreeBlendTree35766Child1.motion = tridentAimStrafeAnimationClip18386;
			aimWaterAnimatorState35352blendTreeBlendTree35766Child1.cycleOffset = 0f;
			aimWaterAnimatorState35352blendTreeBlendTree35766Child1.directBlendParameter = "HorizontalMovement";
			aimWaterAnimatorState35352blendTreeBlendTree35766Child1.mirror = false;
			aimWaterAnimatorState35352blendTreeBlendTree35766Child1.position = new Vector2(-1f, 0f);
			aimWaterAnimatorState35352blendTreeBlendTree35766Child1.threshold = 0.25f;
			aimWaterAnimatorState35352blendTreeBlendTree35766Child1.timeScale = 1f;
			var aimWaterAnimatorState35352blendTreeBlendTree35766Child2 =  new ChildMotion();
			aimWaterAnimatorState35352blendTreeBlendTree35766Child2.motion = tridentAimAnimationClip20800;
			aimWaterAnimatorState35352blendTreeBlendTree35766Child2.cycleOffset = 0f;
			aimWaterAnimatorState35352blendTreeBlendTree35766Child2.directBlendParameter = "HorizontalMovement";
			aimWaterAnimatorState35352blendTreeBlendTree35766Child2.mirror = false;
			aimWaterAnimatorState35352blendTreeBlendTree35766Child2.position = new Vector2(0f, 0f);
			aimWaterAnimatorState35352blendTreeBlendTree35766Child2.threshold = 0.5f;
			aimWaterAnimatorState35352blendTreeBlendTree35766Child2.timeScale = 1f;
			var aimWaterAnimatorState35352blendTreeBlendTree35766Child3 =  new ChildMotion();
			aimWaterAnimatorState35352blendTreeBlendTree35766Child3.motion = tridentAimStrafeAnimationClip18386;
			aimWaterAnimatorState35352blendTreeBlendTree35766Child3.cycleOffset = 0f;
			aimWaterAnimatorState35352blendTreeBlendTree35766Child3.directBlendParameter = "HorizontalMovement";
			aimWaterAnimatorState35352blendTreeBlendTree35766Child3.mirror = false;
			aimWaterAnimatorState35352blendTreeBlendTree35766Child3.position = new Vector2(1f, 0f);
			aimWaterAnimatorState35352blendTreeBlendTree35766Child3.threshold = 0.75f;
			aimWaterAnimatorState35352blendTreeBlendTree35766Child3.timeScale = 1f;
			var aimWaterAnimatorState35352blendTreeBlendTree35766Child4 =  new ChildMotion();
			aimWaterAnimatorState35352blendTreeBlendTree35766Child4.motion = tridentAimAnimationClip20800;
			aimWaterAnimatorState35352blendTreeBlendTree35766Child4.cycleOffset = 0f;
			aimWaterAnimatorState35352blendTreeBlendTree35766Child4.directBlendParameter = "HorizontalMovement";
			aimWaterAnimatorState35352blendTreeBlendTree35766Child4.mirror = false;
			aimWaterAnimatorState35352blendTreeBlendTree35766Child4.position = new Vector2(0f, 1f);
			aimWaterAnimatorState35352blendTreeBlendTree35766Child4.threshold = 1f;
			aimWaterAnimatorState35352blendTreeBlendTree35766Child4.timeScale = 1f;
			aimWaterAnimatorState35352blendTreeBlendTree35766.children = new ChildMotion[] {
				aimWaterAnimatorState35352blendTreeBlendTree35766Child0,
				aimWaterAnimatorState35352blendTreeBlendTree35766Child1,
				aimWaterAnimatorState35352blendTreeBlendTree35766Child2,
				aimWaterAnimatorState35352blendTreeBlendTree35766Child3,
				aimWaterAnimatorState35352blendTreeBlendTree35766Child4
			};
			aimWaterAnimatorState35352.motion = aimWaterAnimatorState35352blendTreeBlendTree35766;
			aimWaterAnimatorState35352.cycleOffset = 0f;
			aimWaterAnimatorState35352.cycleOffsetParameterActive = false;
			aimWaterAnimatorState35352.iKOnFeet = false;
			aimWaterAnimatorState35352.mirror = false;
			aimWaterAnimatorState35352.mirrorParameterActive = false;
			aimWaterAnimatorState35352.speed = 1f;
			aimWaterAnimatorState35352.speedParameterActive = false;
			aimWaterAnimatorState35352.writeDefaultValues = true;

			var aimLandAnimatorState35384 = tridentAnimatorStateMachine34950.AddState("Aim Land", new Vector3(384f, 0f, 0f));
			aimLandAnimatorState35384.motion = tridentAimLandAnimationClip16030;
			aimLandAnimatorState35384.cycleOffset = 0f;
			aimLandAnimatorState35384.cycleOffsetParameterActive = false;
			aimLandAnimatorState35384.iKOnFeet = false;
			aimLandAnimatorState35384.mirror = false;
			aimLandAnimatorState35384.mirrorParameterActive = false;
			aimLandAnimatorState35384.speed = 1f;
			aimLandAnimatorState35384.speedParameterActive = false;
			aimLandAnimatorState35384.writeDefaultValues = true;

			// State Transitions.
			var animatorStateTransition35762 = aimWaterAnimatorState35352.AddExitTransition();
			animatorStateTransition35762.canTransitionToSelf = true;
			animatorStateTransition35762.duration = 0.25f;
			animatorStateTransition35762.exitTime = 0f;
			animatorStateTransition35762.hasExitTime = false;
			animatorStateTransition35762.hasFixedDuration = true;
			animatorStateTransition35762.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition35762.offset = 0f;
			animatorStateTransition35762.orderedInterruption = true;
			animatorStateTransition35762.isExit = true;
			animatorStateTransition35762.mute = false;
			animatorStateTransition35762.solo = false;
			animatorStateTransition35762.AddCondition(AnimatorConditionMode.NotEqual, 26f, "Slot0ItemID");

			var animatorStateTransition35764 = aimWaterAnimatorState35352.AddExitTransition();
			animatorStateTransition35764.canTransitionToSelf = true;
			animatorStateTransition35764.duration = 0.25f;
			animatorStateTransition35764.exitTime = 0f;
			animatorStateTransition35764.hasExitTime = false;
			animatorStateTransition35764.hasFixedDuration = true;
			animatorStateTransition35764.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition35764.offset = 0f;
			animatorStateTransition35764.orderedInterruption = true;
			animatorStateTransition35764.isExit = true;
			animatorStateTransition35764.mute = false;
			animatorStateTransition35764.solo = false;
			animatorStateTransition35764.AddCondition(AnimatorConditionMode.IfNot, 0f, "Aiming");

			var animatorStateTransition35768 = aimLandAnimatorState35384.AddExitTransition();
			animatorStateTransition35768.canTransitionToSelf = true;
			animatorStateTransition35768.duration = 0.15f;
			animatorStateTransition35768.exitTime = 0f;
			animatorStateTransition35768.hasExitTime = false;
			animatorStateTransition35768.hasFixedDuration = true;
			animatorStateTransition35768.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition35768.offset = 0f;
			animatorStateTransition35768.orderedInterruption = true;
			animatorStateTransition35768.isExit = true;
			animatorStateTransition35768.mute = false;
			animatorStateTransition35768.solo = false;
			animatorStateTransition35768.AddCondition(AnimatorConditionMode.NotEqual, 26f, "Slot0ItemID");

			var animatorStateTransition35770 = aimLandAnimatorState35384.AddExitTransition();
			animatorStateTransition35770.canTransitionToSelf = true;
			animatorStateTransition35770.duration = 0.15f;
			animatorStateTransition35770.exitTime = 0f;
			animatorStateTransition35770.hasExitTime = false;
			animatorStateTransition35770.hasFixedDuration = true;
			animatorStateTransition35770.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition35770.offset = 0f;
			animatorStateTransition35770.orderedInterruption = true;
			animatorStateTransition35770.isExit = true;
			animatorStateTransition35770.mute = false;
			animatorStateTransition35770.solo = false;
			animatorStateTransition35770.AddCondition(AnimatorConditionMode.IfNot, 0f, "Aiming");

			// State Machine Defaults.
			tridentAnimatorStateMachine34950.anyStatePosition = new Vector3(50f, 20f, 0f);
			tridentAnimatorStateMachine34950.defaultState = aimWaterAnimatorState35352;
			tridentAnimatorStateMachine34950.entryPosition = new Vector3(50f, 120f, 0f);
			tridentAnimatorStateMachine34950.exitPosition = new Vector3(800f, 120f, 0f);
			tridentAnimatorStateMachine34950.parentStateMachinePosition = new Vector3(800f, 20f, 0f);

			var baseStateMachine1299744904 = animatorController.layers[3].stateMachine;

			// The state machine should start fresh.
			for (int i = 0; i < animatorController.layers.Length; ++i) {
				for (int j = 0; j < baseStateMachine1299744904.stateMachines.Length; ++j) {
					if (baseStateMachine1299744904.stateMachines[j].stateMachine.name == "Underwater Gun") {
						baseStateMachine1299744904.RemoveStateMachine(baseStateMachine1299744904.stateMachines[j].stateMachine);
						break;
					}
				}
			}

			// AnimationClip references.
			var underwaterGunUnequipFromAimLandAnimationClip25762Path = AssetDatabase.GUIDToAssetPath("721f647ca7925b545ac8c7f61fc52e70"); 
			var underwaterGunUnequipFromAimLandAnimationClip25762 = AnimatorBuilder.GetAnimationClip(underwaterGunUnequipFromAimLandAnimationClip25762Path, "UnderwaterGunUnequipFromAimLand");
			var underwaterGunEquipFromAimLandAnimationClip16726Path = AssetDatabase.GUIDToAssetPath("ca1e4aa3f69753b49a943a147431fa92"); 
			var underwaterGunEquipFromAimLandAnimationClip16726 = AnimatorBuilder.GetAnimationClip(underwaterGunEquipFromAimLandAnimationClip16726Path, "UnderwaterGunEquipFromAimLand");
			var underwaterGunEquipFromIdleLandAnimationClip21246Path = AssetDatabase.GUIDToAssetPath("79dd6fe7e9b79e24f8e03530a53ffac6"); 
			var underwaterGunEquipFromIdleLandAnimationClip21246 = AnimatorBuilder.GetAnimationClip(underwaterGunEquipFromIdleLandAnimationClip21246Path, "UnderwaterGunEquipFromIdleLand");
			var underwaterGunDropLandAnimationClip22892Path = AssetDatabase.GUIDToAssetPath("10638b29e54942c4a85aed37b4ffb959"); 
			var underwaterGunDropLandAnimationClip22892 = AnimatorBuilder.GetAnimationClip(underwaterGunDropLandAnimationClip22892Path, "UnderwaterGunDropLand");
			var underwaterGunIdleLandAnimationClip21656Path = AssetDatabase.GUIDToAssetPath("d5ac8d1801a8b2b42bf9f42101d745a0"); 
			var underwaterGunIdleLandAnimationClip21656 = AnimatorBuilder.GetAnimationClip(underwaterGunIdleLandAnimationClip21656Path, "UnderwaterGunIdleLand");
			var underwaterGunAimLandAnimationClip25976Path = AssetDatabase.GUIDToAssetPath("61c2f2ac67418014bb259550547d31c7"); 
			var underwaterGunAimLandAnimationClip25976 = AnimatorBuilder.GetAnimationClip(underwaterGunAimLandAnimationClip25976Path, "UnderwaterGunAimLand");
			var underwaterGunFireLandAnimationClip26056Path = AssetDatabase.GUIDToAssetPath("2c4975bc16f2e2d488e6705318e32a92"); 
			var underwaterGunFireLandAnimationClip26056 = AnimatorBuilder.GetAnimationClip(underwaterGunFireLandAnimationClip26056Path, "UnderwaterGunFireLand");
			var underwaterGunFireStrafeAnimationClip22664Path = AssetDatabase.GUIDToAssetPath("9c1724098a8521747acf7a5b0e63cc67"); 
			var underwaterGunFireStrafeAnimationClip22664 = AnimatorBuilder.GetAnimationClip(underwaterGunFireStrafeAnimationClip22664Path, "UnderwaterGunFireStrafe");
			var underwaterGunFireAnimationClip29798Path = AssetDatabase.GUIDToAssetPath("18156ecfb59e8ae4595703fddc1939a4"); 
			var underwaterGunFireAnimationClip29798 = AnimatorBuilder.GetAnimationClip(underwaterGunFireAnimationClip29798Path, "UnderwaterGunFire");
			var underwaterGunAimStrafeAnimationClip20408Path = AssetDatabase.GUIDToAssetPath("e0859a37264257345b1b27f8f2adace1"); 
			var underwaterGunAimStrafeAnimationClip20408 = AnimatorBuilder.GetAnimationClip(underwaterGunAimStrafeAnimationClip20408Path, "UnderwaterGunAimStrafe");
			var underwaterGunAimAnimationClip25670Path = AssetDatabase.GUIDToAssetPath("ea90e76c69b5dac41b0f0dbee1c486fe"); 
			var underwaterGunAimAnimationClip25670 = AnimatorBuilder.GetAnimationClip(underwaterGunAimAnimationClip25670Path, "UnderwaterGunAim");
			var underwaterGunIdleStrafeAnimationClip26406Path = AssetDatabase.GUIDToAssetPath("1ce7681d2f2345b4e881131942d5eb7b"); 
			var underwaterGunIdleStrafeAnimationClip26406 = AnimatorBuilder.GetAnimationClip(underwaterGunIdleStrafeAnimationClip26406Path, "UnderwaterGunIdleStrafe");
			var underwaterGunIdleAnimationClip23044Path = AssetDatabase.GUIDToAssetPath("dd83fc596d1210143bc3b2b50c61124e"); 
			var underwaterGunIdleAnimationClip23044 = AnimatorBuilder.GetAnimationClip(underwaterGunIdleAnimationClip23044Path, "UnderwaterGunIdle");
			var underwaterGunDropStrafeAnimationClip17190Path = AssetDatabase.GUIDToAssetPath("a68a1714e46821741b53ae17a67efa4c"); 
			var underwaterGunDropStrafeAnimationClip17190 = AnimatorBuilder.GetAnimationClip(underwaterGunDropStrafeAnimationClip17190Path, "UnderwaterGunDropStrafe");
			var underwaterGunDropAnimationClip13600Path = AssetDatabase.GUIDToAssetPath("b4d39e80ba9664840abca8241b43665f"); 
			var underwaterGunDropAnimationClip13600 = AnimatorBuilder.GetAnimationClip(underwaterGunDropAnimationClip13600Path, "UnderwaterGunDrop");
			var underwaterGunEquipFromIdleStrafeAnimationClip29814Path = AssetDatabase.GUIDToAssetPath("567464df1b0be0c4682de5c69b509784"); 
			var underwaterGunEquipFromIdleStrafeAnimationClip29814 = AnimatorBuilder.GetAnimationClip(underwaterGunEquipFromIdleStrafeAnimationClip29814Path, "UnderwaterGunEquipFromIdleStrafe");
			var underwaterGunEquipFromIdleAnimationClip19166Path = AssetDatabase.GUIDToAssetPath("085123f580067e9408bb4644102a74fb"); 
			var underwaterGunEquipFromIdleAnimationClip19166 = AnimatorBuilder.GetAnimationClip(underwaterGunEquipFromIdleAnimationClip19166Path, "UnderwaterGunEquipFromIdle");
			var underwaterGunEquipFromAimStrafeAnimationClip22506Path = AssetDatabase.GUIDToAssetPath("5bb3fdd8073bd3145b5b2928c66c734f"); 
			var underwaterGunEquipFromAimStrafeAnimationClip22506 = AnimatorBuilder.GetAnimationClip(underwaterGunEquipFromAimStrafeAnimationClip22506Path, "UnderwaterGunEquipFromAimStrafe");
			var underwaterGunEquipFromAimAnimationClip19138Path = AssetDatabase.GUIDToAssetPath("afd46ae593ba8c04a82c28b5bdf0e36a"); 
			var underwaterGunEquipFromAimAnimationClip19138 = AnimatorBuilder.GetAnimationClip(underwaterGunEquipFromAimAnimationClip19138Path, "UnderwaterGunEquipFromAim");
			var underwaterGunUnequipFromAimStrafeAnimationClip23604Path = AssetDatabase.GUIDToAssetPath("75639ef9d4aa3b74c82c8ad6b9708bd3"); 
			var underwaterGunUnequipFromAimStrafeAnimationClip23604 = AnimatorBuilder.GetAnimationClip(underwaterGunUnequipFromAimStrafeAnimationClip23604Path, "UnderwaterGunUnequipFromAimStrafe");
			var underwaterGunUnequipFromAimAnimationClip22528Path = AssetDatabase.GUIDToAssetPath("c81201e8deaa85147bf8993a3fca205f"); 
			var underwaterGunUnequipFromAimAnimationClip22528 = AnimatorBuilder.GetAnimationClip(underwaterGunUnequipFromAimAnimationClip22528Path, "UnderwaterGunUnequipFromAim");
			var underwaterGunUnequipFromIdleLandAnimationClip23408Path = AssetDatabase.GUIDToAssetPath("7d0010c9ac2cd534dbda1b07ee98a9cd"); 
			var underwaterGunUnequipFromIdleLandAnimationClip23408 = AnimatorBuilder.GetAnimationClip(underwaterGunUnequipFromIdleLandAnimationClip23408Path, "UnderwaterGunUnequipFromIdleLand");
			var underwaterGunUnequipFromIdleStrafeAnimationClip14186Path = AssetDatabase.GUIDToAssetPath("ded0b711b659eca43a979b6fa2300874"); 
			var underwaterGunUnequipFromIdleStrafeAnimationClip14186 = AnimatorBuilder.GetAnimationClip(underwaterGunUnequipFromIdleStrafeAnimationClip14186Path, "UnderwaterGunUnequipFromIdleStrafe");
			var underwaterGunUnequipFromIdleAnimationClip15246Path = AssetDatabase.GUIDToAssetPath("ce536312b48abf34a8f6590cece82921"); 
			var underwaterGunUnequipFromIdleAnimationClip15246 = AnimatorBuilder.GetAnimationClip(underwaterGunUnequipFromIdleAnimationClip15246Path, "UnderwaterGunUnequipFromIdle");

			// State Machine.
			var underwaterGunAnimatorStateMachine34952 = baseStateMachine1299744904.AddStateMachine("Underwater Gun", new Vector3(384f, 348f, 0f));

			// States.
			var unequipFromIdleLandAnimatorState35354 = underwaterGunAnimatorStateMachine34952.AddState("Unequip From Idle Land", new Vector3(384f, -36f, 0f));
			unequipFromIdleLandAnimatorState35354.motion = underwaterGunUnequipFromAimLandAnimationClip25762;
			unequipFromIdleLandAnimatorState35354.cycleOffset = 0f;
			unequipFromIdleLandAnimatorState35354.cycleOffsetParameterActive = false;
			unequipFromIdleLandAnimatorState35354.iKOnFeet = false;
			unequipFromIdleLandAnimatorState35354.mirror = false;
			unequipFromIdleLandAnimatorState35354.mirrorParameterActive = false;
			unequipFromIdleLandAnimatorState35354.speed = 3f;
			unequipFromIdleLandAnimatorState35354.speedParameterActive = false;
			unequipFromIdleLandAnimatorState35354.writeDefaultValues = true;

			var unequipFromAimLandAnimatorState35356 = underwaterGunAnimatorStateMachine34952.AddState("Unequip From Aim Land", new Vector3(384f, -156f, 0f));
			unequipFromAimLandAnimatorState35356.motion = underwaterGunUnequipFromAimLandAnimationClip25762;
			unequipFromAimLandAnimatorState35356.cycleOffset = 0f;
			unequipFromAimLandAnimatorState35356.cycleOffsetParameterActive = false;
			unequipFromAimLandAnimatorState35356.iKOnFeet = false;
			unequipFromAimLandAnimatorState35356.mirror = false;
			unequipFromAimLandAnimatorState35356.mirrorParameterActive = false;
			unequipFromAimLandAnimatorState35356.speed = 3f;
			unequipFromAimLandAnimatorState35356.speedParameterActive = false;
			unequipFromAimLandAnimatorState35356.writeDefaultValues = true;

			var equipFromAimLandAnimatorState35358 = underwaterGunAnimatorStateMachine34952.AddState("Equip From Aim Land", new Vector3(384f, -216f, 0f));
			equipFromAimLandAnimatorState35358.motion = underwaterGunEquipFromAimLandAnimationClip16726;
			equipFromAimLandAnimatorState35358.cycleOffset = 0f;
			equipFromAimLandAnimatorState35358.cycleOffsetParameterActive = false;
			equipFromAimLandAnimatorState35358.iKOnFeet = false;
			equipFromAimLandAnimatorState35358.mirror = false;
			equipFromAimLandAnimatorState35358.mirrorParameterActive = false;
			equipFromAimLandAnimatorState35358.speed = 3f;
			equipFromAimLandAnimatorState35358.speedParameterActive = false;
			equipFromAimLandAnimatorState35358.writeDefaultValues = true;

			var equipFromIdleLandAnimatorState35360 = underwaterGunAnimatorStateMachine34952.AddState("Equip From Idle Land", new Vector3(384f, -96f, 0f));
			equipFromIdleLandAnimatorState35360.motion = underwaterGunEquipFromIdleLandAnimationClip21246;
			equipFromIdleLandAnimatorState35360.cycleOffset = 0f;
			equipFromIdleLandAnimatorState35360.cycleOffsetParameterActive = false;
			equipFromIdleLandAnimatorState35360.iKOnFeet = false;
			equipFromIdleLandAnimatorState35360.mirror = false;
			equipFromIdleLandAnimatorState35360.mirrorParameterActive = false;
			equipFromIdleLandAnimatorState35360.speed = 3f;
			equipFromIdleLandAnimatorState35360.speedParameterActive = false;
			equipFromIdleLandAnimatorState35360.writeDefaultValues = true;

			var dropLandAnimatorState35362 = underwaterGunAnimatorStateMachine34952.AddState("Drop Land", new Vector3(384f, 24f, 0f));
			dropLandAnimatorState35362.motion = underwaterGunDropLandAnimationClip22892;
			dropLandAnimatorState35362.cycleOffset = 0f;
			dropLandAnimatorState35362.cycleOffsetParameterActive = false;
			dropLandAnimatorState35362.iKOnFeet = false;
			dropLandAnimatorState35362.mirror = false;
			dropLandAnimatorState35362.mirrorParameterActive = false;
			dropLandAnimatorState35362.speed = 1f;
			dropLandAnimatorState35362.speedParameterActive = false;
			dropLandAnimatorState35362.writeDefaultValues = true;

			var idleLandAnimatorState35364 = underwaterGunAnimatorStateMachine34952.AddState("Idle Land", new Vector3(384f, -336f, 0f));
			idleLandAnimatorState35364.motion = underwaterGunIdleLandAnimationClip21656;
			idleLandAnimatorState35364.cycleOffset = 0f;
			idleLandAnimatorState35364.cycleOffsetParameterActive = false;
			idleLandAnimatorState35364.iKOnFeet = false;
			idleLandAnimatorState35364.mirror = false;
			idleLandAnimatorState35364.mirrorParameterActive = false;
			idleLandAnimatorState35364.speed = 1f;
			idleLandAnimatorState35364.speedParameterActive = false;
			idleLandAnimatorState35364.writeDefaultValues = true;

			var aimLandAnimatorState35366 = underwaterGunAnimatorStateMachine34952.AddState("Aim Land", new Vector3(384f, -276f, 0f));
			aimLandAnimatorState35366.motion = underwaterGunAimLandAnimationClip25976;
			aimLandAnimatorState35366.cycleOffset = 0f;
			aimLandAnimatorState35366.cycleOffsetParameterActive = false;
			aimLandAnimatorState35366.iKOnFeet = false;
			aimLandAnimatorState35366.mirror = false;
			aimLandAnimatorState35366.mirrorParameterActive = false;
			aimLandAnimatorState35366.speed = 1f;
			aimLandAnimatorState35366.speedParameterActive = false;
			aimLandAnimatorState35366.writeDefaultValues = true;

			var fireWaterAnimatorState35368 = underwaterGunAnimatorStateMachine34952.AddState("Fire Water", new Vector3(384f, 204f, 0f));
			var fireWaterAnimatorState35368blendTreeBlendTree35788 = new BlendTree();
			AssetDatabase.AddObjectToAsset(fireWaterAnimatorState35368blendTreeBlendTree35788, animatorController);
			fireWaterAnimatorState35368blendTreeBlendTree35788.hideFlags = HideFlags.HideInHierarchy;
			fireWaterAnimatorState35368blendTreeBlendTree35788.blendParameter = "HorizontalMovement";
			fireWaterAnimatorState35368blendTreeBlendTree35788.blendParameterY = "ForwardMovement";
			fireWaterAnimatorState35368blendTreeBlendTree35788.blendType = BlendTreeType.FreeformCartesian2D;
			fireWaterAnimatorState35368blendTreeBlendTree35788.maxThreshold = 1f;
			fireWaterAnimatorState35368blendTreeBlendTree35788.minThreshold = 0f;
			fireWaterAnimatorState35368blendTreeBlendTree35788.name = "Blend Tree";
			fireWaterAnimatorState35368blendTreeBlendTree35788.useAutomaticThresholds = true;
			var fireWaterAnimatorState35368blendTreeBlendTree35788Child0 =  new ChildMotion();
			fireWaterAnimatorState35368blendTreeBlendTree35788Child0.motion = underwaterGunFireLandAnimationClip26056;
			fireWaterAnimatorState35368blendTreeBlendTree35788Child0.cycleOffset = 0f;
			fireWaterAnimatorState35368blendTreeBlendTree35788Child0.directBlendParameter = "HorizontalMovement";
			fireWaterAnimatorState35368blendTreeBlendTree35788Child0.mirror = false;
			fireWaterAnimatorState35368blendTreeBlendTree35788Child0.position = new Vector2(0f, -1f);
			fireWaterAnimatorState35368blendTreeBlendTree35788Child0.threshold = 0f;
			fireWaterAnimatorState35368blendTreeBlendTree35788Child0.timeScale = 1f;
			var fireWaterAnimatorState35368blendTreeBlendTree35788Child1 =  new ChildMotion();
			fireWaterAnimatorState35368blendTreeBlendTree35788Child1.motion = underwaterGunFireStrafeAnimationClip22664;
			fireWaterAnimatorState35368blendTreeBlendTree35788Child1.cycleOffset = 0f;
			fireWaterAnimatorState35368blendTreeBlendTree35788Child1.directBlendParameter = "HorizontalMovement";
			fireWaterAnimatorState35368blendTreeBlendTree35788Child1.mirror = false;
			fireWaterAnimatorState35368blendTreeBlendTree35788Child1.position = new Vector2(-1f, 0f);
			fireWaterAnimatorState35368blendTreeBlendTree35788Child1.threshold = 0.25f;
			fireWaterAnimatorState35368blendTreeBlendTree35788Child1.timeScale = 1f;
			var fireWaterAnimatorState35368blendTreeBlendTree35788Child2 =  new ChildMotion();
			fireWaterAnimatorState35368blendTreeBlendTree35788Child2.motion = underwaterGunFireAnimationClip29798;
			fireWaterAnimatorState35368blendTreeBlendTree35788Child2.cycleOffset = 0f;
			fireWaterAnimatorState35368blendTreeBlendTree35788Child2.directBlendParameter = "HorizontalMovement";
			fireWaterAnimatorState35368blendTreeBlendTree35788Child2.mirror = false;
			fireWaterAnimatorState35368blendTreeBlendTree35788Child2.position = new Vector2(0f, 0f);
			fireWaterAnimatorState35368blendTreeBlendTree35788Child2.threshold = 0.5f;
			fireWaterAnimatorState35368blendTreeBlendTree35788Child2.timeScale = 1f;
			var fireWaterAnimatorState35368blendTreeBlendTree35788Child3 =  new ChildMotion();
			fireWaterAnimatorState35368blendTreeBlendTree35788Child3.motion = underwaterGunFireStrafeAnimationClip22664;
			fireWaterAnimatorState35368blendTreeBlendTree35788Child3.cycleOffset = 0.5f;
			fireWaterAnimatorState35368blendTreeBlendTree35788Child3.directBlendParameter = "HorizontalMovement";
			fireWaterAnimatorState35368blendTreeBlendTree35788Child3.mirror = true;
			fireWaterAnimatorState35368blendTreeBlendTree35788Child3.position = new Vector2(1f, 0f);
			fireWaterAnimatorState35368blendTreeBlendTree35788Child3.threshold = 0.75f;
			fireWaterAnimatorState35368blendTreeBlendTree35788Child3.timeScale = 1f;
			var fireWaterAnimatorState35368blendTreeBlendTree35788Child4 =  new ChildMotion();
			fireWaterAnimatorState35368blendTreeBlendTree35788Child4.motion = underwaterGunFireAnimationClip29798;
			fireWaterAnimatorState35368blendTreeBlendTree35788Child4.cycleOffset = 0f;
			fireWaterAnimatorState35368blendTreeBlendTree35788Child4.directBlendParameter = "HorizontalMovement";
			fireWaterAnimatorState35368blendTreeBlendTree35788Child4.mirror = false;
			fireWaterAnimatorState35368blendTreeBlendTree35788Child4.position = new Vector2(0f, 1f);
			fireWaterAnimatorState35368blendTreeBlendTree35788Child4.threshold = 1f;
			fireWaterAnimatorState35368blendTreeBlendTree35788Child4.timeScale = 1f;
			fireWaterAnimatorState35368blendTreeBlendTree35788.children = new ChildMotion[] {
				fireWaterAnimatorState35368blendTreeBlendTree35788Child0,
				fireWaterAnimatorState35368blendTreeBlendTree35788Child1,
				fireWaterAnimatorState35368blendTreeBlendTree35788Child2,
				fireWaterAnimatorState35368blendTreeBlendTree35788Child3,
				fireWaterAnimatorState35368blendTreeBlendTree35788Child4
			};
			fireWaterAnimatorState35368.motion = fireWaterAnimatorState35368blendTreeBlendTree35788;
			fireWaterAnimatorState35368.cycleOffset = 0f;
			fireWaterAnimatorState35368.cycleOffsetParameterActive = false;
			fireWaterAnimatorState35368.iKOnFeet = false;
			fireWaterAnimatorState35368.mirror = false;
			fireWaterAnimatorState35368.mirrorParameterActive = false;
			fireWaterAnimatorState35368.speed = 1.75f;
			fireWaterAnimatorState35368.speedParameterActive = false;
			fireWaterAnimatorState35368.writeDefaultValues = true;

			var aimWaterAnimatorState35370 = underwaterGunAnimatorStateMachine34952.AddState("Aim Water", new Vector3(384f, 144f, 0f));
			var aimWaterAnimatorState35370blendTreeBlendTree35792 = new BlendTree();
			AssetDatabase.AddObjectToAsset(aimWaterAnimatorState35370blendTreeBlendTree35792, animatorController);
			aimWaterAnimatorState35370blendTreeBlendTree35792.hideFlags = HideFlags.HideInHierarchy;
			aimWaterAnimatorState35370blendTreeBlendTree35792.blendParameter = "HorizontalMovement";
			aimWaterAnimatorState35370blendTreeBlendTree35792.blendParameterY = "ForwardMovement";
			aimWaterAnimatorState35370blendTreeBlendTree35792.blendType = BlendTreeType.FreeformCartesian2D;
			aimWaterAnimatorState35370blendTreeBlendTree35792.maxThreshold = 1f;
			aimWaterAnimatorState35370blendTreeBlendTree35792.minThreshold = 0f;
			aimWaterAnimatorState35370blendTreeBlendTree35792.name = "Blend Tree";
			aimWaterAnimatorState35370blendTreeBlendTree35792.useAutomaticThresholds = true;
			var aimWaterAnimatorState35370blendTreeBlendTree35792Child0 =  new ChildMotion();
			aimWaterAnimatorState35370blendTreeBlendTree35792Child0.motion = underwaterGunAimLandAnimationClip25976;
			aimWaterAnimatorState35370blendTreeBlendTree35792Child0.cycleOffset = 0f;
			aimWaterAnimatorState35370blendTreeBlendTree35792Child0.directBlendParameter = "HorizontalMovement";
			aimWaterAnimatorState35370blendTreeBlendTree35792Child0.mirror = false;
			aimWaterAnimatorState35370blendTreeBlendTree35792Child0.position = new Vector2(0f, -1f);
			aimWaterAnimatorState35370blendTreeBlendTree35792Child0.threshold = 0f;
			aimWaterAnimatorState35370blendTreeBlendTree35792Child0.timeScale = 1f;
			var aimWaterAnimatorState35370blendTreeBlendTree35792Child1 =  new ChildMotion();
			aimWaterAnimatorState35370blendTreeBlendTree35792Child1.motion = underwaterGunAimStrafeAnimationClip20408;
			aimWaterAnimatorState35370blendTreeBlendTree35792Child1.cycleOffset = 0f;
			aimWaterAnimatorState35370blendTreeBlendTree35792Child1.directBlendParameter = "HorizontalMovement";
			aimWaterAnimatorState35370blendTreeBlendTree35792Child1.mirror = false;
			aimWaterAnimatorState35370blendTreeBlendTree35792Child1.position = new Vector2(-1f, 0f);
			aimWaterAnimatorState35370blendTreeBlendTree35792Child1.threshold = 0.25f;
			aimWaterAnimatorState35370blendTreeBlendTree35792Child1.timeScale = 1f;
			var aimWaterAnimatorState35370blendTreeBlendTree35792Child2 =  new ChildMotion();
			aimWaterAnimatorState35370blendTreeBlendTree35792Child2.motion = underwaterGunAimAnimationClip25670;
			aimWaterAnimatorState35370blendTreeBlendTree35792Child2.cycleOffset = 0f;
			aimWaterAnimatorState35370blendTreeBlendTree35792Child2.directBlendParameter = "HorizontalMovement";
			aimWaterAnimatorState35370blendTreeBlendTree35792Child2.mirror = false;
			aimWaterAnimatorState35370blendTreeBlendTree35792Child2.position = new Vector2(0f, 0f);
			aimWaterAnimatorState35370blendTreeBlendTree35792Child2.threshold = 0.5f;
			aimWaterAnimatorState35370blendTreeBlendTree35792Child2.timeScale = 1f;
			var aimWaterAnimatorState35370blendTreeBlendTree35792Child3 =  new ChildMotion();
			aimWaterAnimatorState35370blendTreeBlendTree35792Child3.motion = underwaterGunAimStrafeAnimationClip20408;
			aimWaterAnimatorState35370blendTreeBlendTree35792Child3.cycleOffset = 0.5f;
			aimWaterAnimatorState35370blendTreeBlendTree35792Child3.directBlendParameter = "HorizontalMovement";
			aimWaterAnimatorState35370blendTreeBlendTree35792Child3.mirror = true;
			aimWaterAnimatorState35370blendTreeBlendTree35792Child3.position = new Vector2(1f, 0f);
			aimWaterAnimatorState35370blendTreeBlendTree35792Child3.threshold = 0.75f;
			aimWaterAnimatorState35370blendTreeBlendTree35792Child3.timeScale = 1f;
			var aimWaterAnimatorState35370blendTreeBlendTree35792Child4 =  new ChildMotion();
			aimWaterAnimatorState35370blendTreeBlendTree35792Child4.motion = underwaterGunAimAnimationClip25670;
			aimWaterAnimatorState35370blendTreeBlendTree35792Child4.cycleOffset = 0f;
			aimWaterAnimatorState35370blendTreeBlendTree35792Child4.directBlendParameter = "HorizontalMovement";
			aimWaterAnimatorState35370blendTreeBlendTree35792Child4.mirror = false;
			aimWaterAnimatorState35370blendTreeBlendTree35792Child4.position = new Vector2(0f, 1f);
			aimWaterAnimatorState35370blendTreeBlendTree35792Child4.threshold = 1f;
			aimWaterAnimatorState35370blendTreeBlendTree35792Child4.timeScale = 1f;
			aimWaterAnimatorState35370blendTreeBlendTree35792.children = new ChildMotion[] {
				aimWaterAnimatorState35370blendTreeBlendTree35792Child0,
				aimWaterAnimatorState35370blendTreeBlendTree35792Child1,
				aimWaterAnimatorState35370blendTreeBlendTree35792Child2,
				aimWaterAnimatorState35370blendTreeBlendTree35792Child3,
				aimWaterAnimatorState35370blendTreeBlendTree35792Child4
			};
			aimWaterAnimatorState35370.motion = aimWaterAnimatorState35370blendTreeBlendTree35792;
			aimWaterAnimatorState35370.cycleOffset = 0f;
			aimWaterAnimatorState35370.cycleOffsetParameterActive = false;
			aimWaterAnimatorState35370.iKOnFeet = false;
			aimWaterAnimatorState35370.mirror = false;
			aimWaterAnimatorState35370.mirrorParameterActive = false;
			aimWaterAnimatorState35370.speed = 1f;
			aimWaterAnimatorState35370.speedParameterActive = false;
			aimWaterAnimatorState35370.writeDefaultValues = true;

			var idleWaterAnimatorState35372 = underwaterGunAnimatorStateMachine34952.AddState("Idle Water", new Vector3(384f, 84f, 0f));
			var idleWaterAnimatorState35372blendTreeBlendTree35796 = new BlendTree();
			AssetDatabase.AddObjectToAsset(idleWaterAnimatorState35372blendTreeBlendTree35796, animatorController);
			idleWaterAnimatorState35372blendTreeBlendTree35796.hideFlags = HideFlags.HideInHierarchy;
			idleWaterAnimatorState35372blendTreeBlendTree35796.blendParameter = "HorizontalMovement";
			idleWaterAnimatorState35372blendTreeBlendTree35796.blendParameterY = "ForwardMovement";
			idleWaterAnimatorState35372blendTreeBlendTree35796.blendType = BlendTreeType.FreeformCartesian2D;
			idleWaterAnimatorState35372blendTreeBlendTree35796.maxThreshold = 1f;
			idleWaterAnimatorState35372blendTreeBlendTree35796.minThreshold = 0f;
			idleWaterAnimatorState35372blendTreeBlendTree35796.name = "Blend Tree";
			idleWaterAnimatorState35372blendTreeBlendTree35796.useAutomaticThresholds = true;
			var idleWaterAnimatorState35372blendTreeBlendTree35796Child0 =  new ChildMotion();
			idleWaterAnimatorState35372blendTreeBlendTree35796Child0.motion = underwaterGunIdleLandAnimationClip21656;
			idleWaterAnimatorState35372blendTreeBlendTree35796Child0.cycleOffset = 0f;
			idleWaterAnimatorState35372blendTreeBlendTree35796Child0.directBlendParameter = "HorizontalMovement";
			idleWaterAnimatorState35372blendTreeBlendTree35796Child0.mirror = false;
			idleWaterAnimatorState35372blendTreeBlendTree35796Child0.position = new Vector2(0f, -1f);
			idleWaterAnimatorState35372blendTreeBlendTree35796Child0.threshold = 0f;
			idleWaterAnimatorState35372blendTreeBlendTree35796Child0.timeScale = 1f;
			var idleWaterAnimatorState35372blendTreeBlendTree35796Child1 =  new ChildMotion();
			idleWaterAnimatorState35372blendTreeBlendTree35796Child1.motion = underwaterGunIdleStrafeAnimationClip26406;
			idleWaterAnimatorState35372blendTreeBlendTree35796Child1.cycleOffset = 0f;
			idleWaterAnimatorState35372blendTreeBlendTree35796Child1.directBlendParameter = "HorizontalMovement";
			idleWaterAnimatorState35372blendTreeBlendTree35796Child1.mirror = false;
			idleWaterAnimatorState35372blendTreeBlendTree35796Child1.position = new Vector2(-1f, 0f);
			idleWaterAnimatorState35372blendTreeBlendTree35796Child1.threshold = 0.25f;
			idleWaterAnimatorState35372blendTreeBlendTree35796Child1.timeScale = 1f;
			var idleWaterAnimatorState35372blendTreeBlendTree35796Child2 =  new ChildMotion();
			idleWaterAnimatorState35372blendTreeBlendTree35796Child2.motion = underwaterGunIdleAnimationClip23044;
			idleWaterAnimatorState35372blendTreeBlendTree35796Child2.cycleOffset = 0f;
			idleWaterAnimatorState35372blendTreeBlendTree35796Child2.directBlendParameter = "HorizontalMovement";
			idleWaterAnimatorState35372blendTreeBlendTree35796Child2.mirror = false;
			idleWaterAnimatorState35372blendTreeBlendTree35796Child2.position = new Vector2(0f, 0f);
			idleWaterAnimatorState35372blendTreeBlendTree35796Child2.threshold = 0.5f;
			idleWaterAnimatorState35372blendTreeBlendTree35796Child2.timeScale = 1f;
			var idleWaterAnimatorState35372blendTreeBlendTree35796Child3 =  new ChildMotion();
			idleWaterAnimatorState35372blendTreeBlendTree35796Child3.motion = underwaterGunIdleStrafeAnimationClip26406;
			idleWaterAnimatorState35372blendTreeBlendTree35796Child3.cycleOffset = 0f;
			idleWaterAnimatorState35372blendTreeBlendTree35796Child3.directBlendParameter = "HorizontalMovement";
			idleWaterAnimatorState35372blendTreeBlendTree35796Child3.mirror = false;
			idleWaterAnimatorState35372blendTreeBlendTree35796Child3.position = new Vector2(1f, 0f);
			idleWaterAnimatorState35372blendTreeBlendTree35796Child3.threshold = 0.75f;
			idleWaterAnimatorState35372blendTreeBlendTree35796Child3.timeScale = 1f;
			var idleWaterAnimatorState35372blendTreeBlendTree35796Child4 =  new ChildMotion();
			idleWaterAnimatorState35372blendTreeBlendTree35796Child4.motion = underwaterGunIdleAnimationClip23044;
			idleWaterAnimatorState35372blendTreeBlendTree35796Child4.cycleOffset = 0f;
			idleWaterAnimatorState35372blendTreeBlendTree35796Child4.directBlendParameter = "HorizontalMovement";
			idleWaterAnimatorState35372blendTreeBlendTree35796Child4.mirror = false;
			idleWaterAnimatorState35372blendTreeBlendTree35796Child4.position = new Vector2(0f, 1f);
			idleWaterAnimatorState35372blendTreeBlendTree35796Child4.threshold = 1f;
			idleWaterAnimatorState35372blendTreeBlendTree35796Child4.timeScale = 1f;
			idleWaterAnimatorState35372blendTreeBlendTree35796.children = new ChildMotion[] {
				idleWaterAnimatorState35372blendTreeBlendTree35796Child0,
				idleWaterAnimatorState35372blendTreeBlendTree35796Child1,
				idleWaterAnimatorState35372blendTreeBlendTree35796Child2,
				idleWaterAnimatorState35372blendTreeBlendTree35796Child3,
				idleWaterAnimatorState35372blendTreeBlendTree35796Child4
			};
			idleWaterAnimatorState35372.motion = idleWaterAnimatorState35372blendTreeBlendTree35796;
			idleWaterAnimatorState35372.cycleOffset = 0f;
			idleWaterAnimatorState35372.cycleOffsetParameterActive = false;
			idleWaterAnimatorState35372.iKOnFeet = false;
			idleWaterAnimatorState35372.mirror = false;
			idleWaterAnimatorState35372.mirrorParameterActive = false;
			idleWaterAnimatorState35372.speed = 1f;
			idleWaterAnimatorState35372.speedParameterActive = false;
			idleWaterAnimatorState35372.writeDefaultValues = true;

			var dropWaterAnimatorState35374 = underwaterGunAnimatorStateMachine34952.AddState("Drop Water", new Vector3(384f, 504f, 0f));
			var dropWaterAnimatorState35374blendTreeBlendTree35800 = new BlendTree();
			AssetDatabase.AddObjectToAsset(dropWaterAnimatorState35374blendTreeBlendTree35800, animatorController);
			dropWaterAnimatorState35374blendTreeBlendTree35800.hideFlags = HideFlags.HideInHierarchy;
			dropWaterAnimatorState35374blendTreeBlendTree35800.blendParameter = "HorizontalMovement";
			dropWaterAnimatorState35374blendTreeBlendTree35800.blendParameterY = "ForwardMovement";
			dropWaterAnimatorState35374blendTreeBlendTree35800.blendType = BlendTreeType.FreeformCartesian2D;
			dropWaterAnimatorState35374blendTreeBlendTree35800.maxThreshold = 1f;
			dropWaterAnimatorState35374blendTreeBlendTree35800.minThreshold = 0f;
			dropWaterAnimatorState35374blendTreeBlendTree35800.name = "Blend Tree";
			dropWaterAnimatorState35374blendTreeBlendTree35800.useAutomaticThresholds = true;
			var dropWaterAnimatorState35374blendTreeBlendTree35800Child0 =  new ChildMotion();
			dropWaterAnimatorState35374blendTreeBlendTree35800Child0.motion = underwaterGunDropLandAnimationClip22892;
			dropWaterAnimatorState35374blendTreeBlendTree35800Child0.cycleOffset = 0f;
			dropWaterAnimatorState35374blendTreeBlendTree35800Child0.directBlendParameter = "HorizontalMovement";
			dropWaterAnimatorState35374blendTreeBlendTree35800Child0.mirror = false;
			dropWaterAnimatorState35374blendTreeBlendTree35800Child0.position = new Vector2(0f, -1f);
			dropWaterAnimatorState35374blendTreeBlendTree35800Child0.threshold = 0f;
			dropWaterAnimatorState35374blendTreeBlendTree35800Child0.timeScale = 1f;
			var dropWaterAnimatorState35374blendTreeBlendTree35800Child1 =  new ChildMotion();
			dropWaterAnimatorState35374blendTreeBlendTree35800Child1.motion = underwaterGunDropStrafeAnimationClip17190;
			dropWaterAnimatorState35374blendTreeBlendTree35800Child1.cycleOffset = 0f;
			dropWaterAnimatorState35374blendTreeBlendTree35800Child1.directBlendParameter = "HorizontalMovement";
			dropWaterAnimatorState35374blendTreeBlendTree35800Child1.mirror = false;
			dropWaterAnimatorState35374blendTreeBlendTree35800Child1.position = new Vector2(-1f, 0f);
			dropWaterAnimatorState35374blendTreeBlendTree35800Child1.threshold = 0.25f;
			dropWaterAnimatorState35374blendTreeBlendTree35800Child1.timeScale = 1f;
			var dropWaterAnimatorState35374blendTreeBlendTree35800Child2 =  new ChildMotion();
			dropWaterAnimatorState35374blendTreeBlendTree35800Child2.motion = underwaterGunDropAnimationClip13600;
			dropWaterAnimatorState35374blendTreeBlendTree35800Child2.cycleOffset = 0f;
			dropWaterAnimatorState35374blendTreeBlendTree35800Child2.directBlendParameter = "HorizontalMovement";
			dropWaterAnimatorState35374blendTreeBlendTree35800Child2.mirror = false;
			dropWaterAnimatorState35374blendTreeBlendTree35800Child2.position = new Vector2(0f, 0f);
			dropWaterAnimatorState35374blendTreeBlendTree35800Child2.threshold = 0.5f;
			dropWaterAnimatorState35374blendTreeBlendTree35800Child2.timeScale = 1f;
			var dropWaterAnimatorState35374blendTreeBlendTree35800Child3 =  new ChildMotion();
			dropWaterAnimatorState35374blendTreeBlendTree35800Child3.motion = underwaterGunDropStrafeAnimationClip17190;
			dropWaterAnimatorState35374blendTreeBlendTree35800Child3.cycleOffset = 0f;
			dropWaterAnimatorState35374blendTreeBlendTree35800Child3.directBlendParameter = "HorizontalMovement";
			dropWaterAnimatorState35374blendTreeBlendTree35800Child3.mirror = false;
			dropWaterAnimatorState35374blendTreeBlendTree35800Child3.position = new Vector2(1f, 0f);
			dropWaterAnimatorState35374blendTreeBlendTree35800Child3.threshold = 0.75f;
			dropWaterAnimatorState35374blendTreeBlendTree35800Child3.timeScale = 1f;
			var dropWaterAnimatorState35374blendTreeBlendTree35800Child4 =  new ChildMotion();
			dropWaterAnimatorState35374blendTreeBlendTree35800Child4.motion = underwaterGunDropAnimationClip13600;
			dropWaterAnimatorState35374blendTreeBlendTree35800Child4.cycleOffset = 0f;
			dropWaterAnimatorState35374blendTreeBlendTree35800Child4.directBlendParameter = "HorizontalMovement";
			dropWaterAnimatorState35374blendTreeBlendTree35800Child4.mirror = false;
			dropWaterAnimatorState35374blendTreeBlendTree35800Child4.position = new Vector2(0f, 1f);
			dropWaterAnimatorState35374blendTreeBlendTree35800Child4.threshold = 1f;
			dropWaterAnimatorState35374blendTreeBlendTree35800Child4.timeScale = 1f;
			dropWaterAnimatorState35374blendTreeBlendTree35800.children = new ChildMotion[] {
				dropWaterAnimatorState35374blendTreeBlendTree35800Child0,
				dropWaterAnimatorState35374blendTreeBlendTree35800Child1,
				dropWaterAnimatorState35374blendTreeBlendTree35800Child2,
				dropWaterAnimatorState35374blendTreeBlendTree35800Child3,
				dropWaterAnimatorState35374blendTreeBlendTree35800Child4
			};
			dropWaterAnimatorState35374.motion = dropWaterAnimatorState35374blendTreeBlendTree35800;
			dropWaterAnimatorState35374.cycleOffset = 0f;
			dropWaterAnimatorState35374.cycleOffsetParameterActive = false;
			dropWaterAnimatorState35374.iKOnFeet = false;
			dropWaterAnimatorState35374.mirror = false;
			dropWaterAnimatorState35374.mirrorParameterActive = false;
			dropWaterAnimatorState35374.speed = 1f;
			dropWaterAnimatorState35374.speedParameterActive = false;
			dropWaterAnimatorState35374.writeDefaultValues = true;

			var equipFromIdleWaterAnimatorState35376 = underwaterGunAnimatorStateMachine34952.AddState("Equip From Idle Water", new Vector3(384f, 384f, 0f));
			var equipFromIdleWaterAnimatorState35376blendTreeBlendTree35804 = new BlendTree();
			AssetDatabase.AddObjectToAsset(equipFromIdleWaterAnimatorState35376blendTreeBlendTree35804, animatorController);
			equipFromIdleWaterAnimatorState35376blendTreeBlendTree35804.hideFlags = HideFlags.HideInHierarchy;
			equipFromIdleWaterAnimatorState35376blendTreeBlendTree35804.blendParameter = "HorizontalMovement";
			equipFromIdleWaterAnimatorState35376blendTreeBlendTree35804.blendParameterY = "ForwardMovement";
			equipFromIdleWaterAnimatorState35376blendTreeBlendTree35804.blendType = BlendTreeType.FreeformCartesian2D;
			equipFromIdleWaterAnimatorState35376blendTreeBlendTree35804.maxThreshold = 1f;
			equipFromIdleWaterAnimatorState35376blendTreeBlendTree35804.minThreshold = 0f;
			equipFromIdleWaterAnimatorState35376blendTreeBlendTree35804.name = "Blend Tree";
			equipFromIdleWaterAnimatorState35376blendTreeBlendTree35804.useAutomaticThresholds = true;
			var equipFromIdleWaterAnimatorState35376blendTreeBlendTree35804Child0 =  new ChildMotion();
			equipFromIdleWaterAnimatorState35376blendTreeBlendTree35804Child0.motion = underwaterGunEquipFromIdleLandAnimationClip21246;
			equipFromIdleWaterAnimatorState35376blendTreeBlendTree35804Child0.cycleOffset = 0f;
			equipFromIdleWaterAnimatorState35376blendTreeBlendTree35804Child0.directBlendParameter = "HorizontalMovement";
			equipFromIdleWaterAnimatorState35376blendTreeBlendTree35804Child0.mirror = false;
			equipFromIdleWaterAnimatorState35376blendTreeBlendTree35804Child0.position = new Vector2(0f, -1f);
			equipFromIdleWaterAnimatorState35376blendTreeBlendTree35804Child0.threshold = 0f;
			equipFromIdleWaterAnimatorState35376blendTreeBlendTree35804Child0.timeScale = 1f;
			var equipFromIdleWaterAnimatorState35376blendTreeBlendTree35804Child1 =  new ChildMotion();
			equipFromIdleWaterAnimatorState35376blendTreeBlendTree35804Child1.motion = underwaterGunEquipFromIdleStrafeAnimationClip29814;
			equipFromIdleWaterAnimatorState35376blendTreeBlendTree35804Child1.cycleOffset = 0f;
			equipFromIdleWaterAnimatorState35376blendTreeBlendTree35804Child1.directBlendParameter = "HorizontalMovement";
			equipFromIdleWaterAnimatorState35376blendTreeBlendTree35804Child1.mirror = false;
			equipFromIdleWaterAnimatorState35376blendTreeBlendTree35804Child1.position = new Vector2(-1f, 0f);
			equipFromIdleWaterAnimatorState35376blendTreeBlendTree35804Child1.threshold = 0.25f;
			equipFromIdleWaterAnimatorState35376blendTreeBlendTree35804Child1.timeScale = 1f;
			var equipFromIdleWaterAnimatorState35376blendTreeBlendTree35804Child2 =  new ChildMotion();
			equipFromIdleWaterAnimatorState35376blendTreeBlendTree35804Child2.motion = underwaterGunEquipFromIdleAnimationClip19166;
			equipFromIdleWaterAnimatorState35376blendTreeBlendTree35804Child2.cycleOffset = 0f;
			equipFromIdleWaterAnimatorState35376blendTreeBlendTree35804Child2.directBlendParameter = "HorizontalMovement";
			equipFromIdleWaterAnimatorState35376blendTreeBlendTree35804Child2.mirror = false;
			equipFromIdleWaterAnimatorState35376blendTreeBlendTree35804Child2.position = new Vector2(0f, 0f);
			equipFromIdleWaterAnimatorState35376blendTreeBlendTree35804Child2.threshold = 0.5f;
			equipFromIdleWaterAnimatorState35376blendTreeBlendTree35804Child2.timeScale = 1f;
			var equipFromIdleWaterAnimatorState35376blendTreeBlendTree35804Child3 =  new ChildMotion();
			equipFromIdleWaterAnimatorState35376blendTreeBlendTree35804Child3.motion = underwaterGunEquipFromIdleStrafeAnimationClip29814;
			equipFromIdleWaterAnimatorState35376blendTreeBlendTree35804Child3.cycleOffset = 0f;
			equipFromIdleWaterAnimatorState35376blendTreeBlendTree35804Child3.directBlendParameter = "HorizontalMovement";
			equipFromIdleWaterAnimatorState35376blendTreeBlendTree35804Child3.mirror = false;
			equipFromIdleWaterAnimatorState35376blendTreeBlendTree35804Child3.position = new Vector2(1f, 0f);
			equipFromIdleWaterAnimatorState35376blendTreeBlendTree35804Child3.threshold = 0.75f;
			equipFromIdleWaterAnimatorState35376blendTreeBlendTree35804Child3.timeScale = 1f;
			var equipFromIdleWaterAnimatorState35376blendTreeBlendTree35804Child4 =  new ChildMotion();
			equipFromIdleWaterAnimatorState35376blendTreeBlendTree35804Child4.motion = underwaterGunEquipFromIdleAnimationClip19166;
			equipFromIdleWaterAnimatorState35376blendTreeBlendTree35804Child4.cycleOffset = 0f;
			equipFromIdleWaterAnimatorState35376blendTreeBlendTree35804Child4.directBlendParameter = "HorizontalMovement";
			equipFromIdleWaterAnimatorState35376blendTreeBlendTree35804Child4.mirror = false;
			equipFromIdleWaterAnimatorState35376blendTreeBlendTree35804Child4.position = new Vector2(0f, 1f);
			equipFromIdleWaterAnimatorState35376blendTreeBlendTree35804Child4.threshold = 1f;
			equipFromIdleWaterAnimatorState35376blendTreeBlendTree35804Child4.timeScale = 1f;
			equipFromIdleWaterAnimatorState35376blendTreeBlendTree35804.children = new ChildMotion[] {
				equipFromIdleWaterAnimatorState35376blendTreeBlendTree35804Child0,
				equipFromIdleWaterAnimatorState35376blendTreeBlendTree35804Child1,
				equipFromIdleWaterAnimatorState35376blendTreeBlendTree35804Child2,
				equipFromIdleWaterAnimatorState35376blendTreeBlendTree35804Child3,
				equipFromIdleWaterAnimatorState35376blendTreeBlendTree35804Child4
			};
			equipFromIdleWaterAnimatorState35376.motion = equipFromIdleWaterAnimatorState35376blendTreeBlendTree35804;
			equipFromIdleWaterAnimatorState35376.cycleOffset = 0f;
			equipFromIdleWaterAnimatorState35376.cycleOffsetParameterActive = false;
			equipFromIdleWaterAnimatorState35376.iKOnFeet = false;
			equipFromIdleWaterAnimatorState35376.mirror = false;
			equipFromIdleWaterAnimatorState35376.mirrorParameterActive = false;
			equipFromIdleWaterAnimatorState35376.speed = 3f;
			equipFromIdleWaterAnimatorState35376.speedParameterActive = false;
			equipFromIdleWaterAnimatorState35376.writeDefaultValues = true;

			var equipFromAimWaterAnimatorState35378 = underwaterGunAnimatorStateMachine34952.AddState("Equip From Aim Water", new Vector3(384f, 264f, 0f));
			var equipFromAimWaterAnimatorState35378blendTreeBlendTree35808 = new BlendTree();
			AssetDatabase.AddObjectToAsset(equipFromAimWaterAnimatorState35378blendTreeBlendTree35808, animatorController);
			equipFromAimWaterAnimatorState35378blendTreeBlendTree35808.hideFlags = HideFlags.HideInHierarchy;
			equipFromAimWaterAnimatorState35378blendTreeBlendTree35808.blendParameter = "HorizontalMovement";
			equipFromAimWaterAnimatorState35378blendTreeBlendTree35808.blendParameterY = "ForwardMovement";
			equipFromAimWaterAnimatorState35378blendTreeBlendTree35808.blendType = BlendTreeType.FreeformCartesian2D;
			equipFromAimWaterAnimatorState35378blendTreeBlendTree35808.maxThreshold = 1.333333f;
			equipFromAimWaterAnimatorState35378blendTreeBlendTree35808.minThreshold = 0f;
			equipFromAimWaterAnimatorState35378blendTreeBlendTree35808.name = "Blend Tree";
			equipFromAimWaterAnimatorState35378blendTreeBlendTree35808.useAutomaticThresholds = false;
			var equipFromAimWaterAnimatorState35378blendTreeBlendTree35808Child0 =  new ChildMotion();
			equipFromAimWaterAnimatorState35378blendTreeBlendTree35808Child0.motion = underwaterGunEquipFromAimLandAnimationClip16726;
			equipFromAimWaterAnimatorState35378blendTreeBlendTree35808Child0.cycleOffset = 0f;
			equipFromAimWaterAnimatorState35378blendTreeBlendTree35808Child0.directBlendParameter = "HorizontalMovement";
			equipFromAimWaterAnimatorState35378blendTreeBlendTree35808Child0.mirror = false;
			equipFromAimWaterAnimatorState35378blendTreeBlendTree35808Child0.position = new Vector2(0f, -1f);
			equipFromAimWaterAnimatorState35378blendTreeBlendTree35808Child0.threshold = 0f;
			equipFromAimWaterAnimatorState35378blendTreeBlendTree35808Child0.timeScale = 1f;
			var equipFromAimWaterAnimatorState35378blendTreeBlendTree35808Child1 =  new ChildMotion();
			equipFromAimWaterAnimatorState35378blendTreeBlendTree35808Child1.motion = underwaterGunEquipFromAimStrafeAnimationClip22506;
			equipFromAimWaterAnimatorState35378blendTreeBlendTree35808Child1.cycleOffset = 0f;
			equipFromAimWaterAnimatorState35378blendTreeBlendTree35808Child1.directBlendParameter = "HorizontalMovement";
			equipFromAimWaterAnimatorState35378blendTreeBlendTree35808Child1.mirror = false;
			equipFromAimWaterAnimatorState35378blendTreeBlendTree35808Child1.position = new Vector2(-1f, 0f);
			equipFromAimWaterAnimatorState35378blendTreeBlendTree35808Child1.threshold = 0.3333333f;
			equipFromAimWaterAnimatorState35378blendTreeBlendTree35808Child1.timeScale = 1f;
			var equipFromAimWaterAnimatorState35378blendTreeBlendTree35808Child2 =  new ChildMotion();
			equipFromAimWaterAnimatorState35378blendTreeBlendTree35808Child2.motion = underwaterGunEquipFromAimAnimationClip19138;
			equipFromAimWaterAnimatorState35378blendTreeBlendTree35808Child2.cycleOffset = 0f;
			equipFromAimWaterAnimatorState35378blendTreeBlendTree35808Child2.directBlendParameter = "HorizontalMovement";
			equipFromAimWaterAnimatorState35378blendTreeBlendTree35808Child2.mirror = false;
			equipFromAimWaterAnimatorState35378blendTreeBlendTree35808Child2.position = new Vector2(0f, 0f);
			equipFromAimWaterAnimatorState35378blendTreeBlendTree35808Child2.threshold = 0.6666667f;
			equipFromAimWaterAnimatorState35378blendTreeBlendTree35808Child2.timeScale = 1f;
			var equipFromAimWaterAnimatorState35378blendTreeBlendTree35808Child3 =  new ChildMotion();
			equipFromAimWaterAnimatorState35378blendTreeBlendTree35808Child3.motion = underwaterGunEquipFromAimStrafeAnimationClip22506;
			equipFromAimWaterAnimatorState35378blendTreeBlendTree35808Child3.cycleOffset = 0.5f;
			equipFromAimWaterAnimatorState35378blendTreeBlendTree35808Child3.directBlendParameter = "HorizontalMovement";
			equipFromAimWaterAnimatorState35378blendTreeBlendTree35808Child3.mirror = true;
			equipFromAimWaterAnimatorState35378blendTreeBlendTree35808Child3.position = new Vector2(1f, 0f);
			equipFromAimWaterAnimatorState35378blendTreeBlendTree35808Child3.threshold = 1f;
			equipFromAimWaterAnimatorState35378blendTreeBlendTree35808Child3.timeScale = 1f;
			var equipFromAimWaterAnimatorState35378blendTreeBlendTree35808Child4 =  new ChildMotion();
			equipFromAimWaterAnimatorState35378blendTreeBlendTree35808Child4.motion = underwaterGunEquipFromAimAnimationClip19138;
			equipFromAimWaterAnimatorState35378blendTreeBlendTree35808Child4.cycleOffset = 0f;
			equipFromAimWaterAnimatorState35378blendTreeBlendTree35808Child4.directBlendParameter = "HorizontalMovement";
			equipFromAimWaterAnimatorState35378blendTreeBlendTree35808Child4.mirror = false;
			equipFromAimWaterAnimatorState35378blendTreeBlendTree35808Child4.position = new Vector2(0f, 1f);
			equipFromAimWaterAnimatorState35378blendTreeBlendTree35808Child4.threshold = 1.333333f;
			equipFromAimWaterAnimatorState35378blendTreeBlendTree35808Child4.timeScale = 1f;
			equipFromAimWaterAnimatorState35378blendTreeBlendTree35808.children = new ChildMotion[] {
				equipFromAimWaterAnimatorState35378blendTreeBlendTree35808Child0,
				equipFromAimWaterAnimatorState35378blendTreeBlendTree35808Child1,
				equipFromAimWaterAnimatorState35378blendTreeBlendTree35808Child2,
				equipFromAimWaterAnimatorState35378blendTreeBlendTree35808Child3,
				equipFromAimWaterAnimatorState35378blendTreeBlendTree35808Child4
			};
			equipFromAimWaterAnimatorState35378.motion = equipFromAimWaterAnimatorState35378blendTreeBlendTree35808;
			equipFromAimWaterAnimatorState35378.cycleOffset = 0f;
			equipFromAimWaterAnimatorState35378.cycleOffsetParameterActive = false;
			equipFromAimWaterAnimatorState35378.iKOnFeet = false;
			equipFromAimWaterAnimatorState35378.mirror = false;
			equipFromAimWaterAnimatorState35378.mirrorParameterActive = false;
			equipFromAimWaterAnimatorState35378.speed = 3f;
			equipFromAimWaterAnimatorState35378.speedParameterActive = false;
			equipFromAimWaterAnimatorState35378.writeDefaultValues = true;

			var unequipFromAimWaterAnimatorState35380 = underwaterGunAnimatorStateMachine34952.AddState("Unequip From Aim Water", new Vector3(384f, 324f, 0f));
			var unequipFromAimWaterAnimatorState35380blendTreeBlendTree35812 = new BlendTree();
			AssetDatabase.AddObjectToAsset(unequipFromAimWaterAnimatorState35380blendTreeBlendTree35812, animatorController);
			unequipFromAimWaterAnimatorState35380blendTreeBlendTree35812.hideFlags = HideFlags.HideInHierarchy;
			unequipFromAimWaterAnimatorState35380blendTreeBlendTree35812.blendParameter = "HorizontalMovement";
			unequipFromAimWaterAnimatorState35380blendTreeBlendTree35812.blendParameterY = "ForwardMovement";
			unequipFromAimWaterAnimatorState35380blendTreeBlendTree35812.blendType = BlendTreeType.FreeformCartesian2D;
			unequipFromAimWaterAnimatorState35380blendTreeBlendTree35812.maxThreshold = 1f;
			unequipFromAimWaterAnimatorState35380blendTreeBlendTree35812.minThreshold = 0f;
			unequipFromAimWaterAnimatorState35380blendTreeBlendTree35812.name = "Blend Tree";
			unequipFromAimWaterAnimatorState35380blendTreeBlendTree35812.useAutomaticThresholds = true;
			var unequipFromAimWaterAnimatorState35380blendTreeBlendTree35812Child0 =  new ChildMotion();
			unequipFromAimWaterAnimatorState35380blendTreeBlendTree35812Child0.motion = underwaterGunUnequipFromAimLandAnimationClip25762;
			unequipFromAimWaterAnimatorState35380blendTreeBlendTree35812Child0.cycleOffset = 0f;
			unequipFromAimWaterAnimatorState35380blendTreeBlendTree35812Child0.directBlendParameter = "HorizontalMovement";
			unequipFromAimWaterAnimatorState35380blendTreeBlendTree35812Child0.mirror = false;
			unequipFromAimWaterAnimatorState35380blendTreeBlendTree35812Child0.position = new Vector2(0f, -1f);
			unequipFromAimWaterAnimatorState35380blendTreeBlendTree35812Child0.threshold = 0f;
			unequipFromAimWaterAnimatorState35380blendTreeBlendTree35812Child0.timeScale = 1f;
			var unequipFromAimWaterAnimatorState35380blendTreeBlendTree35812Child1 =  new ChildMotion();
			unequipFromAimWaterAnimatorState35380blendTreeBlendTree35812Child1.motion = underwaterGunUnequipFromAimStrafeAnimationClip23604;
			unequipFromAimWaterAnimatorState35380blendTreeBlendTree35812Child1.cycleOffset = 0f;
			unequipFromAimWaterAnimatorState35380blendTreeBlendTree35812Child1.directBlendParameter = "HorizontalMovement";
			unequipFromAimWaterAnimatorState35380blendTreeBlendTree35812Child1.mirror = false;
			unequipFromAimWaterAnimatorState35380blendTreeBlendTree35812Child1.position = new Vector2(-1f, 0f);
			unequipFromAimWaterAnimatorState35380blendTreeBlendTree35812Child1.threshold = 0.25f;
			unequipFromAimWaterAnimatorState35380blendTreeBlendTree35812Child1.timeScale = 1f;
			var unequipFromAimWaterAnimatorState35380blendTreeBlendTree35812Child2 =  new ChildMotion();
			unequipFromAimWaterAnimatorState35380blendTreeBlendTree35812Child2.motion = underwaterGunUnequipFromAimAnimationClip22528;
			unequipFromAimWaterAnimatorState35380blendTreeBlendTree35812Child2.cycleOffset = 0f;
			unequipFromAimWaterAnimatorState35380blendTreeBlendTree35812Child2.directBlendParameter = "HorizontalMovement";
			unequipFromAimWaterAnimatorState35380blendTreeBlendTree35812Child2.mirror = false;
			unequipFromAimWaterAnimatorState35380blendTreeBlendTree35812Child2.position = new Vector2(0f, 0f);
			unequipFromAimWaterAnimatorState35380blendTreeBlendTree35812Child2.threshold = 0.5f;
			unequipFromAimWaterAnimatorState35380blendTreeBlendTree35812Child2.timeScale = 1f;
			var unequipFromAimWaterAnimatorState35380blendTreeBlendTree35812Child3 =  new ChildMotion();
			unequipFromAimWaterAnimatorState35380blendTreeBlendTree35812Child3.motion = underwaterGunUnequipFromAimStrafeAnimationClip23604;
			unequipFromAimWaterAnimatorState35380blendTreeBlendTree35812Child3.cycleOffset = 0f;
			unequipFromAimWaterAnimatorState35380blendTreeBlendTree35812Child3.directBlendParameter = "HorizontalMovement";
			unequipFromAimWaterAnimatorState35380blendTreeBlendTree35812Child3.mirror = false;
			unequipFromAimWaterAnimatorState35380blendTreeBlendTree35812Child3.position = new Vector2(1f, 0f);
			unequipFromAimWaterAnimatorState35380blendTreeBlendTree35812Child3.threshold = 0.75f;
			unequipFromAimWaterAnimatorState35380blendTreeBlendTree35812Child3.timeScale = 1f;
			var unequipFromAimWaterAnimatorState35380blendTreeBlendTree35812Child4 =  new ChildMotion();
			unequipFromAimWaterAnimatorState35380blendTreeBlendTree35812Child4.motion = underwaterGunUnequipFromAimAnimationClip22528;
			unequipFromAimWaterAnimatorState35380blendTreeBlendTree35812Child4.cycleOffset = 0f;
			unequipFromAimWaterAnimatorState35380blendTreeBlendTree35812Child4.directBlendParameter = "HorizontalMovement";
			unequipFromAimWaterAnimatorState35380blendTreeBlendTree35812Child4.mirror = false;
			unequipFromAimWaterAnimatorState35380blendTreeBlendTree35812Child4.position = new Vector2(0f, 1f);
			unequipFromAimWaterAnimatorState35380blendTreeBlendTree35812Child4.threshold = 1f;
			unequipFromAimWaterAnimatorState35380blendTreeBlendTree35812Child4.timeScale = 1f;
			unequipFromAimWaterAnimatorState35380blendTreeBlendTree35812.children = new ChildMotion[] {
				unequipFromAimWaterAnimatorState35380blendTreeBlendTree35812Child0,
				unequipFromAimWaterAnimatorState35380blendTreeBlendTree35812Child1,
				unequipFromAimWaterAnimatorState35380blendTreeBlendTree35812Child2,
				unequipFromAimWaterAnimatorState35380blendTreeBlendTree35812Child3,
				unequipFromAimWaterAnimatorState35380blendTreeBlendTree35812Child4
			};
			unequipFromAimWaterAnimatorState35380.motion = unequipFromAimWaterAnimatorState35380blendTreeBlendTree35812;
			unequipFromAimWaterAnimatorState35380.cycleOffset = 0f;
			unequipFromAimWaterAnimatorState35380.cycleOffsetParameterActive = false;
			unequipFromAimWaterAnimatorState35380.iKOnFeet = false;
			unequipFromAimWaterAnimatorState35380.mirror = false;
			unequipFromAimWaterAnimatorState35380.mirrorParameterActive = false;
			unequipFromAimWaterAnimatorState35380.speed = 3f;
			unequipFromAimWaterAnimatorState35380.speedParameterActive = false;
			unequipFromAimWaterAnimatorState35380.writeDefaultValues = true;

			var unequipFromIdleWaterAnimatorState35382 = underwaterGunAnimatorStateMachine34952.AddState("Unequip From Idle Water", new Vector3(384f, 444f, 0f));
			var unequipFromIdleWaterAnimatorState35382blendTreeBlendTree35816 = new BlendTree();
			AssetDatabase.AddObjectToAsset(unequipFromIdleWaterAnimatorState35382blendTreeBlendTree35816, animatorController);
			unequipFromIdleWaterAnimatorState35382blendTreeBlendTree35816.hideFlags = HideFlags.HideInHierarchy;
			unequipFromIdleWaterAnimatorState35382blendTreeBlendTree35816.blendParameter = "HorizontalMovement";
			unequipFromIdleWaterAnimatorState35382blendTreeBlendTree35816.blendParameterY = "ForwardMovement";
			unequipFromIdleWaterAnimatorState35382blendTreeBlendTree35816.blendType = BlendTreeType.FreeformCartesian2D;
			unequipFromIdleWaterAnimatorState35382blendTreeBlendTree35816.maxThreshold = 1f;
			unequipFromIdleWaterAnimatorState35382blendTreeBlendTree35816.minThreshold = 0f;
			unequipFromIdleWaterAnimatorState35382blendTreeBlendTree35816.name = "Blend Tree";
			unequipFromIdleWaterAnimatorState35382blendTreeBlendTree35816.useAutomaticThresholds = true;
			var unequipFromIdleWaterAnimatorState35382blendTreeBlendTree35816Child0 =  new ChildMotion();
			unequipFromIdleWaterAnimatorState35382blendTreeBlendTree35816Child0.motion = underwaterGunUnequipFromIdleLandAnimationClip23408;
			unequipFromIdleWaterAnimatorState35382blendTreeBlendTree35816Child0.cycleOffset = 0f;
			unequipFromIdleWaterAnimatorState35382blendTreeBlendTree35816Child0.directBlendParameter = "HorizontalMovement";
			unequipFromIdleWaterAnimatorState35382blendTreeBlendTree35816Child0.mirror = false;
			unequipFromIdleWaterAnimatorState35382blendTreeBlendTree35816Child0.position = new Vector2(0f, -1f);
			unequipFromIdleWaterAnimatorState35382blendTreeBlendTree35816Child0.threshold = 0f;
			unequipFromIdleWaterAnimatorState35382blendTreeBlendTree35816Child0.timeScale = 1f;
			var unequipFromIdleWaterAnimatorState35382blendTreeBlendTree35816Child1 =  new ChildMotion();
			unequipFromIdleWaterAnimatorState35382blendTreeBlendTree35816Child1.motion = underwaterGunUnequipFromIdleStrafeAnimationClip14186;
			unequipFromIdleWaterAnimatorState35382blendTreeBlendTree35816Child1.cycleOffset = 0f;
			unequipFromIdleWaterAnimatorState35382blendTreeBlendTree35816Child1.directBlendParameter = "HorizontalMovement";
			unequipFromIdleWaterAnimatorState35382blendTreeBlendTree35816Child1.mirror = false;
			unequipFromIdleWaterAnimatorState35382blendTreeBlendTree35816Child1.position = new Vector2(-1f, 0f);
			unequipFromIdleWaterAnimatorState35382blendTreeBlendTree35816Child1.threshold = 0.25f;
			unequipFromIdleWaterAnimatorState35382blendTreeBlendTree35816Child1.timeScale = 1f;
			var unequipFromIdleWaterAnimatorState35382blendTreeBlendTree35816Child2 =  new ChildMotion();
			unequipFromIdleWaterAnimatorState35382blendTreeBlendTree35816Child2.motion = underwaterGunUnequipFromIdleAnimationClip15246;
			unequipFromIdleWaterAnimatorState35382blendTreeBlendTree35816Child2.cycleOffset = 0f;
			unequipFromIdleWaterAnimatorState35382blendTreeBlendTree35816Child2.directBlendParameter = "HorizontalMovement";
			unequipFromIdleWaterAnimatorState35382blendTreeBlendTree35816Child2.mirror = false;
			unequipFromIdleWaterAnimatorState35382blendTreeBlendTree35816Child2.position = new Vector2(0f, 0f);
			unequipFromIdleWaterAnimatorState35382blendTreeBlendTree35816Child2.threshold = 0.5f;
			unequipFromIdleWaterAnimatorState35382blendTreeBlendTree35816Child2.timeScale = 1f;
			var unequipFromIdleWaterAnimatorState35382blendTreeBlendTree35816Child3 =  new ChildMotion();
			unequipFromIdleWaterAnimatorState35382blendTreeBlendTree35816Child3.motion = underwaterGunUnequipFromIdleStrafeAnimationClip14186;
			unequipFromIdleWaterAnimatorState35382blendTreeBlendTree35816Child3.cycleOffset = 0f;
			unequipFromIdleWaterAnimatorState35382blendTreeBlendTree35816Child3.directBlendParameter = "HorizontalMovement";
			unequipFromIdleWaterAnimatorState35382blendTreeBlendTree35816Child3.mirror = false;
			unequipFromIdleWaterAnimatorState35382blendTreeBlendTree35816Child3.position = new Vector2(1f, 0f);
			unequipFromIdleWaterAnimatorState35382blendTreeBlendTree35816Child3.threshold = 0.75f;
			unequipFromIdleWaterAnimatorState35382blendTreeBlendTree35816Child3.timeScale = 1f;
			var unequipFromIdleWaterAnimatorState35382blendTreeBlendTree35816Child4 =  new ChildMotion();
			unequipFromIdleWaterAnimatorState35382blendTreeBlendTree35816Child4.motion = underwaterGunUnequipFromIdleAnimationClip15246;
			unequipFromIdleWaterAnimatorState35382blendTreeBlendTree35816Child4.cycleOffset = 0f;
			unequipFromIdleWaterAnimatorState35382blendTreeBlendTree35816Child4.directBlendParameter = "HorizontalMovement";
			unequipFromIdleWaterAnimatorState35382blendTreeBlendTree35816Child4.mirror = false;
			unequipFromIdleWaterAnimatorState35382blendTreeBlendTree35816Child4.position = new Vector2(0f, 1f);
			unequipFromIdleWaterAnimatorState35382blendTreeBlendTree35816Child4.threshold = 1f;
			unequipFromIdleWaterAnimatorState35382blendTreeBlendTree35816Child4.timeScale = 1f;
			unequipFromIdleWaterAnimatorState35382blendTreeBlendTree35816.children = new ChildMotion[] {
				unequipFromIdleWaterAnimatorState35382blendTreeBlendTree35816Child0,
				unequipFromIdleWaterAnimatorState35382blendTreeBlendTree35816Child1,
				unequipFromIdleWaterAnimatorState35382blendTreeBlendTree35816Child2,
				unequipFromIdleWaterAnimatorState35382blendTreeBlendTree35816Child3,
				unequipFromIdleWaterAnimatorState35382blendTreeBlendTree35816Child4
			};
			unequipFromIdleWaterAnimatorState35382.motion = unequipFromIdleWaterAnimatorState35382blendTreeBlendTree35816;
			unequipFromIdleWaterAnimatorState35382.cycleOffset = 0f;
			unequipFromIdleWaterAnimatorState35382.cycleOffsetParameterActive = false;
			unequipFromIdleWaterAnimatorState35382.iKOnFeet = false;
			unequipFromIdleWaterAnimatorState35382.mirror = false;
			unequipFromIdleWaterAnimatorState35382.mirrorParameterActive = false;
			unequipFromIdleWaterAnimatorState35382.speed = 3f;
			unequipFromIdleWaterAnimatorState35382.speedParameterActive = false;
			unequipFromIdleWaterAnimatorState35382.writeDefaultValues = true;

			// State Transitions.
			var animatorStateTransition35772 = unequipFromIdleLandAnimatorState35354.AddExitTransition();
			animatorStateTransition35772.canTransitionToSelf = true;
			animatorStateTransition35772.duration = 0.2f;
			animatorStateTransition35772.exitTime = 0.75f;
			animatorStateTransition35772.hasExitTime = false;
			animatorStateTransition35772.hasFixedDuration = true;
			animatorStateTransition35772.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition35772.offset = 0f;
			animatorStateTransition35772.orderedInterruption = true;
			animatorStateTransition35772.isExit = true;
			animatorStateTransition35772.mute = false;
			animatorStateTransition35772.solo = false;
			animatorStateTransition35772.AddCondition(AnimatorConditionMode.NotEqual, 5f, "Slot0ItemStateIndex");

			var animatorStateTransition35774 = unequipFromAimLandAnimatorState35356.AddExitTransition();
			animatorStateTransition35774.canTransitionToSelf = true;
			animatorStateTransition35774.duration = 0.2f;
			animatorStateTransition35774.exitTime = 0.8846154f;
			animatorStateTransition35774.hasExitTime = false;
			animatorStateTransition35774.hasFixedDuration = true;
			animatorStateTransition35774.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition35774.offset = 0f;
			animatorStateTransition35774.orderedInterruption = true;
			animatorStateTransition35774.isExit = true;
			animatorStateTransition35774.mute = false;
			animatorStateTransition35774.solo = false;
			animatorStateTransition35774.AddCondition(AnimatorConditionMode.NotEqual, 5f, "Slot0ItemStateIndex");

			var animatorStateTransition35776 = equipFromAimLandAnimatorState35358.AddExitTransition();
			animatorStateTransition35776.canTransitionToSelf = true;
			animatorStateTransition35776.duration = 0.2f;
			animatorStateTransition35776.exitTime = 0.8846154f;
			animatorStateTransition35776.hasExitTime = false;
			animatorStateTransition35776.hasFixedDuration = true;
			animatorStateTransition35776.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition35776.offset = 0f;
			animatorStateTransition35776.orderedInterruption = true;
			animatorStateTransition35776.isExit = true;
			animatorStateTransition35776.mute = false;
			animatorStateTransition35776.solo = false;
			animatorStateTransition35776.AddCondition(AnimatorConditionMode.NotEqual, 4f, "Slot0ItemStateIndex");

			var animatorStateTransition35778 = equipFromIdleLandAnimatorState35360.AddExitTransition();
			animatorStateTransition35778.canTransitionToSelf = true;
			animatorStateTransition35778.duration = 0.2f;
			animatorStateTransition35778.exitTime = 0.75f;
			animatorStateTransition35778.hasExitTime = false;
			animatorStateTransition35778.hasFixedDuration = true;
			animatorStateTransition35778.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition35778.offset = 0f;
			animatorStateTransition35778.orderedInterruption = true;
			animatorStateTransition35778.isExit = true;
			animatorStateTransition35778.mute = false;
			animatorStateTransition35778.solo = false;
			animatorStateTransition35778.AddCondition(AnimatorConditionMode.NotEqual, 4f, "Slot0ItemStateIndex");

			var animatorStateTransition35780 = dropLandAnimatorState35362.AddExitTransition();
			animatorStateTransition35780.canTransitionToSelf = true;
			animatorStateTransition35780.duration = 0.1f;
			animatorStateTransition35780.exitTime = 0.9f;
			animatorStateTransition35780.hasExitTime = true;
			animatorStateTransition35780.hasFixedDuration = true;
			animatorStateTransition35780.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition35780.offset = 0f;
			animatorStateTransition35780.orderedInterruption = true;
			animatorStateTransition35780.isExit = true;
			animatorStateTransition35780.mute = false;
			animatorStateTransition35780.solo = false;

			var animatorStateTransition35782 = idleLandAnimatorState35364.AddExitTransition();
			animatorStateTransition35782.canTransitionToSelf = true;
			animatorStateTransition35782.duration = 0.15f;
			animatorStateTransition35782.exitTime = 0.75f;
			animatorStateTransition35782.hasExitTime = false;
			animatorStateTransition35782.hasFixedDuration = true;
			animatorStateTransition35782.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition35782.offset = 0f;
			animatorStateTransition35782.orderedInterruption = true;
			animatorStateTransition35782.isExit = true;
			animatorStateTransition35782.mute = false;
			animatorStateTransition35782.solo = false;
			animatorStateTransition35782.AddCondition(AnimatorConditionMode.NotEqual, 7f, "Slot0ItemID");

			var animatorStateTransition35784 = aimLandAnimatorState35366.AddExitTransition();
			animatorStateTransition35784.canTransitionToSelf = true;
			animatorStateTransition35784.duration = 0.15f;
			animatorStateTransition35784.exitTime = 0.75f;
			animatorStateTransition35784.hasExitTime = false;
			animatorStateTransition35784.hasFixedDuration = true;
			animatorStateTransition35784.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition35784.offset = 0f;
			animatorStateTransition35784.orderedInterruption = true;
			animatorStateTransition35784.isExit = true;
			animatorStateTransition35784.mute = false;
			animatorStateTransition35784.solo = false;
			animatorStateTransition35784.AddCondition(AnimatorConditionMode.NotEqual, 7f, "Slot0ItemID");

			var animatorStateTransition35786 = fireWaterAnimatorState35368.AddExitTransition();
			animatorStateTransition35786.canTransitionToSelf = true;
			animatorStateTransition35786.duration = 0.04f;
			animatorStateTransition35786.exitTime = 0f;
			animatorStateTransition35786.hasExitTime = false;
			animatorStateTransition35786.hasFixedDuration = true;
			animatorStateTransition35786.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition35786.offset = 0f;
			animatorStateTransition35786.orderedInterruption = false;
			animatorStateTransition35786.isExit = true;
			animatorStateTransition35786.mute = false;
			animatorStateTransition35786.solo = false;
			animatorStateTransition35786.AddCondition(AnimatorConditionMode.NotEqual, 2f, "Slot0ItemStateIndex");

			var animatorStateTransition35790 = aimWaterAnimatorState35370.AddExitTransition();
			animatorStateTransition35790.canTransitionToSelf = true;
			animatorStateTransition35790.duration = 0.15f;
			animatorStateTransition35790.exitTime = 0.75f;
			animatorStateTransition35790.hasExitTime = false;
			animatorStateTransition35790.hasFixedDuration = true;
			animatorStateTransition35790.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition35790.offset = 0f;
			animatorStateTransition35790.orderedInterruption = true;
			animatorStateTransition35790.isExit = true;
			animatorStateTransition35790.mute = false;
			animatorStateTransition35790.solo = false;
			animatorStateTransition35790.AddCondition(AnimatorConditionMode.NotEqual, 7f, "Slot0ItemID");

			var animatorStateTransition35794 = idleWaterAnimatorState35372.AddExitTransition();
			animatorStateTransition35794.canTransitionToSelf = true;
			animatorStateTransition35794.duration = 0.15f;
			animatorStateTransition35794.exitTime = 0.75f;
			animatorStateTransition35794.hasExitTime = false;
			animatorStateTransition35794.hasFixedDuration = true;
			animatorStateTransition35794.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition35794.offset = 0f;
			animatorStateTransition35794.orderedInterruption = true;
			animatorStateTransition35794.isExit = true;
			animatorStateTransition35794.mute = false;
			animatorStateTransition35794.solo = false;
			animatorStateTransition35794.AddCondition(AnimatorConditionMode.NotEqual, 7f, "Slot0ItemID");

			var animatorStateTransition35798 = dropWaterAnimatorState35374.AddExitTransition();
			animatorStateTransition35798.canTransitionToSelf = true;
			animatorStateTransition35798.duration = 0.1f;
			animatorStateTransition35798.exitTime = 0.9f;
			animatorStateTransition35798.hasExitTime = true;
			animatorStateTransition35798.hasFixedDuration = true;
			animatorStateTransition35798.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition35798.offset = 0f;
			animatorStateTransition35798.orderedInterruption = true;
			animatorStateTransition35798.isExit = true;
			animatorStateTransition35798.mute = false;
			animatorStateTransition35798.solo = false;

			var animatorStateTransition35802 = equipFromIdleWaterAnimatorState35376.AddExitTransition();
			animatorStateTransition35802.canTransitionToSelf = true;
			animatorStateTransition35802.duration = 0.2f;
			animatorStateTransition35802.exitTime = 0.75f;
			animatorStateTransition35802.hasExitTime = false;
			animatorStateTransition35802.hasFixedDuration = true;
			animatorStateTransition35802.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition35802.offset = 0f;
			animatorStateTransition35802.orderedInterruption = true;
			animatorStateTransition35802.isExit = true;
			animatorStateTransition35802.mute = false;
			animatorStateTransition35802.solo = false;
			animatorStateTransition35802.AddCondition(AnimatorConditionMode.NotEqual, 4f, "Slot0ItemStateIndex");

			var animatorStateTransition35806 = equipFromAimWaterAnimatorState35378.AddExitTransition();
			animatorStateTransition35806.canTransitionToSelf = true;
			animatorStateTransition35806.duration = 0.2f;
			animatorStateTransition35806.exitTime = 0.8846154f;
			animatorStateTransition35806.hasExitTime = false;
			animatorStateTransition35806.hasFixedDuration = true;
			animatorStateTransition35806.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition35806.offset = 0f;
			animatorStateTransition35806.orderedInterruption = true;
			animatorStateTransition35806.isExit = true;
			animatorStateTransition35806.mute = false;
			animatorStateTransition35806.solo = false;
			animatorStateTransition35806.AddCondition(AnimatorConditionMode.NotEqual, 4f, "Slot0ItemStateIndex");

			var animatorStateTransition35810 = unequipFromAimWaterAnimatorState35380.AddExitTransition();
			animatorStateTransition35810.canTransitionToSelf = true;
			animatorStateTransition35810.duration = 0.2f;
			animatorStateTransition35810.exitTime = 0.8846154f;
			animatorStateTransition35810.hasExitTime = false;
			animatorStateTransition35810.hasFixedDuration = true;
			animatorStateTransition35810.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition35810.offset = 0f;
			animatorStateTransition35810.orderedInterruption = true;
			animatorStateTransition35810.isExit = true;
			animatorStateTransition35810.mute = false;
			animatorStateTransition35810.solo = false;
			animatorStateTransition35810.AddCondition(AnimatorConditionMode.NotEqual, 5f, "Slot0ItemStateIndex");

			var animatorStateTransition35814 = unequipFromIdleWaterAnimatorState35382.AddExitTransition();
			animatorStateTransition35814.canTransitionToSelf = true;
			animatorStateTransition35814.duration = 0.2f;
			animatorStateTransition35814.exitTime = 0.75f;
			animatorStateTransition35814.hasExitTime = false;
			animatorStateTransition35814.hasFixedDuration = true;
			animatorStateTransition35814.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition35814.offset = 0f;
			animatorStateTransition35814.orderedInterruption = true;
			animatorStateTransition35814.isExit = true;
			animatorStateTransition35814.mute = false;
			animatorStateTransition35814.solo = false;
			animatorStateTransition35814.AddCondition(AnimatorConditionMode.NotEqual, 5f, "Slot0ItemStateIndex");

			// State Machine Defaults.
			underwaterGunAnimatorStateMachine34952.anyStatePosition = new Vector3(50f, 20f, 0f);
			underwaterGunAnimatorStateMachine34952.defaultState = unequipFromIdleLandAnimatorState35354;
			underwaterGunAnimatorStateMachine34952.entryPosition = new Vector3(50f, 120f, 0f);
			underwaterGunAnimatorStateMachine34952.exitPosition = new Vector3(800f, 120f, 0f);
			underwaterGunAnimatorStateMachine34952.parentStateMachinePosition = new Vector3(800f, 20f, 0f);


			// State Machine Transitions.
			var animatorStateTransition35132 = baseStateMachine1227655302.AddAnyStateTransition(aimWaterAnimatorState35352);
			animatorStateTransition35132.canTransitionToSelf = false;
			animatorStateTransition35132.duration = 0.25f;
			animatorStateTransition35132.exitTime = 0.75f;
			animatorStateTransition35132.hasExitTime = false;
			animatorStateTransition35132.hasFixedDuration = true;
			animatorStateTransition35132.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition35132.offset = 0f;
			animatorStateTransition35132.orderedInterruption = true;
			animatorStateTransition35132.isExit = false;
			animatorStateTransition35132.mute = false;
			animatorStateTransition35132.solo = false;
			animatorStateTransition35132.AddCondition(AnimatorConditionMode.Equals, 26f, "Slot0ItemID");
			animatorStateTransition35132.AddCondition(AnimatorConditionMode.If, 0f, "Aiming");
			animatorStateTransition35132.AddCondition(AnimatorConditionMode.Equals, 301f, "AbilityIndex");
			animatorStateTransition35132.AddCondition(AnimatorConditionMode.NotEqual, 1f, "AbilityIntData");

			var animatorStateTransition35186 = baseStateMachine1227655302.AddAnyStateTransition(aimLandAnimatorState35384);
			animatorStateTransition35186.canTransitionToSelf = false;
			animatorStateTransition35186.duration = 0.1f;
			animatorStateTransition35186.exitTime = 0.75f;
			animatorStateTransition35186.hasExitTime = false;
			animatorStateTransition35186.hasFixedDuration = true;
			animatorStateTransition35186.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition35186.offset = 0f;
			animatorStateTransition35186.orderedInterruption = true;
			animatorStateTransition35186.isExit = false;
			animatorStateTransition35186.mute = false;
			animatorStateTransition35186.solo = false;
			animatorStateTransition35186.AddCondition(AnimatorConditionMode.Equals, 26f, "Slot0ItemID");
			animatorStateTransition35186.AddCondition(AnimatorConditionMode.If, 0f, "Aiming");
			animatorStateTransition35186.AddCondition(AnimatorConditionMode.Equals, 301f, "AbilityIndex");
			animatorStateTransition35186.AddCondition(AnimatorConditionMode.Equals, 1f, "AbilityIntData");

			// State Machine Transitions.
			var animatorStateTransition35150 = baseStateMachine1299744904.AddAnyStateTransition(fireWaterAnimatorState35368);
			animatorStateTransition35150.canTransitionToSelf = false;
			animatorStateTransition35150.duration = 0.04f;
			animatorStateTransition35150.exitTime = 0.75f;
			animatorStateTransition35150.hasExitTime = false;
			animatorStateTransition35150.hasFixedDuration = true;
			animatorStateTransition35150.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition35150.offset = 0f;
			animatorStateTransition35150.orderedInterruption = true;
			animatorStateTransition35150.isExit = false;
			animatorStateTransition35150.mute = false;
			animatorStateTransition35150.solo = false;
			animatorStateTransition35150.AddCondition(AnimatorConditionMode.Equals, 7f, "Slot0ItemID");
			animatorStateTransition35150.AddCondition(AnimatorConditionMode.Equals, 2f, "Slot0ItemStateIndex");
			animatorStateTransition35150.AddCondition(AnimatorConditionMode.Equals, 2f, "Slot0ItemSubstateIndex");
			animatorStateTransition35150.AddCondition(AnimatorConditionMode.Equals, 301f, "AbilityIndex");
			animatorStateTransition35150.AddCondition(AnimatorConditionMode.NotEqual, 1f, "AbilityIntData");

			var animatorStateTransition35152 = baseStateMachine1299744904.AddAnyStateTransition(aimWaterAnimatorState35370);
			animatorStateTransition35152.canTransitionToSelf = false;
			animatorStateTransition35152.duration = 0.04f;
			animatorStateTransition35152.exitTime = 0.75f;
			animatorStateTransition35152.hasExitTime = false;
			animatorStateTransition35152.hasFixedDuration = true;
			animatorStateTransition35152.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition35152.offset = 0f;
			animatorStateTransition35152.orderedInterruption = true;
			animatorStateTransition35152.isExit = false;
			animatorStateTransition35152.mute = false;
			animatorStateTransition35152.solo = false;
			animatorStateTransition35152.AddCondition(AnimatorConditionMode.Equals, 7f, "Slot0ItemID");
			animatorStateTransition35152.AddCondition(AnimatorConditionMode.Equals, 2f, "Slot0ItemStateIndex");
			animatorStateTransition35152.AddCondition(AnimatorConditionMode.NotEqual, 11f, "Slot0ItemSubstateIndex");
			animatorStateTransition35152.AddCondition(AnimatorConditionMode.NotEqual, 2f, "Slot0ItemSubstateIndex");
			animatorStateTransition35152.AddCondition(AnimatorConditionMode.Equals, 301f, "AbilityIndex");
			animatorStateTransition35152.AddCondition(AnimatorConditionMode.NotEqual, 1f, "AbilityIntData");

			var animatorStateTransition35154 = baseStateMachine1299744904.AddAnyStateTransition(aimWaterAnimatorState35370);
			animatorStateTransition35154.canTransitionToSelf = false;
			animatorStateTransition35154.duration = 0.08f;
			animatorStateTransition35154.exitTime = 0.75f;
			animatorStateTransition35154.hasExitTime = false;
			animatorStateTransition35154.hasFixedDuration = true;
			animatorStateTransition35154.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition35154.offset = 0f;
			animatorStateTransition35154.orderedInterruption = true;
			animatorStateTransition35154.isExit = false;
			animatorStateTransition35154.mute = false;
			animatorStateTransition35154.solo = false;
			animatorStateTransition35154.AddCondition(AnimatorConditionMode.Equals, 7f, "Slot0ItemID");
			animatorStateTransition35154.AddCondition(AnimatorConditionMode.If, 0f, "Aiming");
			animatorStateTransition35154.AddCondition(AnimatorConditionMode.Less, 2f, "Slot0ItemStateIndex");
			animatorStateTransition35154.AddCondition(AnimatorConditionMode.Equals, 301f, "AbilityIndex");
			animatorStateTransition35154.AddCondition(AnimatorConditionMode.NotEqual, 1f, "AbilityIntData");

			var animatorStateTransition35156 = baseStateMachine1299744904.AddAnyStateTransition(idleWaterAnimatorState35372);
			animatorStateTransition35156.canTransitionToSelf = false;
			animatorStateTransition35156.duration = 0.1f;
			animatorStateTransition35156.exitTime = 0.75f;
			animatorStateTransition35156.hasExitTime = false;
			animatorStateTransition35156.hasFixedDuration = true;
			animatorStateTransition35156.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition35156.offset = 0f;
			animatorStateTransition35156.orderedInterruption = true;
			animatorStateTransition35156.isExit = false;
			animatorStateTransition35156.mute = false;
			animatorStateTransition35156.solo = false;
			animatorStateTransition35156.AddCondition(AnimatorConditionMode.Equals, 7f, "Slot0ItemID");
			animatorStateTransition35156.AddCondition(AnimatorConditionMode.Less, 2f, "Slot0ItemStateIndex");
			animatorStateTransition35156.AddCondition(AnimatorConditionMode.IfNot, 0f, "Aiming");
			animatorStateTransition35156.AddCondition(AnimatorConditionMode.Equals, 301f, "AbilityIndex");
			animatorStateTransition35156.AddCondition(AnimatorConditionMode.NotEqual, 1f, "AbilityIntData");

			var animatorStateTransition35158 = baseStateMachine1299744904.AddAnyStateTransition(dropWaterAnimatorState35374);
			animatorStateTransition35158.canTransitionToSelf = false;
			animatorStateTransition35158.duration = 0.1f;
			animatorStateTransition35158.exitTime = 0.75f;
			animatorStateTransition35158.hasExitTime = false;
			animatorStateTransition35158.hasFixedDuration = true;
			animatorStateTransition35158.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition35158.offset = 0f;
			animatorStateTransition35158.orderedInterruption = true;
			animatorStateTransition35158.isExit = false;
			animatorStateTransition35158.mute = false;
			animatorStateTransition35158.solo = false;
			animatorStateTransition35158.AddCondition(AnimatorConditionMode.If, 0f, "Slot0ItemStateIndexChange");
			animatorStateTransition35158.AddCondition(AnimatorConditionMode.Equals, 7f, "Slot0ItemID");
			animatorStateTransition35158.AddCondition(AnimatorConditionMode.Equals, 6f, "Slot0ItemStateIndex");
			animatorStateTransition35158.AddCondition(AnimatorConditionMode.Equals, 301f, "AbilityIndex");
			animatorStateTransition35158.AddCondition(AnimatorConditionMode.NotEqual, 1f, "AbilityIntData");

			var animatorStateTransition35160 = baseStateMachine1299744904.AddAnyStateTransition(equipFromIdleWaterAnimatorState35376);
			animatorStateTransition35160.canTransitionToSelf = false;
			animatorStateTransition35160.duration = 0.15f;
			animatorStateTransition35160.exitTime = 0.75f;
			animatorStateTransition35160.hasExitTime = false;
			animatorStateTransition35160.hasFixedDuration = true;
			animatorStateTransition35160.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition35160.offset = 0f;
			animatorStateTransition35160.orderedInterruption = true;
			animatorStateTransition35160.isExit = false;
			animatorStateTransition35160.mute = false;
			animatorStateTransition35160.solo = false;
			animatorStateTransition35160.AddCondition(AnimatorConditionMode.If, 0f, "Slot0ItemStateIndexChange");
			animatorStateTransition35160.AddCondition(AnimatorConditionMode.Equals, 7f, "Slot0ItemID");
			animatorStateTransition35160.AddCondition(AnimatorConditionMode.Equals, 4f, "Slot0ItemStateIndex");
			animatorStateTransition35160.AddCondition(AnimatorConditionMode.IfNot, 0f, "Aiming");
			animatorStateTransition35160.AddCondition(AnimatorConditionMode.Equals, 301f, "AbilityIndex");
			animatorStateTransition35160.AddCondition(AnimatorConditionMode.NotEqual, 1f, "AbilityIntData");

			var animatorStateTransition35162 = baseStateMachine1299744904.AddAnyStateTransition(equipFromAimWaterAnimatorState35378);
			animatorStateTransition35162.canTransitionToSelf = false;
			animatorStateTransition35162.duration = 0.15f;
			animatorStateTransition35162.exitTime = 0.75f;
			animatorStateTransition35162.hasExitTime = false;
			animatorStateTransition35162.hasFixedDuration = true;
			animatorStateTransition35162.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition35162.offset = 0f;
			animatorStateTransition35162.orderedInterruption = true;
			animatorStateTransition35162.isExit = false;
			animatorStateTransition35162.mute = false;
			animatorStateTransition35162.solo = false;
			animatorStateTransition35162.AddCondition(AnimatorConditionMode.If, 0f, "Slot0ItemStateIndexChange");
			animatorStateTransition35162.AddCondition(AnimatorConditionMode.Equals, 7f, "Slot0ItemID");
			animatorStateTransition35162.AddCondition(AnimatorConditionMode.Equals, 4f, "Slot0ItemStateIndex");
			animatorStateTransition35162.AddCondition(AnimatorConditionMode.If, 0f, "Aiming");
			animatorStateTransition35162.AddCondition(AnimatorConditionMode.Equals, 301f, "AbilityIndex");
			animatorStateTransition35162.AddCondition(AnimatorConditionMode.NotEqual, 1f, "AbilityIntData");

			var animatorStateTransition35164 = baseStateMachine1299744904.AddAnyStateTransition(unequipFromAimWaterAnimatorState35380);
			animatorStateTransition35164.canTransitionToSelf = false;
			animatorStateTransition35164.duration = 0.15f;
			animatorStateTransition35164.exitTime = 0.75f;
			animatorStateTransition35164.hasExitTime = false;
			animatorStateTransition35164.hasFixedDuration = true;
			animatorStateTransition35164.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition35164.offset = 0f;
			animatorStateTransition35164.orderedInterruption = true;
			animatorStateTransition35164.isExit = false;
			animatorStateTransition35164.mute = false;
			animatorStateTransition35164.solo = false;
			animatorStateTransition35164.AddCondition(AnimatorConditionMode.If, 0f, "Slot0ItemStateIndexChange");
			animatorStateTransition35164.AddCondition(AnimatorConditionMode.Equals, 7f, "Slot0ItemID");
			animatorStateTransition35164.AddCondition(AnimatorConditionMode.Equals, 5f, "Slot0ItemStateIndex");
			animatorStateTransition35164.AddCondition(AnimatorConditionMode.If, 0f, "Aiming");
			animatorStateTransition35164.AddCondition(AnimatorConditionMode.Equals, 301f, "AbilityIndex");
			animatorStateTransition35164.AddCondition(AnimatorConditionMode.NotEqual, 1f, "AbilityIntData");

			var animatorStateTransition35166 = baseStateMachine1299744904.AddAnyStateTransition(unequipFromIdleWaterAnimatorState35382);
			animatorStateTransition35166.canTransitionToSelf = false;
			animatorStateTransition35166.duration = 0.15f;
			animatorStateTransition35166.exitTime = 0.75f;
			animatorStateTransition35166.hasExitTime = false;
			animatorStateTransition35166.hasFixedDuration = true;
			animatorStateTransition35166.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition35166.offset = 0f;
			animatorStateTransition35166.orderedInterruption = true;
			animatorStateTransition35166.isExit = false;
			animatorStateTransition35166.mute = false;
			animatorStateTransition35166.solo = false;
			animatorStateTransition35166.AddCondition(AnimatorConditionMode.If, 0f, "Slot0ItemStateIndexChange");
			animatorStateTransition35166.AddCondition(AnimatorConditionMode.Equals, 7f, "Slot0ItemID");
			animatorStateTransition35166.AddCondition(AnimatorConditionMode.Equals, 5f, "Slot0ItemStateIndex");
			animatorStateTransition35166.AddCondition(AnimatorConditionMode.IfNot, 0f, "Aiming");
			animatorStateTransition35166.AddCondition(AnimatorConditionMode.Equals, 301f, "AbilityIndex");
			animatorStateTransition35166.AddCondition(AnimatorConditionMode.NotEqual, 1f, "AbilityIntData");

			var animatorStateTransition35170 = baseStateMachine1299744904.AddAnyStateTransition(idleLandAnimatorState35364);
			animatorStateTransition35170.canTransitionToSelf = false;
			animatorStateTransition35170.duration = 0.1f;
			animatorStateTransition35170.exitTime = 0.75f;
			animatorStateTransition35170.hasExitTime = false;
			animatorStateTransition35170.hasFixedDuration = true;
			animatorStateTransition35170.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition35170.offset = 0f;
			animatorStateTransition35170.orderedInterruption = true;
			animatorStateTransition35170.isExit = false;
			animatorStateTransition35170.mute = false;
			animatorStateTransition35170.solo = false;
			animatorStateTransition35170.AddCondition(AnimatorConditionMode.Equals, 7f, "Slot0ItemID");
			animatorStateTransition35170.AddCondition(AnimatorConditionMode.Less, 2f, "Slot0ItemStateIndex");
			animatorStateTransition35170.AddCondition(AnimatorConditionMode.IfNot, 0f, "Aiming");
			animatorStateTransition35170.AddCondition(AnimatorConditionMode.Equals, 301f, "AbilityIndex");
			animatorStateTransition35170.AddCondition(AnimatorConditionMode.Equals, 1f, "AbilityIntData");

			var animatorStateTransition35172 = baseStateMachine1299744904.AddAnyStateTransition(aimLandAnimatorState35366);
			animatorStateTransition35172.canTransitionToSelf = false;
			animatorStateTransition35172.duration = 0.04f;
			animatorStateTransition35172.exitTime = 0.75f;
			animatorStateTransition35172.hasExitTime = false;
			animatorStateTransition35172.hasFixedDuration = true;
			animatorStateTransition35172.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition35172.offset = 0f;
			animatorStateTransition35172.orderedInterruption = true;
			animatorStateTransition35172.isExit = false;
			animatorStateTransition35172.mute = false;
			animatorStateTransition35172.solo = false;
			animatorStateTransition35172.AddCondition(AnimatorConditionMode.Equals, 7f, "Slot0ItemID");
			animatorStateTransition35172.AddCondition(AnimatorConditionMode.Equals, 2f, "Slot0ItemStateIndex");
			animatorStateTransition35172.AddCondition(AnimatorConditionMode.NotEqual, 2f, "Slot0ItemSubstateIndex");
			animatorStateTransition35172.AddCondition(AnimatorConditionMode.NotEqual, 11f, "Slot0ItemSubstateIndex");
			animatorStateTransition35172.AddCondition(AnimatorConditionMode.Equals, 301f, "AbilityIndex");
			animatorStateTransition35172.AddCondition(AnimatorConditionMode.Equals, 1f, "AbilityIntData");

			var animatorStateTransition35174 = baseStateMachine1299744904.AddAnyStateTransition(equipFromAimLandAnimatorState35358);
			animatorStateTransition35174.canTransitionToSelf = false;
			animatorStateTransition35174.duration = 0.15f;
			animatorStateTransition35174.exitTime = 0.75f;
			animatorStateTransition35174.hasExitTime = false;
			animatorStateTransition35174.hasFixedDuration = true;
			animatorStateTransition35174.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition35174.offset = 0f;
			animatorStateTransition35174.orderedInterruption = true;
			animatorStateTransition35174.isExit = false;
			animatorStateTransition35174.mute = false;
			animatorStateTransition35174.solo = false;
			animatorStateTransition35174.AddCondition(AnimatorConditionMode.If, 0f, "Slot0ItemStateIndexChange");
			animatorStateTransition35174.AddCondition(AnimatorConditionMode.Equals, 7f, "Slot0ItemID");
			animatorStateTransition35174.AddCondition(AnimatorConditionMode.Equals, 4f, "Slot0ItemStateIndex");
			animatorStateTransition35174.AddCondition(AnimatorConditionMode.If, 0f, "Aiming");
			animatorStateTransition35174.AddCondition(AnimatorConditionMode.Equals, 301f, "AbilityIndex");
			animatorStateTransition35174.AddCondition(AnimatorConditionMode.Equals, 1f, "AbilityIntData");

			var animatorStateTransition35176 = baseStateMachine1299744904.AddAnyStateTransition(unequipFromAimLandAnimatorState35356);
			animatorStateTransition35176.canTransitionToSelf = false;
			animatorStateTransition35176.duration = 0.15f;
			animatorStateTransition35176.exitTime = 0.75f;
			animatorStateTransition35176.hasExitTime = false;
			animatorStateTransition35176.hasFixedDuration = true;
			animatorStateTransition35176.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition35176.offset = 0f;
			animatorStateTransition35176.orderedInterruption = true;
			animatorStateTransition35176.isExit = false;
			animatorStateTransition35176.mute = false;
			animatorStateTransition35176.solo = false;
			animatorStateTransition35176.AddCondition(AnimatorConditionMode.If, 0f, "Slot0ItemStateIndexChange");
			animatorStateTransition35176.AddCondition(AnimatorConditionMode.Equals, 7f, "Slot0ItemID");
			animatorStateTransition35176.AddCondition(AnimatorConditionMode.Equals, 5f, "Slot0ItemStateIndex");
			animatorStateTransition35176.AddCondition(AnimatorConditionMode.If, 0f, "Aiming");
			animatorStateTransition35176.AddCondition(AnimatorConditionMode.Equals, 301f, "AbilityIndex");
			animatorStateTransition35176.AddCondition(AnimatorConditionMode.Equals, 1f, "AbilityIntData");

			var animatorStateTransition35178 = baseStateMachine1299744904.AddAnyStateTransition(equipFromIdleLandAnimatorState35360);
			animatorStateTransition35178.canTransitionToSelf = false;
			animatorStateTransition35178.duration = 0.15f;
			animatorStateTransition35178.exitTime = 0.75f;
			animatorStateTransition35178.hasExitTime = false;
			animatorStateTransition35178.hasFixedDuration = true;
			animatorStateTransition35178.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition35178.offset = 0f;
			animatorStateTransition35178.orderedInterruption = true;
			animatorStateTransition35178.isExit = false;
			animatorStateTransition35178.mute = false;
			animatorStateTransition35178.solo = false;
			animatorStateTransition35178.AddCondition(AnimatorConditionMode.If, 0f, "Slot0ItemStateIndexChange");
			animatorStateTransition35178.AddCondition(AnimatorConditionMode.Equals, 7f, "Slot0ItemID");
			animatorStateTransition35178.AddCondition(AnimatorConditionMode.Equals, 4f, "Slot0ItemStateIndex");
			animatorStateTransition35178.AddCondition(AnimatorConditionMode.IfNot, 0f, "Aiming");
			animatorStateTransition35178.AddCondition(AnimatorConditionMode.Equals, 301f, "AbilityIndex");
			animatorStateTransition35178.AddCondition(AnimatorConditionMode.Equals, 1f, "AbilityIntData");

			var animatorStateTransition35180 = baseStateMachine1299744904.AddAnyStateTransition(unequipFromIdleLandAnimatorState35354);
			animatorStateTransition35180.canTransitionToSelf = false;
			animatorStateTransition35180.duration = 0.15f;
			animatorStateTransition35180.exitTime = 0.75f;
			animatorStateTransition35180.hasExitTime = false;
			animatorStateTransition35180.hasFixedDuration = true;
			animatorStateTransition35180.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition35180.offset = 0f;
			animatorStateTransition35180.orderedInterruption = true;
			animatorStateTransition35180.isExit = false;
			animatorStateTransition35180.mute = false;
			animatorStateTransition35180.solo = false;
			animatorStateTransition35180.AddCondition(AnimatorConditionMode.If, 0f, "Slot0ItemStateIndexChange");
			animatorStateTransition35180.AddCondition(AnimatorConditionMode.Equals, 7f, "Slot0ItemID");
			animatorStateTransition35180.AddCondition(AnimatorConditionMode.Equals, 5f, "Slot0ItemStateIndex");
			animatorStateTransition35180.AddCondition(AnimatorConditionMode.IfNot, 0f, "Aiming");
			animatorStateTransition35180.AddCondition(AnimatorConditionMode.Equals, 301f, "AbilityIndex");
			animatorStateTransition35180.AddCondition(AnimatorConditionMode.Equals, 1f, "AbilityIntData");

			var animatorStateTransition35182 = baseStateMachine1299744904.AddAnyStateTransition(dropLandAnimatorState35362);
			animatorStateTransition35182.canTransitionToSelf = false;
			animatorStateTransition35182.duration = 0.1f;
			animatorStateTransition35182.exitTime = 0.75f;
			animatorStateTransition35182.hasExitTime = false;
			animatorStateTransition35182.hasFixedDuration = true;
			animatorStateTransition35182.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition35182.offset = 0f;
			animatorStateTransition35182.orderedInterruption = true;
			animatorStateTransition35182.isExit = false;
			animatorStateTransition35182.mute = false;
			animatorStateTransition35182.solo = false;
			animatorStateTransition35182.AddCondition(AnimatorConditionMode.If, 0f, "Slot0ItemStateIndexChange");
			animatorStateTransition35182.AddCondition(AnimatorConditionMode.Equals, 7f, "Slot0ItemID");
			animatorStateTransition35182.AddCondition(AnimatorConditionMode.Equals, 6f, "Slot0ItemStateIndex");
			animatorStateTransition35182.AddCondition(AnimatorConditionMode.Equals, 301f, "AbilityIndex");
			animatorStateTransition35182.AddCondition(AnimatorConditionMode.Equals, 1f, "AbilityIntData");

			var animatorStateTransition35184 = baseStateMachine1299744904.AddAnyStateTransition(aimLandAnimatorState35366);
			animatorStateTransition35184.canTransitionToSelf = false;
			animatorStateTransition35184.duration = 0.08f;
			animatorStateTransition35184.exitTime = 0.75f;
			animatorStateTransition35184.hasExitTime = false;
			animatorStateTransition35184.hasFixedDuration = true;
			animatorStateTransition35184.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition35184.offset = 0f;
			animatorStateTransition35184.orderedInterruption = true;
			animatorStateTransition35184.isExit = false;
			animatorStateTransition35184.mute = false;
			animatorStateTransition35184.solo = false;
			animatorStateTransition35184.AddCondition(AnimatorConditionMode.Equals, 7f, "Slot0ItemID");
			animatorStateTransition35184.AddCondition(AnimatorConditionMode.Less, 2f, "Slot0ItemStateIndex");
			animatorStateTransition35184.AddCondition(AnimatorConditionMode.If, 0f, "Aiming");
			animatorStateTransition35184.AddCondition(AnimatorConditionMode.Equals, 301f, "AbilityIndex");
			animatorStateTransition35184.AddCondition(AnimatorConditionMode.Equals, 1f, "AbilityIntData");


			var baseStateMachine1240239114 = animatorController.layers[4].stateMachine;

			// The state machine should start fresh.
			for (int i = 0; i < animatorController.layers.Length; ++i) {
				for (int j = 0; j < baseStateMachine1240239114.stateMachines.Length; ++j) {
					if (baseStateMachine1240239114.stateMachines[j].stateMachine.name == "Trident") {
						baseStateMachine1240239114.RemoveStateMachine(baseStateMachine1240239114.stateMachines[j].stateMachine);
						break;
					}
				}
			}

			// AnimationClip references.
			var tridentAttackFromAimBwdAnimationClip13394Path = AssetDatabase.GUIDToAssetPath("8e1d50508cb45d847a6d1f3a2cd0329d"); 
			var tridentAttackFromAimBwdAnimationClip13394 = AnimatorBuilder.GetAnimationClip(tridentAttackFromAimBwdAnimationClip13394Path, "TridentAttackFromAimBwd");
			var tridentAttackFromAimStrafeAnimationClip16470Path = AssetDatabase.GUIDToAssetPath("eb98d063a1589c340970b18c17ce6eb6"); 
			var tridentAttackFromAimStrafeAnimationClip16470 = AnimatorBuilder.GetAnimationClip(tridentAttackFromAimStrafeAnimationClip16470Path, "TridentAttackFromAimStrafe");
			var tridentAttackFromAimAnimationClip22680Path = AssetDatabase.GUIDToAssetPath("a3dc8609e0cfedf4b9f68f0d6a46bfbe"); 
			var tridentAttackFromAimAnimationClip22680 = AnimatorBuilder.GetAnimationClip(tridentAttackFromAimAnimationClip22680Path, "TridentAttackFromAim");
			var tridentEquipFromIdleLandAnimationClip24446Path = AssetDatabase.GUIDToAssetPath("e9d28eea056551b46a22a0fed06f09e9"); 
			var tridentEquipFromIdleLandAnimationClip24446 = AnimatorBuilder.GetAnimationClip(tridentEquipFromIdleLandAnimationClip24446Path, "TridentEquipFromIdleLand");
			var tridentEquipFromIdleStrafeAnimationClip25624Path = AssetDatabase.GUIDToAssetPath("b77d965c9cc37b4439e3d09f139252b2"); 
			var tridentEquipFromIdleStrafeAnimationClip25624 = AnimatorBuilder.GetAnimationClip(tridentEquipFromIdleStrafeAnimationClip25624Path, "TridentEquipFromIdleStrafe");
			var tridentEquipFromIdleAnimationClip13516Path = AssetDatabase.GUIDToAssetPath("4f016170e4a6faa4daa47381af83fe28"); 
			var tridentEquipFromIdleAnimationClip13516 = AnimatorBuilder.GetAnimationClip(tridentEquipFromIdleAnimationClip13516Path, "TridentEquipFromIdle");
			var tridentUnequipFromIdleLandAnimationClip15942Path = AssetDatabase.GUIDToAssetPath("fc0d82d29e11a424599530e5f0bad0c7"); 
			var tridentUnequipFromIdleLandAnimationClip15942 = AnimatorBuilder.GetAnimationClip(tridentUnequipFromIdleLandAnimationClip15942Path, "TridentUnequipFromIdleLand");
			var tridentUnequipFromIdleStrafeAnimationClip18048Path = AssetDatabase.GUIDToAssetPath("cfc8ade4e0e71ae45829ee2140024302"); 
			var tridentUnequipFromIdleStrafeAnimationClip18048 = AnimatorBuilder.GetAnimationClip(tridentUnequipFromIdleStrafeAnimationClip18048Path, "TridentUnequipFromIdleStrafe");
			var tridentUnequipFromIdleAnimationClip22604Path = AssetDatabase.GUIDToAssetPath("3c2a7bf84a2d5114fb37c5a297a7b887"); 
			var tridentUnequipFromIdleAnimationClip22604 = AnimatorBuilder.GetAnimationClip(tridentUnequipFromIdleAnimationClip22604Path, "TridentUnequipFromIdle");
			var tridentDropLandAnimationClip26280Path = AssetDatabase.GUIDToAssetPath("959e65fca30dd644f9cae654ec81b8da"); 
			var tridentDropLandAnimationClip26280 = AnimatorBuilder.GetAnimationClip(tridentDropLandAnimationClip26280Path, "TridentDropLand");
			var tridentDropStrafeAnimationClip27058Path = AssetDatabase.GUIDToAssetPath("452c61bd405e6f449bb623ea43646c9b"); 
			var tridentDropStrafeAnimationClip27058 = AnimatorBuilder.GetAnimationClip(tridentDropStrafeAnimationClip27058Path, "TridentDropStrafe");
			var tridentDropAnimationClip26782Path = AssetDatabase.GUIDToAssetPath("c96b586da7c6f7a4591ed7da7b70de97"); 
			var tridentDropAnimationClip26782 = AnimatorBuilder.GetAnimationClip(tridentDropAnimationClip26782Path, "TridentDrop");
			var tridentAttackFromIdleBwdAnimationClip15052Path = AssetDatabase.GUIDToAssetPath("9a9972e171c764a4f9b610f74b77d2e5"); 
			var tridentAttackFromIdleBwdAnimationClip15052 = AnimatorBuilder.GetAnimationClip(tridentAttackFromIdleBwdAnimationClip15052Path, "TridentAttackFromIdleBwd");
			var tridentAttackFromIdleStrafeAnimationClip20162Path = AssetDatabase.GUIDToAssetPath("980924073cfd7e84d86ea042125f9d02"); 
			var tridentAttackFromIdleStrafeAnimationClip20162 = AnimatorBuilder.GetAnimationClip(tridentAttackFromIdleStrafeAnimationClip20162Path, "TridentAttackFromIdleStrafe");
			var tridentAttackFromIdleAnimationClip13130Path = AssetDatabase.GUIDToAssetPath("73689710cc9c0a543a885976d45739f2"); 
			var tridentAttackFromIdleAnimationClip13130 = AnimatorBuilder.GetAnimationClip(tridentAttackFromIdleAnimationClip13130Path, "TridentAttackFromIdle");
			var tridentEquipFromAimLandAnimationClip26258Path = AssetDatabase.GUIDToAssetPath("22eb24fca486bd54d9a4ac0fbd103b12"); 
			var tridentEquipFromAimLandAnimationClip26258 = AnimatorBuilder.GetAnimationClip(tridentEquipFromAimLandAnimationClip26258Path, "TridentEquipFromAimLand");
			var tridentEquipFromAimStrafeAnimationClip25286Path = AssetDatabase.GUIDToAssetPath("ebbc17eb546e5504dbe03a2044a1e81f"); 
			var tridentEquipFromAimStrafeAnimationClip25286 = AnimatorBuilder.GetAnimationClip(tridentEquipFromAimStrafeAnimationClip25286Path, "TridentEquipFromAimStrafe");
			var tridentEquipFromAimAnimationClip23118Path = AssetDatabase.GUIDToAssetPath("d9368f69e3256be42907b3357b79cc49"); 
			var tridentEquipFromAimAnimationClip23118 = AnimatorBuilder.GetAnimationClip(tridentEquipFromAimAnimationClip23118Path, "TridentEquipFromAim");
			var tridentUnequipFromAimLandAnimationClip29556Path = AssetDatabase.GUIDToAssetPath("c09b728f5db1996409aa4b944e46091f"); 
			var tridentUnequipFromAimLandAnimationClip29556 = AnimatorBuilder.GetAnimationClip(tridentUnequipFromAimLandAnimationClip29556Path, "TridentUnequipFromAimLand");
			var tridentUnequipFromAimStrafeAnimationClip20492Path = AssetDatabase.GUIDToAssetPath("09db21570b913e441925305c64671094"); 
			var tridentUnequipFromAimStrafeAnimationClip20492 = AnimatorBuilder.GetAnimationClip(tridentUnequipFromAimStrafeAnimationClip20492Path, "TridentUnequipFromAimStrafe");
			var tridentUnequipFromAimAnimationClip21188Path = AssetDatabase.GUIDToAssetPath("4c125ce7139dc9b4098e90e495807e34"); 
			var tridentUnequipFromAimAnimationClip21188 = AnimatorBuilder.GetAnimationClip(tridentUnequipFromAimAnimationClip21188Path, "TridentUnequipFromAim");

			// State Machine.
			var tridentAnimatorStateMachine35850 = baseStateMachine1240239114.AddStateMachine("Trident", new Vector3(624f, 252f, 0f));

			// States.
			var attackFromAimAnimatorState36440 = tridentAnimatorStateMachine35850.AddState("Attack From Aim", new Vector3(144f, -228f, 0f));
			var attackFromAimAnimatorState36440blendTreeBlendTree37260 = new BlendTree();
			AssetDatabase.AddObjectToAsset(attackFromAimAnimatorState36440blendTreeBlendTree37260, animatorController);
			attackFromAimAnimatorState36440blendTreeBlendTree37260.hideFlags = HideFlags.HideInHierarchy;
			attackFromAimAnimatorState36440blendTreeBlendTree37260.blendParameter = "HorizontalMovement";
			attackFromAimAnimatorState36440blendTreeBlendTree37260.blendParameterY = "ForwardMovement";
			attackFromAimAnimatorState36440blendTreeBlendTree37260.blendType = BlendTreeType.FreeformCartesian2D;
			attackFromAimAnimatorState36440blendTreeBlendTree37260.maxThreshold = 1f;
			attackFromAimAnimatorState36440blendTreeBlendTree37260.minThreshold = 0f;
			attackFromAimAnimatorState36440blendTreeBlendTree37260.name = "Blend Tree";
			attackFromAimAnimatorState36440blendTreeBlendTree37260.useAutomaticThresholds = true;
			var attackFromAimAnimatorState36440blendTreeBlendTree37260Child0 =  new ChildMotion();
			attackFromAimAnimatorState36440blendTreeBlendTree37260Child0.motion = tridentAttackFromAimBwdAnimationClip13394;
			attackFromAimAnimatorState36440blendTreeBlendTree37260Child0.cycleOffset = 0f;
			attackFromAimAnimatorState36440blendTreeBlendTree37260Child0.directBlendParameter = "HorizontalMovement";
			attackFromAimAnimatorState36440blendTreeBlendTree37260Child0.mirror = false;
			attackFromAimAnimatorState36440blendTreeBlendTree37260Child0.position = new Vector2(0f, -1f);
			attackFromAimAnimatorState36440blendTreeBlendTree37260Child0.threshold = 0f;
			attackFromAimAnimatorState36440blendTreeBlendTree37260Child0.timeScale = 1f;
			var attackFromAimAnimatorState36440blendTreeBlendTree37260Child1 =  new ChildMotion();
			attackFromAimAnimatorState36440blendTreeBlendTree37260Child1.motion = tridentAttackFromAimStrafeAnimationClip16470;
			attackFromAimAnimatorState36440blendTreeBlendTree37260Child1.cycleOffset = 0f;
			attackFromAimAnimatorState36440blendTreeBlendTree37260Child1.directBlendParameter = "HorizontalMovement";
			attackFromAimAnimatorState36440blendTreeBlendTree37260Child1.mirror = false;
			attackFromAimAnimatorState36440blendTreeBlendTree37260Child1.position = new Vector2(-1f, 0f);
			attackFromAimAnimatorState36440blendTreeBlendTree37260Child1.threshold = 0.25f;
			attackFromAimAnimatorState36440blendTreeBlendTree37260Child1.timeScale = 1f;
			var attackFromAimAnimatorState36440blendTreeBlendTree37260Child2 =  new ChildMotion();
			attackFromAimAnimatorState36440blendTreeBlendTree37260Child2.motion = tridentAttackFromAimAnimationClip22680;
			attackFromAimAnimatorState36440blendTreeBlendTree37260Child2.cycleOffset = 0f;
			attackFromAimAnimatorState36440blendTreeBlendTree37260Child2.directBlendParameter = "HorizontalMovement";
			attackFromAimAnimatorState36440blendTreeBlendTree37260Child2.mirror = false;
			attackFromAimAnimatorState36440blendTreeBlendTree37260Child2.position = new Vector2(0f, 0f);
			attackFromAimAnimatorState36440blendTreeBlendTree37260Child2.threshold = 0.5f;
			attackFromAimAnimatorState36440blendTreeBlendTree37260Child2.timeScale = 1f;
			var attackFromAimAnimatorState36440blendTreeBlendTree37260Child3 =  new ChildMotion();
			attackFromAimAnimatorState36440blendTreeBlendTree37260Child3.motion = tridentAttackFromAimStrafeAnimationClip16470;
			attackFromAimAnimatorState36440blendTreeBlendTree37260Child3.cycleOffset = 0f;
			attackFromAimAnimatorState36440blendTreeBlendTree37260Child3.directBlendParameter = "HorizontalMovement";
			attackFromAimAnimatorState36440blendTreeBlendTree37260Child3.mirror = false;
			attackFromAimAnimatorState36440blendTreeBlendTree37260Child3.position = new Vector2(1f, 0f);
			attackFromAimAnimatorState36440blendTreeBlendTree37260Child3.threshold = 0.75f;
			attackFromAimAnimatorState36440blendTreeBlendTree37260Child3.timeScale = 1f;
			var attackFromAimAnimatorState36440blendTreeBlendTree37260Child4 =  new ChildMotion();
			attackFromAimAnimatorState36440blendTreeBlendTree37260Child4.motion = tridentAttackFromAimAnimationClip22680;
			attackFromAimAnimatorState36440blendTreeBlendTree37260Child4.cycleOffset = 0f;
			attackFromAimAnimatorState36440blendTreeBlendTree37260Child4.directBlendParameter = "HorizontalMovement";
			attackFromAimAnimatorState36440blendTreeBlendTree37260Child4.mirror = false;
			attackFromAimAnimatorState36440blendTreeBlendTree37260Child4.position = new Vector2(0f, 1f);
			attackFromAimAnimatorState36440blendTreeBlendTree37260Child4.threshold = 1f;
			attackFromAimAnimatorState36440blendTreeBlendTree37260Child4.timeScale = 1f;
			attackFromAimAnimatorState36440blendTreeBlendTree37260.children = new ChildMotion[] {
				attackFromAimAnimatorState36440blendTreeBlendTree37260Child0,
				attackFromAimAnimatorState36440blendTreeBlendTree37260Child1,
				attackFromAimAnimatorState36440blendTreeBlendTree37260Child2,
				attackFromAimAnimatorState36440blendTreeBlendTree37260Child3,
				attackFromAimAnimatorState36440blendTreeBlendTree37260Child4
			};
			attackFromAimAnimatorState36440.motion = attackFromAimAnimatorState36440blendTreeBlendTree37260;
			attackFromAimAnimatorState36440.cycleOffset = 0f;
			attackFromAimAnimatorState36440.cycleOffsetParameterActive = false;
			attackFromAimAnimatorState36440.iKOnFeet = false;
			attackFromAimAnimatorState36440.mirror = false;
			attackFromAimAnimatorState36440.mirrorParameterActive = false;
			attackFromAimAnimatorState36440.speed = 3f;
			attackFromAimAnimatorState36440.speedParameterActive = false;
			attackFromAimAnimatorState36440.writeDefaultValues = true;

			var equipFromIdleWaterAnimatorState36446 = tridentAnimatorStateMachine35850.AddState("Equip From Idle Water", new Vector3(144f, 312f, 0f));
			var equipFromIdleWaterAnimatorState36446blendTreeBlendTree37264 = new BlendTree();
			AssetDatabase.AddObjectToAsset(equipFromIdleWaterAnimatorState36446blendTreeBlendTree37264, animatorController);
			equipFromIdleWaterAnimatorState36446blendTreeBlendTree37264.hideFlags = HideFlags.HideInHierarchy;
			equipFromIdleWaterAnimatorState36446blendTreeBlendTree37264.blendParameter = "HorizontalMovement";
			equipFromIdleWaterAnimatorState36446blendTreeBlendTree37264.blendParameterY = "ForwardMovement";
			equipFromIdleWaterAnimatorState36446blendTreeBlendTree37264.blendType = BlendTreeType.FreeformCartesian2D;
			equipFromIdleWaterAnimatorState36446blendTreeBlendTree37264.maxThreshold = 1f;
			equipFromIdleWaterAnimatorState36446blendTreeBlendTree37264.minThreshold = 0f;
			equipFromIdleWaterAnimatorState36446blendTreeBlendTree37264.name = "Blend Tree";
			equipFromIdleWaterAnimatorState36446blendTreeBlendTree37264.useAutomaticThresholds = true;
			var equipFromIdleWaterAnimatorState36446blendTreeBlendTree37264Child0 =  new ChildMotion();
			equipFromIdleWaterAnimatorState36446blendTreeBlendTree37264Child0.motion = tridentEquipFromIdleLandAnimationClip24446;
			equipFromIdleWaterAnimatorState36446blendTreeBlendTree37264Child0.cycleOffset = 0f;
			equipFromIdleWaterAnimatorState36446blendTreeBlendTree37264Child0.directBlendParameter = "HorizontalMovement";
			equipFromIdleWaterAnimatorState36446blendTreeBlendTree37264Child0.mirror = false;
			equipFromIdleWaterAnimatorState36446blendTreeBlendTree37264Child0.position = new Vector2(0f, -1f);
			equipFromIdleWaterAnimatorState36446blendTreeBlendTree37264Child0.threshold = 0f;
			equipFromIdleWaterAnimatorState36446blendTreeBlendTree37264Child0.timeScale = 1f;
			var equipFromIdleWaterAnimatorState36446blendTreeBlendTree37264Child1 =  new ChildMotion();
			equipFromIdleWaterAnimatorState36446blendTreeBlendTree37264Child1.motion = tridentEquipFromIdleStrafeAnimationClip25624;
			equipFromIdleWaterAnimatorState36446blendTreeBlendTree37264Child1.cycleOffset = 0f;
			equipFromIdleWaterAnimatorState36446blendTreeBlendTree37264Child1.directBlendParameter = "HorizontalMovement";
			equipFromIdleWaterAnimatorState36446blendTreeBlendTree37264Child1.mirror = false;
			equipFromIdleWaterAnimatorState36446blendTreeBlendTree37264Child1.position = new Vector2(-1f, 0f);
			equipFromIdleWaterAnimatorState36446blendTreeBlendTree37264Child1.threshold = 0.25f;
			equipFromIdleWaterAnimatorState36446blendTreeBlendTree37264Child1.timeScale = 1f;
			var equipFromIdleWaterAnimatorState36446blendTreeBlendTree37264Child2 =  new ChildMotion();
			equipFromIdleWaterAnimatorState36446blendTreeBlendTree37264Child2.motion = tridentEquipFromIdleAnimationClip13516;
			equipFromIdleWaterAnimatorState36446blendTreeBlendTree37264Child2.cycleOffset = 0f;
			equipFromIdleWaterAnimatorState36446blendTreeBlendTree37264Child2.directBlendParameter = "HorizontalMovement";
			equipFromIdleWaterAnimatorState36446blendTreeBlendTree37264Child2.mirror = false;
			equipFromIdleWaterAnimatorState36446blendTreeBlendTree37264Child2.position = new Vector2(0f, 0f);
			equipFromIdleWaterAnimatorState36446blendTreeBlendTree37264Child2.threshold = 0.5f;
			equipFromIdleWaterAnimatorState36446blendTreeBlendTree37264Child2.timeScale = 1f;
			var equipFromIdleWaterAnimatorState36446blendTreeBlendTree37264Child3 =  new ChildMotion();
			equipFromIdleWaterAnimatorState36446blendTreeBlendTree37264Child3.motion = tridentEquipFromIdleStrafeAnimationClip25624;
			equipFromIdleWaterAnimatorState36446blendTreeBlendTree37264Child3.cycleOffset = 0f;
			equipFromIdleWaterAnimatorState36446blendTreeBlendTree37264Child3.directBlendParameter = "HorizontalMovement";
			equipFromIdleWaterAnimatorState36446blendTreeBlendTree37264Child3.mirror = false;
			equipFromIdleWaterAnimatorState36446blendTreeBlendTree37264Child3.position = new Vector2(1f, 0f);
			equipFromIdleWaterAnimatorState36446blendTreeBlendTree37264Child3.threshold = 0.75f;
			equipFromIdleWaterAnimatorState36446blendTreeBlendTree37264Child3.timeScale = 1f;
			var equipFromIdleWaterAnimatorState36446blendTreeBlendTree37264Child4 =  new ChildMotion();
			equipFromIdleWaterAnimatorState36446blendTreeBlendTree37264Child4.motion = tridentEquipFromIdleAnimationClip13516;
			equipFromIdleWaterAnimatorState36446blendTreeBlendTree37264Child4.cycleOffset = 0f;
			equipFromIdleWaterAnimatorState36446blendTreeBlendTree37264Child4.directBlendParameter = "HorizontalMovement";
			equipFromIdleWaterAnimatorState36446blendTreeBlendTree37264Child4.mirror = false;
			equipFromIdleWaterAnimatorState36446blendTreeBlendTree37264Child4.position = new Vector2(0f, 1f);
			equipFromIdleWaterAnimatorState36446blendTreeBlendTree37264Child4.threshold = 1f;
			equipFromIdleWaterAnimatorState36446blendTreeBlendTree37264Child4.timeScale = 1f;
			equipFromIdleWaterAnimatorState36446blendTreeBlendTree37264.children = new ChildMotion[] {
				equipFromIdleWaterAnimatorState36446blendTreeBlendTree37264Child0,
				equipFromIdleWaterAnimatorState36446blendTreeBlendTree37264Child1,
				equipFromIdleWaterAnimatorState36446blendTreeBlendTree37264Child2,
				equipFromIdleWaterAnimatorState36446blendTreeBlendTree37264Child3,
				equipFromIdleWaterAnimatorState36446blendTreeBlendTree37264Child4
			};
			equipFromIdleWaterAnimatorState36446.motion = equipFromIdleWaterAnimatorState36446blendTreeBlendTree37264;
			equipFromIdleWaterAnimatorState36446.cycleOffset = 0f;
			equipFromIdleWaterAnimatorState36446.cycleOffsetParameterActive = false;
			equipFromIdleWaterAnimatorState36446.iKOnFeet = false;
			equipFromIdleWaterAnimatorState36446.mirror = false;
			equipFromIdleWaterAnimatorState36446.mirrorParameterActive = false;
			equipFromIdleWaterAnimatorState36446.speed = 2.75f;
			equipFromIdleWaterAnimatorState36446.speedParameterActive = false;
			equipFromIdleWaterAnimatorState36446.writeDefaultValues = true;

			var unequipFromIdleWaterAnimatorState36448 = tridentAnimatorStateMachine35850.AddState("Unequip From Idle Water", new Vector3(144f, 372f, 0f));
			var unequipFromIdleWaterAnimatorState36448blendTreeBlendTree37268 = new BlendTree();
			AssetDatabase.AddObjectToAsset(unequipFromIdleWaterAnimatorState36448blendTreeBlendTree37268, animatorController);
			unequipFromIdleWaterAnimatorState36448blendTreeBlendTree37268.hideFlags = HideFlags.HideInHierarchy;
			unequipFromIdleWaterAnimatorState36448blendTreeBlendTree37268.blendParameter = "HorizontalMovement";
			unequipFromIdleWaterAnimatorState36448blendTreeBlendTree37268.blendParameterY = "ForwardMovement";
			unequipFromIdleWaterAnimatorState36448blendTreeBlendTree37268.blendType = BlendTreeType.FreeformCartesian2D;
			unequipFromIdleWaterAnimatorState36448blendTreeBlendTree37268.maxThreshold = 1f;
			unequipFromIdleWaterAnimatorState36448blendTreeBlendTree37268.minThreshold = 0f;
			unequipFromIdleWaterAnimatorState36448blendTreeBlendTree37268.name = "Blend Tree";
			unequipFromIdleWaterAnimatorState36448blendTreeBlendTree37268.useAutomaticThresholds = true;
			var unequipFromIdleWaterAnimatorState36448blendTreeBlendTree37268Child0 =  new ChildMotion();
			unequipFromIdleWaterAnimatorState36448blendTreeBlendTree37268Child0.motion = tridentUnequipFromIdleLandAnimationClip15942;
			unequipFromIdleWaterAnimatorState36448blendTreeBlendTree37268Child0.cycleOffset = 0f;
			unequipFromIdleWaterAnimatorState36448blendTreeBlendTree37268Child0.directBlendParameter = "HorizontalMovement";
			unequipFromIdleWaterAnimatorState36448blendTreeBlendTree37268Child0.mirror = false;
			unequipFromIdleWaterAnimatorState36448blendTreeBlendTree37268Child0.position = new Vector2(0f, -1f);
			unequipFromIdleWaterAnimatorState36448blendTreeBlendTree37268Child0.threshold = 0f;
			unequipFromIdleWaterAnimatorState36448blendTreeBlendTree37268Child0.timeScale = 1f;
			var unequipFromIdleWaterAnimatorState36448blendTreeBlendTree37268Child1 =  new ChildMotion();
			unequipFromIdleWaterAnimatorState36448blendTreeBlendTree37268Child1.motion = tridentUnequipFromIdleStrafeAnimationClip18048;
			unequipFromIdleWaterAnimatorState36448blendTreeBlendTree37268Child1.cycleOffset = 0f;
			unequipFromIdleWaterAnimatorState36448blendTreeBlendTree37268Child1.directBlendParameter = "HorizontalMovement";
			unequipFromIdleWaterAnimatorState36448blendTreeBlendTree37268Child1.mirror = false;
			unequipFromIdleWaterAnimatorState36448blendTreeBlendTree37268Child1.position = new Vector2(-1f, 0f);
			unequipFromIdleWaterAnimatorState36448blendTreeBlendTree37268Child1.threshold = 0.25f;
			unequipFromIdleWaterAnimatorState36448blendTreeBlendTree37268Child1.timeScale = 1f;
			var unequipFromIdleWaterAnimatorState36448blendTreeBlendTree37268Child2 =  new ChildMotion();
			unequipFromIdleWaterAnimatorState36448blendTreeBlendTree37268Child2.motion = tridentUnequipFromIdleAnimationClip22604;
			unequipFromIdleWaterAnimatorState36448blendTreeBlendTree37268Child2.cycleOffset = 0f;
			unequipFromIdleWaterAnimatorState36448blendTreeBlendTree37268Child2.directBlendParameter = "HorizontalMovement";
			unequipFromIdleWaterAnimatorState36448blendTreeBlendTree37268Child2.mirror = false;
			unequipFromIdleWaterAnimatorState36448blendTreeBlendTree37268Child2.position = new Vector2(0f, 0f);
			unequipFromIdleWaterAnimatorState36448blendTreeBlendTree37268Child2.threshold = 0.5f;
			unequipFromIdleWaterAnimatorState36448blendTreeBlendTree37268Child2.timeScale = 1f;
			var unequipFromIdleWaterAnimatorState36448blendTreeBlendTree37268Child3 =  new ChildMotion();
			unequipFromIdleWaterAnimatorState36448blendTreeBlendTree37268Child3.motion = tridentUnequipFromIdleStrafeAnimationClip18048;
			unequipFromIdleWaterAnimatorState36448blendTreeBlendTree37268Child3.cycleOffset = 0f;
			unequipFromIdleWaterAnimatorState36448blendTreeBlendTree37268Child3.directBlendParameter = "HorizontalMovement";
			unequipFromIdleWaterAnimatorState36448blendTreeBlendTree37268Child3.mirror = false;
			unequipFromIdleWaterAnimatorState36448blendTreeBlendTree37268Child3.position = new Vector2(1f, 0f);
			unequipFromIdleWaterAnimatorState36448blendTreeBlendTree37268Child3.threshold = 0.75f;
			unequipFromIdleWaterAnimatorState36448blendTreeBlendTree37268Child3.timeScale = 1f;
			var unequipFromIdleWaterAnimatorState36448blendTreeBlendTree37268Child4 =  new ChildMotion();
			unequipFromIdleWaterAnimatorState36448blendTreeBlendTree37268Child4.motion = tridentUnequipFromIdleAnimationClip22604;
			unequipFromIdleWaterAnimatorState36448blendTreeBlendTree37268Child4.cycleOffset = 0f;
			unequipFromIdleWaterAnimatorState36448blendTreeBlendTree37268Child4.directBlendParameter = "HorizontalMovement";
			unequipFromIdleWaterAnimatorState36448blendTreeBlendTree37268Child4.mirror = false;
			unequipFromIdleWaterAnimatorState36448blendTreeBlendTree37268Child4.position = new Vector2(0f, 1f);
			unequipFromIdleWaterAnimatorState36448blendTreeBlendTree37268Child4.threshold = 1f;
			unequipFromIdleWaterAnimatorState36448blendTreeBlendTree37268Child4.timeScale = 1f;
			unequipFromIdleWaterAnimatorState36448blendTreeBlendTree37268.children = new ChildMotion[] {
				unequipFromIdleWaterAnimatorState36448blendTreeBlendTree37268Child0,
				unequipFromIdleWaterAnimatorState36448blendTreeBlendTree37268Child1,
				unequipFromIdleWaterAnimatorState36448blendTreeBlendTree37268Child2,
				unequipFromIdleWaterAnimatorState36448blendTreeBlendTree37268Child3,
				unequipFromIdleWaterAnimatorState36448blendTreeBlendTree37268Child4
			};
			unequipFromIdleWaterAnimatorState36448.motion = unequipFromIdleWaterAnimatorState36448blendTreeBlendTree37268;
			unequipFromIdleWaterAnimatorState36448.cycleOffset = 0f;
			unequipFromIdleWaterAnimatorState36448.cycleOffsetParameterActive = false;
			unequipFromIdleWaterAnimatorState36448.iKOnFeet = false;
			unequipFromIdleWaterAnimatorState36448.mirror = false;
			unequipFromIdleWaterAnimatorState36448.mirrorParameterActive = false;
			unequipFromIdleWaterAnimatorState36448.speed = 2.25f;
			unequipFromIdleWaterAnimatorState36448.speedParameterActive = false;
			unequipFromIdleWaterAnimatorState36448.writeDefaultValues = true;

			var dropWaterAnimatorState36450 = tridentAnimatorStateMachine35850.AddState("Drop Water", new Vector3(144f, 432f, 0f));
			var dropWaterAnimatorState36450blendTreeBlendTree37272 = new BlendTree();
			AssetDatabase.AddObjectToAsset(dropWaterAnimatorState36450blendTreeBlendTree37272, animatorController);
			dropWaterAnimatorState36450blendTreeBlendTree37272.hideFlags = HideFlags.HideInHierarchy;
			dropWaterAnimatorState36450blendTreeBlendTree37272.blendParameter = "HorizontalMovement";
			dropWaterAnimatorState36450blendTreeBlendTree37272.blendParameterY = "ForwardMovement";
			dropWaterAnimatorState36450blendTreeBlendTree37272.blendType = BlendTreeType.FreeformCartesian2D;
			dropWaterAnimatorState36450blendTreeBlendTree37272.maxThreshold = 1f;
			dropWaterAnimatorState36450blendTreeBlendTree37272.minThreshold = 0f;
			dropWaterAnimatorState36450blendTreeBlendTree37272.name = "Blend Tree";
			dropWaterAnimatorState36450blendTreeBlendTree37272.useAutomaticThresholds = true;
			var dropWaterAnimatorState36450blendTreeBlendTree37272Child0 =  new ChildMotion();
			dropWaterAnimatorState36450blendTreeBlendTree37272Child0.motion = tridentDropLandAnimationClip26280;
			dropWaterAnimatorState36450blendTreeBlendTree37272Child0.cycleOffset = 0f;
			dropWaterAnimatorState36450blendTreeBlendTree37272Child0.directBlendParameter = "HorizontalMovement";
			dropWaterAnimatorState36450blendTreeBlendTree37272Child0.mirror = false;
			dropWaterAnimatorState36450blendTreeBlendTree37272Child0.position = new Vector2(0f, -1f);
			dropWaterAnimatorState36450blendTreeBlendTree37272Child0.threshold = 0f;
			dropWaterAnimatorState36450blendTreeBlendTree37272Child0.timeScale = 1f;
			var dropWaterAnimatorState36450blendTreeBlendTree37272Child1 =  new ChildMotion();
			dropWaterAnimatorState36450blendTreeBlendTree37272Child1.motion = tridentDropStrafeAnimationClip27058;
			dropWaterAnimatorState36450blendTreeBlendTree37272Child1.cycleOffset = 0f;
			dropWaterAnimatorState36450blendTreeBlendTree37272Child1.directBlendParameter = "HorizontalMovement";
			dropWaterAnimatorState36450blendTreeBlendTree37272Child1.mirror = false;
			dropWaterAnimatorState36450blendTreeBlendTree37272Child1.position = new Vector2(-1f, 0f);
			dropWaterAnimatorState36450blendTreeBlendTree37272Child1.threshold = 0.25f;
			dropWaterAnimatorState36450blendTreeBlendTree37272Child1.timeScale = 1f;
			var dropWaterAnimatorState36450blendTreeBlendTree37272Child2 =  new ChildMotion();
			dropWaterAnimatorState36450blendTreeBlendTree37272Child2.motion = tridentDropAnimationClip26782;
			dropWaterAnimatorState36450blendTreeBlendTree37272Child2.cycleOffset = 0f;
			dropWaterAnimatorState36450blendTreeBlendTree37272Child2.directBlendParameter = "HorizontalMovement";
			dropWaterAnimatorState36450blendTreeBlendTree37272Child2.mirror = false;
			dropWaterAnimatorState36450blendTreeBlendTree37272Child2.position = new Vector2(0f, 0f);
			dropWaterAnimatorState36450blendTreeBlendTree37272Child2.threshold = 0.5f;
			dropWaterAnimatorState36450blendTreeBlendTree37272Child2.timeScale = 1f;
			var dropWaterAnimatorState36450blendTreeBlendTree37272Child3 =  new ChildMotion();
			dropWaterAnimatorState36450blendTreeBlendTree37272Child3.motion = tridentDropStrafeAnimationClip27058;
			dropWaterAnimatorState36450blendTreeBlendTree37272Child3.cycleOffset = 0f;
			dropWaterAnimatorState36450blendTreeBlendTree37272Child3.directBlendParameter = "HorizontalMovement";
			dropWaterAnimatorState36450blendTreeBlendTree37272Child3.mirror = false;
			dropWaterAnimatorState36450blendTreeBlendTree37272Child3.position = new Vector2(1f, 0f);
			dropWaterAnimatorState36450blendTreeBlendTree37272Child3.threshold = 0.75f;
			dropWaterAnimatorState36450blendTreeBlendTree37272Child3.timeScale = 1f;
			var dropWaterAnimatorState36450blendTreeBlendTree37272Child4 =  new ChildMotion();
			dropWaterAnimatorState36450blendTreeBlendTree37272Child4.motion = tridentDropAnimationClip26782;
			dropWaterAnimatorState36450blendTreeBlendTree37272Child4.cycleOffset = 0f;
			dropWaterAnimatorState36450blendTreeBlendTree37272Child4.directBlendParameter = "HorizontalMovement";
			dropWaterAnimatorState36450blendTreeBlendTree37272Child4.mirror = false;
			dropWaterAnimatorState36450blendTreeBlendTree37272Child4.position = new Vector2(0f, 1f);
			dropWaterAnimatorState36450blendTreeBlendTree37272Child4.threshold = 1f;
			dropWaterAnimatorState36450blendTreeBlendTree37272Child4.timeScale = 1f;
			dropWaterAnimatorState36450blendTreeBlendTree37272.children = new ChildMotion[] {
				dropWaterAnimatorState36450blendTreeBlendTree37272Child0,
				dropWaterAnimatorState36450blendTreeBlendTree37272Child1,
				dropWaterAnimatorState36450blendTreeBlendTree37272Child2,
				dropWaterAnimatorState36450blendTreeBlendTree37272Child3,
				dropWaterAnimatorState36450blendTreeBlendTree37272Child4
			};
			dropWaterAnimatorState36450.motion = dropWaterAnimatorState36450blendTreeBlendTree37272;
			dropWaterAnimatorState36450.cycleOffset = 0f;
			dropWaterAnimatorState36450.cycleOffsetParameterActive = false;
			dropWaterAnimatorState36450.iKOnFeet = false;
			dropWaterAnimatorState36450.mirror = false;
			dropWaterAnimatorState36450.mirrorParameterActive = false;
			dropWaterAnimatorState36450.speed = 1f;
			dropWaterAnimatorState36450.speedParameterActive = false;
			dropWaterAnimatorState36450.writeDefaultValues = true;

			var attackFromIdleAnimatorState36438 = tridentAnimatorStateMachine35850.AddState("Attack From Idle", new Vector3(144f, -288f, 0f));
			var attackFromIdleAnimatorState36438blendTreeBlendTree37276 = new BlendTree();
			AssetDatabase.AddObjectToAsset(attackFromIdleAnimatorState36438blendTreeBlendTree37276, animatorController);
			attackFromIdleAnimatorState36438blendTreeBlendTree37276.hideFlags = HideFlags.HideInHierarchy;
			attackFromIdleAnimatorState36438blendTreeBlendTree37276.blendParameter = "HorizontalMovement";
			attackFromIdleAnimatorState36438blendTreeBlendTree37276.blendParameterY = "ForwardMovement";
			attackFromIdleAnimatorState36438blendTreeBlendTree37276.blendType = BlendTreeType.FreeformCartesian2D;
			attackFromIdleAnimatorState36438blendTreeBlendTree37276.maxThreshold = 1f;
			attackFromIdleAnimatorState36438blendTreeBlendTree37276.minThreshold = 0f;
			attackFromIdleAnimatorState36438blendTreeBlendTree37276.name = "Blend Tree";
			attackFromIdleAnimatorState36438blendTreeBlendTree37276.useAutomaticThresholds = true;
			var attackFromIdleAnimatorState36438blendTreeBlendTree37276Child0 =  new ChildMotion();
			attackFromIdleAnimatorState36438blendTreeBlendTree37276Child0.motion = tridentAttackFromIdleBwdAnimationClip15052;
			attackFromIdleAnimatorState36438blendTreeBlendTree37276Child0.cycleOffset = 0f;
			attackFromIdleAnimatorState36438blendTreeBlendTree37276Child0.directBlendParameter = "HorizontalMovement";
			attackFromIdleAnimatorState36438blendTreeBlendTree37276Child0.mirror = false;
			attackFromIdleAnimatorState36438blendTreeBlendTree37276Child0.position = new Vector2(0f, -1f);
			attackFromIdleAnimatorState36438blendTreeBlendTree37276Child0.threshold = 0f;
			attackFromIdleAnimatorState36438blendTreeBlendTree37276Child0.timeScale = 1f;
			var attackFromIdleAnimatorState36438blendTreeBlendTree37276Child1 =  new ChildMotion();
			attackFromIdleAnimatorState36438blendTreeBlendTree37276Child1.motion = tridentAttackFromIdleStrafeAnimationClip20162;
			attackFromIdleAnimatorState36438blendTreeBlendTree37276Child1.cycleOffset = 0f;
			attackFromIdleAnimatorState36438blendTreeBlendTree37276Child1.directBlendParameter = "HorizontalMovement";
			attackFromIdleAnimatorState36438blendTreeBlendTree37276Child1.mirror = false;
			attackFromIdleAnimatorState36438blendTreeBlendTree37276Child1.position = new Vector2(-1f, 0f);
			attackFromIdleAnimatorState36438blendTreeBlendTree37276Child1.threshold = 0.25f;
			attackFromIdleAnimatorState36438blendTreeBlendTree37276Child1.timeScale = 1f;
			var attackFromIdleAnimatorState36438blendTreeBlendTree37276Child2 =  new ChildMotion();
			attackFromIdleAnimatorState36438blendTreeBlendTree37276Child2.motion = tridentAttackFromIdleAnimationClip13130;
			attackFromIdleAnimatorState36438blendTreeBlendTree37276Child2.cycleOffset = 0f;
			attackFromIdleAnimatorState36438blendTreeBlendTree37276Child2.directBlendParameter = "HorizontalMovement";
			attackFromIdleAnimatorState36438blendTreeBlendTree37276Child2.mirror = false;
			attackFromIdleAnimatorState36438blendTreeBlendTree37276Child2.position = new Vector2(0f, 0f);
			attackFromIdleAnimatorState36438blendTreeBlendTree37276Child2.threshold = 0.5f;
			attackFromIdleAnimatorState36438blendTreeBlendTree37276Child2.timeScale = 1f;
			var attackFromIdleAnimatorState36438blendTreeBlendTree37276Child3 =  new ChildMotion();
			attackFromIdleAnimatorState36438blendTreeBlendTree37276Child3.motion = tridentAttackFromIdleStrafeAnimationClip20162;
			attackFromIdleAnimatorState36438blendTreeBlendTree37276Child3.cycleOffset = 0f;
			attackFromIdleAnimatorState36438blendTreeBlendTree37276Child3.directBlendParameter = "HorizontalMovement";
			attackFromIdleAnimatorState36438blendTreeBlendTree37276Child3.mirror = false;
			attackFromIdleAnimatorState36438blendTreeBlendTree37276Child3.position = new Vector2(1f, 0f);
			attackFromIdleAnimatorState36438blendTreeBlendTree37276Child3.threshold = 0.75f;
			attackFromIdleAnimatorState36438blendTreeBlendTree37276Child3.timeScale = 1f;
			var attackFromIdleAnimatorState36438blendTreeBlendTree37276Child4 =  new ChildMotion();
			attackFromIdleAnimatorState36438blendTreeBlendTree37276Child4.motion = tridentAttackFromIdleAnimationClip13130;
			attackFromIdleAnimatorState36438blendTreeBlendTree37276Child4.cycleOffset = 0f;
			attackFromIdleAnimatorState36438blendTreeBlendTree37276Child4.directBlendParameter = "HorizontalMovement";
			attackFromIdleAnimatorState36438blendTreeBlendTree37276Child4.mirror = false;
			attackFromIdleAnimatorState36438blendTreeBlendTree37276Child4.position = new Vector2(0f, 1f);
			attackFromIdleAnimatorState36438blendTreeBlendTree37276Child4.threshold = 1f;
			attackFromIdleAnimatorState36438blendTreeBlendTree37276Child4.timeScale = 1f;
			attackFromIdleAnimatorState36438blendTreeBlendTree37276.children = new ChildMotion[] {
				attackFromIdleAnimatorState36438blendTreeBlendTree37276Child0,
				attackFromIdleAnimatorState36438blendTreeBlendTree37276Child1,
				attackFromIdleAnimatorState36438blendTreeBlendTree37276Child2,
				attackFromIdleAnimatorState36438blendTreeBlendTree37276Child3,
				attackFromIdleAnimatorState36438blendTreeBlendTree37276Child4
			};
			attackFromIdleAnimatorState36438.motion = attackFromIdleAnimatorState36438blendTreeBlendTree37276;
			attackFromIdleAnimatorState36438.cycleOffset = 0f;
			attackFromIdleAnimatorState36438.cycleOffsetParameterActive = false;
			attackFromIdleAnimatorState36438.iKOnFeet = false;
			attackFromIdleAnimatorState36438.mirror = false;
			attackFromIdleAnimatorState36438.mirrorParameterActive = false;
			attackFromIdleAnimatorState36438.speed = 3f;
			attackFromIdleAnimatorState36438.speedParameterActive = false;
			attackFromIdleAnimatorState36438.writeDefaultValues = true;

			var equipFromAimWaterAnimatorState36442 = tridentAnimatorStateMachine35850.AddState("Equip From Aim Water", new Vector3(144f, 192f, 0f));
			var equipFromAimWaterAnimatorState36442blendTreeBlendTree37280 = new BlendTree();
			AssetDatabase.AddObjectToAsset(equipFromAimWaterAnimatorState36442blendTreeBlendTree37280, animatorController);
			equipFromAimWaterAnimatorState36442blendTreeBlendTree37280.hideFlags = HideFlags.HideInHierarchy;
			equipFromAimWaterAnimatorState36442blendTreeBlendTree37280.blendParameter = "HorizontalMovement";
			equipFromAimWaterAnimatorState36442blendTreeBlendTree37280.blendParameterY = "ForwardMovement";
			equipFromAimWaterAnimatorState36442blendTreeBlendTree37280.blendType = BlendTreeType.FreeformCartesian2D;
			equipFromAimWaterAnimatorState36442blendTreeBlendTree37280.maxThreshold = 1f;
			equipFromAimWaterAnimatorState36442blendTreeBlendTree37280.minThreshold = 0f;
			equipFromAimWaterAnimatorState36442blendTreeBlendTree37280.name = "Blend Tree";
			equipFromAimWaterAnimatorState36442blendTreeBlendTree37280.useAutomaticThresholds = true;
			var equipFromAimWaterAnimatorState36442blendTreeBlendTree37280Child0 =  new ChildMotion();
			equipFromAimWaterAnimatorState36442blendTreeBlendTree37280Child0.motion = tridentEquipFromAimLandAnimationClip26258;
			equipFromAimWaterAnimatorState36442blendTreeBlendTree37280Child0.cycleOffset = 0f;
			equipFromAimWaterAnimatorState36442blendTreeBlendTree37280Child0.directBlendParameter = "HorizontalMovement";
			equipFromAimWaterAnimatorState36442blendTreeBlendTree37280Child0.mirror = false;
			equipFromAimWaterAnimatorState36442blendTreeBlendTree37280Child0.position = new Vector2(0f, -1f);
			equipFromAimWaterAnimatorState36442blendTreeBlendTree37280Child0.threshold = 0f;
			equipFromAimWaterAnimatorState36442blendTreeBlendTree37280Child0.timeScale = 1f;
			var equipFromAimWaterAnimatorState36442blendTreeBlendTree37280Child1 =  new ChildMotion();
			equipFromAimWaterAnimatorState36442blendTreeBlendTree37280Child1.motion = tridentEquipFromAimStrafeAnimationClip25286;
			equipFromAimWaterAnimatorState36442blendTreeBlendTree37280Child1.cycleOffset = 0f;
			equipFromAimWaterAnimatorState36442blendTreeBlendTree37280Child1.directBlendParameter = "HorizontalMovement";
			equipFromAimWaterAnimatorState36442blendTreeBlendTree37280Child1.mirror = false;
			equipFromAimWaterAnimatorState36442blendTreeBlendTree37280Child1.position = new Vector2(-1f, 0f);
			equipFromAimWaterAnimatorState36442blendTreeBlendTree37280Child1.threshold = 0.25f;
			equipFromAimWaterAnimatorState36442blendTreeBlendTree37280Child1.timeScale = 1f;
			var equipFromAimWaterAnimatorState36442blendTreeBlendTree37280Child2 =  new ChildMotion();
			equipFromAimWaterAnimatorState36442blendTreeBlendTree37280Child2.motion = tridentEquipFromAimAnimationClip23118;
			equipFromAimWaterAnimatorState36442blendTreeBlendTree37280Child2.cycleOffset = 0f;
			equipFromAimWaterAnimatorState36442blendTreeBlendTree37280Child2.directBlendParameter = "HorizontalMovement";
			equipFromAimWaterAnimatorState36442blendTreeBlendTree37280Child2.mirror = false;
			equipFromAimWaterAnimatorState36442blendTreeBlendTree37280Child2.position = new Vector2(0f, 0f);
			equipFromAimWaterAnimatorState36442blendTreeBlendTree37280Child2.threshold = 0.5f;
			equipFromAimWaterAnimatorState36442blendTreeBlendTree37280Child2.timeScale = 1f;
			var equipFromAimWaterAnimatorState36442blendTreeBlendTree37280Child3 =  new ChildMotion();
			equipFromAimWaterAnimatorState36442blendTreeBlendTree37280Child3.motion = tridentEquipFromAimStrafeAnimationClip25286;
			equipFromAimWaterAnimatorState36442blendTreeBlendTree37280Child3.cycleOffset = 0f;
			equipFromAimWaterAnimatorState36442blendTreeBlendTree37280Child3.directBlendParameter = "HorizontalMovement";
			equipFromAimWaterAnimatorState36442blendTreeBlendTree37280Child3.mirror = false;
			equipFromAimWaterAnimatorState36442blendTreeBlendTree37280Child3.position = new Vector2(1f, 0f);
			equipFromAimWaterAnimatorState36442blendTreeBlendTree37280Child3.threshold = 0.75f;
			equipFromAimWaterAnimatorState36442blendTreeBlendTree37280Child3.timeScale = 1f;
			var equipFromAimWaterAnimatorState36442blendTreeBlendTree37280Child4 =  new ChildMotion();
			equipFromAimWaterAnimatorState36442blendTreeBlendTree37280Child4.motion = tridentEquipFromAimAnimationClip23118;
			equipFromAimWaterAnimatorState36442blendTreeBlendTree37280Child4.cycleOffset = 0f;
			equipFromAimWaterAnimatorState36442blendTreeBlendTree37280Child4.directBlendParameter = "HorizontalMovement";
			equipFromAimWaterAnimatorState36442blendTreeBlendTree37280Child4.mirror = false;
			equipFromAimWaterAnimatorState36442blendTreeBlendTree37280Child4.position = new Vector2(0f, 1f);
			equipFromAimWaterAnimatorState36442blendTreeBlendTree37280Child4.threshold = 1f;
			equipFromAimWaterAnimatorState36442blendTreeBlendTree37280Child4.timeScale = 1f;
			equipFromAimWaterAnimatorState36442blendTreeBlendTree37280.children = new ChildMotion[] {
				equipFromAimWaterAnimatorState36442blendTreeBlendTree37280Child0,
				equipFromAimWaterAnimatorState36442blendTreeBlendTree37280Child1,
				equipFromAimWaterAnimatorState36442blendTreeBlendTree37280Child2,
				equipFromAimWaterAnimatorState36442blendTreeBlendTree37280Child3,
				equipFromAimWaterAnimatorState36442blendTreeBlendTree37280Child4
			};
			equipFromAimWaterAnimatorState36442.motion = equipFromAimWaterAnimatorState36442blendTreeBlendTree37280;
			equipFromAimWaterAnimatorState36442.cycleOffset = 0f;
			equipFromAimWaterAnimatorState36442.cycleOffsetParameterActive = false;
			equipFromAimWaterAnimatorState36442.iKOnFeet = false;
			equipFromAimWaterAnimatorState36442.mirror = false;
			equipFromAimWaterAnimatorState36442.mirrorParameterActive = false;
			equipFromAimWaterAnimatorState36442.speed = 2.75f;
			equipFromAimWaterAnimatorState36442.speedParameterActive = false;
			equipFromAimWaterAnimatorState36442.writeDefaultValues = true;

			var unequipFromAimWaterAnimatorState36444 = tridentAnimatorStateMachine35850.AddState("Unequip From Aim Water", new Vector3(144f, 252f, 0f));
			var unequipFromAimWaterAnimatorState36444blendTreeBlendTree37284 = new BlendTree();
			AssetDatabase.AddObjectToAsset(unequipFromAimWaterAnimatorState36444blendTreeBlendTree37284, animatorController);
			unequipFromAimWaterAnimatorState36444blendTreeBlendTree37284.hideFlags = HideFlags.HideInHierarchy;
			unequipFromAimWaterAnimatorState36444blendTreeBlendTree37284.blendParameter = "HorizontalMovement";
			unequipFromAimWaterAnimatorState36444blendTreeBlendTree37284.blendParameterY = "ForwardMovement";
			unequipFromAimWaterAnimatorState36444blendTreeBlendTree37284.blendType = BlendTreeType.FreeformCartesian2D;
			unequipFromAimWaterAnimatorState36444blendTreeBlendTree37284.maxThreshold = 1f;
			unequipFromAimWaterAnimatorState36444blendTreeBlendTree37284.minThreshold = 0f;
			unequipFromAimWaterAnimatorState36444blendTreeBlendTree37284.name = "Blend Tree";
			unequipFromAimWaterAnimatorState36444blendTreeBlendTree37284.useAutomaticThresholds = true;
			var unequipFromAimWaterAnimatorState36444blendTreeBlendTree37284Child0 =  new ChildMotion();
			unequipFromAimWaterAnimatorState36444blendTreeBlendTree37284Child0.motion = tridentUnequipFromAimLandAnimationClip29556;
			unequipFromAimWaterAnimatorState36444blendTreeBlendTree37284Child0.cycleOffset = 0f;
			unequipFromAimWaterAnimatorState36444blendTreeBlendTree37284Child0.directBlendParameter = "HorizontalMovement";
			unequipFromAimWaterAnimatorState36444blendTreeBlendTree37284Child0.mirror = false;
			unequipFromAimWaterAnimatorState36444blendTreeBlendTree37284Child0.position = new Vector2(0f, -1f);
			unequipFromAimWaterAnimatorState36444blendTreeBlendTree37284Child0.threshold = 0f;
			unequipFromAimWaterAnimatorState36444blendTreeBlendTree37284Child0.timeScale = 1f;
			var unequipFromAimWaterAnimatorState36444blendTreeBlendTree37284Child1 =  new ChildMotion();
			unequipFromAimWaterAnimatorState36444blendTreeBlendTree37284Child1.motion = tridentUnequipFromAimStrafeAnimationClip20492;
			unequipFromAimWaterAnimatorState36444blendTreeBlendTree37284Child1.cycleOffset = 0f;
			unequipFromAimWaterAnimatorState36444blendTreeBlendTree37284Child1.directBlendParameter = "HorizontalMovement";
			unequipFromAimWaterAnimatorState36444blendTreeBlendTree37284Child1.mirror = false;
			unequipFromAimWaterAnimatorState36444blendTreeBlendTree37284Child1.position = new Vector2(-1f, 0f);
			unequipFromAimWaterAnimatorState36444blendTreeBlendTree37284Child1.threshold = 0.25f;
			unequipFromAimWaterAnimatorState36444blendTreeBlendTree37284Child1.timeScale = 1f;
			var unequipFromAimWaterAnimatorState36444blendTreeBlendTree37284Child2 =  new ChildMotion();
			unequipFromAimWaterAnimatorState36444blendTreeBlendTree37284Child2.motion = tridentUnequipFromAimAnimationClip21188;
			unequipFromAimWaterAnimatorState36444blendTreeBlendTree37284Child2.cycleOffset = 0f;
			unequipFromAimWaterAnimatorState36444blendTreeBlendTree37284Child2.directBlendParameter = "HorizontalMovement";
			unequipFromAimWaterAnimatorState36444blendTreeBlendTree37284Child2.mirror = false;
			unequipFromAimWaterAnimatorState36444blendTreeBlendTree37284Child2.position = new Vector2(0f, 0f);
			unequipFromAimWaterAnimatorState36444blendTreeBlendTree37284Child2.threshold = 0.5f;
			unequipFromAimWaterAnimatorState36444blendTreeBlendTree37284Child2.timeScale = 1f;
			var unequipFromAimWaterAnimatorState36444blendTreeBlendTree37284Child3 =  new ChildMotion();
			unequipFromAimWaterAnimatorState36444blendTreeBlendTree37284Child3.motion = tridentUnequipFromAimStrafeAnimationClip20492;
			unequipFromAimWaterAnimatorState36444blendTreeBlendTree37284Child3.cycleOffset = 0f;
			unequipFromAimWaterAnimatorState36444blendTreeBlendTree37284Child3.directBlendParameter = "HorizontalMovement";
			unequipFromAimWaterAnimatorState36444blendTreeBlendTree37284Child3.mirror = false;
			unequipFromAimWaterAnimatorState36444blendTreeBlendTree37284Child3.position = new Vector2(1f, 0f);
			unequipFromAimWaterAnimatorState36444blendTreeBlendTree37284Child3.threshold = 0.75f;
			unequipFromAimWaterAnimatorState36444blendTreeBlendTree37284Child3.timeScale = 1f;
			var unequipFromAimWaterAnimatorState36444blendTreeBlendTree37284Child4 =  new ChildMotion();
			unequipFromAimWaterAnimatorState36444blendTreeBlendTree37284Child4.motion = tridentUnequipFromAimAnimationClip21188;
			unequipFromAimWaterAnimatorState36444blendTreeBlendTree37284Child4.cycleOffset = 0f;
			unequipFromAimWaterAnimatorState36444blendTreeBlendTree37284Child4.directBlendParameter = "HorizontalMovement";
			unequipFromAimWaterAnimatorState36444blendTreeBlendTree37284Child4.mirror = false;
			unequipFromAimWaterAnimatorState36444blendTreeBlendTree37284Child4.position = new Vector2(0f, 1f);
			unequipFromAimWaterAnimatorState36444blendTreeBlendTree37284Child4.threshold = 1f;
			unequipFromAimWaterAnimatorState36444blendTreeBlendTree37284Child4.timeScale = 1f;
			unequipFromAimWaterAnimatorState36444blendTreeBlendTree37284.children = new ChildMotion[] {
				unequipFromAimWaterAnimatorState36444blendTreeBlendTree37284Child0,
				unequipFromAimWaterAnimatorState36444blendTreeBlendTree37284Child1,
				unequipFromAimWaterAnimatorState36444blendTreeBlendTree37284Child2,
				unequipFromAimWaterAnimatorState36444blendTreeBlendTree37284Child3,
				unequipFromAimWaterAnimatorState36444blendTreeBlendTree37284Child4
			};
			unequipFromAimWaterAnimatorState36444.motion = unequipFromAimWaterAnimatorState36444blendTreeBlendTree37284;
			unequipFromAimWaterAnimatorState36444.cycleOffset = 0f;
			unequipFromAimWaterAnimatorState36444.cycleOffsetParameterActive = false;
			unequipFromAimWaterAnimatorState36444.iKOnFeet = false;
			unequipFromAimWaterAnimatorState36444.mirror = false;
			unequipFromAimWaterAnimatorState36444.mirrorParameterActive = false;
			unequipFromAimWaterAnimatorState36444.speed = 2.25f;
			unequipFromAimWaterAnimatorState36444.speedParameterActive = false;
			unequipFromAimWaterAnimatorState36444.writeDefaultValues = true;

			var equipFromAimLandAnimatorState36470 = tridentAnimatorStateMachine35850.AddState("Equip From Aim Land", new Vector3(144f, -108f, 0f));
			equipFromAimLandAnimatorState36470.motion = tridentEquipFromAimLandAnimationClip26258;
			equipFromAimLandAnimatorState36470.cycleOffset = 0f;
			equipFromAimLandAnimatorState36470.cycleOffsetParameterActive = false;
			equipFromAimLandAnimatorState36470.iKOnFeet = false;
			equipFromAimLandAnimatorState36470.mirror = false;
			equipFromAimLandAnimatorState36470.mirrorParameterActive = false;
			equipFromAimLandAnimatorState36470.speed = 2.75f;
			equipFromAimLandAnimatorState36470.speedParameterActive = false;
			equipFromAimLandAnimatorState36470.writeDefaultValues = true;

			var unequipFromAimLandAnimatorState36472 = tridentAnimatorStateMachine35850.AddState("Unequip From Aim Land", new Vector3(144f, -48f, 0f));
			unequipFromAimLandAnimatorState36472.motion = tridentUnequipFromAimLandAnimationClip29556;
			unequipFromAimLandAnimatorState36472.cycleOffset = 0f;
			unequipFromAimLandAnimatorState36472.cycleOffsetParameterActive = false;
			unequipFromAimLandAnimatorState36472.iKOnFeet = false;
			unequipFromAimLandAnimatorState36472.mirror = false;
			unequipFromAimLandAnimatorState36472.mirrorParameterActive = false;
			unequipFromAimLandAnimatorState36472.speed = 2.25f;
			unequipFromAimLandAnimatorState36472.speedParameterActive = false;
			unequipFromAimLandAnimatorState36472.writeDefaultValues = true;

			var equipFromIdleLandAnimatorState36474 = tridentAnimatorStateMachine35850.AddState("Equip From Idle Land", new Vector3(144f, 12f, 0f));
			equipFromIdleLandAnimatorState36474.motion = tridentEquipFromIdleLandAnimationClip24446;
			equipFromIdleLandAnimatorState36474.cycleOffset = 0f;
			equipFromIdleLandAnimatorState36474.cycleOffsetParameterActive = false;
			equipFromIdleLandAnimatorState36474.iKOnFeet = false;
			equipFromIdleLandAnimatorState36474.mirror = false;
			equipFromIdleLandAnimatorState36474.mirrorParameterActive = false;
			equipFromIdleLandAnimatorState36474.speed = 2.75f;
			equipFromIdleLandAnimatorState36474.speedParameterActive = false;
			equipFromIdleLandAnimatorState36474.writeDefaultValues = true;

			var unequipFromIdleLandAnimatorState36476 = tridentAnimatorStateMachine35850.AddState("Unequip From Idle Land", new Vector3(144f, 72f, 0f));
			unequipFromIdleLandAnimatorState36476.motion = tridentUnequipFromIdleLandAnimationClip15942;
			unequipFromIdleLandAnimatorState36476.cycleOffset = 0f;
			unequipFromIdleLandAnimatorState36476.cycleOffsetParameterActive = false;
			unequipFromIdleLandAnimatorState36476.iKOnFeet = false;
			unequipFromIdleLandAnimatorState36476.mirror = false;
			unequipFromIdleLandAnimatorState36476.mirrorParameterActive = false;
			unequipFromIdleLandAnimatorState36476.speed = 2.25f;
			unequipFromIdleLandAnimatorState36476.speedParameterActive = false;
			unequipFromIdleLandAnimatorState36476.writeDefaultValues = true;

			var dropWaterLandAnimatorState36478 = tridentAnimatorStateMachine35850.AddState("Drop Water Land", new Vector3(144f, 132f, 0f));
			dropWaterLandAnimatorState36478.motion = tridentDropAnimationClip26782;
			dropWaterLandAnimatorState36478.cycleOffset = 0f;
			dropWaterLandAnimatorState36478.cycleOffsetParameterActive = false;
			dropWaterLandAnimatorState36478.iKOnFeet = false;
			dropWaterLandAnimatorState36478.mirror = false;
			dropWaterLandAnimatorState36478.mirrorParameterActive = false;
			dropWaterLandAnimatorState36478.speed = 1f;
			dropWaterLandAnimatorState36478.speedParameterActive = false;
			dropWaterLandAnimatorState36478.writeDefaultValues = true;

			// State Transitions.
			var animatorStateTransition37258 = attackFromAimAnimatorState36440.AddExitTransition();
			animatorStateTransition37258.canTransitionToSelf = true;
			animatorStateTransition37258.duration = 0.25f;
			animatorStateTransition37258.exitTime = 0.8f;
			animatorStateTransition37258.hasExitTime = false;
			animatorStateTransition37258.hasFixedDuration = true;
			animatorStateTransition37258.interruptionSource = TransitionInterruptionSource.Source;
			animatorStateTransition37258.offset = 0f;
			animatorStateTransition37258.orderedInterruption = true;
			animatorStateTransition37258.isExit = true;
			animatorStateTransition37258.mute = false;
			animatorStateTransition37258.solo = false;
			animatorStateTransition37258.AddCondition(AnimatorConditionMode.NotEqual, 2f, "Slot0ItemStateIndex");

			var animatorStateTransition37262 = equipFromIdleWaterAnimatorState36446.AddExitTransition();
			animatorStateTransition37262.canTransitionToSelf = true;
			animatorStateTransition37262.duration = 0.2f;
			animatorStateTransition37262.exitTime = 0.75f;
			animatorStateTransition37262.hasExitTime = false;
			animatorStateTransition37262.hasFixedDuration = true;
			animatorStateTransition37262.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition37262.offset = 0f;
			animatorStateTransition37262.orderedInterruption = true;
			animatorStateTransition37262.isExit = true;
			animatorStateTransition37262.mute = false;
			animatorStateTransition37262.solo = false;
			animatorStateTransition37262.AddCondition(AnimatorConditionMode.NotEqual, 4f, "Slot0ItemStateIndex");

			var animatorStateTransition37266 = unequipFromIdleWaterAnimatorState36448.AddExitTransition();
			animatorStateTransition37266.canTransitionToSelf = true;
			animatorStateTransition37266.duration = 0.2f;
			animatorStateTransition37266.exitTime = 0.75f;
			animatorStateTransition37266.hasExitTime = false;
			animatorStateTransition37266.hasFixedDuration = true;
			animatorStateTransition37266.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition37266.offset = 0f;
			animatorStateTransition37266.orderedInterruption = true;
			animatorStateTransition37266.isExit = true;
			animatorStateTransition37266.mute = false;
			animatorStateTransition37266.solo = false;
			animatorStateTransition37266.AddCondition(AnimatorConditionMode.NotEqual, 5f, "Slot0ItemStateIndex");

			var animatorStateTransition37270 = dropWaterAnimatorState36450.AddExitTransition();
			animatorStateTransition37270.canTransitionToSelf = true;
			animatorStateTransition37270.duration = 0.1f;
			animatorStateTransition37270.exitTime = 0.9f;
			animatorStateTransition37270.hasExitTime = true;
			animatorStateTransition37270.hasFixedDuration = true;
			animatorStateTransition37270.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition37270.offset = 0f;
			animatorStateTransition37270.orderedInterruption = true;
			animatorStateTransition37270.isExit = true;
			animatorStateTransition37270.mute = false;
			animatorStateTransition37270.solo = false;

			var animatorStateTransition37274 = attackFromIdleAnimatorState36438.AddExitTransition();
			animatorStateTransition37274.canTransitionToSelf = true;
			animatorStateTransition37274.duration = 0.25f;
			animatorStateTransition37274.exitTime = 0.8f;
			animatorStateTransition37274.hasExitTime = false;
			animatorStateTransition37274.hasFixedDuration = true;
			animatorStateTransition37274.interruptionSource = TransitionInterruptionSource.Source;
			animatorStateTransition37274.offset = 0f;
			animatorStateTransition37274.orderedInterruption = true;
			animatorStateTransition37274.isExit = true;
			animatorStateTransition37274.mute = false;
			animatorStateTransition37274.solo = false;
			animatorStateTransition37274.AddCondition(AnimatorConditionMode.NotEqual, 2f, "Slot0ItemStateIndex");

			var animatorStateTransition37278 = equipFromAimWaterAnimatorState36442.AddExitTransition();
			animatorStateTransition37278.canTransitionToSelf = true;
			animatorStateTransition37278.duration = 0.2f;
			animatorStateTransition37278.exitTime = 0.85f;
			animatorStateTransition37278.hasExitTime = false;
			animatorStateTransition37278.hasFixedDuration = true;
			animatorStateTransition37278.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition37278.offset = 0f;
			animatorStateTransition37278.orderedInterruption = true;
			animatorStateTransition37278.isExit = true;
			animatorStateTransition37278.mute = false;
			animatorStateTransition37278.solo = false;
			animatorStateTransition37278.AddCondition(AnimatorConditionMode.NotEqual, 4f, "Slot0ItemStateIndex");

			var animatorStateTransition37282 = unequipFromAimWaterAnimatorState36444.AddExitTransition();
			animatorStateTransition37282.canTransitionToSelf = true;
			animatorStateTransition37282.duration = 0.2f;
			animatorStateTransition37282.exitTime = 0.8f;
			animatorStateTransition37282.hasExitTime = false;
			animatorStateTransition37282.hasFixedDuration = true;
			animatorStateTransition37282.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition37282.offset = 0f;
			animatorStateTransition37282.orderedInterruption = true;
			animatorStateTransition37282.isExit = true;
			animatorStateTransition37282.mute = false;
			animatorStateTransition37282.solo = false;
			animatorStateTransition37282.AddCondition(AnimatorConditionMode.NotEqual, 5f, "Slot0ItemStateIndex");

			var animatorStateTransition37286 = equipFromAimLandAnimatorState36470.AddExitTransition();
			animatorStateTransition37286.canTransitionToSelf = true;
			animatorStateTransition37286.duration = 0.2f;
			animatorStateTransition37286.exitTime = 0.85f;
			animatorStateTransition37286.hasExitTime = false;
			animatorStateTransition37286.hasFixedDuration = true;
			animatorStateTransition37286.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition37286.offset = 0f;
			animatorStateTransition37286.orderedInterruption = true;
			animatorStateTransition37286.isExit = true;
			animatorStateTransition37286.mute = false;
			animatorStateTransition37286.solo = false;
			animatorStateTransition37286.AddCondition(AnimatorConditionMode.NotEqual, 4f, "Slot0ItemStateIndex");

			var animatorStateTransition37288 = unequipFromAimLandAnimatorState36472.AddExitTransition();
			animatorStateTransition37288.canTransitionToSelf = true;
			animatorStateTransition37288.duration = 0.2f;
			animatorStateTransition37288.exitTime = 0.8f;
			animatorStateTransition37288.hasExitTime = false;
			animatorStateTransition37288.hasFixedDuration = true;
			animatorStateTransition37288.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition37288.offset = 0f;
			animatorStateTransition37288.orderedInterruption = true;
			animatorStateTransition37288.isExit = true;
			animatorStateTransition37288.mute = false;
			animatorStateTransition37288.solo = false;
			animatorStateTransition37288.AddCondition(AnimatorConditionMode.NotEqual, 5f, "Slot0ItemStateIndex");

			var animatorStateTransition37290 = equipFromIdleLandAnimatorState36474.AddExitTransition();
			animatorStateTransition37290.canTransitionToSelf = true;
			animatorStateTransition37290.duration = 0.2f;
			animatorStateTransition37290.exitTime = 0.75f;
			animatorStateTransition37290.hasExitTime = false;
			animatorStateTransition37290.hasFixedDuration = true;
			animatorStateTransition37290.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition37290.offset = 0f;
			animatorStateTransition37290.orderedInterruption = true;
			animatorStateTransition37290.isExit = true;
			animatorStateTransition37290.mute = false;
			animatorStateTransition37290.solo = false;
			animatorStateTransition37290.AddCondition(AnimatorConditionMode.NotEqual, 4f, "Slot0ItemStateIndex");

			var animatorStateTransition37292 = unequipFromIdleLandAnimatorState36476.AddExitTransition();
			animatorStateTransition37292.canTransitionToSelf = true;
			animatorStateTransition37292.duration = 0.2f;
			animatorStateTransition37292.exitTime = 0.75f;
			animatorStateTransition37292.hasExitTime = false;
			animatorStateTransition37292.hasFixedDuration = true;
			animatorStateTransition37292.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition37292.offset = 0f;
			animatorStateTransition37292.orderedInterruption = true;
			animatorStateTransition37292.isExit = true;
			animatorStateTransition37292.mute = false;
			animatorStateTransition37292.solo = false;
			animatorStateTransition37292.AddCondition(AnimatorConditionMode.NotEqual, 5f, "Slot0ItemStateIndex");

			var animatorStateTransition37294 = dropWaterLandAnimatorState36478.AddExitTransition();
			animatorStateTransition37294.canTransitionToSelf = true;
			animatorStateTransition37294.duration = 0.1f;
			animatorStateTransition37294.exitTime = 0.9f;
			animatorStateTransition37294.hasExitTime = true;
			animatorStateTransition37294.hasFixedDuration = true;
			animatorStateTransition37294.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition37294.offset = 0f;
			animatorStateTransition37294.orderedInterruption = true;
			animatorStateTransition37294.isExit = true;
			animatorStateTransition37294.mute = false;
			animatorStateTransition37294.solo = false;

			// State Machine Defaults.
			tridentAnimatorStateMachine35850.anyStatePosition = new Vector3(-192f, 36f, 0f);
			tridentAnimatorStateMachine35850.defaultState = attackFromIdleAnimatorState36438;
			tridentAnimatorStateMachine35850.entryPosition = new Vector3(-192f, -36f, 0f);
			tridentAnimatorStateMachine35850.exitPosition = new Vector3(516f, 36f, 0f);
			tridentAnimatorStateMachine35850.parentStateMachinePosition = new Vector3(504f, -60f, 0f);

			var baseStateMachine1289260044 = animatorController.layers[4].stateMachine;

			// The state machine should start fresh.
			for (int i = 0; i < animatorController.layers.Length; ++i) {
				for (int j = 0; j < baseStateMachine1289260044.stateMachines.Length; ++j) {
					if (baseStateMachine1289260044.stateMachines[j].stateMachine.name == "Underwater Gun") {
						baseStateMachine1289260044.RemoveStateMachine(baseStateMachine1289260044.stateMachines[j].stateMachine);
						break;
					}
				}
			}

			// AnimationClip references.

			// State Machine.
			var underwaterGunAnimatorStateMachine35852 = baseStateMachine1289260044.AddStateMachine("Underwater Gun", new Vector3(384f, 396f, 0f));

			// States.
			var unequipFromIdleWaterAnimatorState36452 = underwaterGunAnimatorStateMachine35852.AddState("Unequip From Idle Water", new Vector3(264f, 240f, 0f));
			var unequipFromIdleWaterAnimatorState36452blendTreeBlendTree37298 = new BlendTree();
			AssetDatabase.AddObjectToAsset(unequipFromIdleWaterAnimatorState36452blendTreeBlendTree37298, animatorController);
			unequipFromIdleWaterAnimatorState36452blendTreeBlendTree37298.hideFlags = HideFlags.HideInHierarchy;
			unequipFromIdleWaterAnimatorState36452blendTreeBlendTree37298.blendParameter = "HorizontalMovement";
			unequipFromIdleWaterAnimatorState36452blendTreeBlendTree37298.blendParameterY = "ForwardMovement";
			unequipFromIdleWaterAnimatorState36452blendTreeBlendTree37298.blendType = BlendTreeType.FreeformCartesian2D;
			unequipFromIdleWaterAnimatorState36452blendTreeBlendTree37298.maxThreshold = 1f;
			unequipFromIdleWaterAnimatorState36452blendTreeBlendTree37298.minThreshold = 0f;
			unequipFromIdleWaterAnimatorState36452blendTreeBlendTree37298.name = "Blend Tree";
			unequipFromIdleWaterAnimatorState36452blendTreeBlendTree37298.useAutomaticThresholds = true;
			var unequipFromIdleWaterAnimatorState36452blendTreeBlendTree37298Child0 =  new ChildMotion();
			unequipFromIdleWaterAnimatorState36452blendTreeBlendTree37298Child0.motion = underwaterGunUnequipFromIdleLandAnimationClip23408;
			unequipFromIdleWaterAnimatorState36452blendTreeBlendTree37298Child0.cycleOffset = 0f;
			unequipFromIdleWaterAnimatorState36452blendTreeBlendTree37298Child0.directBlendParameter = "HorizontalMovement";
			unequipFromIdleWaterAnimatorState36452blendTreeBlendTree37298Child0.mirror = false;
			unequipFromIdleWaterAnimatorState36452blendTreeBlendTree37298Child0.position = new Vector2(0f, -1f);
			unequipFromIdleWaterAnimatorState36452blendTreeBlendTree37298Child0.threshold = 0f;
			unequipFromIdleWaterAnimatorState36452blendTreeBlendTree37298Child0.timeScale = 1f;
			var unequipFromIdleWaterAnimatorState36452blendTreeBlendTree37298Child1 =  new ChildMotion();
			unequipFromIdleWaterAnimatorState36452blendTreeBlendTree37298Child1.motion = underwaterGunUnequipFromIdleStrafeAnimationClip14186;
			unequipFromIdleWaterAnimatorState36452blendTreeBlendTree37298Child1.cycleOffset = 0f;
			unequipFromIdleWaterAnimatorState36452blendTreeBlendTree37298Child1.directBlendParameter = "HorizontalMovement";
			unequipFromIdleWaterAnimatorState36452blendTreeBlendTree37298Child1.mirror = false;
			unequipFromIdleWaterAnimatorState36452blendTreeBlendTree37298Child1.position = new Vector2(-1f, 0f);
			unequipFromIdleWaterAnimatorState36452blendTreeBlendTree37298Child1.threshold = 0.25f;
			unequipFromIdleWaterAnimatorState36452blendTreeBlendTree37298Child1.timeScale = 1f;
			var unequipFromIdleWaterAnimatorState36452blendTreeBlendTree37298Child2 =  new ChildMotion();
			unequipFromIdleWaterAnimatorState36452blendTreeBlendTree37298Child2.motion = underwaterGunUnequipFromIdleAnimationClip15246;
			unequipFromIdleWaterAnimatorState36452blendTreeBlendTree37298Child2.cycleOffset = 0f;
			unequipFromIdleWaterAnimatorState36452blendTreeBlendTree37298Child2.directBlendParameter = "HorizontalMovement";
			unequipFromIdleWaterAnimatorState36452blendTreeBlendTree37298Child2.mirror = false;
			unequipFromIdleWaterAnimatorState36452blendTreeBlendTree37298Child2.position = new Vector2(0f, 0f);
			unequipFromIdleWaterAnimatorState36452blendTreeBlendTree37298Child2.threshold = 0.5f;
			unequipFromIdleWaterAnimatorState36452blendTreeBlendTree37298Child2.timeScale = 1f;
			var unequipFromIdleWaterAnimatorState36452blendTreeBlendTree37298Child3 =  new ChildMotion();
			unequipFromIdleWaterAnimatorState36452blendTreeBlendTree37298Child3.motion = underwaterGunUnequipFromIdleStrafeAnimationClip14186;
			unequipFromIdleWaterAnimatorState36452blendTreeBlendTree37298Child3.cycleOffset = 0f;
			unequipFromIdleWaterAnimatorState36452blendTreeBlendTree37298Child3.directBlendParameter = "HorizontalMovement";
			unequipFromIdleWaterAnimatorState36452blendTreeBlendTree37298Child3.mirror = false;
			unequipFromIdleWaterAnimatorState36452blendTreeBlendTree37298Child3.position = new Vector2(1f, 0f);
			unequipFromIdleWaterAnimatorState36452blendTreeBlendTree37298Child3.threshold = 0.75f;
			unequipFromIdleWaterAnimatorState36452blendTreeBlendTree37298Child3.timeScale = 1f;
			var unequipFromIdleWaterAnimatorState36452blendTreeBlendTree37298Child4 =  new ChildMotion();
			unequipFromIdleWaterAnimatorState36452blendTreeBlendTree37298Child4.motion = underwaterGunUnequipFromIdleAnimationClip15246;
			unequipFromIdleWaterAnimatorState36452blendTreeBlendTree37298Child4.cycleOffset = 0f;
			unequipFromIdleWaterAnimatorState36452blendTreeBlendTree37298Child4.directBlendParameter = "HorizontalMovement";
			unequipFromIdleWaterAnimatorState36452blendTreeBlendTree37298Child4.mirror = false;
			unequipFromIdleWaterAnimatorState36452blendTreeBlendTree37298Child4.position = new Vector2(0f, 1f);
			unequipFromIdleWaterAnimatorState36452blendTreeBlendTree37298Child4.threshold = 1f;
			unequipFromIdleWaterAnimatorState36452blendTreeBlendTree37298Child4.timeScale = 1f;
			unequipFromIdleWaterAnimatorState36452blendTreeBlendTree37298.children = new ChildMotion[] {
				unequipFromIdleWaterAnimatorState36452blendTreeBlendTree37298Child0,
				unequipFromIdleWaterAnimatorState36452blendTreeBlendTree37298Child1,
				unequipFromIdleWaterAnimatorState36452blendTreeBlendTree37298Child2,
				unequipFromIdleWaterAnimatorState36452blendTreeBlendTree37298Child3,
				unequipFromIdleWaterAnimatorState36452blendTreeBlendTree37298Child4
			};
			unequipFromIdleWaterAnimatorState36452.motion = unequipFromIdleWaterAnimatorState36452blendTreeBlendTree37298;
			unequipFromIdleWaterAnimatorState36452.cycleOffset = 0f;
			unequipFromIdleWaterAnimatorState36452.cycleOffsetParameterActive = false;
			unequipFromIdleWaterAnimatorState36452.iKOnFeet = false;
			unequipFromIdleWaterAnimatorState36452.mirror = false;
			unequipFromIdleWaterAnimatorState36452.mirrorParameterActive = false;
			unequipFromIdleWaterAnimatorState36452.speed = 3f;
			unequipFromIdleWaterAnimatorState36452.speedParameterActive = false;
			unequipFromIdleWaterAnimatorState36452.writeDefaultValues = true;

			var unequipFromAimWaterAnimatorState36454 = underwaterGunAnimatorStateMachine35852.AddState("Unequip From Aim Water", new Vector3(264f, 120f, 0f));
			var unequipFromAimWaterAnimatorState36454blendTreeBlendTree37302 = new BlendTree();
			AssetDatabase.AddObjectToAsset(unequipFromAimWaterAnimatorState36454blendTreeBlendTree37302, animatorController);
			unequipFromAimWaterAnimatorState36454blendTreeBlendTree37302.hideFlags = HideFlags.HideInHierarchy;
			unequipFromAimWaterAnimatorState36454blendTreeBlendTree37302.blendParameter = "HorizontalMovement";
			unequipFromAimWaterAnimatorState36454blendTreeBlendTree37302.blendParameterY = "ForwardMovement";
			unequipFromAimWaterAnimatorState36454blendTreeBlendTree37302.blendType = BlendTreeType.FreeformCartesian2D;
			unequipFromAimWaterAnimatorState36454blendTreeBlendTree37302.maxThreshold = 1f;
			unequipFromAimWaterAnimatorState36454blendTreeBlendTree37302.minThreshold = 0f;
			unequipFromAimWaterAnimatorState36454blendTreeBlendTree37302.name = "Blend Tree";
			unequipFromAimWaterAnimatorState36454blendTreeBlendTree37302.useAutomaticThresholds = true;
			var unequipFromAimWaterAnimatorState36454blendTreeBlendTree37302Child0 =  new ChildMotion();
			unequipFromAimWaterAnimatorState36454blendTreeBlendTree37302Child0.motion = underwaterGunUnequipFromAimLandAnimationClip25762;
			unequipFromAimWaterAnimatorState36454blendTreeBlendTree37302Child0.cycleOffset = 0f;
			unequipFromAimWaterAnimatorState36454blendTreeBlendTree37302Child0.directBlendParameter = "HorizontalMovement";
			unequipFromAimWaterAnimatorState36454blendTreeBlendTree37302Child0.mirror = false;
			unequipFromAimWaterAnimatorState36454blendTreeBlendTree37302Child0.position = new Vector2(0f, -1f);
			unequipFromAimWaterAnimatorState36454blendTreeBlendTree37302Child0.threshold = 0f;
			unequipFromAimWaterAnimatorState36454blendTreeBlendTree37302Child0.timeScale = 1f;
			var unequipFromAimWaterAnimatorState36454blendTreeBlendTree37302Child1 =  new ChildMotion();
			unequipFromAimWaterAnimatorState36454blendTreeBlendTree37302Child1.motion = underwaterGunUnequipFromAimStrafeAnimationClip23604;
			unequipFromAimWaterAnimatorState36454blendTreeBlendTree37302Child1.cycleOffset = 0f;
			unequipFromAimWaterAnimatorState36454blendTreeBlendTree37302Child1.directBlendParameter = "HorizontalMovement";
			unequipFromAimWaterAnimatorState36454blendTreeBlendTree37302Child1.mirror = false;
			unequipFromAimWaterAnimatorState36454blendTreeBlendTree37302Child1.position = new Vector2(-1f, 0f);
			unequipFromAimWaterAnimatorState36454blendTreeBlendTree37302Child1.threshold = 0.25f;
			unequipFromAimWaterAnimatorState36454blendTreeBlendTree37302Child1.timeScale = 1f;
			var unequipFromAimWaterAnimatorState36454blendTreeBlendTree37302Child2 =  new ChildMotion();
			unequipFromAimWaterAnimatorState36454blendTreeBlendTree37302Child2.motion = underwaterGunUnequipFromAimAnimationClip22528;
			unequipFromAimWaterAnimatorState36454blendTreeBlendTree37302Child2.cycleOffset = 0f;
			unequipFromAimWaterAnimatorState36454blendTreeBlendTree37302Child2.directBlendParameter = "HorizontalMovement";
			unequipFromAimWaterAnimatorState36454blendTreeBlendTree37302Child2.mirror = false;
			unequipFromAimWaterAnimatorState36454blendTreeBlendTree37302Child2.position = new Vector2(0f, 0f);
			unequipFromAimWaterAnimatorState36454blendTreeBlendTree37302Child2.threshold = 0.5f;
			unequipFromAimWaterAnimatorState36454blendTreeBlendTree37302Child2.timeScale = 1f;
			var unequipFromAimWaterAnimatorState36454blendTreeBlendTree37302Child3 =  new ChildMotion();
			unequipFromAimWaterAnimatorState36454blendTreeBlendTree37302Child3.motion = underwaterGunUnequipFromAimStrafeAnimationClip23604;
			unequipFromAimWaterAnimatorState36454blendTreeBlendTree37302Child3.cycleOffset = 0.5f;
			unequipFromAimWaterAnimatorState36454blendTreeBlendTree37302Child3.directBlendParameter = "HorizontalMovement";
			unequipFromAimWaterAnimatorState36454blendTreeBlendTree37302Child3.mirror = true;
			unequipFromAimWaterAnimatorState36454blendTreeBlendTree37302Child3.position = new Vector2(1f, 0f);
			unequipFromAimWaterAnimatorState36454blendTreeBlendTree37302Child3.threshold = 0.75f;
			unequipFromAimWaterAnimatorState36454blendTreeBlendTree37302Child3.timeScale = 1f;
			var unequipFromAimWaterAnimatorState36454blendTreeBlendTree37302Child4 =  new ChildMotion();
			unequipFromAimWaterAnimatorState36454blendTreeBlendTree37302Child4.motion = underwaterGunUnequipFromAimAnimationClip22528;
			unequipFromAimWaterAnimatorState36454blendTreeBlendTree37302Child4.cycleOffset = 0f;
			unequipFromAimWaterAnimatorState36454blendTreeBlendTree37302Child4.directBlendParameter = "HorizontalMovement";
			unequipFromAimWaterAnimatorState36454blendTreeBlendTree37302Child4.mirror = false;
			unequipFromAimWaterAnimatorState36454blendTreeBlendTree37302Child4.position = new Vector2(0f, 1f);
			unequipFromAimWaterAnimatorState36454blendTreeBlendTree37302Child4.threshold = 1f;
			unequipFromAimWaterAnimatorState36454blendTreeBlendTree37302Child4.timeScale = 1f;
			unequipFromAimWaterAnimatorState36454blendTreeBlendTree37302.children = new ChildMotion[] {
				unequipFromAimWaterAnimatorState36454blendTreeBlendTree37302Child0,
				unequipFromAimWaterAnimatorState36454blendTreeBlendTree37302Child1,
				unequipFromAimWaterAnimatorState36454blendTreeBlendTree37302Child2,
				unequipFromAimWaterAnimatorState36454blendTreeBlendTree37302Child3,
				unequipFromAimWaterAnimatorState36454blendTreeBlendTree37302Child4
			};
			unequipFromAimWaterAnimatorState36454.motion = unequipFromAimWaterAnimatorState36454blendTreeBlendTree37302;
			unequipFromAimWaterAnimatorState36454.cycleOffset = 0f;
			unequipFromAimWaterAnimatorState36454.cycleOffsetParameterActive = false;
			unequipFromAimWaterAnimatorState36454.iKOnFeet = false;
			unequipFromAimWaterAnimatorState36454.mirror = false;
			unequipFromAimWaterAnimatorState36454.mirrorParameterActive = false;
			unequipFromAimWaterAnimatorState36454.speed = 3f;
			unequipFromAimWaterAnimatorState36454.speedParameterActive = false;
			unequipFromAimWaterAnimatorState36454.writeDefaultValues = true;

			var equipFromAimWaterAnimatorState36456 = underwaterGunAnimatorStateMachine35852.AddState("Equip From Aim Water", new Vector3(264f, 60f, 0f));
			var equipFromAimWaterAnimatorState36456blendTreeBlendTree37306 = new BlendTree();
			AssetDatabase.AddObjectToAsset(equipFromAimWaterAnimatorState36456blendTreeBlendTree37306, animatorController);
			equipFromAimWaterAnimatorState36456blendTreeBlendTree37306.hideFlags = HideFlags.HideInHierarchy;
			equipFromAimWaterAnimatorState36456blendTreeBlendTree37306.blendParameter = "HorizontalMovement";
			equipFromAimWaterAnimatorState36456blendTreeBlendTree37306.blendParameterY = "ForwardMovement";
			equipFromAimWaterAnimatorState36456blendTreeBlendTree37306.blendType = BlendTreeType.FreeformCartesian2D;
			equipFromAimWaterAnimatorState36456blendTreeBlendTree37306.maxThreshold = 1f;
			equipFromAimWaterAnimatorState36456blendTreeBlendTree37306.minThreshold = 0f;
			equipFromAimWaterAnimatorState36456blendTreeBlendTree37306.name = "Blend Tree";
			equipFromAimWaterAnimatorState36456blendTreeBlendTree37306.useAutomaticThresholds = true;
			var equipFromAimWaterAnimatorState36456blendTreeBlendTree37306Child0 =  new ChildMotion();
			equipFromAimWaterAnimatorState36456blendTreeBlendTree37306Child0.motion = underwaterGunEquipFromAimLandAnimationClip16726;
			equipFromAimWaterAnimatorState36456blendTreeBlendTree37306Child0.cycleOffset = 0f;
			equipFromAimWaterAnimatorState36456blendTreeBlendTree37306Child0.directBlendParameter = "HorizontalMovement";
			equipFromAimWaterAnimatorState36456blendTreeBlendTree37306Child0.mirror = false;
			equipFromAimWaterAnimatorState36456blendTreeBlendTree37306Child0.position = new Vector2(0f, -1f);
			equipFromAimWaterAnimatorState36456blendTreeBlendTree37306Child0.threshold = 0f;
			equipFromAimWaterAnimatorState36456blendTreeBlendTree37306Child0.timeScale = 1f;
			var equipFromAimWaterAnimatorState36456blendTreeBlendTree37306Child1 =  new ChildMotion();
			equipFromAimWaterAnimatorState36456blendTreeBlendTree37306Child1.motion = underwaterGunEquipFromAimStrafeAnimationClip22506;
			equipFromAimWaterAnimatorState36456blendTreeBlendTree37306Child1.cycleOffset = 0f;
			equipFromAimWaterAnimatorState36456blendTreeBlendTree37306Child1.directBlendParameter = "HorizontalMovement";
			equipFromAimWaterAnimatorState36456blendTreeBlendTree37306Child1.mirror = false;
			equipFromAimWaterAnimatorState36456blendTreeBlendTree37306Child1.position = new Vector2(-1f, 0f);
			equipFromAimWaterAnimatorState36456blendTreeBlendTree37306Child1.threshold = 0.25f;
			equipFromAimWaterAnimatorState36456blendTreeBlendTree37306Child1.timeScale = 1f;
			var equipFromAimWaterAnimatorState36456blendTreeBlendTree37306Child2 =  new ChildMotion();
			equipFromAimWaterAnimatorState36456blendTreeBlendTree37306Child2.motion = underwaterGunEquipFromAimAnimationClip19138;
			equipFromAimWaterAnimatorState36456blendTreeBlendTree37306Child2.cycleOffset = 0f;
			equipFromAimWaterAnimatorState36456blendTreeBlendTree37306Child2.directBlendParameter = "HorizontalMovement";
			equipFromAimWaterAnimatorState36456blendTreeBlendTree37306Child2.mirror = false;
			equipFromAimWaterAnimatorState36456blendTreeBlendTree37306Child2.position = new Vector2(0f, 0f);
			equipFromAimWaterAnimatorState36456blendTreeBlendTree37306Child2.threshold = 0.5f;
			equipFromAimWaterAnimatorState36456blendTreeBlendTree37306Child2.timeScale = 1f;
			var equipFromAimWaterAnimatorState36456blendTreeBlendTree37306Child3 =  new ChildMotion();
			equipFromAimWaterAnimatorState36456blendTreeBlendTree37306Child3.motion = underwaterGunEquipFromAimStrafeAnimationClip22506;
			equipFromAimWaterAnimatorState36456blendTreeBlendTree37306Child3.cycleOffset = 0.5f;
			equipFromAimWaterAnimatorState36456blendTreeBlendTree37306Child3.directBlendParameter = "HorizontalMovement";
			equipFromAimWaterAnimatorState36456blendTreeBlendTree37306Child3.mirror = true;
			equipFromAimWaterAnimatorState36456blendTreeBlendTree37306Child3.position = new Vector2(1f, 0f);
			equipFromAimWaterAnimatorState36456blendTreeBlendTree37306Child3.threshold = 0.75f;
			equipFromAimWaterAnimatorState36456blendTreeBlendTree37306Child3.timeScale = 1f;
			var equipFromAimWaterAnimatorState36456blendTreeBlendTree37306Child4 =  new ChildMotion();
			equipFromAimWaterAnimatorState36456blendTreeBlendTree37306Child4.motion = underwaterGunEquipFromAimAnimationClip19138;
			equipFromAimWaterAnimatorState36456blendTreeBlendTree37306Child4.cycleOffset = 0f;
			equipFromAimWaterAnimatorState36456blendTreeBlendTree37306Child4.directBlendParameter = "HorizontalMovement";
			equipFromAimWaterAnimatorState36456blendTreeBlendTree37306Child4.mirror = false;
			equipFromAimWaterAnimatorState36456blendTreeBlendTree37306Child4.position = new Vector2(0f, 1f);
			equipFromAimWaterAnimatorState36456blendTreeBlendTree37306Child4.threshold = 1f;
			equipFromAimWaterAnimatorState36456blendTreeBlendTree37306Child4.timeScale = 1f;
			equipFromAimWaterAnimatorState36456blendTreeBlendTree37306.children = new ChildMotion[] {
				equipFromAimWaterAnimatorState36456blendTreeBlendTree37306Child0,
				equipFromAimWaterAnimatorState36456blendTreeBlendTree37306Child1,
				equipFromAimWaterAnimatorState36456blendTreeBlendTree37306Child2,
				equipFromAimWaterAnimatorState36456blendTreeBlendTree37306Child3,
				equipFromAimWaterAnimatorState36456blendTreeBlendTree37306Child4
			};
			equipFromAimWaterAnimatorState36456.motion = equipFromAimWaterAnimatorState36456blendTreeBlendTree37306;
			equipFromAimWaterAnimatorState36456.cycleOffset = 0f;
			equipFromAimWaterAnimatorState36456.cycleOffsetParameterActive = false;
			equipFromAimWaterAnimatorState36456.iKOnFeet = false;
			equipFromAimWaterAnimatorState36456.mirror = false;
			equipFromAimWaterAnimatorState36456.mirrorParameterActive = false;
			equipFromAimWaterAnimatorState36456.speed = 3f;
			equipFromAimWaterAnimatorState36456.speedParameterActive = false;
			equipFromAimWaterAnimatorState36456.writeDefaultValues = true;

			var equipFromIdleWaterAnimatorState36480 = underwaterGunAnimatorStateMachine35852.AddState("Equip From Idle Water", new Vector3(264f, 180f, 0f));
			var equipFromIdleWaterAnimatorState36480blendTreeBlendTree37310 = new BlendTree();
			AssetDatabase.AddObjectToAsset(equipFromIdleWaterAnimatorState36480blendTreeBlendTree37310, animatorController);
			equipFromIdleWaterAnimatorState36480blendTreeBlendTree37310.hideFlags = HideFlags.HideInHierarchy;
			equipFromIdleWaterAnimatorState36480blendTreeBlendTree37310.blendParameter = "HorizontalMovement";
			equipFromIdleWaterAnimatorState36480blendTreeBlendTree37310.blendParameterY = "ForwardMovement";
			equipFromIdleWaterAnimatorState36480blendTreeBlendTree37310.blendType = BlendTreeType.FreeformCartesian2D;
			equipFromIdleWaterAnimatorState36480blendTreeBlendTree37310.maxThreshold = 1f;
			equipFromIdleWaterAnimatorState36480blendTreeBlendTree37310.minThreshold = 0f;
			equipFromIdleWaterAnimatorState36480blendTreeBlendTree37310.name = "Blend Tree";
			equipFromIdleWaterAnimatorState36480blendTreeBlendTree37310.useAutomaticThresholds = true;
			var equipFromIdleWaterAnimatorState36480blendTreeBlendTree37310Child0 =  new ChildMotion();
			equipFromIdleWaterAnimatorState36480blendTreeBlendTree37310Child0.motion = underwaterGunEquipFromIdleLandAnimationClip21246;
			equipFromIdleWaterAnimatorState36480blendTreeBlendTree37310Child0.cycleOffset = 0f;
			equipFromIdleWaterAnimatorState36480blendTreeBlendTree37310Child0.directBlendParameter = "HorizontalMovement";
			equipFromIdleWaterAnimatorState36480blendTreeBlendTree37310Child0.mirror = false;
			equipFromIdleWaterAnimatorState36480blendTreeBlendTree37310Child0.position = new Vector2(0f, -1f);
			equipFromIdleWaterAnimatorState36480blendTreeBlendTree37310Child0.threshold = 0f;
			equipFromIdleWaterAnimatorState36480blendTreeBlendTree37310Child0.timeScale = 1f;
			var equipFromIdleWaterAnimatorState36480blendTreeBlendTree37310Child1 =  new ChildMotion();
			equipFromIdleWaterAnimatorState36480blendTreeBlendTree37310Child1.motion = underwaterGunEquipFromIdleStrafeAnimationClip29814;
			equipFromIdleWaterAnimatorState36480blendTreeBlendTree37310Child1.cycleOffset = 0f;
			equipFromIdleWaterAnimatorState36480blendTreeBlendTree37310Child1.directBlendParameter = "HorizontalMovement";
			equipFromIdleWaterAnimatorState36480blendTreeBlendTree37310Child1.mirror = false;
			equipFromIdleWaterAnimatorState36480blendTreeBlendTree37310Child1.position = new Vector2(-1f, 0f);
			equipFromIdleWaterAnimatorState36480blendTreeBlendTree37310Child1.threshold = 0.25f;
			equipFromIdleWaterAnimatorState36480blendTreeBlendTree37310Child1.timeScale = 1f;
			var equipFromIdleWaterAnimatorState36480blendTreeBlendTree37310Child2 =  new ChildMotion();
			equipFromIdleWaterAnimatorState36480blendTreeBlendTree37310Child2.motion = underwaterGunEquipFromIdleAnimationClip19166;
			equipFromIdleWaterAnimatorState36480blendTreeBlendTree37310Child2.cycleOffset = 0f;
			equipFromIdleWaterAnimatorState36480blendTreeBlendTree37310Child2.directBlendParameter = "HorizontalMovement";
			equipFromIdleWaterAnimatorState36480blendTreeBlendTree37310Child2.mirror = false;
			equipFromIdleWaterAnimatorState36480blendTreeBlendTree37310Child2.position = new Vector2(0f, 0f);
			equipFromIdleWaterAnimatorState36480blendTreeBlendTree37310Child2.threshold = 0.5f;
			equipFromIdleWaterAnimatorState36480blendTreeBlendTree37310Child2.timeScale = 1f;
			var equipFromIdleWaterAnimatorState36480blendTreeBlendTree37310Child3 =  new ChildMotion();
			equipFromIdleWaterAnimatorState36480blendTreeBlendTree37310Child3.motion = underwaterGunEquipFromIdleStrafeAnimationClip29814;
			equipFromIdleWaterAnimatorState36480blendTreeBlendTree37310Child3.cycleOffset = 0f;
			equipFromIdleWaterAnimatorState36480blendTreeBlendTree37310Child3.directBlendParameter = "HorizontalMovement";
			equipFromIdleWaterAnimatorState36480blendTreeBlendTree37310Child3.mirror = false;
			equipFromIdleWaterAnimatorState36480blendTreeBlendTree37310Child3.position = new Vector2(1f, 0f);
			equipFromIdleWaterAnimatorState36480blendTreeBlendTree37310Child3.threshold = 0.75f;
			equipFromIdleWaterAnimatorState36480blendTreeBlendTree37310Child3.timeScale = 1f;
			var equipFromIdleWaterAnimatorState36480blendTreeBlendTree37310Child4 =  new ChildMotion();
			equipFromIdleWaterAnimatorState36480blendTreeBlendTree37310Child4.motion = underwaterGunEquipFromIdleAnimationClip19166;
			equipFromIdleWaterAnimatorState36480blendTreeBlendTree37310Child4.cycleOffset = 0f;
			equipFromIdleWaterAnimatorState36480blendTreeBlendTree37310Child4.directBlendParameter = "HorizontalMovement";
			equipFromIdleWaterAnimatorState36480blendTreeBlendTree37310Child4.mirror = false;
			equipFromIdleWaterAnimatorState36480blendTreeBlendTree37310Child4.position = new Vector2(0f, 1f);
			equipFromIdleWaterAnimatorState36480blendTreeBlendTree37310Child4.threshold = 1f;
			equipFromIdleWaterAnimatorState36480blendTreeBlendTree37310Child4.timeScale = 1f;
			equipFromIdleWaterAnimatorState36480blendTreeBlendTree37310.children = new ChildMotion[] {
				equipFromIdleWaterAnimatorState36480blendTreeBlendTree37310Child0,
				equipFromIdleWaterAnimatorState36480blendTreeBlendTree37310Child1,
				equipFromIdleWaterAnimatorState36480blendTreeBlendTree37310Child2,
				equipFromIdleWaterAnimatorState36480blendTreeBlendTree37310Child3,
				equipFromIdleWaterAnimatorState36480blendTreeBlendTree37310Child4
			};
			equipFromIdleWaterAnimatorState36480.motion = equipFromIdleWaterAnimatorState36480blendTreeBlendTree37310;
			equipFromIdleWaterAnimatorState36480.cycleOffset = 0f;
			equipFromIdleWaterAnimatorState36480.cycleOffsetParameterActive = false;
			equipFromIdleWaterAnimatorState36480.iKOnFeet = false;
			equipFromIdleWaterAnimatorState36480.mirror = false;
			equipFromIdleWaterAnimatorState36480.mirrorParameterActive = false;
			equipFromIdleWaterAnimatorState36480.speed = 3f;
			equipFromIdleWaterAnimatorState36480.speedParameterActive = false;
			equipFromIdleWaterAnimatorState36480.writeDefaultValues = true;

			var dropWaterAnimatorState36458 = underwaterGunAnimatorStateMachine35852.AddState("Drop Water", new Vector3(264f, 300f, 0f));
			dropWaterAnimatorState36458.motion = underwaterGunDropAnimationClip13600;
			dropWaterAnimatorState36458.cycleOffset = 0f;
			dropWaterAnimatorState36458.cycleOffsetParameterActive = false;
			dropWaterAnimatorState36458.iKOnFeet = false;
			dropWaterAnimatorState36458.mirror = false;
			dropWaterAnimatorState36458.mirrorParameterActive = false;
			dropWaterAnimatorState36458.speed = 1f;
			dropWaterAnimatorState36458.speedParameterActive = false;
			dropWaterAnimatorState36458.writeDefaultValues = true;

			var dropLandAnimatorState36460 = underwaterGunAnimatorStateMachine35852.AddState("Drop Land", new Vector3(264f, 0f, 0f));
			dropLandAnimatorState36460.motion = underwaterGunDropLandAnimationClip22892;
			dropLandAnimatorState36460.cycleOffset = 0f;
			dropLandAnimatorState36460.cycleOffsetParameterActive = false;
			dropLandAnimatorState36460.iKOnFeet = false;
			dropLandAnimatorState36460.mirror = false;
			dropLandAnimatorState36460.mirrorParameterActive = false;
			dropLandAnimatorState36460.speed = 1f;
			dropLandAnimatorState36460.speedParameterActive = false;
			dropLandAnimatorState36460.writeDefaultValues = true;

			var equipFromIdleLandAnimatorState36462 = underwaterGunAnimatorStateMachine35852.AddState("Equip From Idle Land", new Vector3(264f, -120f, 0f));
			equipFromIdleLandAnimatorState36462.motion = underwaterGunEquipFromIdleLandAnimationClip21246;
			equipFromIdleLandAnimatorState36462.cycleOffset = 0f;
			equipFromIdleLandAnimatorState36462.cycleOffsetParameterActive = false;
			equipFromIdleLandAnimatorState36462.iKOnFeet = false;
			equipFromIdleLandAnimatorState36462.mirror = false;
			equipFromIdleLandAnimatorState36462.mirrorParameterActive = false;
			equipFromIdleLandAnimatorState36462.speed = 3f;
			equipFromIdleLandAnimatorState36462.speedParameterActive = false;
			equipFromIdleLandAnimatorState36462.writeDefaultValues = true;

			var equipFromAimLandAnimatorState36464 = underwaterGunAnimatorStateMachine35852.AddState("Equip From Aim Land", new Vector3(264f, -240f, 0f));
			equipFromAimLandAnimatorState36464.motion = underwaterGunEquipFromAimLandAnimationClip16726;
			equipFromAimLandAnimatorState36464.cycleOffset = 0f;
			equipFromAimLandAnimatorState36464.cycleOffsetParameterActive = false;
			equipFromAimLandAnimatorState36464.iKOnFeet = false;
			equipFromAimLandAnimatorState36464.mirror = false;
			equipFromAimLandAnimatorState36464.mirrorParameterActive = false;
			equipFromAimLandAnimatorState36464.speed = 3f;
			equipFromAimLandAnimatorState36464.speedParameterActive = false;
			equipFromAimLandAnimatorState36464.writeDefaultValues = true;

			var unequipFromAimLandAnimatorState36466 = underwaterGunAnimatorStateMachine35852.AddState("Unequip From Aim Land", new Vector3(264f, -180f, 0f));
			unequipFromAimLandAnimatorState36466.motion = underwaterGunUnequipFromAimLandAnimationClip25762;
			unequipFromAimLandAnimatorState36466.cycleOffset = 0f;
			unequipFromAimLandAnimatorState36466.cycleOffsetParameterActive = false;
			unequipFromAimLandAnimatorState36466.iKOnFeet = false;
			unequipFromAimLandAnimatorState36466.mirror = false;
			unequipFromAimLandAnimatorState36466.mirrorParameterActive = false;
			unequipFromAimLandAnimatorState36466.speed = 3f;
			unequipFromAimLandAnimatorState36466.speedParameterActive = false;
			unequipFromAimLandAnimatorState36466.writeDefaultValues = true;

			var unequipFromIdleLandAnimatorState36468 = underwaterGunAnimatorStateMachine35852.AddState("Unequip From Idle Land", new Vector3(264f, -60f, 0f));
			unequipFromIdleLandAnimatorState36468.motion = underwaterGunUnequipFromAimLandAnimationClip25762;
			unequipFromIdleLandAnimatorState36468.cycleOffset = 0f;
			unequipFromIdleLandAnimatorState36468.cycleOffsetParameterActive = false;
			unequipFromIdleLandAnimatorState36468.iKOnFeet = false;
			unequipFromIdleLandAnimatorState36468.mirror = false;
			unequipFromIdleLandAnimatorState36468.mirrorParameterActive = false;
			unequipFromIdleLandAnimatorState36468.speed = 3f;
			unequipFromIdleLandAnimatorState36468.speedParameterActive = false;
			unequipFromIdleLandAnimatorState36468.writeDefaultValues = true;

			// State Transitions.
			var animatorStateTransition37296 = unequipFromIdleWaterAnimatorState36452.AddExitTransition();
			animatorStateTransition37296.canTransitionToSelf = true;
			animatorStateTransition37296.duration = 0.2f;
			animatorStateTransition37296.exitTime = 0.75f;
			animatorStateTransition37296.hasExitTime = false;
			animatorStateTransition37296.hasFixedDuration = true;
			animatorStateTransition37296.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition37296.offset = 0f;
			animatorStateTransition37296.orderedInterruption = true;
			animatorStateTransition37296.isExit = true;
			animatorStateTransition37296.mute = false;
			animatorStateTransition37296.solo = false;
			animatorStateTransition37296.AddCondition(AnimatorConditionMode.NotEqual, 5f, "Slot0ItemStateIndex");

			var animatorStateTransition37300 = unequipFromAimWaterAnimatorState36454.AddExitTransition();
			animatorStateTransition37300.canTransitionToSelf = true;
			animatorStateTransition37300.duration = 0.2f;
			animatorStateTransition37300.exitTime = 0.8846154f;
			animatorStateTransition37300.hasExitTime = false;
			animatorStateTransition37300.hasFixedDuration = true;
			animatorStateTransition37300.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition37300.offset = 0f;
			animatorStateTransition37300.orderedInterruption = true;
			animatorStateTransition37300.isExit = true;
			animatorStateTransition37300.mute = false;
			animatorStateTransition37300.solo = false;
			animatorStateTransition37300.AddCondition(AnimatorConditionMode.NotEqual, 5f, "Slot0ItemStateIndex");

			var animatorStateTransition37304 = equipFromAimWaterAnimatorState36456.AddExitTransition();
			animatorStateTransition37304.canTransitionToSelf = true;
			animatorStateTransition37304.duration = 0.2f;
			animatorStateTransition37304.exitTime = 0.8846154f;
			animatorStateTransition37304.hasExitTime = false;
			animatorStateTransition37304.hasFixedDuration = true;
			animatorStateTransition37304.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition37304.offset = 0f;
			animatorStateTransition37304.orderedInterruption = true;
			animatorStateTransition37304.isExit = true;
			animatorStateTransition37304.mute = false;
			animatorStateTransition37304.solo = false;
			animatorStateTransition37304.AddCondition(AnimatorConditionMode.NotEqual, 4f, "Slot0ItemStateIndex");

			var animatorStateTransition37308 = equipFromIdleWaterAnimatorState36480.AddExitTransition();
			animatorStateTransition37308.canTransitionToSelf = true;
			animatorStateTransition37308.duration = 0.2f;
			animatorStateTransition37308.exitTime = 0.75f;
			animatorStateTransition37308.hasExitTime = false;
			animatorStateTransition37308.hasFixedDuration = true;
			animatorStateTransition37308.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition37308.offset = 0f;
			animatorStateTransition37308.orderedInterruption = true;
			animatorStateTransition37308.isExit = true;
			animatorStateTransition37308.mute = false;
			animatorStateTransition37308.solo = false;
			animatorStateTransition37308.AddCondition(AnimatorConditionMode.NotEqual, 4f, "Slot0ItemStateIndex");

			var animatorStateTransition37312 = dropWaterAnimatorState36458.AddExitTransition();
			animatorStateTransition37312.canTransitionToSelf = true;
			animatorStateTransition37312.duration = 0.1f;
			animatorStateTransition37312.exitTime = 0.9f;
			animatorStateTransition37312.hasExitTime = true;
			animatorStateTransition37312.hasFixedDuration = true;
			animatorStateTransition37312.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition37312.offset = 0f;
			animatorStateTransition37312.orderedInterruption = true;
			animatorStateTransition37312.isExit = true;
			animatorStateTransition37312.mute = false;
			animatorStateTransition37312.solo = false;

			var animatorStateTransition37314 = dropLandAnimatorState36460.AddExitTransition();
			animatorStateTransition37314.canTransitionToSelf = true;
			animatorStateTransition37314.duration = 0.1f;
			animatorStateTransition37314.exitTime = 0.9f;
			animatorStateTransition37314.hasExitTime = true;
			animatorStateTransition37314.hasFixedDuration = true;
			animatorStateTransition37314.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition37314.offset = 0f;
			animatorStateTransition37314.orderedInterruption = true;
			animatorStateTransition37314.isExit = true;
			animatorStateTransition37314.mute = false;
			animatorStateTransition37314.solo = false;

			var animatorStateTransition37316 = equipFromIdleLandAnimatorState36462.AddExitTransition();
			animatorStateTransition37316.canTransitionToSelf = true;
			animatorStateTransition37316.duration = 0.2f;
			animatorStateTransition37316.exitTime = 0.75f;
			animatorStateTransition37316.hasExitTime = false;
			animatorStateTransition37316.hasFixedDuration = true;
			animatorStateTransition37316.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition37316.offset = 0f;
			animatorStateTransition37316.orderedInterruption = true;
			animatorStateTransition37316.isExit = true;
			animatorStateTransition37316.mute = false;
			animatorStateTransition37316.solo = false;
			animatorStateTransition37316.AddCondition(AnimatorConditionMode.NotEqual, 4f, "Slot0ItemStateIndex");

			var animatorStateTransition37318 = equipFromAimLandAnimatorState36464.AddExitTransition();
			animatorStateTransition37318.canTransitionToSelf = true;
			animatorStateTransition37318.duration = 0.2f;
			animatorStateTransition37318.exitTime = 0.8846154f;
			animatorStateTransition37318.hasExitTime = false;
			animatorStateTransition37318.hasFixedDuration = true;
			animatorStateTransition37318.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition37318.offset = 0f;
			animatorStateTransition37318.orderedInterruption = true;
			animatorStateTransition37318.isExit = true;
			animatorStateTransition37318.mute = false;
			animatorStateTransition37318.solo = false;
			animatorStateTransition37318.AddCondition(AnimatorConditionMode.NotEqual, 4f, "Slot0ItemStateIndex");

			var animatorStateTransition37320 = unequipFromAimLandAnimatorState36466.AddExitTransition();
			animatorStateTransition37320.canTransitionToSelf = true;
			animatorStateTransition37320.duration = 0.2f;
			animatorStateTransition37320.exitTime = 0.8846154f;
			animatorStateTransition37320.hasExitTime = false;
			animatorStateTransition37320.hasFixedDuration = true;
			animatorStateTransition37320.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition37320.offset = 0f;
			animatorStateTransition37320.orderedInterruption = true;
			animatorStateTransition37320.isExit = true;
			animatorStateTransition37320.mute = false;
			animatorStateTransition37320.solo = false;
			animatorStateTransition37320.AddCondition(AnimatorConditionMode.NotEqual, 5f, "Slot0ItemStateIndex");

			var animatorStateTransition37322 = unequipFromIdleLandAnimatorState36468.AddExitTransition();
			animatorStateTransition37322.canTransitionToSelf = true;
			animatorStateTransition37322.duration = 0.2f;
			animatorStateTransition37322.exitTime = 0.75f;
			animatorStateTransition37322.hasExitTime = false;
			animatorStateTransition37322.hasFixedDuration = true;
			animatorStateTransition37322.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition37322.offset = 0f;
			animatorStateTransition37322.orderedInterruption = true;
			animatorStateTransition37322.isExit = true;
			animatorStateTransition37322.mute = false;
			animatorStateTransition37322.solo = false;
			animatorStateTransition37322.AddCondition(AnimatorConditionMode.NotEqual, 5f, "Slot0ItemStateIndex");

			// State Machine Defaults.
			underwaterGunAnimatorStateMachine35852.anyStatePosition = new Vector3(-84f, 36f, 0f);
			underwaterGunAnimatorStateMachine35852.defaultState = unequipFromIdleWaterAnimatorState36452;
			underwaterGunAnimatorStateMachine35852.entryPosition = new Vector3(-84f, -36f, 0f);
			underwaterGunAnimatorStateMachine35852.exitPosition = new Vector3(636f, 36f, 0f);
			underwaterGunAnimatorStateMachine35852.parentStateMachinePosition = new Vector3(624f, -48f, 0f);


			// State Machine Transitions.
			var animatorStateTransition36146 = baseStateMachine1240239114.AddAnyStateTransition(equipFromAimWaterAnimatorState36442);
			animatorStateTransition36146.canTransitionToSelf = false;
			animatorStateTransition36146.duration = 0.15f;
			animatorStateTransition36146.exitTime = 0.75f;
			animatorStateTransition36146.hasExitTime = false;
			animatorStateTransition36146.hasFixedDuration = true;
			animatorStateTransition36146.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition36146.offset = 0f;
			animatorStateTransition36146.orderedInterruption = true;
			animatorStateTransition36146.isExit = false;
			animatorStateTransition36146.mute = false;
			animatorStateTransition36146.solo = false;
			animatorStateTransition36146.AddCondition(AnimatorConditionMode.If, 0f, "Slot0ItemStateIndexChange");
			animatorStateTransition36146.AddCondition(AnimatorConditionMode.Equals, 26f, "Slot0ItemID");
			animatorStateTransition36146.AddCondition(AnimatorConditionMode.Equals, 4f, "Slot0ItemStateIndex");
			animatorStateTransition36146.AddCondition(AnimatorConditionMode.IfNot, 0f, "Moving");
			animatorStateTransition36146.AddCondition(AnimatorConditionMode.If, 0f, "Aiming");
			animatorStateTransition36146.AddCondition(AnimatorConditionMode.Equals, 301f, "AbilityIndex");
			animatorStateTransition36146.AddCondition(AnimatorConditionMode.NotEqual, 1f, "AbilityIntData");

			var animatorStateTransition36148 = baseStateMachine1240239114.AddAnyStateTransition(unequipFromAimWaterAnimatorState36444);
			animatorStateTransition36148.canTransitionToSelf = false;
			animatorStateTransition36148.duration = 0.15f;
			animatorStateTransition36148.exitTime = 0.75f;
			animatorStateTransition36148.hasExitTime = false;
			animatorStateTransition36148.hasFixedDuration = true;
			animatorStateTransition36148.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition36148.offset = 0f;
			animatorStateTransition36148.orderedInterruption = true;
			animatorStateTransition36148.isExit = false;
			animatorStateTransition36148.mute = false;
			animatorStateTransition36148.solo = false;
			animatorStateTransition36148.AddCondition(AnimatorConditionMode.If, 0f, "Slot0ItemStateIndexChange");
			animatorStateTransition36148.AddCondition(AnimatorConditionMode.Equals, 26f, "Slot0ItemID");
			animatorStateTransition36148.AddCondition(AnimatorConditionMode.Equals, 5f, "Slot0ItemStateIndex");
			animatorStateTransition36148.AddCondition(AnimatorConditionMode.IfNot, 0f, "Moving");
			animatorStateTransition36148.AddCondition(AnimatorConditionMode.If, 0f, "Aiming");
			animatorStateTransition36148.AddCondition(AnimatorConditionMode.Equals, 301f, "AbilityIndex");
			animatorStateTransition36148.AddCondition(AnimatorConditionMode.NotEqual, 1f, "AbilityIntData");

			var animatorStateTransition36150 = baseStateMachine1240239114.AddAnyStateTransition(equipFromIdleWaterAnimatorState36446);
			animatorStateTransition36150.canTransitionToSelf = false;
			animatorStateTransition36150.duration = 0.15f;
			animatorStateTransition36150.exitTime = 0.75f;
			animatorStateTransition36150.hasExitTime = false;
			animatorStateTransition36150.hasFixedDuration = true;
			animatorStateTransition36150.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition36150.offset = 0f;
			animatorStateTransition36150.orderedInterruption = true;
			animatorStateTransition36150.isExit = false;
			animatorStateTransition36150.mute = false;
			animatorStateTransition36150.solo = false;
			animatorStateTransition36150.AddCondition(AnimatorConditionMode.If, 0f, "Slot0ItemStateIndexChange");
			animatorStateTransition36150.AddCondition(AnimatorConditionMode.Equals, 26f, "Slot0ItemID");
			animatorStateTransition36150.AddCondition(AnimatorConditionMode.Equals, 4f, "Slot0ItemStateIndex");
			animatorStateTransition36150.AddCondition(AnimatorConditionMode.IfNot, 0f, "Moving");
			animatorStateTransition36150.AddCondition(AnimatorConditionMode.IfNot, 0f, "Aiming");
			animatorStateTransition36150.AddCondition(AnimatorConditionMode.Equals, 301f, "AbilityIndex");
			animatorStateTransition36150.AddCondition(AnimatorConditionMode.NotEqual, 1f, "AbilityIntData");

			var animatorStateTransition36152 = baseStateMachine1240239114.AddAnyStateTransition(unequipFromIdleWaterAnimatorState36448);
			animatorStateTransition36152.canTransitionToSelf = false;
			animatorStateTransition36152.duration = 0.15f;
			animatorStateTransition36152.exitTime = 0.75f;
			animatorStateTransition36152.hasExitTime = false;
			animatorStateTransition36152.hasFixedDuration = true;
			animatorStateTransition36152.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition36152.offset = 0f;
			animatorStateTransition36152.orderedInterruption = true;
			animatorStateTransition36152.isExit = false;
			animatorStateTransition36152.mute = false;
			animatorStateTransition36152.solo = false;
			animatorStateTransition36152.AddCondition(AnimatorConditionMode.If, 0f, "Slot0ItemStateIndexChange");
			animatorStateTransition36152.AddCondition(AnimatorConditionMode.Equals, 26f, "Slot0ItemID");
			animatorStateTransition36152.AddCondition(AnimatorConditionMode.Equals, 5f, "Slot0ItemStateIndex");
			animatorStateTransition36152.AddCondition(AnimatorConditionMode.IfNot, 0f, "Moving");
			animatorStateTransition36152.AddCondition(AnimatorConditionMode.IfNot, 0f, "Aiming");
			animatorStateTransition36152.AddCondition(AnimatorConditionMode.Equals, 301f, "AbilityIndex");
			animatorStateTransition36152.AddCondition(AnimatorConditionMode.NotEqual, 1f, "AbilityIntData");

			var animatorStateTransition36154 = baseStateMachine1240239114.AddAnyStateTransition(dropWaterAnimatorState36450);
			animatorStateTransition36154.canTransitionToSelf = false;
			animatorStateTransition36154.duration = 0.1f;
			animatorStateTransition36154.exitTime = 0.75f;
			animatorStateTransition36154.hasExitTime = false;
			animatorStateTransition36154.hasFixedDuration = true;
			animatorStateTransition36154.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition36154.offset = 0f;
			animatorStateTransition36154.orderedInterruption = true;
			animatorStateTransition36154.isExit = false;
			animatorStateTransition36154.mute = false;
			animatorStateTransition36154.solo = false;
			animatorStateTransition36154.AddCondition(AnimatorConditionMode.If, 0f, "Slot0ItemStateIndexChange");
			animatorStateTransition36154.AddCondition(AnimatorConditionMode.Equals, 26f, "Slot0ItemID");
			animatorStateTransition36154.AddCondition(AnimatorConditionMode.Equals, 6f, "Slot0ItemStateIndex");
			animatorStateTransition36154.AddCondition(AnimatorConditionMode.IfNot, 0f, "Moving");
			animatorStateTransition36154.AddCondition(AnimatorConditionMode.Equals, 301f, "AbilityIndex");
			animatorStateTransition36154.AddCondition(AnimatorConditionMode.NotEqual, 1f, "AbilityIntData");

			var animatorStateTransition36196 = baseStateMachine1240239114.AddAnyStateTransition(equipFromAimLandAnimatorState36470);
			animatorStateTransition36196.canTransitionToSelf = false;
			animatorStateTransition36196.duration = 0.15f;
			animatorStateTransition36196.exitTime = 0.75f;
			animatorStateTransition36196.hasExitTime = false;
			animatorStateTransition36196.hasFixedDuration = true;
			animatorStateTransition36196.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition36196.offset = 0f;
			animatorStateTransition36196.orderedInterruption = true;
			animatorStateTransition36196.isExit = false;
			animatorStateTransition36196.mute = false;
			animatorStateTransition36196.solo = false;
			animatorStateTransition36196.AddCondition(AnimatorConditionMode.If, 0f, "Slot0ItemStateIndexChange");
			animatorStateTransition36196.AddCondition(AnimatorConditionMode.Equals, 26f, "Slot0ItemID");
			animatorStateTransition36196.AddCondition(AnimatorConditionMode.Equals, 4f, "Slot0ItemStateIndex");
			animatorStateTransition36196.AddCondition(AnimatorConditionMode.IfNot, 0f, "Moving");
			animatorStateTransition36196.AddCondition(AnimatorConditionMode.If, 0f, "Aiming");
			animatorStateTransition36196.AddCondition(AnimatorConditionMode.Equals, 301f, "AbilityIndex");
			animatorStateTransition36196.AddCondition(AnimatorConditionMode.Equals, 1f, "AbilityIntData");

			var animatorStateTransition36198 = baseStateMachine1240239114.AddAnyStateTransition(unequipFromAimLandAnimatorState36472);
			animatorStateTransition36198.canTransitionToSelf = false;
			animatorStateTransition36198.duration = 0.15f;
			animatorStateTransition36198.exitTime = 0.75f;
			animatorStateTransition36198.hasExitTime = false;
			animatorStateTransition36198.hasFixedDuration = false;
			animatorStateTransition36198.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition36198.offset = 0f;
			animatorStateTransition36198.orderedInterruption = true;
			animatorStateTransition36198.isExit = false;
			animatorStateTransition36198.mute = false;
			animatorStateTransition36198.solo = false;
			animatorStateTransition36198.AddCondition(AnimatorConditionMode.If, 0f, "Slot0ItemStateIndexChange");
			animatorStateTransition36198.AddCondition(AnimatorConditionMode.Equals, 26f, "Slot0ItemID");
			animatorStateTransition36198.AddCondition(AnimatorConditionMode.Equals, 5f, "Slot0ItemStateIndex");
			animatorStateTransition36198.AddCondition(AnimatorConditionMode.IfNot, 0f, "Moving");
			animatorStateTransition36198.AddCondition(AnimatorConditionMode.If, 0f, "Aiming");
			animatorStateTransition36198.AddCondition(AnimatorConditionMode.Equals, 301f, "AbilityIndex");
			animatorStateTransition36198.AddCondition(AnimatorConditionMode.Equals, 1f, "AbilityIntData");

			var animatorStateTransition36200 = baseStateMachine1240239114.AddAnyStateTransition(equipFromIdleLandAnimatorState36474);
			animatorStateTransition36200.canTransitionToSelf = false;
			animatorStateTransition36200.duration = 0.15f;
			animatorStateTransition36200.exitTime = 0.75f;
			animatorStateTransition36200.hasExitTime = false;
			animatorStateTransition36200.hasFixedDuration = true;
			animatorStateTransition36200.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition36200.offset = 0f;
			animatorStateTransition36200.orderedInterruption = true;
			animatorStateTransition36200.isExit = false;
			animatorStateTransition36200.mute = false;
			animatorStateTransition36200.solo = false;
			animatorStateTransition36200.AddCondition(AnimatorConditionMode.If, 0f, "Slot0ItemStateIndexChange");
			animatorStateTransition36200.AddCondition(AnimatorConditionMode.Equals, 26f, "Slot0ItemID");
			animatorStateTransition36200.AddCondition(AnimatorConditionMode.Equals, 4f, "Slot0ItemStateIndex");
			animatorStateTransition36200.AddCondition(AnimatorConditionMode.IfNot, 0f, "Moving");
			animatorStateTransition36200.AddCondition(AnimatorConditionMode.IfNot, 0f, "Aiming");
			animatorStateTransition36200.AddCondition(AnimatorConditionMode.Equals, 301f, "AbilityIndex");
			animatorStateTransition36200.AddCondition(AnimatorConditionMode.Equals, 1f, "AbilityIntData");

			var animatorStateTransition36202 = baseStateMachine1240239114.AddAnyStateTransition(unequipFromIdleLandAnimatorState36476);
			animatorStateTransition36202.canTransitionToSelf = false;
			animatorStateTransition36202.duration = 0.15f;
			animatorStateTransition36202.exitTime = 0.75f;
			animatorStateTransition36202.hasExitTime = false;
			animatorStateTransition36202.hasFixedDuration = true;
			animatorStateTransition36202.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition36202.offset = 0f;
			animatorStateTransition36202.orderedInterruption = true;
			animatorStateTransition36202.isExit = false;
			animatorStateTransition36202.mute = false;
			animatorStateTransition36202.solo = false;
			animatorStateTransition36202.AddCondition(AnimatorConditionMode.If, 0f, "Slot0ItemStateIndexChange");
			animatorStateTransition36202.AddCondition(AnimatorConditionMode.Equals, 26f, "Slot0ItemID");
			animatorStateTransition36202.AddCondition(AnimatorConditionMode.Equals, 5f, "Slot0ItemStateIndex");
			animatorStateTransition36202.AddCondition(AnimatorConditionMode.IfNot, 0f, "Moving");
			animatorStateTransition36202.AddCondition(AnimatorConditionMode.IfNot, 0f, "Aiming");
			animatorStateTransition36202.AddCondition(AnimatorConditionMode.Equals, 301f, "AbilityIndex");
			animatorStateTransition36202.AddCondition(AnimatorConditionMode.Equals, 1f, "AbilityIntData");

			var animatorStateTransition36204 = baseStateMachine1240239114.AddAnyStateTransition(dropWaterLandAnimatorState36478);
			animatorStateTransition36204.canTransitionToSelf = false;
			animatorStateTransition36204.duration = 0.1f;
			animatorStateTransition36204.exitTime = 0.75f;
			animatorStateTransition36204.hasExitTime = false;
			animatorStateTransition36204.hasFixedDuration = true;
			animatorStateTransition36204.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition36204.offset = 0f;
			animatorStateTransition36204.orderedInterruption = true;
			animatorStateTransition36204.isExit = false;
			animatorStateTransition36204.mute = false;
			animatorStateTransition36204.solo = false;
			animatorStateTransition36204.AddCondition(AnimatorConditionMode.If, 0f, "Slot0ItemStateIndexChange");
			animatorStateTransition36204.AddCondition(AnimatorConditionMode.Equals, 26f, "Slot0ItemID");
			animatorStateTransition36204.AddCondition(AnimatorConditionMode.Equals, 6f, "Slot0ItemStateIndex");
			animatorStateTransition36204.AddCondition(AnimatorConditionMode.IfNot, 0f, "Moving");
			animatorStateTransition36204.AddCondition(AnimatorConditionMode.Equals, 301f, "AbilityIndex");
			animatorStateTransition36204.AddCondition(AnimatorConditionMode.Equals, 1f, "AbilityIntData");

			// State Machine Transitions.
			var animatorStateTransition36156 = baseStateMachine1289260044.AddAnyStateTransition(unequipFromIdleWaterAnimatorState36452);
			animatorStateTransition36156.canTransitionToSelf = false;
			animatorStateTransition36156.duration = 0.15f;
			animatorStateTransition36156.exitTime = 0.75f;
			animatorStateTransition36156.hasExitTime = false;
			animatorStateTransition36156.hasFixedDuration = true;
			animatorStateTransition36156.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition36156.offset = 0f;
			animatorStateTransition36156.orderedInterruption = true;
			animatorStateTransition36156.isExit = false;
			animatorStateTransition36156.mute = false;
			animatorStateTransition36156.solo = false;
			animatorStateTransition36156.AddCondition(AnimatorConditionMode.If, 0f, "Slot0ItemStateIndexChange");
			animatorStateTransition36156.AddCondition(AnimatorConditionMode.Equals, 7f, "Slot0ItemID");
			animatorStateTransition36156.AddCondition(AnimatorConditionMode.Equals, 5f, "Slot0ItemStateIndex");
			animatorStateTransition36156.AddCondition(AnimatorConditionMode.IfNot, 0f, "Aiming");
			animatorStateTransition36156.AddCondition(AnimatorConditionMode.IfNot, 0f, "Moving");
			animatorStateTransition36156.AddCondition(AnimatorConditionMode.Equals, 301f, "AbilityIndex");
			animatorStateTransition36156.AddCondition(AnimatorConditionMode.NotEqual, 1f, "AbilityIntData");

			var animatorStateTransition36158 = baseStateMachine1289260044.AddAnyStateTransition(unequipFromAimWaterAnimatorState36454);
			animatorStateTransition36158.canTransitionToSelf = false;
			animatorStateTransition36158.duration = 0.15f;
			animatorStateTransition36158.exitTime = 0.75f;
			animatorStateTransition36158.hasExitTime = false;
			animatorStateTransition36158.hasFixedDuration = true;
			animatorStateTransition36158.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition36158.offset = 0f;
			animatorStateTransition36158.orderedInterruption = true;
			animatorStateTransition36158.isExit = false;
			animatorStateTransition36158.mute = false;
			animatorStateTransition36158.solo = false;
			animatorStateTransition36158.AddCondition(AnimatorConditionMode.If, 0f, "Slot0ItemStateIndexChange");
			animatorStateTransition36158.AddCondition(AnimatorConditionMode.Equals, 7f, "Slot0ItemID");
			animatorStateTransition36158.AddCondition(AnimatorConditionMode.Equals, 5f, "Slot0ItemStateIndex");
			animatorStateTransition36158.AddCondition(AnimatorConditionMode.If, 0f, "Aiming");
			animatorStateTransition36158.AddCondition(AnimatorConditionMode.IfNot, 0f, "Moving");
			animatorStateTransition36158.AddCondition(AnimatorConditionMode.Equals, 301f, "AbilityIndex");
			animatorStateTransition36158.AddCondition(AnimatorConditionMode.NotEqual, 1f, "AbilityIntData");

			var animatorStateTransition36160 = baseStateMachine1289260044.AddAnyStateTransition(equipFromAimWaterAnimatorState36456);
			animatorStateTransition36160.canTransitionToSelf = false;
			animatorStateTransition36160.duration = 0.15f;
			animatorStateTransition36160.exitTime = 0.75f;
			animatorStateTransition36160.hasExitTime = false;
			animatorStateTransition36160.hasFixedDuration = true;
			animatorStateTransition36160.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition36160.offset = 0f;
			animatorStateTransition36160.orderedInterruption = true;
			animatorStateTransition36160.isExit = false;
			animatorStateTransition36160.mute = false;
			animatorStateTransition36160.solo = false;
			animatorStateTransition36160.AddCondition(AnimatorConditionMode.If, 0f, "Slot0ItemStateIndexChange");
			animatorStateTransition36160.AddCondition(AnimatorConditionMode.Equals, 7f, "Slot0ItemID");
			animatorStateTransition36160.AddCondition(AnimatorConditionMode.Equals, 4f, "Slot0ItemStateIndex");
			animatorStateTransition36160.AddCondition(AnimatorConditionMode.If, 0f, "Aiming");
			animatorStateTransition36160.AddCondition(AnimatorConditionMode.IfNot, 0f, "Moving");
			animatorStateTransition36160.AddCondition(AnimatorConditionMode.Equals, 301f, "AbilityIndex");
			animatorStateTransition36160.AddCondition(AnimatorConditionMode.NotEqual, 1f, "AbilityIntData");

			var animatorStateTransition36162 = baseStateMachine1289260044.AddAnyStateTransition(dropWaterAnimatorState36458);
			animatorStateTransition36162.canTransitionToSelf = false;
			animatorStateTransition36162.duration = 0.1f;
			animatorStateTransition36162.exitTime = 0.75f;
			animatorStateTransition36162.hasExitTime = false;
			animatorStateTransition36162.hasFixedDuration = true;
			animatorStateTransition36162.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition36162.offset = 0f;
			animatorStateTransition36162.orderedInterruption = true;
			animatorStateTransition36162.isExit = false;
			animatorStateTransition36162.mute = false;
			animatorStateTransition36162.solo = false;
			animatorStateTransition36162.AddCondition(AnimatorConditionMode.If, 0f, "Slot0ItemStateIndexChange");
			animatorStateTransition36162.AddCondition(AnimatorConditionMode.Equals, 7f, "Slot0ItemID");
			animatorStateTransition36162.AddCondition(AnimatorConditionMode.Equals, 6f, "Slot0ItemStateIndex");
			animatorStateTransition36162.AddCondition(AnimatorConditionMode.IfNot, 0f, "Moving");
			animatorStateTransition36162.AddCondition(AnimatorConditionMode.Equals, 301f, "AbilityIndex");
			animatorStateTransition36162.AddCondition(AnimatorConditionMode.NotEqual, 1f, "AbilityIntData");

			var animatorStateTransition36184 = baseStateMachine1289260044.AddAnyStateTransition(equipFromIdleWaterAnimatorState36480);
			animatorStateTransition36184.canTransitionToSelf = false;
			animatorStateTransition36184.duration = 0.15f;
			animatorStateTransition36184.exitTime = 0.75f;
			animatorStateTransition36184.hasExitTime = false;
			animatorStateTransition36184.hasFixedDuration = true;
			animatorStateTransition36184.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition36184.offset = 0f;
			animatorStateTransition36184.orderedInterruption = true;
			animatorStateTransition36184.isExit = false;
			animatorStateTransition36184.mute = false;
			animatorStateTransition36184.solo = false;
			animatorStateTransition36184.AddCondition(AnimatorConditionMode.If, 0f, "Slot0ItemStateIndexChange");
			animatorStateTransition36184.AddCondition(AnimatorConditionMode.Equals, 7f, "Slot0ItemID");
			animatorStateTransition36184.AddCondition(AnimatorConditionMode.Equals, 4f, "Slot0ItemStateIndex");
			animatorStateTransition36184.AddCondition(AnimatorConditionMode.IfNot, 0f, "Aiming");
			animatorStateTransition36184.AddCondition(AnimatorConditionMode.IfNot, 0f, "Moving");
			animatorStateTransition36184.AddCondition(AnimatorConditionMode.Equals, 301f, "AbilityIndex");
			animatorStateTransition36184.AddCondition(AnimatorConditionMode.NotEqual, 1f, "AbilityIntData");

			var animatorStateTransition36186 = baseStateMachine1289260044.AddAnyStateTransition(dropLandAnimatorState36460);
			animatorStateTransition36186.canTransitionToSelf = false;
			animatorStateTransition36186.duration = 0.1f;
			animatorStateTransition36186.exitTime = 0.75f;
			animatorStateTransition36186.hasExitTime = false;
			animatorStateTransition36186.hasFixedDuration = true;
			animatorStateTransition36186.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition36186.offset = 0f;
			animatorStateTransition36186.orderedInterruption = true;
			animatorStateTransition36186.isExit = false;
			animatorStateTransition36186.mute = false;
			animatorStateTransition36186.solo = false;
			animatorStateTransition36186.AddCondition(AnimatorConditionMode.If, 0f, "Slot0ItemStateIndexChange");
			animatorStateTransition36186.AddCondition(AnimatorConditionMode.Equals, 7f, "Slot0ItemID");
			animatorStateTransition36186.AddCondition(AnimatorConditionMode.Equals, 6f, "Slot0ItemStateIndex");
			animatorStateTransition36186.AddCondition(AnimatorConditionMode.IfNot, 0f, "Moving");
			animatorStateTransition36186.AddCondition(AnimatorConditionMode.Equals, 301f, "AbilityIndex");
			animatorStateTransition36186.AddCondition(AnimatorConditionMode.Equals, 1f, "AbilityIntData");

			var animatorStateTransition36188 = baseStateMachine1289260044.AddAnyStateTransition(unequipFromIdleLandAnimatorState36468);
			animatorStateTransition36188.canTransitionToSelf = false;
			animatorStateTransition36188.duration = 0.15f;
			animatorStateTransition36188.exitTime = 0.75f;
			animatorStateTransition36188.hasExitTime = false;
			animatorStateTransition36188.hasFixedDuration = true;
			animatorStateTransition36188.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition36188.offset = 0f;
			animatorStateTransition36188.orderedInterruption = true;
			animatorStateTransition36188.isExit = false;
			animatorStateTransition36188.mute = false;
			animatorStateTransition36188.solo = false;
			animatorStateTransition36188.AddCondition(AnimatorConditionMode.If, 0f, "Slot0ItemStateIndexChange");
			animatorStateTransition36188.AddCondition(AnimatorConditionMode.Equals, 7f, "Slot0ItemID");
			animatorStateTransition36188.AddCondition(AnimatorConditionMode.Equals, 5f, "Slot0ItemStateIndex");
			animatorStateTransition36188.AddCondition(AnimatorConditionMode.IfNot, 0f, "Moving");
			animatorStateTransition36188.AddCondition(AnimatorConditionMode.IfNot, 0f, "Aiming");
			animatorStateTransition36188.AddCondition(AnimatorConditionMode.Equals, 301f, "AbilityIndex");
			animatorStateTransition36188.AddCondition(AnimatorConditionMode.Equals, 1f, "AbilityIntData");

			var animatorStateTransition36190 = baseStateMachine1289260044.AddAnyStateTransition(equipFromIdleLandAnimatorState36462);
			animatorStateTransition36190.canTransitionToSelf = false;
			animatorStateTransition36190.duration = 0.15f;
			animatorStateTransition36190.exitTime = 0.75f;
			animatorStateTransition36190.hasExitTime = false;
			animatorStateTransition36190.hasFixedDuration = true;
			animatorStateTransition36190.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition36190.offset = 0f;
			animatorStateTransition36190.orderedInterruption = true;
			animatorStateTransition36190.isExit = false;
			animatorStateTransition36190.mute = false;
			animatorStateTransition36190.solo = false;
			animatorStateTransition36190.AddCondition(AnimatorConditionMode.If, 0f, "Slot0ItemStateIndexChange");
			animatorStateTransition36190.AddCondition(AnimatorConditionMode.Equals, 7f, "Slot0ItemID");
			animatorStateTransition36190.AddCondition(AnimatorConditionMode.Equals, 4f, "Slot0ItemStateIndex");
			animatorStateTransition36190.AddCondition(AnimatorConditionMode.IfNot, 0f, "Moving");
			animatorStateTransition36190.AddCondition(AnimatorConditionMode.IfNot, 0f, "Aiming");
			animatorStateTransition36190.AddCondition(AnimatorConditionMode.Equals, 301f, "AbilityIndex");
			animatorStateTransition36190.AddCondition(AnimatorConditionMode.Equals, 1f, "AbilityIntData");

			var animatorStateTransition36192 = baseStateMachine1289260044.AddAnyStateTransition(unequipFromAimLandAnimatorState36466);
			animatorStateTransition36192.canTransitionToSelf = false;
			animatorStateTransition36192.duration = 0.15f;
			animatorStateTransition36192.exitTime = 0.75f;
			animatorStateTransition36192.hasExitTime = false;
			animatorStateTransition36192.hasFixedDuration = true;
			animatorStateTransition36192.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition36192.offset = 0f;
			animatorStateTransition36192.orderedInterruption = true;
			animatorStateTransition36192.isExit = false;
			animatorStateTransition36192.mute = false;
			animatorStateTransition36192.solo = false;
			animatorStateTransition36192.AddCondition(AnimatorConditionMode.If, 0f, "Slot0ItemStateIndexChange");
			animatorStateTransition36192.AddCondition(AnimatorConditionMode.Equals, 7f, "Slot0ItemID");
			animatorStateTransition36192.AddCondition(AnimatorConditionMode.Equals, 5f, "Slot0ItemStateIndex");
			animatorStateTransition36192.AddCondition(AnimatorConditionMode.If, 0f, "Moving");
			animatorStateTransition36192.AddCondition(AnimatorConditionMode.IfNot, 0f, "Aiming");
			animatorStateTransition36192.AddCondition(AnimatorConditionMode.Equals, 301f, "AbilityIndex");
			animatorStateTransition36192.AddCondition(AnimatorConditionMode.Equals, 1f, "AbilityIntData");

			var animatorStateTransition36194 = baseStateMachine1289260044.AddAnyStateTransition(equipFromAimLandAnimatorState36464);
			animatorStateTransition36194.canTransitionToSelf = false;
			animatorStateTransition36194.duration = 0.15f;
			animatorStateTransition36194.exitTime = 0.75f;
			animatorStateTransition36194.hasExitTime = false;
			animatorStateTransition36194.hasFixedDuration = true;
			animatorStateTransition36194.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition36194.offset = 0f;
			animatorStateTransition36194.orderedInterruption = true;
			animatorStateTransition36194.isExit = false;
			animatorStateTransition36194.mute = false;
			animatorStateTransition36194.solo = false;
			animatorStateTransition36194.AddCondition(AnimatorConditionMode.If, 0f, "Slot0ItemStateIndexChange");
			animatorStateTransition36194.AddCondition(AnimatorConditionMode.Equals, 7f, "Slot0ItemID");
			animatorStateTransition36194.AddCondition(AnimatorConditionMode.Equals, 4f, "Slot0ItemStateIndex");
			animatorStateTransition36194.AddCondition(AnimatorConditionMode.If, 0f, "Moving");
			animatorStateTransition36194.AddCondition(AnimatorConditionMode.IfNot, 0f, "Aiming");
			animatorStateTransition36194.AddCondition(AnimatorConditionMode.Equals, 301f, "AbilityIndex");
			animatorStateTransition36194.AddCondition(AnimatorConditionMode.Equals, 1f, "AbilityIntData");


			var baseStateMachine1333564080 = animatorController.layers[6].stateMachine;

			// The state machine should start fresh.
			for (int i = 0; i < animatorController.layers.Length; ++i) {
				for (int j = 0; j < baseStateMachine1333564080.stateMachines.Length; ++j) {
					if (baseStateMachine1333564080.stateMachines[j].stateMachine.name == "Trident") {
						baseStateMachine1333564080.RemoveStateMachine(baseStateMachine1333564080.stateMachines[j].stateMachine);
						break;
					}
				}
			}

			// AnimationClip references.
			var tridentIdleLandAnimationClip17184Path = AssetDatabase.GUIDToAssetPath("664f5614e71a779429822b87be463208"); 
			var tridentIdleLandAnimationClip17184 = AnimatorBuilder.GetAnimationClip(tridentIdleLandAnimationClip17184Path, "TridentIdleLand");
			var tridentIdleStrafeAnimationClip19932Path = AssetDatabase.GUIDToAssetPath("96ff63c6525571940b7406e08ecdd02b"); 
			var tridentIdleStrafeAnimationClip19932 = AnimatorBuilder.GetAnimationClip(tridentIdleStrafeAnimationClip19932Path, "TridentIdleStrafe");
			var tridentIdleAnimationClip19442Path = AssetDatabase.GUIDToAssetPath("2351243658e3dc34898ce26659e281f4"); 
			var tridentIdleAnimationClip19442 = AnimatorBuilder.GetAnimationClip(tridentIdleAnimationClip19442Path, "TridentIdle");

			// State Machine.
			var tridentAnimatorStateMachine37552 = baseStateMachine1333564080.AddStateMachine("Trident", new Vector3(624f, 108f, 0f));

			// States.
			var dropWaterAnimatorState37696 = tridentAnimatorStateMachine37552.AddState("Drop Water", new Vector3(384f, 348f, 0f));
			var dropWaterAnimatorState37696blendTreeBlendTree37848 = new BlendTree();
			AssetDatabase.AddObjectToAsset(dropWaterAnimatorState37696blendTreeBlendTree37848, animatorController);
			dropWaterAnimatorState37696blendTreeBlendTree37848.hideFlags = HideFlags.HideInHierarchy;
			dropWaterAnimatorState37696blendTreeBlendTree37848.blendParameter = "HorizontalMovement";
			dropWaterAnimatorState37696blendTreeBlendTree37848.blendParameterY = "ForwardMovement";
			dropWaterAnimatorState37696blendTreeBlendTree37848.blendType = BlendTreeType.FreeformCartesian2D;
			dropWaterAnimatorState37696blendTreeBlendTree37848.maxThreshold = 1f;
			dropWaterAnimatorState37696blendTreeBlendTree37848.minThreshold = 0f;
			dropWaterAnimatorState37696blendTreeBlendTree37848.name = "Blend Tree";
			dropWaterAnimatorState37696blendTreeBlendTree37848.useAutomaticThresholds = true;
			var dropWaterAnimatorState37696blendTreeBlendTree37848Child0 =  new ChildMotion();
			dropWaterAnimatorState37696blendTreeBlendTree37848Child0.motion = tridentDropLandAnimationClip26280;
			dropWaterAnimatorState37696blendTreeBlendTree37848Child0.cycleOffset = 0f;
			dropWaterAnimatorState37696blendTreeBlendTree37848Child0.directBlendParameter = "HorizontalMovement";
			dropWaterAnimatorState37696blendTreeBlendTree37848Child0.mirror = false;
			dropWaterAnimatorState37696blendTreeBlendTree37848Child0.position = new Vector2(0f, -1f);
			dropWaterAnimatorState37696blendTreeBlendTree37848Child0.threshold = 0f;
			dropWaterAnimatorState37696blendTreeBlendTree37848Child0.timeScale = 1f;
			var dropWaterAnimatorState37696blendTreeBlendTree37848Child1 =  new ChildMotion();
			dropWaterAnimatorState37696blendTreeBlendTree37848Child1.motion = tridentDropStrafeAnimationClip27058;
			dropWaterAnimatorState37696blendTreeBlendTree37848Child1.cycleOffset = 0f;
			dropWaterAnimatorState37696blendTreeBlendTree37848Child1.directBlendParameter = "HorizontalMovement";
			dropWaterAnimatorState37696blendTreeBlendTree37848Child1.mirror = false;
			dropWaterAnimatorState37696blendTreeBlendTree37848Child1.position = new Vector2(-1f, 0f);
			dropWaterAnimatorState37696blendTreeBlendTree37848Child1.threshold = 0.25f;
			dropWaterAnimatorState37696blendTreeBlendTree37848Child1.timeScale = 1f;
			var dropWaterAnimatorState37696blendTreeBlendTree37848Child2 =  new ChildMotion();
			dropWaterAnimatorState37696blendTreeBlendTree37848Child2.motion = tridentDropAnimationClip26782;
			dropWaterAnimatorState37696blendTreeBlendTree37848Child2.cycleOffset = 0f;
			dropWaterAnimatorState37696blendTreeBlendTree37848Child2.directBlendParameter = "HorizontalMovement";
			dropWaterAnimatorState37696blendTreeBlendTree37848Child2.mirror = false;
			dropWaterAnimatorState37696blendTreeBlendTree37848Child2.position = new Vector2(0f, 0f);
			dropWaterAnimatorState37696blendTreeBlendTree37848Child2.threshold = 0.5f;
			dropWaterAnimatorState37696blendTreeBlendTree37848Child2.timeScale = 1f;
			var dropWaterAnimatorState37696blendTreeBlendTree37848Child3 =  new ChildMotion();
			dropWaterAnimatorState37696blendTreeBlendTree37848Child3.motion = tridentDropStrafeAnimationClip27058;
			dropWaterAnimatorState37696blendTreeBlendTree37848Child3.cycleOffset = 0f;
			dropWaterAnimatorState37696blendTreeBlendTree37848Child3.directBlendParameter = "HorizontalMovement";
			dropWaterAnimatorState37696blendTreeBlendTree37848Child3.mirror = false;
			dropWaterAnimatorState37696blendTreeBlendTree37848Child3.position = new Vector2(1f, 0f);
			dropWaterAnimatorState37696blendTreeBlendTree37848Child3.threshold = 0.75f;
			dropWaterAnimatorState37696blendTreeBlendTree37848Child3.timeScale = 1f;
			var dropWaterAnimatorState37696blendTreeBlendTree37848Child4 =  new ChildMotion();
			dropWaterAnimatorState37696blendTreeBlendTree37848Child4.motion = tridentDropAnimationClip26782;
			dropWaterAnimatorState37696blendTreeBlendTree37848Child4.cycleOffset = 0f;
			dropWaterAnimatorState37696blendTreeBlendTree37848Child4.directBlendParameter = "HorizontalMovement";
			dropWaterAnimatorState37696blendTreeBlendTree37848Child4.mirror = false;
			dropWaterAnimatorState37696blendTreeBlendTree37848Child4.position = new Vector2(0f, 1f);
			dropWaterAnimatorState37696blendTreeBlendTree37848Child4.threshold = 1f;
			dropWaterAnimatorState37696blendTreeBlendTree37848Child4.timeScale = 1f;
			dropWaterAnimatorState37696blendTreeBlendTree37848.children = new ChildMotion[] {
				dropWaterAnimatorState37696blendTreeBlendTree37848Child0,
				dropWaterAnimatorState37696blendTreeBlendTree37848Child1,
				dropWaterAnimatorState37696blendTreeBlendTree37848Child2,
				dropWaterAnimatorState37696blendTreeBlendTree37848Child3,
				dropWaterAnimatorState37696blendTreeBlendTree37848Child4
			};
			dropWaterAnimatorState37696.motion = dropWaterAnimatorState37696blendTreeBlendTree37848;
			dropWaterAnimatorState37696.cycleOffset = 0f;
			dropWaterAnimatorState37696.cycleOffsetParameterActive = false;
			dropWaterAnimatorState37696.iKOnFeet = false;
			dropWaterAnimatorState37696.mirror = false;
			dropWaterAnimatorState37696.mirrorParameterActive = false;
			dropWaterAnimatorState37696.speed = 1f;
			dropWaterAnimatorState37696.speedParameterActive = false;
			dropWaterAnimatorState37696.writeDefaultValues = true;

			var equipFromAimWaterAnimatorState37704 = tridentAnimatorStateMachine37552.AddState("Equip From Aim Water", new Vector3(384f, 108f, 0f));
			var equipFromAimWaterAnimatorState37704blendTreeBlendTree37852 = new BlendTree();
			AssetDatabase.AddObjectToAsset(equipFromAimWaterAnimatorState37704blendTreeBlendTree37852, animatorController);
			equipFromAimWaterAnimatorState37704blendTreeBlendTree37852.hideFlags = HideFlags.HideInHierarchy;
			equipFromAimWaterAnimatorState37704blendTreeBlendTree37852.blendParameter = "HorizontalMovement";
			equipFromAimWaterAnimatorState37704blendTreeBlendTree37852.blendParameterY = "ForwardMovement";
			equipFromAimWaterAnimatorState37704blendTreeBlendTree37852.blendType = BlendTreeType.FreeformCartesian2D;
			equipFromAimWaterAnimatorState37704blendTreeBlendTree37852.maxThreshold = 1.333333f;
			equipFromAimWaterAnimatorState37704blendTreeBlendTree37852.minThreshold = 0f;
			equipFromAimWaterAnimatorState37704blendTreeBlendTree37852.name = "Blend Tree";
			equipFromAimWaterAnimatorState37704blendTreeBlendTree37852.useAutomaticThresholds = false;
			var equipFromAimWaterAnimatorState37704blendTreeBlendTree37852Child0 =  new ChildMotion();
			equipFromAimWaterAnimatorState37704blendTreeBlendTree37852Child0.motion = tridentEquipFromAimLandAnimationClip26258;
			equipFromAimWaterAnimatorState37704blendTreeBlendTree37852Child0.cycleOffset = 0f;
			equipFromAimWaterAnimatorState37704blendTreeBlendTree37852Child0.directBlendParameter = "HorizontalMovement";
			equipFromAimWaterAnimatorState37704blendTreeBlendTree37852Child0.mirror = false;
			equipFromAimWaterAnimatorState37704blendTreeBlendTree37852Child0.position = new Vector2(0f, -1f);
			equipFromAimWaterAnimatorState37704blendTreeBlendTree37852Child0.threshold = 0f;
			equipFromAimWaterAnimatorState37704blendTreeBlendTree37852Child0.timeScale = 1f;
			var equipFromAimWaterAnimatorState37704blendTreeBlendTree37852Child1 =  new ChildMotion();
			equipFromAimWaterAnimatorState37704blendTreeBlendTree37852Child1.motion = tridentEquipFromAimStrafeAnimationClip25286;
			equipFromAimWaterAnimatorState37704blendTreeBlendTree37852Child1.cycleOffset = 0f;
			equipFromAimWaterAnimatorState37704blendTreeBlendTree37852Child1.directBlendParameter = "HorizontalMovement";
			equipFromAimWaterAnimatorState37704blendTreeBlendTree37852Child1.mirror = false;
			equipFromAimWaterAnimatorState37704blendTreeBlendTree37852Child1.position = new Vector2(-1f, 0f);
			equipFromAimWaterAnimatorState37704blendTreeBlendTree37852Child1.threshold = 0.3333333f;
			equipFromAimWaterAnimatorState37704blendTreeBlendTree37852Child1.timeScale = 1f;
			var equipFromAimWaterAnimatorState37704blendTreeBlendTree37852Child2 =  new ChildMotion();
			equipFromAimWaterAnimatorState37704blendTreeBlendTree37852Child2.motion = tridentEquipFromAimAnimationClip23118;
			equipFromAimWaterAnimatorState37704blendTreeBlendTree37852Child2.cycleOffset = 0f;
			equipFromAimWaterAnimatorState37704blendTreeBlendTree37852Child2.directBlendParameter = "HorizontalMovement";
			equipFromAimWaterAnimatorState37704blendTreeBlendTree37852Child2.mirror = false;
			equipFromAimWaterAnimatorState37704blendTreeBlendTree37852Child2.position = new Vector2(0f, 0f);
			equipFromAimWaterAnimatorState37704blendTreeBlendTree37852Child2.threshold = 0.6666667f;
			equipFromAimWaterAnimatorState37704blendTreeBlendTree37852Child2.timeScale = 1f;
			var equipFromAimWaterAnimatorState37704blendTreeBlendTree37852Child3 =  new ChildMotion();
			equipFromAimWaterAnimatorState37704blendTreeBlendTree37852Child3.motion = tridentEquipFromAimStrafeAnimationClip25286;
			equipFromAimWaterAnimatorState37704blendTreeBlendTree37852Child3.cycleOffset = 0f;
			equipFromAimWaterAnimatorState37704blendTreeBlendTree37852Child3.directBlendParameter = "HorizontalMovement";
			equipFromAimWaterAnimatorState37704blendTreeBlendTree37852Child3.mirror = false;
			equipFromAimWaterAnimatorState37704blendTreeBlendTree37852Child3.position = new Vector2(1f, 0f);
			equipFromAimWaterAnimatorState37704blendTreeBlendTree37852Child3.threshold = 1f;
			equipFromAimWaterAnimatorState37704blendTreeBlendTree37852Child3.timeScale = 1f;
			var equipFromAimWaterAnimatorState37704blendTreeBlendTree37852Child4 =  new ChildMotion();
			equipFromAimWaterAnimatorState37704blendTreeBlendTree37852Child4.motion = tridentEquipFromAimAnimationClip23118;
			equipFromAimWaterAnimatorState37704blendTreeBlendTree37852Child4.cycleOffset = 0f;
			equipFromAimWaterAnimatorState37704blendTreeBlendTree37852Child4.directBlendParameter = "HorizontalMovement";
			equipFromAimWaterAnimatorState37704blendTreeBlendTree37852Child4.mirror = false;
			equipFromAimWaterAnimatorState37704blendTreeBlendTree37852Child4.position = new Vector2(0f, 1f);
			equipFromAimWaterAnimatorState37704blendTreeBlendTree37852Child4.threshold = 1.333333f;
			equipFromAimWaterAnimatorState37704blendTreeBlendTree37852Child4.timeScale = 1f;
			equipFromAimWaterAnimatorState37704blendTreeBlendTree37852.children = new ChildMotion[] {
				equipFromAimWaterAnimatorState37704blendTreeBlendTree37852Child0,
				equipFromAimWaterAnimatorState37704blendTreeBlendTree37852Child1,
				equipFromAimWaterAnimatorState37704blendTreeBlendTree37852Child2,
				equipFromAimWaterAnimatorState37704blendTreeBlendTree37852Child3,
				equipFromAimWaterAnimatorState37704blendTreeBlendTree37852Child4
			};
			equipFromAimWaterAnimatorState37704.motion = equipFromAimWaterAnimatorState37704blendTreeBlendTree37852;
			equipFromAimWaterAnimatorState37704.cycleOffset = 0f;
			equipFromAimWaterAnimatorState37704.cycleOffsetParameterActive = false;
			equipFromAimWaterAnimatorState37704.iKOnFeet = false;
			equipFromAimWaterAnimatorState37704.mirror = false;
			equipFromAimWaterAnimatorState37704.mirrorParameterActive = false;
			equipFromAimWaterAnimatorState37704.speed = 2.75f;
			equipFromAimWaterAnimatorState37704.speedParameterActive = false;
			equipFromAimWaterAnimatorState37704.writeDefaultValues = true;

			var equipFromIdleWaterAnimatorState37700 = tridentAnimatorStateMachine37552.AddState("Equip From Idle Water", new Vector3(384f, 228f, 0f));
			var equipFromIdleWaterAnimatorState37700blendTreeBlendTree37856 = new BlendTree();
			AssetDatabase.AddObjectToAsset(equipFromIdleWaterAnimatorState37700blendTreeBlendTree37856, animatorController);
			equipFromIdleWaterAnimatorState37700blendTreeBlendTree37856.hideFlags = HideFlags.HideInHierarchy;
			equipFromIdleWaterAnimatorState37700blendTreeBlendTree37856.blendParameter = "HorizontalMovement";
			equipFromIdleWaterAnimatorState37700blendTreeBlendTree37856.blendParameterY = "ForwardMovement";
			equipFromIdleWaterAnimatorState37700blendTreeBlendTree37856.blendType = BlendTreeType.FreeformCartesian2D;
			equipFromIdleWaterAnimatorState37700blendTreeBlendTree37856.maxThreshold = 1f;
			equipFromIdleWaterAnimatorState37700blendTreeBlendTree37856.minThreshold = 0f;
			equipFromIdleWaterAnimatorState37700blendTreeBlendTree37856.name = "Blend Tree";
			equipFromIdleWaterAnimatorState37700blendTreeBlendTree37856.useAutomaticThresholds = true;
			var equipFromIdleWaterAnimatorState37700blendTreeBlendTree37856Child0 =  new ChildMotion();
			equipFromIdleWaterAnimatorState37700blendTreeBlendTree37856Child0.motion = tridentEquipFromIdleLandAnimationClip24446;
			equipFromIdleWaterAnimatorState37700blendTreeBlendTree37856Child0.cycleOffset = 0f;
			equipFromIdleWaterAnimatorState37700blendTreeBlendTree37856Child0.directBlendParameter = "HorizontalMovement";
			equipFromIdleWaterAnimatorState37700blendTreeBlendTree37856Child0.mirror = false;
			equipFromIdleWaterAnimatorState37700blendTreeBlendTree37856Child0.position = new Vector2(0f, -1f);
			equipFromIdleWaterAnimatorState37700blendTreeBlendTree37856Child0.threshold = 0f;
			equipFromIdleWaterAnimatorState37700blendTreeBlendTree37856Child0.timeScale = 1f;
			var equipFromIdleWaterAnimatorState37700blendTreeBlendTree37856Child1 =  new ChildMotion();
			equipFromIdleWaterAnimatorState37700blendTreeBlendTree37856Child1.motion = tridentEquipFromIdleStrafeAnimationClip25624;
			equipFromIdleWaterAnimatorState37700blendTreeBlendTree37856Child1.cycleOffset = 0f;
			equipFromIdleWaterAnimatorState37700blendTreeBlendTree37856Child1.directBlendParameter = "HorizontalMovement";
			equipFromIdleWaterAnimatorState37700blendTreeBlendTree37856Child1.mirror = false;
			equipFromIdleWaterAnimatorState37700blendTreeBlendTree37856Child1.position = new Vector2(-1f, 0f);
			equipFromIdleWaterAnimatorState37700blendTreeBlendTree37856Child1.threshold = 0.25f;
			equipFromIdleWaterAnimatorState37700blendTreeBlendTree37856Child1.timeScale = 1f;
			var equipFromIdleWaterAnimatorState37700blendTreeBlendTree37856Child2 =  new ChildMotion();
			equipFromIdleWaterAnimatorState37700blendTreeBlendTree37856Child2.motion = tridentEquipFromIdleAnimationClip13516;
			equipFromIdleWaterAnimatorState37700blendTreeBlendTree37856Child2.cycleOffset = 0f;
			equipFromIdleWaterAnimatorState37700blendTreeBlendTree37856Child2.directBlendParameter = "HorizontalMovement";
			equipFromIdleWaterAnimatorState37700blendTreeBlendTree37856Child2.mirror = false;
			equipFromIdleWaterAnimatorState37700blendTreeBlendTree37856Child2.position = new Vector2(0f, 0f);
			equipFromIdleWaterAnimatorState37700blendTreeBlendTree37856Child2.threshold = 0.5f;
			equipFromIdleWaterAnimatorState37700blendTreeBlendTree37856Child2.timeScale = 1f;
			var equipFromIdleWaterAnimatorState37700blendTreeBlendTree37856Child3 =  new ChildMotion();
			equipFromIdleWaterAnimatorState37700blendTreeBlendTree37856Child3.motion = tridentEquipFromIdleStrafeAnimationClip25624;
			equipFromIdleWaterAnimatorState37700blendTreeBlendTree37856Child3.cycleOffset = 0f;
			equipFromIdleWaterAnimatorState37700blendTreeBlendTree37856Child3.directBlendParameter = "HorizontalMovement";
			equipFromIdleWaterAnimatorState37700blendTreeBlendTree37856Child3.mirror = false;
			equipFromIdleWaterAnimatorState37700blendTreeBlendTree37856Child3.position = new Vector2(1f, 0f);
			equipFromIdleWaterAnimatorState37700blendTreeBlendTree37856Child3.threshold = 0.75f;
			equipFromIdleWaterAnimatorState37700blendTreeBlendTree37856Child3.timeScale = 1f;
			var equipFromIdleWaterAnimatorState37700blendTreeBlendTree37856Child4 =  new ChildMotion();
			equipFromIdleWaterAnimatorState37700blendTreeBlendTree37856Child4.motion = tridentEquipFromIdleAnimationClip13516;
			equipFromIdleWaterAnimatorState37700blendTreeBlendTree37856Child4.cycleOffset = 0f;
			equipFromIdleWaterAnimatorState37700blendTreeBlendTree37856Child4.directBlendParameter = "HorizontalMovement";
			equipFromIdleWaterAnimatorState37700blendTreeBlendTree37856Child4.mirror = false;
			equipFromIdleWaterAnimatorState37700blendTreeBlendTree37856Child4.position = new Vector2(0f, 1f);
			equipFromIdleWaterAnimatorState37700blendTreeBlendTree37856Child4.threshold = 1f;
			equipFromIdleWaterAnimatorState37700blendTreeBlendTree37856Child4.timeScale = 1f;
			equipFromIdleWaterAnimatorState37700blendTreeBlendTree37856.children = new ChildMotion[] {
				equipFromIdleWaterAnimatorState37700blendTreeBlendTree37856Child0,
				equipFromIdleWaterAnimatorState37700blendTreeBlendTree37856Child1,
				equipFromIdleWaterAnimatorState37700blendTreeBlendTree37856Child2,
				equipFromIdleWaterAnimatorState37700blendTreeBlendTree37856Child3,
				equipFromIdleWaterAnimatorState37700blendTreeBlendTree37856Child4
			};
			equipFromIdleWaterAnimatorState37700.motion = equipFromIdleWaterAnimatorState37700blendTreeBlendTree37856;
			equipFromIdleWaterAnimatorState37700.cycleOffset = 0f;
			equipFromIdleWaterAnimatorState37700.cycleOffsetParameterActive = false;
			equipFromIdleWaterAnimatorState37700.iKOnFeet = false;
			equipFromIdleWaterAnimatorState37700.mirror = false;
			equipFromIdleWaterAnimatorState37700.mirrorParameterActive = false;
			equipFromIdleWaterAnimatorState37700.speed = 2.75f;
			equipFromIdleWaterAnimatorState37700.speedParameterActive = false;
			equipFromIdleWaterAnimatorState37700.writeDefaultValues = true;

			var unequipFromAimWaterAnimatorState37702 = tridentAnimatorStateMachine37552.AddState("Unequip From Aim Water", new Vector3(384f, 168f, 0f));
			var unequipFromAimWaterAnimatorState37702blendTreeBlendTree37860 = new BlendTree();
			AssetDatabase.AddObjectToAsset(unequipFromAimWaterAnimatorState37702blendTreeBlendTree37860, animatorController);
			unequipFromAimWaterAnimatorState37702blendTreeBlendTree37860.hideFlags = HideFlags.HideInHierarchy;
			unequipFromAimWaterAnimatorState37702blendTreeBlendTree37860.blendParameter = "HorizontalMovement";
			unequipFromAimWaterAnimatorState37702blendTreeBlendTree37860.blendParameterY = "ForwardMovement";
			unequipFromAimWaterAnimatorState37702blendTreeBlendTree37860.blendType = BlendTreeType.FreeformCartesian2D;
			unequipFromAimWaterAnimatorState37702blendTreeBlendTree37860.maxThreshold = 1f;
			unequipFromAimWaterAnimatorState37702blendTreeBlendTree37860.minThreshold = 0f;
			unequipFromAimWaterAnimatorState37702blendTreeBlendTree37860.name = "Blend Tree";
			unequipFromAimWaterAnimatorState37702blendTreeBlendTree37860.useAutomaticThresholds = true;
			var unequipFromAimWaterAnimatorState37702blendTreeBlendTree37860Child0 =  new ChildMotion();
			unequipFromAimWaterAnimatorState37702blendTreeBlendTree37860Child0.motion = tridentUnequipFromAimLandAnimationClip29556;
			unequipFromAimWaterAnimatorState37702blendTreeBlendTree37860Child0.cycleOffset = 0f;
			unequipFromAimWaterAnimatorState37702blendTreeBlendTree37860Child0.directBlendParameter = "HorizontalMovement";
			unequipFromAimWaterAnimatorState37702blendTreeBlendTree37860Child0.mirror = false;
			unequipFromAimWaterAnimatorState37702blendTreeBlendTree37860Child0.position = new Vector2(0f, -1f);
			unequipFromAimWaterAnimatorState37702blendTreeBlendTree37860Child0.threshold = 0f;
			unequipFromAimWaterAnimatorState37702blendTreeBlendTree37860Child0.timeScale = 1f;
			var unequipFromAimWaterAnimatorState37702blendTreeBlendTree37860Child1 =  new ChildMotion();
			unequipFromAimWaterAnimatorState37702blendTreeBlendTree37860Child1.motion = tridentUnequipFromAimStrafeAnimationClip20492;
			unequipFromAimWaterAnimatorState37702blendTreeBlendTree37860Child1.cycleOffset = 0f;
			unequipFromAimWaterAnimatorState37702blendTreeBlendTree37860Child1.directBlendParameter = "HorizontalMovement";
			unequipFromAimWaterAnimatorState37702blendTreeBlendTree37860Child1.mirror = false;
			unequipFromAimWaterAnimatorState37702blendTreeBlendTree37860Child1.position = new Vector2(-1f, 0f);
			unequipFromAimWaterAnimatorState37702blendTreeBlendTree37860Child1.threshold = 0.25f;
			unequipFromAimWaterAnimatorState37702blendTreeBlendTree37860Child1.timeScale = 1f;
			var unequipFromAimWaterAnimatorState37702blendTreeBlendTree37860Child2 =  new ChildMotion();
			unequipFromAimWaterAnimatorState37702blendTreeBlendTree37860Child2.motion = tridentUnequipFromAimAnimationClip21188;
			unequipFromAimWaterAnimatorState37702blendTreeBlendTree37860Child2.cycleOffset = 0f;
			unequipFromAimWaterAnimatorState37702blendTreeBlendTree37860Child2.directBlendParameter = "HorizontalMovement";
			unequipFromAimWaterAnimatorState37702blendTreeBlendTree37860Child2.mirror = false;
			unequipFromAimWaterAnimatorState37702blendTreeBlendTree37860Child2.position = new Vector2(0f, 0f);
			unequipFromAimWaterAnimatorState37702blendTreeBlendTree37860Child2.threshold = 0.5f;
			unequipFromAimWaterAnimatorState37702blendTreeBlendTree37860Child2.timeScale = 1f;
			var unequipFromAimWaterAnimatorState37702blendTreeBlendTree37860Child3 =  new ChildMotion();
			unequipFromAimWaterAnimatorState37702blendTreeBlendTree37860Child3.motion = tridentUnequipFromAimStrafeAnimationClip20492;
			unequipFromAimWaterAnimatorState37702blendTreeBlendTree37860Child3.cycleOffset = 0f;
			unequipFromAimWaterAnimatorState37702blendTreeBlendTree37860Child3.directBlendParameter = "HorizontalMovement";
			unequipFromAimWaterAnimatorState37702blendTreeBlendTree37860Child3.mirror = false;
			unequipFromAimWaterAnimatorState37702blendTreeBlendTree37860Child3.position = new Vector2(1f, 0f);
			unequipFromAimWaterAnimatorState37702blendTreeBlendTree37860Child3.threshold = 0.75f;
			unequipFromAimWaterAnimatorState37702blendTreeBlendTree37860Child3.timeScale = 1f;
			var unequipFromAimWaterAnimatorState37702blendTreeBlendTree37860Child4 =  new ChildMotion();
			unequipFromAimWaterAnimatorState37702blendTreeBlendTree37860Child4.motion = tridentUnequipFromAimAnimationClip21188;
			unequipFromAimWaterAnimatorState37702blendTreeBlendTree37860Child4.cycleOffset = 0f;
			unequipFromAimWaterAnimatorState37702blendTreeBlendTree37860Child4.directBlendParameter = "HorizontalMovement";
			unequipFromAimWaterAnimatorState37702blendTreeBlendTree37860Child4.mirror = false;
			unequipFromAimWaterAnimatorState37702blendTreeBlendTree37860Child4.position = new Vector2(0f, 1f);
			unequipFromAimWaterAnimatorState37702blendTreeBlendTree37860Child4.threshold = 1f;
			unequipFromAimWaterAnimatorState37702blendTreeBlendTree37860Child4.timeScale = 1f;
			unequipFromAimWaterAnimatorState37702blendTreeBlendTree37860.children = new ChildMotion[] {
				unequipFromAimWaterAnimatorState37702blendTreeBlendTree37860Child0,
				unequipFromAimWaterAnimatorState37702blendTreeBlendTree37860Child1,
				unequipFromAimWaterAnimatorState37702blendTreeBlendTree37860Child2,
				unequipFromAimWaterAnimatorState37702blendTreeBlendTree37860Child3,
				unequipFromAimWaterAnimatorState37702blendTreeBlendTree37860Child4
			};
			unequipFromAimWaterAnimatorState37702.motion = unequipFromAimWaterAnimatorState37702blendTreeBlendTree37860;
			unequipFromAimWaterAnimatorState37702.cycleOffset = 0f;
			unequipFromAimWaterAnimatorState37702.cycleOffsetParameterActive = false;
			unequipFromAimWaterAnimatorState37702.iKOnFeet = false;
			unequipFromAimWaterAnimatorState37702.mirror = false;
			unequipFromAimWaterAnimatorState37702.mirrorParameterActive = false;
			unequipFromAimWaterAnimatorState37702.speed = 2.25f;
			unequipFromAimWaterAnimatorState37702.speedParameterActive = false;
			unequipFromAimWaterAnimatorState37702.writeDefaultValues = true;

			var unequipFromIdleWaterAnimatorState37698 = tridentAnimatorStateMachine37552.AddState("Unequip From Idle Water", new Vector3(384f, 288f, 0f));
			var unequipFromIdleWaterAnimatorState37698blendTreeBlendTree37864 = new BlendTree();
			AssetDatabase.AddObjectToAsset(unequipFromIdleWaterAnimatorState37698blendTreeBlendTree37864, animatorController);
			unequipFromIdleWaterAnimatorState37698blendTreeBlendTree37864.hideFlags = HideFlags.HideInHierarchy;
			unequipFromIdleWaterAnimatorState37698blendTreeBlendTree37864.blendParameter = "HorizontalMovement";
			unequipFromIdleWaterAnimatorState37698blendTreeBlendTree37864.blendParameterY = "ForwardMovement";
			unequipFromIdleWaterAnimatorState37698blendTreeBlendTree37864.blendType = BlendTreeType.FreeformCartesian2D;
			unequipFromIdleWaterAnimatorState37698blendTreeBlendTree37864.maxThreshold = 1f;
			unequipFromIdleWaterAnimatorState37698blendTreeBlendTree37864.minThreshold = 0f;
			unequipFromIdleWaterAnimatorState37698blendTreeBlendTree37864.name = "Blend Tree";
			unequipFromIdleWaterAnimatorState37698blendTreeBlendTree37864.useAutomaticThresholds = true;
			var unequipFromIdleWaterAnimatorState37698blendTreeBlendTree37864Child0 =  new ChildMotion();
			unequipFromIdleWaterAnimatorState37698blendTreeBlendTree37864Child0.motion = tridentUnequipFromIdleLandAnimationClip15942;
			unequipFromIdleWaterAnimatorState37698blendTreeBlendTree37864Child0.cycleOffset = 0f;
			unequipFromIdleWaterAnimatorState37698blendTreeBlendTree37864Child0.directBlendParameter = "HorizontalMovement";
			unequipFromIdleWaterAnimatorState37698blendTreeBlendTree37864Child0.mirror = false;
			unequipFromIdleWaterAnimatorState37698blendTreeBlendTree37864Child0.position = new Vector2(0f, -1f);
			unequipFromIdleWaterAnimatorState37698blendTreeBlendTree37864Child0.threshold = 0f;
			unequipFromIdleWaterAnimatorState37698blendTreeBlendTree37864Child0.timeScale = 1f;
			var unequipFromIdleWaterAnimatorState37698blendTreeBlendTree37864Child1 =  new ChildMotion();
			unequipFromIdleWaterAnimatorState37698blendTreeBlendTree37864Child1.motion = tridentUnequipFromIdleStrafeAnimationClip18048;
			unequipFromIdleWaterAnimatorState37698blendTreeBlendTree37864Child1.cycleOffset = 0f;
			unequipFromIdleWaterAnimatorState37698blendTreeBlendTree37864Child1.directBlendParameter = "HorizontalMovement";
			unequipFromIdleWaterAnimatorState37698blendTreeBlendTree37864Child1.mirror = false;
			unequipFromIdleWaterAnimatorState37698blendTreeBlendTree37864Child1.position = new Vector2(-1f, 0f);
			unequipFromIdleWaterAnimatorState37698blendTreeBlendTree37864Child1.threshold = 0.25f;
			unequipFromIdleWaterAnimatorState37698blendTreeBlendTree37864Child1.timeScale = 1f;
			var unequipFromIdleWaterAnimatorState37698blendTreeBlendTree37864Child2 =  new ChildMotion();
			unequipFromIdleWaterAnimatorState37698blendTreeBlendTree37864Child2.motion = tridentUnequipFromIdleAnimationClip22604;
			unequipFromIdleWaterAnimatorState37698blendTreeBlendTree37864Child2.cycleOffset = 0f;
			unequipFromIdleWaterAnimatorState37698blendTreeBlendTree37864Child2.directBlendParameter = "HorizontalMovement";
			unequipFromIdleWaterAnimatorState37698blendTreeBlendTree37864Child2.mirror = false;
			unequipFromIdleWaterAnimatorState37698blendTreeBlendTree37864Child2.position = new Vector2(0f, 0f);
			unequipFromIdleWaterAnimatorState37698blendTreeBlendTree37864Child2.threshold = 0.5f;
			unequipFromIdleWaterAnimatorState37698blendTreeBlendTree37864Child2.timeScale = 1f;
			var unequipFromIdleWaterAnimatorState37698blendTreeBlendTree37864Child3 =  new ChildMotion();
			unequipFromIdleWaterAnimatorState37698blendTreeBlendTree37864Child3.motion = tridentUnequipFromIdleStrafeAnimationClip18048;
			unequipFromIdleWaterAnimatorState37698blendTreeBlendTree37864Child3.cycleOffset = 0f;
			unequipFromIdleWaterAnimatorState37698blendTreeBlendTree37864Child3.directBlendParameter = "HorizontalMovement";
			unequipFromIdleWaterAnimatorState37698blendTreeBlendTree37864Child3.mirror = false;
			unequipFromIdleWaterAnimatorState37698blendTreeBlendTree37864Child3.position = new Vector2(1f, 0f);
			unequipFromIdleWaterAnimatorState37698blendTreeBlendTree37864Child3.threshold = 0.75f;
			unequipFromIdleWaterAnimatorState37698blendTreeBlendTree37864Child3.timeScale = 1f;
			var unequipFromIdleWaterAnimatorState37698blendTreeBlendTree37864Child4 =  new ChildMotion();
			unequipFromIdleWaterAnimatorState37698blendTreeBlendTree37864Child4.motion = tridentUnequipFromIdleAnimationClip22604;
			unequipFromIdleWaterAnimatorState37698blendTreeBlendTree37864Child4.cycleOffset = 0f;
			unequipFromIdleWaterAnimatorState37698blendTreeBlendTree37864Child4.directBlendParameter = "HorizontalMovement";
			unequipFromIdleWaterAnimatorState37698blendTreeBlendTree37864Child4.mirror = false;
			unequipFromIdleWaterAnimatorState37698blendTreeBlendTree37864Child4.position = new Vector2(0f, 1f);
			unequipFromIdleWaterAnimatorState37698blendTreeBlendTree37864Child4.threshold = 1f;
			unequipFromIdleWaterAnimatorState37698blendTreeBlendTree37864Child4.timeScale = 1f;
			unequipFromIdleWaterAnimatorState37698blendTreeBlendTree37864.children = new ChildMotion[] {
				unequipFromIdleWaterAnimatorState37698blendTreeBlendTree37864Child0,
				unequipFromIdleWaterAnimatorState37698blendTreeBlendTree37864Child1,
				unequipFromIdleWaterAnimatorState37698blendTreeBlendTree37864Child2,
				unequipFromIdleWaterAnimatorState37698blendTreeBlendTree37864Child3,
				unequipFromIdleWaterAnimatorState37698blendTreeBlendTree37864Child4
			};
			unequipFromIdleWaterAnimatorState37698.motion = unequipFromIdleWaterAnimatorState37698blendTreeBlendTree37864;
			unequipFromIdleWaterAnimatorState37698.cycleOffset = 0f;
			unequipFromIdleWaterAnimatorState37698.cycleOffsetParameterActive = false;
			unequipFromIdleWaterAnimatorState37698.iKOnFeet = false;
			unequipFromIdleWaterAnimatorState37698.mirror = false;
			unequipFromIdleWaterAnimatorState37698.mirrorParameterActive = false;
			unequipFromIdleWaterAnimatorState37698.speed = 2.25f;
			unequipFromIdleWaterAnimatorState37698.speedParameterActive = false;
			unequipFromIdleWaterAnimatorState37698.writeDefaultValues = true;

			var idleWaterAnimatorState37706 = tridentAnimatorStateMachine37552.AddState("Idle Water", new Vector3(384f, 48f, 0f));
			var idleWaterAnimatorState37706blendTreeBlendTree37870 = new BlendTree();
			AssetDatabase.AddObjectToAsset(idleWaterAnimatorState37706blendTreeBlendTree37870, animatorController);
			idleWaterAnimatorState37706blendTreeBlendTree37870.hideFlags = HideFlags.HideInHierarchy;
			idleWaterAnimatorState37706blendTreeBlendTree37870.blendParameter = "HorizontalMovement";
			idleWaterAnimatorState37706blendTreeBlendTree37870.blendParameterY = "ForwardMovement";
			idleWaterAnimatorState37706blendTreeBlendTree37870.blendType = BlendTreeType.FreeformCartesian2D;
			idleWaterAnimatorState37706blendTreeBlendTree37870.maxThreshold = 1f;
			idleWaterAnimatorState37706blendTreeBlendTree37870.minThreshold = 0f;
			idleWaterAnimatorState37706blendTreeBlendTree37870.name = "Blend Tree";
			idleWaterAnimatorState37706blendTreeBlendTree37870.useAutomaticThresholds = true;
			var idleWaterAnimatorState37706blendTreeBlendTree37870Child0 =  new ChildMotion();
			idleWaterAnimatorState37706blendTreeBlendTree37870Child0.motion = tridentIdleLandAnimationClip17184;
			idleWaterAnimatorState37706blendTreeBlendTree37870Child0.cycleOffset = 0f;
			idleWaterAnimatorState37706blendTreeBlendTree37870Child0.directBlendParameter = "HorizontalMovement";
			idleWaterAnimatorState37706blendTreeBlendTree37870Child0.mirror = false;
			idleWaterAnimatorState37706blendTreeBlendTree37870Child0.position = new Vector2(0f, -1f);
			idleWaterAnimatorState37706blendTreeBlendTree37870Child0.threshold = 0f;
			idleWaterAnimatorState37706blendTreeBlendTree37870Child0.timeScale = 1f;
			var idleWaterAnimatorState37706blendTreeBlendTree37870Child1 =  new ChildMotion();
			idleWaterAnimatorState37706blendTreeBlendTree37870Child1.motion = tridentIdleStrafeAnimationClip19932;
			idleWaterAnimatorState37706blendTreeBlendTree37870Child1.cycleOffset = 0f;
			idleWaterAnimatorState37706blendTreeBlendTree37870Child1.directBlendParameter = "HorizontalMovement";
			idleWaterAnimatorState37706blendTreeBlendTree37870Child1.mirror = false;
			idleWaterAnimatorState37706blendTreeBlendTree37870Child1.position = new Vector2(-1f, 0f);
			idleWaterAnimatorState37706blendTreeBlendTree37870Child1.threshold = 0.25f;
			idleWaterAnimatorState37706blendTreeBlendTree37870Child1.timeScale = 1f;
			var idleWaterAnimatorState37706blendTreeBlendTree37870Child2 =  new ChildMotion();
			idleWaterAnimatorState37706blendTreeBlendTree37870Child2.motion = tridentIdleAnimationClip19442;
			idleWaterAnimatorState37706blendTreeBlendTree37870Child2.cycleOffset = 0f;
			idleWaterAnimatorState37706blendTreeBlendTree37870Child2.directBlendParameter = "HorizontalMovement";
			idleWaterAnimatorState37706blendTreeBlendTree37870Child2.mirror = false;
			idleWaterAnimatorState37706blendTreeBlendTree37870Child2.position = new Vector2(0f, 0f);
			idleWaterAnimatorState37706blendTreeBlendTree37870Child2.threshold = 0.5f;
			idleWaterAnimatorState37706blendTreeBlendTree37870Child2.timeScale = 1f;
			var idleWaterAnimatorState37706blendTreeBlendTree37870Child3 =  new ChildMotion();
			idleWaterAnimatorState37706blendTreeBlendTree37870Child3.motion = tridentIdleStrafeAnimationClip19932;
			idleWaterAnimatorState37706blendTreeBlendTree37870Child3.cycleOffset = 0.5f;
			idleWaterAnimatorState37706blendTreeBlendTree37870Child3.directBlendParameter = "HorizontalMovement";
			idleWaterAnimatorState37706blendTreeBlendTree37870Child3.mirror = true;
			idleWaterAnimatorState37706blendTreeBlendTree37870Child3.position = new Vector2(1f, 0f);
			idleWaterAnimatorState37706blendTreeBlendTree37870Child3.threshold = 0.75f;
			idleWaterAnimatorState37706blendTreeBlendTree37870Child3.timeScale = 1f;
			var idleWaterAnimatorState37706blendTreeBlendTree37870Child4 =  new ChildMotion();
			idleWaterAnimatorState37706blendTreeBlendTree37870Child4.motion = tridentIdleAnimationClip19442;
			idleWaterAnimatorState37706blendTreeBlendTree37870Child4.cycleOffset = 0f;
			idleWaterAnimatorState37706blendTreeBlendTree37870Child4.directBlendParameter = "HorizontalMovement";
			idleWaterAnimatorState37706blendTreeBlendTree37870Child4.mirror = false;
			idleWaterAnimatorState37706blendTreeBlendTree37870Child4.position = new Vector2(0f, 1f);
			idleWaterAnimatorState37706blendTreeBlendTree37870Child4.threshold = 1f;
			idleWaterAnimatorState37706blendTreeBlendTree37870Child4.timeScale = 1f;
			idleWaterAnimatorState37706blendTreeBlendTree37870.children = new ChildMotion[] {
				idleWaterAnimatorState37706blendTreeBlendTree37870Child0,
				idleWaterAnimatorState37706blendTreeBlendTree37870Child1,
				idleWaterAnimatorState37706blendTreeBlendTree37870Child2,
				idleWaterAnimatorState37706blendTreeBlendTree37870Child3,
				idleWaterAnimatorState37706blendTreeBlendTree37870Child4
			};
			idleWaterAnimatorState37706.motion = idleWaterAnimatorState37706blendTreeBlendTree37870;
			idleWaterAnimatorState37706.cycleOffset = 0f;
			idleWaterAnimatorState37706.cycleOffsetParameterActive = false;
			idleWaterAnimatorState37706.iKOnFeet = true;
			idleWaterAnimatorState37706.mirror = false;
			idleWaterAnimatorState37706.mirrorParameterActive = false;
			idleWaterAnimatorState37706.speed = 1f;
			idleWaterAnimatorState37706.speedParameterActive = false;
			idleWaterAnimatorState37706.writeDefaultValues = true;

			var dropWaterLandAnimatorState37708 = tridentAnimatorStateMachine37552.AddState("Drop Water Land", new Vector3(384f, -12f, 0f));
			dropWaterLandAnimatorState37708.motion = tridentDropLandAnimationClip26280;
			dropWaterLandAnimatorState37708.cycleOffset = 0f;
			dropWaterLandAnimatorState37708.cycleOffsetParameterActive = false;
			dropWaterLandAnimatorState37708.iKOnFeet = false;
			dropWaterLandAnimatorState37708.mirror = false;
			dropWaterLandAnimatorState37708.mirrorParameterActive = false;
			dropWaterLandAnimatorState37708.speed = 1f;
			dropWaterLandAnimatorState37708.speedParameterActive = false;
			dropWaterLandAnimatorState37708.writeDefaultValues = true;

			var unequipFromIdleLandAnimatorState37710 = tridentAnimatorStateMachine37552.AddState("Unequip From Idle Land", new Vector3(384f, -72f, 0f));
			unequipFromIdleLandAnimatorState37710.motion = tridentUnequipFromIdleLandAnimationClip15942;
			unequipFromIdleLandAnimatorState37710.cycleOffset = 0f;
			unequipFromIdleLandAnimatorState37710.cycleOffsetParameterActive = false;
			unequipFromIdleLandAnimatorState37710.iKOnFeet = false;
			unequipFromIdleLandAnimatorState37710.mirror = false;
			unequipFromIdleLandAnimatorState37710.mirrorParameterActive = false;
			unequipFromIdleLandAnimatorState37710.speed = 2.25f;
			unequipFromIdleLandAnimatorState37710.speedParameterActive = false;
			unequipFromIdleLandAnimatorState37710.writeDefaultValues = true;

			var equipFromIdleLandAnimatorState37712 = tridentAnimatorStateMachine37552.AddState("Equip From Idle Land", new Vector3(384f, -132f, 0f));
			equipFromIdleLandAnimatorState37712.motion = tridentEquipFromIdleLandAnimationClip24446;
			equipFromIdleLandAnimatorState37712.cycleOffset = 0f;
			equipFromIdleLandAnimatorState37712.cycleOffsetParameterActive = false;
			equipFromIdleLandAnimatorState37712.iKOnFeet = false;
			equipFromIdleLandAnimatorState37712.mirror = false;
			equipFromIdleLandAnimatorState37712.mirrorParameterActive = false;
			equipFromIdleLandAnimatorState37712.speed = 2.75f;
			equipFromIdleLandAnimatorState37712.speedParameterActive = false;
			equipFromIdleLandAnimatorState37712.writeDefaultValues = true;

			var unequipFromAimLandAnimatorState37714 = tridentAnimatorStateMachine37552.AddState("Unequip From Aim Land", new Vector3(384f, -192f, 0f));
			unequipFromAimLandAnimatorState37714.motion = tridentUnequipFromAimLandAnimationClip29556;
			unequipFromAimLandAnimatorState37714.cycleOffset = 0f;
			unequipFromAimLandAnimatorState37714.cycleOffsetParameterActive = false;
			unequipFromAimLandAnimatorState37714.iKOnFeet = false;
			unequipFromAimLandAnimatorState37714.mirror = false;
			unequipFromAimLandAnimatorState37714.mirrorParameterActive = false;
			unequipFromAimLandAnimatorState37714.speed = 2.25f;
			unequipFromAimLandAnimatorState37714.speedParameterActive = false;
			unequipFromAimLandAnimatorState37714.writeDefaultValues = true;

			var equipFromAimLandAnimatorState37716 = tridentAnimatorStateMachine37552.AddState("Equip From Aim Land", new Vector3(384f, -252f, 0f));
			equipFromAimLandAnimatorState37716.motion = tridentEquipFromAimLandAnimationClip26258;
			equipFromAimLandAnimatorState37716.cycleOffset = 0f;
			equipFromAimLandAnimatorState37716.cycleOffsetParameterActive = false;
			equipFromAimLandAnimatorState37716.iKOnFeet = false;
			equipFromAimLandAnimatorState37716.mirror = false;
			equipFromAimLandAnimatorState37716.mirrorParameterActive = false;
			equipFromAimLandAnimatorState37716.speed = 2.75f;
			equipFromAimLandAnimatorState37716.speedParameterActive = false;
			equipFromAimLandAnimatorState37716.writeDefaultValues = true;

			var idleLandAnimatorState37718 = tridentAnimatorStateMachine37552.AddState("Idle Land", new Vector3(384f, -312f, 0f));
			idleLandAnimatorState37718.motion = tridentIdleLandAnimationClip17184;
			idleLandAnimatorState37718.cycleOffset = 0f;
			idleLandAnimatorState37718.cycleOffsetParameterActive = false;
			idleLandAnimatorState37718.iKOnFeet = true;
			idleLandAnimatorState37718.mirror = false;
			idleLandAnimatorState37718.mirrorParameterActive = false;
			idleLandAnimatorState37718.speed = 1f;
			idleLandAnimatorState37718.speedParameterActive = false;
			idleLandAnimatorState37718.writeDefaultValues = true;

			// State Transitions.
			var animatorStateTransition37846 = dropWaterAnimatorState37696.AddExitTransition();
			animatorStateTransition37846.canTransitionToSelf = true;
			animatorStateTransition37846.duration = 0.1f;
			animatorStateTransition37846.exitTime = 0.9f;
			animatorStateTransition37846.hasExitTime = true;
			animatorStateTransition37846.hasFixedDuration = true;
			animatorStateTransition37846.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition37846.offset = 0f;
			animatorStateTransition37846.orderedInterruption = true;
			animatorStateTransition37846.isExit = true;
			animatorStateTransition37846.mute = false;
			animatorStateTransition37846.solo = false;

			var animatorStateTransition37850 = equipFromAimWaterAnimatorState37704.AddExitTransition();
			animatorStateTransition37850.canTransitionToSelf = true;
			animatorStateTransition37850.duration = 0.2f;
			animatorStateTransition37850.exitTime = 0.85f;
			animatorStateTransition37850.hasExitTime = false;
			animatorStateTransition37850.hasFixedDuration = true;
			animatorStateTransition37850.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition37850.offset = 0f;
			animatorStateTransition37850.orderedInterruption = true;
			animatorStateTransition37850.isExit = true;
			animatorStateTransition37850.mute = false;
			animatorStateTransition37850.solo = false;
			animatorStateTransition37850.AddCondition(AnimatorConditionMode.NotEqual, 4f, "Slot0ItemStateIndex");

			var animatorStateTransition37854 = equipFromIdleWaterAnimatorState37700.AddExitTransition();
			animatorStateTransition37854.canTransitionToSelf = true;
			animatorStateTransition37854.duration = 0.2f;
			animatorStateTransition37854.exitTime = 0.75f;
			animatorStateTransition37854.hasExitTime = false;
			animatorStateTransition37854.hasFixedDuration = true;
			animatorStateTransition37854.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition37854.offset = 0f;
			animatorStateTransition37854.orderedInterruption = true;
			animatorStateTransition37854.isExit = true;
			animatorStateTransition37854.mute = false;
			animatorStateTransition37854.solo = false;
			animatorStateTransition37854.AddCondition(AnimatorConditionMode.NotEqual, 4f, "Slot0ItemStateIndex");

			var animatorStateTransition37858 = unequipFromAimWaterAnimatorState37702.AddExitTransition();
			animatorStateTransition37858.canTransitionToSelf = true;
			animatorStateTransition37858.duration = 0.2f;
			animatorStateTransition37858.exitTime = 0.8f;
			animatorStateTransition37858.hasExitTime = false;
			animatorStateTransition37858.hasFixedDuration = true;
			animatorStateTransition37858.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition37858.offset = 0f;
			animatorStateTransition37858.orderedInterruption = true;
			animatorStateTransition37858.isExit = true;
			animatorStateTransition37858.mute = false;
			animatorStateTransition37858.solo = false;
			animatorStateTransition37858.AddCondition(AnimatorConditionMode.NotEqual, 5f, "Slot0ItemStateIndex");

			var animatorStateTransition37862 = unequipFromIdleWaterAnimatorState37698.AddExitTransition();
			animatorStateTransition37862.canTransitionToSelf = true;
			animatorStateTransition37862.duration = 0.2f;
			animatorStateTransition37862.exitTime = 0.75f;
			animatorStateTransition37862.hasExitTime = false;
			animatorStateTransition37862.hasFixedDuration = true;
			animatorStateTransition37862.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition37862.offset = 0f;
			animatorStateTransition37862.orderedInterruption = true;
			animatorStateTransition37862.isExit = true;
			animatorStateTransition37862.mute = false;
			animatorStateTransition37862.solo = false;
			animatorStateTransition37862.AddCondition(AnimatorConditionMode.NotEqual, 5f, "Slot0ItemStateIndex");

			var animatorStateTransition37866 = idleWaterAnimatorState37706.AddExitTransition();
			animatorStateTransition37866.canTransitionToSelf = true;
			animatorStateTransition37866.duration = 0.15f;
			animatorStateTransition37866.exitTime = 0.7f;
			animatorStateTransition37866.hasExitTime = false;
			animatorStateTransition37866.hasFixedDuration = true;
			animatorStateTransition37866.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition37866.offset = 0f;
			animatorStateTransition37866.orderedInterruption = true;
			animatorStateTransition37866.isExit = true;
			animatorStateTransition37866.mute = false;
			animatorStateTransition37866.solo = false;
			animatorStateTransition37866.AddCondition(AnimatorConditionMode.NotEqual, 26f, "Slot0ItemID");

			var animatorStateTransition37868 = idleWaterAnimatorState37706.AddExitTransition();
			animatorStateTransition37868.canTransitionToSelf = true;
			animatorStateTransition37868.duration = 0.15f;
			animatorStateTransition37868.exitTime = 0.7f;
			animatorStateTransition37868.hasExitTime = false;
			animatorStateTransition37868.hasFixedDuration = true;
			animatorStateTransition37868.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition37868.offset = 0f;
			animatorStateTransition37868.orderedInterruption = true;
			animatorStateTransition37868.isExit = true;
			animatorStateTransition37868.mute = false;
			animatorStateTransition37868.solo = false;
			animatorStateTransition37868.AddCondition(AnimatorConditionMode.NotEqual, 0f, "Slot0ItemStateIndex");

			var animatorStateTransition37872 = dropWaterLandAnimatorState37708.AddExitTransition();
			animatorStateTransition37872.canTransitionToSelf = true;
			animatorStateTransition37872.duration = 0.1f;
			animatorStateTransition37872.exitTime = 0.9f;
			animatorStateTransition37872.hasExitTime = true;
			animatorStateTransition37872.hasFixedDuration = true;
			animatorStateTransition37872.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition37872.offset = 0f;
			animatorStateTransition37872.orderedInterruption = true;
			animatorStateTransition37872.isExit = true;
			animatorStateTransition37872.mute = false;
			animatorStateTransition37872.solo = false;

			var animatorStateTransition37874 = unequipFromIdleLandAnimatorState37710.AddExitTransition();
			animatorStateTransition37874.canTransitionToSelf = true;
			animatorStateTransition37874.duration = 0.2f;
			animatorStateTransition37874.exitTime = 0.75f;
			animatorStateTransition37874.hasExitTime = false;
			animatorStateTransition37874.hasFixedDuration = true;
			animatorStateTransition37874.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition37874.offset = 0f;
			animatorStateTransition37874.orderedInterruption = true;
			animatorStateTransition37874.isExit = true;
			animatorStateTransition37874.mute = false;
			animatorStateTransition37874.solo = false;
			animatorStateTransition37874.AddCondition(AnimatorConditionMode.NotEqual, 5f, "Slot0ItemStateIndex");

			var animatorStateTransition37876 = equipFromIdleLandAnimatorState37712.AddExitTransition();
			animatorStateTransition37876.canTransitionToSelf = true;
			animatorStateTransition37876.duration = 0.2f;
			animatorStateTransition37876.exitTime = 0.75f;
			animatorStateTransition37876.hasExitTime = false;
			animatorStateTransition37876.hasFixedDuration = true;
			animatorStateTransition37876.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition37876.offset = 0f;
			animatorStateTransition37876.orderedInterruption = true;
			animatorStateTransition37876.isExit = true;
			animatorStateTransition37876.mute = false;
			animatorStateTransition37876.solo = false;
			animatorStateTransition37876.AddCondition(AnimatorConditionMode.NotEqual, 4f, "Slot0ItemStateIndex");

			var animatorStateTransition37878 = unequipFromAimLandAnimatorState37714.AddExitTransition();
			animatorStateTransition37878.canTransitionToSelf = true;
			animatorStateTransition37878.duration = 0.2f;
			animatorStateTransition37878.exitTime = 0.8f;
			animatorStateTransition37878.hasExitTime = false;
			animatorStateTransition37878.hasFixedDuration = true;
			animatorStateTransition37878.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition37878.offset = 0f;
			animatorStateTransition37878.orderedInterruption = true;
			animatorStateTransition37878.isExit = true;
			animatorStateTransition37878.mute = false;
			animatorStateTransition37878.solo = false;
			animatorStateTransition37878.AddCondition(AnimatorConditionMode.NotEqual, 5f, "Slot0ItemStateIndex");

			var animatorStateTransition37880 = equipFromAimLandAnimatorState37716.AddExitTransition();
			animatorStateTransition37880.canTransitionToSelf = true;
			animatorStateTransition37880.duration = 0.2f;
			animatorStateTransition37880.exitTime = 0.85f;
			animatorStateTransition37880.hasExitTime = false;
			animatorStateTransition37880.hasFixedDuration = true;
			animatorStateTransition37880.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition37880.offset = 0f;
			animatorStateTransition37880.orderedInterruption = true;
			animatorStateTransition37880.isExit = true;
			animatorStateTransition37880.mute = false;
			animatorStateTransition37880.solo = false;
			animatorStateTransition37880.AddCondition(AnimatorConditionMode.NotEqual, 4f, "Slot0ItemStateIndex");

			var animatorStateTransition37882 = idleLandAnimatorState37718.AddExitTransition();
			animatorStateTransition37882.canTransitionToSelf = true;
			animatorStateTransition37882.duration = 0.15f;
			animatorStateTransition37882.exitTime = 0.7f;
			animatorStateTransition37882.hasExitTime = false;
			animatorStateTransition37882.hasFixedDuration = true;
			animatorStateTransition37882.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition37882.offset = 0f;
			animatorStateTransition37882.orderedInterruption = true;
			animatorStateTransition37882.isExit = true;
			animatorStateTransition37882.mute = false;
			animatorStateTransition37882.solo = false;
			animatorStateTransition37882.AddCondition(AnimatorConditionMode.NotEqual, 26f, "Slot0ItemID");

			var animatorStateTransition37884 = idleLandAnimatorState37718.AddExitTransition();
			animatorStateTransition37884.canTransitionToSelf = true;
			animatorStateTransition37884.duration = 0.15f;
			animatorStateTransition37884.exitTime = 0.7f;
			animatorStateTransition37884.hasExitTime = false;
			animatorStateTransition37884.hasFixedDuration = true;
			animatorStateTransition37884.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition37884.offset = 0f;
			animatorStateTransition37884.orderedInterruption = true;
			animatorStateTransition37884.isExit = true;
			animatorStateTransition37884.mute = false;
			animatorStateTransition37884.solo = false;
			animatorStateTransition37884.AddCondition(AnimatorConditionMode.NotEqual, 0f, "Slot0ItemStateIndex");

			// State Machine Defaults.
			tridentAnimatorStateMachine37552.anyStatePosition = new Vector3(50f, 20f, 0f);
			tridentAnimatorStateMachine37552.defaultState = idleWaterAnimatorState37706;
			tridentAnimatorStateMachine37552.entryPosition = new Vector3(50f, 120f, 0f);
			tridentAnimatorStateMachine37552.exitPosition = new Vector3(800f, 120f, 0f);
			tridentAnimatorStateMachine37552.parentStateMachinePosition = new Vector3(800f, 20f, 0f);


			// State Machine Transitions.
			var animatorStateTransition37608 = baseStateMachine1333564080.AddAnyStateTransition(dropWaterAnimatorState37696);
			animatorStateTransition37608.canTransitionToSelf = false;
			animatorStateTransition37608.duration = 0.1f;
			animatorStateTransition37608.exitTime = 0.75f;
			animatorStateTransition37608.hasExitTime = false;
			animatorStateTransition37608.hasFixedDuration = true;
			animatorStateTransition37608.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition37608.offset = 0f;
			animatorStateTransition37608.orderedInterruption = true;
			animatorStateTransition37608.isExit = false;
			animatorStateTransition37608.mute = false;
			animatorStateTransition37608.solo = false;
			animatorStateTransition37608.AddCondition(AnimatorConditionMode.If, 0f, "Slot0ItemStateIndexChange");
			animatorStateTransition37608.AddCondition(AnimatorConditionMode.Equals, 26f, "Slot0ItemID");
			animatorStateTransition37608.AddCondition(AnimatorConditionMode.Equals, 6f, "Slot0ItemStateIndex");
			animatorStateTransition37608.AddCondition(AnimatorConditionMode.If, 0f, "Moving");
			animatorStateTransition37608.AddCondition(AnimatorConditionMode.Equals, 301f, "AbilityIndex");
			animatorStateTransition37608.AddCondition(AnimatorConditionMode.NotEqual, 1f, "AbilityIntData");

			var animatorStateTransition37610 = baseStateMachine1333564080.AddAnyStateTransition(unequipFromIdleWaterAnimatorState37698);
			animatorStateTransition37610.canTransitionToSelf = false;
			animatorStateTransition37610.duration = 0.15f;
			animatorStateTransition37610.exitTime = 0.75f;
			animatorStateTransition37610.hasExitTime = false;
			animatorStateTransition37610.hasFixedDuration = true;
			animatorStateTransition37610.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition37610.offset = 0f;
			animatorStateTransition37610.orderedInterruption = true;
			animatorStateTransition37610.isExit = false;
			animatorStateTransition37610.mute = false;
			animatorStateTransition37610.solo = false;
			animatorStateTransition37610.AddCondition(AnimatorConditionMode.If, 0f, "Slot0ItemStateIndexChange");
			animatorStateTransition37610.AddCondition(AnimatorConditionMode.Equals, 26f, "Slot0ItemID");
			animatorStateTransition37610.AddCondition(AnimatorConditionMode.Equals, 5f, "Slot0ItemStateIndex");
			animatorStateTransition37610.AddCondition(AnimatorConditionMode.If, 0f, "Moving");
			animatorStateTransition37610.AddCondition(AnimatorConditionMode.IfNot, 0f, "Aiming");
			animatorStateTransition37610.AddCondition(AnimatorConditionMode.Equals, 301f, "AbilityIndex");
			animatorStateTransition37610.AddCondition(AnimatorConditionMode.NotEqual, 1f, "AbilityIntData");

			var animatorStateTransition37612 = baseStateMachine1333564080.AddAnyStateTransition(equipFromIdleWaterAnimatorState37700);
			animatorStateTransition37612.canTransitionToSelf = false;
			animatorStateTransition37612.duration = 0.15f;
			animatorStateTransition37612.exitTime = 0.75f;
			animatorStateTransition37612.hasExitTime = false;
			animatorStateTransition37612.hasFixedDuration = true;
			animatorStateTransition37612.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition37612.offset = 0f;
			animatorStateTransition37612.orderedInterruption = true;
			animatorStateTransition37612.isExit = false;
			animatorStateTransition37612.mute = false;
			animatorStateTransition37612.solo = false;
			animatorStateTransition37612.AddCondition(AnimatorConditionMode.If, 0f, "Slot0ItemStateIndexChange");
			animatorStateTransition37612.AddCondition(AnimatorConditionMode.Equals, 26f, "Slot0ItemID");
			animatorStateTransition37612.AddCondition(AnimatorConditionMode.Equals, 4f, "Slot0ItemStateIndex");
			animatorStateTransition37612.AddCondition(AnimatorConditionMode.If, 0f, "Moving");
			animatorStateTransition37612.AddCondition(AnimatorConditionMode.IfNot, 0f, "Aiming");
			animatorStateTransition37612.AddCondition(AnimatorConditionMode.Equals, 301f, "AbilityIndex");
			animatorStateTransition37612.AddCondition(AnimatorConditionMode.NotEqual, 1f, "AbilityIntData");

			var animatorStateTransition37614 = baseStateMachine1333564080.AddAnyStateTransition(unequipFromAimWaterAnimatorState37702);
			animatorStateTransition37614.canTransitionToSelf = false;
			animatorStateTransition37614.duration = 0.15f;
			animatorStateTransition37614.exitTime = 0.75f;
			animatorStateTransition37614.hasExitTime = false;
			animatorStateTransition37614.hasFixedDuration = true;
			animatorStateTransition37614.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition37614.offset = 0f;
			animatorStateTransition37614.orderedInterruption = true;
			animatorStateTransition37614.isExit = false;
			animatorStateTransition37614.mute = false;
			animatorStateTransition37614.solo = false;
			animatorStateTransition37614.AddCondition(AnimatorConditionMode.If, 0f, "Slot0ItemStateIndexChange");
			animatorStateTransition37614.AddCondition(AnimatorConditionMode.Equals, 26f, "Slot0ItemID");
			animatorStateTransition37614.AddCondition(AnimatorConditionMode.Equals, 5f, "Slot0ItemStateIndex");
			animatorStateTransition37614.AddCondition(AnimatorConditionMode.If, 0f, "Moving");
			animatorStateTransition37614.AddCondition(AnimatorConditionMode.If, 0f, "Aiming");
			animatorStateTransition37614.AddCondition(AnimatorConditionMode.Equals, 301f, "AbilityIndex");
			animatorStateTransition37614.AddCondition(AnimatorConditionMode.NotEqual, 1f, "AbilityIntData");

			var animatorStateTransition37616 = baseStateMachine1333564080.AddAnyStateTransition(equipFromAimWaterAnimatorState37704);
			animatorStateTransition37616.canTransitionToSelf = false;
			animatorStateTransition37616.duration = 0.15f;
			animatorStateTransition37616.exitTime = 0.75f;
			animatorStateTransition37616.hasExitTime = false;
			animatorStateTransition37616.hasFixedDuration = true;
			animatorStateTransition37616.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition37616.offset = 0f;
			animatorStateTransition37616.orderedInterruption = true;
			animatorStateTransition37616.isExit = false;
			animatorStateTransition37616.mute = false;
			animatorStateTransition37616.solo = false;
			animatorStateTransition37616.AddCondition(AnimatorConditionMode.If, 0f, "Slot0ItemStateIndexChange");
			animatorStateTransition37616.AddCondition(AnimatorConditionMode.Equals, 26f, "Slot0ItemID");
			animatorStateTransition37616.AddCondition(AnimatorConditionMode.Equals, 4f, "Slot0ItemStateIndex");
			animatorStateTransition37616.AddCondition(AnimatorConditionMode.If, 0f, "Moving");
			animatorStateTransition37616.AddCondition(AnimatorConditionMode.If, 0f, "Aiming");
			animatorStateTransition37616.AddCondition(AnimatorConditionMode.Equals, 301f, "AbilityIndex");
			animatorStateTransition37616.AddCondition(AnimatorConditionMode.NotEqual, 1f, "AbilityIntData");

			var animatorStateTransition37618 = baseStateMachine1333564080.AddAnyStateTransition(idleWaterAnimatorState37706);
			animatorStateTransition37618.canTransitionToSelf = false;
			animatorStateTransition37618.duration = 0.25f;
			animatorStateTransition37618.exitTime = 0.75f;
			animatorStateTransition37618.hasExitTime = false;
			animatorStateTransition37618.hasFixedDuration = true;
			animatorStateTransition37618.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition37618.offset = 0f;
			animatorStateTransition37618.orderedInterruption = true;
			animatorStateTransition37618.isExit = false;
			animatorStateTransition37618.mute = false;
			animatorStateTransition37618.solo = false;
			animatorStateTransition37618.AddCondition(AnimatorConditionMode.Equals, 26f, "Slot0ItemID");
			animatorStateTransition37618.AddCondition(AnimatorConditionMode.Equals, 0f, "Slot0ItemStateIndex");
			animatorStateTransition37618.AddCondition(AnimatorConditionMode.Equals, 301f, "AbilityIndex");
			animatorStateTransition37618.AddCondition(AnimatorConditionMode.NotEqual, 1f, "AbilityIntData");

			var animatorStateTransition37632 = baseStateMachine1333564080.AddAnyStateTransition(idleLandAnimatorState37718);
			animatorStateTransition37632.canTransitionToSelf = false;
			animatorStateTransition37632.duration = 0.08f;
			animatorStateTransition37632.exitTime = 0.75f;
			animatorStateTransition37632.hasExitTime = false;
			animatorStateTransition37632.hasFixedDuration = true;
			animatorStateTransition37632.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition37632.offset = 0f;
			animatorStateTransition37632.orderedInterruption = true;
			animatorStateTransition37632.isExit = false;
			animatorStateTransition37632.mute = false;
			animatorStateTransition37632.solo = false;
			animatorStateTransition37632.AddCondition(AnimatorConditionMode.Equals, 26f, "Slot0ItemID");
			animatorStateTransition37632.AddCondition(AnimatorConditionMode.Equals, 0f, "Slot0ItemStateIndex");
			animatorStateTransition37632.AddCondition(AnimatorConditionMode.Equals, 301f, "AbilityIndex");
			animatorStateTransition37632.AddCondition(AnimatorConditionMode.Equals, 1f, "AbilityIntData");

			var animatorStateTransition37634 = baseStateMachine1333564080.AddAnyStateTransition(equipFromAimLandAnimatorState37716);
			animatorStateTransition37634.canTransitionToSelf = false;
			animatorStateTransition37634.duration = 0.15f;
			animatorStateTransition37634.exitTime = 0.75f;
			animatorStateTransition37634.hasExitTime = false;
			animatorStateTransition37634.hasFixedDuration = true;
			animatorStateTransition37634.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition37634.offset = 0f;
			animatorStateTransition37634.orderedInterruption = true;
			animatorStateTransition37634.isExit = false;
			animatorStateTransition37634.mute = false;
			animatorStateTransition37634.solo = false;
			animatorStateTransition37634.AddCondition(AnimatorConditionMode.If, 0f, "Slot0ItemStateIndexChange");
			animatorStateTransition37634.AddCondition(AnimatorConditionMode.Equals, 26f, "Slot0ItemID");
			animatorStateTransition37634.AddCondition(AnimatorConditionMode.Equals, 4f, "Slot0ItemStateIndex");
			animatorStateTransition37634.AddCondition(AnimatorConditionMode.If, 0f, "Moving");
			animatorStateTransition37634.AddCondition(AnimatorConditionMode.If, 0f, "Aiming");
			animatorStateTransition37634.AddCondition(AnimatorConditionMode.Equals, 301f, "AbilityIndex");
			animatorStateTransition37634.AddCondition(AnimatorConditionMode.Equals, 1f, "AbilityIntData");

			var animatorStateTransition37636 = baseStateMachine1333564080.AddAnyStateTransition(unequipFromAimLandAnimatorState37714);
			animatorStateTransition37636.canTransitionToSelf = false;
			animatorStateTransition37636.duration = 0.15f;
			animatorStateTransition37636.exitTime = 0.75f;
			animatorStateTransition37636.hasExitTime = false;
			animatorStateTransition37636.hasFixedDuration = true;
			animatorStateTransition37636.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition37636.offset = 0f;
			animatorStateTransition37636.orderedInterruption = true;
			animatorStateTransition37636.isExit = false;
			animatorStateTransition37636.mute = false;
			animatorStateTransition37636.solo = false;
			animatorStateTransition37636.AddCondition(AnimatorConditionMode.If, 0f, "Slot0ItemStateIndexChange");
			animatorStateTransition37636.AddCondition(AnimatorConditionMode.Equals, 26f, "Slot0ItemID");
			animatorStateTransition37636.AddCondition(AnimatorConditionMode.Equals, 5f, "Slot0ItemStateIndex");
			animatorStateTransition37636.AddCondition(AnimatorConditionMode.If, 0f, "Moving");
			animatorStateTransition37636.AddCondition(AnimatorConditionMode.If, 0f, "Aiming");
			animatorStateTransition37636.AddCondition(AnimatorConditionMode.Equals, 301f, "AbilityIndex");
			animatorStateTransition37636.AddCondition(AnimatorConditionMode.Equals, 1f, "AbilityIntData");

			var animatorStateTransition37638 = baseStateMachine1333564080.AddAnyStateTransition(equipFromIdleLandAnimatorState37712);
			animatorStateTransition37638.canTransitionToSelf = false;
			animatorStateTransition37638.duration = 0.15f;
			animatorStateTransition37638.exitTime = 0.75f;
			animatorStateTransition37638.hasExitTime = false;
			animatorStateTransition37638.hasFixedDuration = true;
			animatorStateTransition37638.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition37638.offset = 0f;
			animatorStateTransition37638.orderedInterruption = true;
			animatorStateTransition37638.isExit = false;
			animatorStateTransition37638.mute = false;
			animatorStateTransition37638.solo = false;
			animatorStateTransition37638.AddCondition(AnimatorConditionMode.If, 0f, "Slot0ItemStateIndexChange");
			animatorStateTransition37638.AddCondition(AnimatorConditionMode.Equals, 26f, "Slot0ItemID");
			animatorStateTransition37638.AddCondition(AnimatorConditionMode.Equals, 4f, "Slot0ItemStateIndex");
			animatorStateTransition37638.AddCondition(AnimatorConditionMode.If, 0f, "Moving");
			animatorStateTransition37638.AddCondition(AnimatorConditionMode.IfNot, 0f, "Aiming");
			animatorStateTransition37638.AddCondition(AnimatorConditionMode.Equals, 301f, "AbilityIndex");
			animatorStateTransition37638.AddCondition(AnimatorConditionMode.Equals, 1f, "AbilityIntData");

			var animatorStateTransition37640 = baseStateMachine1333564080.AddAnyStateTransition(unequipFromIdleLandAnimatorState37710);
			animatorStateTransition37640.canTransitionToSelf = false;
			animatorStateTransition37640.duration = 0.15f;
			animatorStateTransition37640.exitTime = 0.75f;
			animatorStateTransition37640.hasExitTime = false;
			animatorStateTransition37640.hasFixedDuration = true;
			animatorStateTransition37640.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition37640.offset = 0f;
			animatorStateTransition37640.orderedInterruption = true;
			animatorStateTransition37640.isExit = false;
			animatorStateTransition37640.mute = false;
			animatorStateTransition37640.solo = false;
			animatorStateTransition37640.AddCondition(AnimatorConditionMode.If, 0f, "Slot0ItemStateIndexChange");
			animatorStateTransition37640.AddCondition(AnimatorConditionMode.Equals, 26f, "Slot0ItemID");
			animatorStateTransition37640.AddCondition(AnimatorConditionMode.Equals, 5f, "Slot0ItemStateIndex");
			animatorStateTransition37640.AddCondition(AnimatorConditionMode.If, 0f, "Moving");
			animatorStateTransition37640.AddCondition(AnimatorConditionMode.IfNot, 0f, "Aiming");
			animatorStateTransition37640.AddCondition(AnimatorConditionMode.Equals, 301f, "AbilityIndex");
			animatorStateTransition37640.AddCondition(AnimatorConditionMode.Equals, 1f, "AbilityIntData");

			var animatorStateTransition37642 = baseStateMachine1333564080.AddAnyStateTransition(dropWaterLandAnimatorState37708);
			animatorStateTransition37642.canTransitionToSelf = false;
			animatorStateTransition37642.duration = 0.1f;
			animatorStateTransition37642.exitTime = 0.75f;
			animatorStateTransition37642.hasExitTime = false;
			animatorStateTransition37642.hasFixedDuration = true;
			animatorStateTransition37642.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition37642.offset = 0f;
			animatorStateTransition37642.orderedInterruption = true;
			animatorStateTransition37642.isExit = false;
			animatorStateTransition37642.mute = false;
			animatorStateTransition37642.solo = false;
			animatorStateTransition37642.AddCondition(AnimatorConditionMode.If, 0f, "Slot0ItemStateIndexChange");
			animatorStateTransition37642.AddCondition(AnimatorConditionMode.Equals, 26f, "Slot0ItemID");
			animatorStateTransition37642.AddCondition(AnimatorConditionMode.Equals, 6f, "Slot0ItemStateIndex");
			animatorStateTransition37642.AddCondition(AnimatorConditionMode.If, 0f, "Moving");
			animatorStateTransition37642.AddCondition(AnimatorConditionMode.Equals, 301f, "AbilityIndex");
			animatorStateTransition37642.AddCondition(AnimatorConditionMode.Equals, 1f, "AbilityIntData");
		}
	}
}
