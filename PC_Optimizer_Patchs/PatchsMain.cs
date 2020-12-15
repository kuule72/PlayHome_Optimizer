using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HarmonyLib;
using System.Reflection;

namespace PC_Optimizer_Patchs
{
    public class PatchsMain
    {
        public static void Main(string[] args)
        {
            // Actual patching is just a one-liner!
           // Harmony.CreateAndPatchAll(typeof(PatchsMain));
        }

        //[HarmonyPatch(typeof(UnityEngine.UI.Outline), "ModifyVertices")] // Specify target method with HarmonyPatch attribute
        //[HarmonyPrefix]                              // There are different patch types. Prefix code runs before original code
        //static bool ModifyVertices()
        //{
        //    return false; // Returning false in prefix patches skips running the original code
        //}

    }
}
