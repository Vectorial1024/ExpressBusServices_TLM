using JetBrains.Annotations;
using TransportLinesManager.Data.DataContainers;

namespace ExpressBusServices_TLM
{
    [UsedImplicitly]
    public class DepartureChecker_TLM
    {
        [UsedImplicitly]
        public static bool TLM_StopIsTerminus(ushort stopID)
        {
            // could this be a TLM bus terminus?
            // architecture reversal: the main mod will read this value to decide things.
            return TLMStopDataContainer.Instance.SafeGet(stopID).IsTerminal;
        }
    }
}
