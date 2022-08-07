using ExpressBusServices;
using HarmonyLib;
using Klyte.TransportLinesManager.Extensions;
using UnityEngine;

namespace ExpressBusServices_TLM
{
    // [HarmonyPatch(typeof(DepartureChecker))]
    //  [HarmonyPatch("StopIsConsideredAsTerminus", MethodType.Normal)]
    public class Patch_DepartureChecker_ForTLM
    {
        // post fix the "is this a terminus stop" to cater for TLM terminus cases
        [HarmonyPostfix]
        public static void PostFix(ref bool __result, ushort stopID)
        {
            // could this be a TLM bus terminus?
            // note that the first stop in line is not a "terminus by computation"; instead, it is a "terminus by definition"
            // and so if we use this "terminus by computation" method, we will not read first stops correctly.
            // we will also need to preserve the value from our base mod
            __result |= TLMStopDataContainer.Instance.SafeGet(stopID).IsTerminal;
        }
    }
}
