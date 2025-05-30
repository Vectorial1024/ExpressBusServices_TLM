using ICities;
using JetBrains.Annotations;

namespace ExpressBusServices_TLM
{
    [UsedImplicitly]
    public class ExpressBusServices_TLM : LoadingExtensionBase, IUserMod
    {
        public virtual string Name => "Express Bus Services (TLM plugin: t1a2l variation)";

        public virtual string Description => "Reads information from TLM termini settings to help the main mod.";
    }
}
