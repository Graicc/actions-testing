using System;
using BepInEx;
using UnityEngine;

namespace actions_testing
{
    [BepInPlugin(PluginInfo.GUID, PluginInfo.Name, PluginInfo.Version)]
    public class Plugin : BaseUnityPlugin
    {
        void Awake()
		{
            HarmonyPatches.ApplyHarmonyPatches();
		}

        void Update()
		{

		}
    }
}
