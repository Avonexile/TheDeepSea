/// ---------------------------------------------
/// Ultimate Character Controller
/// Copyright (c) Opsive. All Rights Reserved.
/// https://www.opsive.com
/// ---------------------------------------------

#if UNITY_WEBGL || UNITY_IOS || UNITY_ANDROID || UNITY_WII || UNITY_WIIU || UNITY_SWITCH || UNITY_PS3 || UNITY_PS4 || UNITY_XBOXONE || UNITY_WSA
using UnityEngine;
using System;
using Opsive.UltimateCharacterController.StateSystem;

namespace Opsive.UltimateCharacterController.AddOns.Swimming
{
    // See Opsive.UltimateCharacterController.StateSystem.AOTLinker for an explanation of this class.
    public class AOTLinker : MonoBehaviour
    {
        public void Linker()
        {
#pragma warning disable 0219
            var waterHeightDetectionGenericDelegate = new Preset.GenericDelegate<Swim.WaterHeightDetection>();
            var waterHeightDetectionFuncDelegate = new Func<Swim.WaterHeightDetection>(() => { return 0; });
            var waterHeightDetectionActionDelegate = new Action<Swim.WaterHeightDetection>((Swim.WaterHeightDetection value) => { });
#pragma warning restore 0219
        }
    }
}
#endif