using Klyte.TransportLinesManager.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExpressBusServices_TLM
{
    public class DepartureChecker_TLM
    {
        public static bool TLM_StopIsTerminus(ushort stopID)
        {
            // could this be a TLM bus terminus?
            // architecture reversal: th main mod will read this value to decide things.
            return TLMStopDataContainer.Instance.SafeGet(stopID).IsTerminal;
        }
    }
}
