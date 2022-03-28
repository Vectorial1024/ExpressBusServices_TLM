using ExpressBusServices;
using HarmonyLib;
using Klyte.TransportLinesManager.Extensions;
using UnityEngine;

namespace ExpressBusServices_TLM
{
    [HarmonyPatch(typeof(DepartureChecker))]
    [HarmonyPatch("StopIsConsideredAsTerminus", MethodType.Normal)]
    public class Patch_DepartureChecker_ForTLM
    {
        // post fix the "is this a terminus stop" to cater for TLM terminus cases
        [HarmonyPrefix]
        public static bool PreFix(ref bool __result, ushort stopID)
        {
            // could this be a TLM bus terminus?
            __result = TLMStopDataContainer.Instance.SafeGet(stopID).IsTerminal;
            return false;
        }
    }
}
