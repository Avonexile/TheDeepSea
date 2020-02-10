/// ---------------------------------------------
/// Ultimate Character Controller
/// Copyright (c) Opsive. All Rights Reserved.
/// https://www.opsive.com
/// ---------------------------------------------

using UnityEngine;
using UnityEditor;
using UnityEditor.Animations;
using Opsive.UltimateCharacterController.Editor.Managers;
using Opsive.UltimateCharacterController.Editor.Inspectors.Character;
using Opsive.UltimateCharacterController.Editor.Inspectors.Utility;

namespace Opsive.UltimateCharacterController.AddOns.Shared.Editor
{
    /// <summary>
    /// Shared methods for drawing the ability animation options.
    /// </summary>
    public static class AddOnInspectorUtility
    {
        private static IAbilityAddOnInspector s_AddOnInspector;

        /// <summary>
        /// Draws the add-on inspector.
        /// </summary>
        public static void DrawInspector(IAbilityAddOnInspector addOnInspector)
        {
            s_AddOnInspector = addOnInspector;

            ManagerUtility.DrawControlBox(s_AddOnInspector.AddOnName + " Animations", DrawCharacterSelection, "This option will add the " + s_AddOnInspector.AddOnName.ToLower() + " animations to your animator controller.",
                            s_AddOnInspector.AnimatorController != null, "Add Animations", AddAnimations, "The animations were successfully added.");
        }

        /// <summary>
        /// Draws the additional controls for the animator.
        /// </summary>
        private static void DrawCharacterSelection()
        {
            EditorGUI.BeginChangeCheck();
            s_AddOnInspector.Character = EditorGUILayout.ObjectField("Character", s_AddOnInspector.Character, typeof(GameObject), true) as GameObject;
            if (EditorGUI.EndChangeCheck()) {
                s_AddOnInspector.AnimatorController = null;
                if (s_AddOnInspector.Character != null) {
                    var animator = s_AddOnInspector.Character.GetComponent<Animator>();
                    if (animator != null) {
                        s_AddOnInspector.AnimatorController = (AnimatorController)animator.runtimeAnimatorController;
                    }
#if FIRST_PERSON_CONTROLLER
                    var firstPersonBaseObjects = s_AddOnInspector.Character.GetComponentsInChildren<FirstPersonController.Character.Identifiers.FirstPersonBaseObject>(true);
                    if (firstPersonBaseObjects != null && firstPersonBaseObjects.Length > 0) {
                        var firstPersonBaseObject = firstPersonBaseObjects[0];
                        // Choose the base object with the lowest ID.
                        for (int i = 1; i < firstPersonBaseObjects.Length; ++i) {
                            if (firstPersonBaseObjects[i].ID < firstPersonBaseObject.ID) {
                                firstPersonBaseObject = firstPersonBaseObjects[i];
                            }
                        }

                        animator = firstPersonBaseObject.GetComponent<Animator>();
                        if (animator != null) {
                            s_AddOnInspector.FirstPersonAnimatorController = (AnimatorController)animator.runtimeAnimatorController;
                        }
                    }
#endif
                }
            }

            if (s_AddOnInspector.Character != null) {
                EditorGUI.indentLevel++;
                s_AddOnInspector.AnimatorController = ClampAnimatorControllerField("Animator Controller", s_AddOnInspector.AnimatorController, 33);
#if FIRST_PERSON_CONTROLLER
                if (s_AddOnInspector.ShowFirstPersonAnimatorController) {
                    s_AddOnInspector.FirstPersonAnimatorController = ClampAnimatorControllerField("First Person Animator", s_AddOnInspector.FirstPersonAnimatorController, 23);
                }
#endif
                EditorGUI.indentLevel--;
            }
            GUILayout.Space(5);
        }

        /// <summary>
        /// Adds the animations to the animator controllers.
        /// </summary>
        private static void AddAnimations()
        {
            var types = InspectorDrawerUtility.GetAllTypesWithinNamespace(s_AddOnInspector.AbilityNamespace);
            if (types == null) {
                return;
            }

            // Call BuildAnimator on all of the inspector drawers for the abilities.
            for (int i = 0; i < types.Count; ++i) {
                var inspectorDrawer = InspectorDrawerUtility.InspectorDrawerForType(types[i]) as AbilityInspectorDrawer;
                if (inspectorDrawer == null || !inspectorDrawer.CanBuildAnimator) {
                    continue;
                }

                inspectorDrawer.BuildAnimator(s_AddOnInspector.AnimatorController, s_AddOnInspector.FirstPersonAnimatorController);
            }
        }

        /// <summary>
        /// Prevents the label from being too far away from the object field.
        /// </summary>
        /// <param name="label">The animator controller label.</param>
        /// <param name="animatorController">The animator controller value.</param>
        /// <param name="widthAddition">Any additional width to separate the label and the control.</param>
        /// <returns>The new animator controller.</returns>
        private static AnimatorController ClampAnimatorControllerField(string label, AnimatorController animatorController, int widthAddition)
        {
            var textDimensions = GUI.skin.label.CalcSize(new GUIContent(label));
            var prevLabelWidth = EditorGUIUtility.labelWidth;
            EditorGUIUtility.labelWidth = textDimensions.x + widthAddition;
            animatorController = EditorGUILayout.ObjectField(label, animatorController, typeof(AnimatorController), true) as AnimatorController;
            EditorGUIUtility.labelWidth = prevLabelWidth;
            return animatorController;
        }
    }
}