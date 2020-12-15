using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BepInEx;
using BepInEx.Configuration;

namespace PC_Optimizer
{
    [BepInPlugin("kuule72.plugins.playclub_optimizer", "PC_Optimizer", "1.0.0.0")]
    [BepInProcess("PlayClub.exe")]
    [BepInProcess("PlayClubStudio.exe")]
    public class PC_Optimizer: BaseUnityPlugin
    {
        private ConfigEntry<bool> configCloseUIOutline;

        // Awake is called once when both the game and the plug-in are loaded
        void Awake()
        {
            configCloseUIOutline = Config.Bind("General.Toggles",
                                            "CloseUIOutline",
                                            true,
                                            "Whether to close the Outline of UI text");

            Logger.LogInfo("PC_Optimizer Awake!");
        }
    }
}
