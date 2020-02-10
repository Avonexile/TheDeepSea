/// ---------------------------------------------
/// Ultimate Character Controller
/// Copyright (c) Opsive. All Rights Reserved.
/// https://www.opsive.com
/// ---------------------------------------------

using UnityEngine;
using UnityEditor.Animations;
using Opsive.UltimateCharacterController.AddOns.Shared.Editor;
using Opsive.UltimateCharacterController.Editor.Managers;

namespace Opsive.UltimateCharacterController.AddOns.Swimming.Editor
{
    /// <summary>
    /// Draws the inspector for the swimming add-on.
    /// </summary>
    [OrderedEditorItem("Swimming Pack", 3)]
    public class SwimmingAddOnInspector : AddOnInspector, IAbilityAddOnInspector
    {
        private GameObject m_Character;
        private AnimatorController m_AnimatorController;

        public GameObject Character { get { return m_Character; } set { m_Character = value; } }
        public AnimatorController AnimatorController { get { return m_AnimatorController; } set { m_AnimatorController = value; } }
        public AnimatorController FirstPersonAnimatorController { get { return null; } set { } }
        public string AddOnName { get { return "Swimming"; } }
        public string AbilityNamespace { get { return "Opsive.UltimateCharacterController.AddOns.Swimming"; } }
        public bool ShowFirstPersonAnimatorController { get { return false; } }

        /// <summary>
        /// Draws the add-on inspector.
        /// </summary>
        public override void DrawInspector()
        {
            AddOnInspectorUtility.DrawInspector(this);
        }
    }
}