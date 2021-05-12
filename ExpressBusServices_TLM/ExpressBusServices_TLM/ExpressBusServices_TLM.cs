﻿using CitiesHarmony.API;
using ICities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExpressBusServices_TLM
{
    public class ExpressBusServices_TLM : LoadingExtensionBase, IUserMod
    {
        public virtual string Name
        {
            get
            {
                return "Express Bus Services (TLM plugin)";
            }
        }

        public virtual string Description
        {
            get
            {
                return "Reads information from TLM termini settings to help the main mod.";
            }
        }

        /// <summary>
        /// Executed whenever a level completes its loading process.
        /// This mod the activates and patches the game using Hramony library.
        /// </summary>
        /// <param name="mode">The loading mode.</param>
        public override void OnLevelLoaded(LoadMode mode)
        {
            /*
             * This function can still be called when loading up the asset editor,
             * so we have to check where we are right now.
             */

            switch (mode)
            {
                case LoadMode.LoadGame:
                case LoadMode.NewGame:
                case LoadMode.LoadScenario:
                case LoadMode.NewGameFromScenario:
                    break;

                default:
                    return;
            }

            // we write settings first so that settings can be updated in case harmony fails
            UnifyHarmonyVersions();
            PatchController.Activate();
        }

        /// <summary>
        /// Executed whenever a map is being unloaded.
        /// This mod then undoes the changes using the Harmony library.
        /// </summary>
        public override void OnLevelUnloading()
        {
            // we write settings first so that settings can be updated in case harmony fails
            UnifyHarmonyVersions();
            PatchController.Deactivate();
        }

        private void UnifyHarmonyVersions()
        {
            if (HarmonyHelper.IsHarmonyInstalled)
            {
                // this code will redirect our Harmony 2.x version to the authoritative version stipulated by CitiesHarmony
                // I will make it such that the game will throw hard error if Harmony is not found,
                // as per my usual software deployment style
                // the user will have to subscribe to Harmony by themselves. I am not their parent anyways.
                // so this block will have to be empty.
            }
        }
    }
}
