using ExpressBusServices;
using HarmonyLib;
using Klyte.TransportLinesManager.Extensions;
using UnityEngine;

namespace ExpressBusServices_TLM
{
    [HarmonyPatch(typeof(DepartureChecker))]
    [HarmonyPatch("StopIsTerminus", MethodType.Normal)]
    public class Patch_DepartureChecker_ForTLM
    {
        // post fix the "is this a terminus stop" to cater for TLM terminus cases
        [HarmonyPostfix]
        public static void PostFix(ref bool __result, ushort stop)
        {
            // could this be a TLM bus terminus?
            __result = TLMStopDataContainer.Instance.SafeGet(stop).IsTerminal;
        }
    }
}
