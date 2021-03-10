using System;
using System.Reflection;
using BepInEx;
using BepInEx.Configuration;
using HarmonyLib;
using System.IO;

namespace fastferment
{
    [BepInPlugin(MID, NAME, VERSION)]
    internal class FastFerment : BaseUnityPlugin
    {
        private const string MID = "valheim.mod.fastferment";
        private const string NAME = "Fast Ferment";
        private const string VERSION = "1.0.0.0";
        private const string author = "Fang86";

        private static ConfigFile configFile = new ConfigFile(Path.Combine(Paths.ConfigPath, "fastferment.cfg"), true);
        private static ConfigEntry<float> duration = configFile.Bind("General", "duration", 1f, "The amount of time it takes for the fermenter to ferment");

        void Awake()
        {
            Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), null);

            Logger.LogInfo($"Fast Ferment mod - Created by {author}");
        }

        [HarmonyPatch(typeof(Fermenter), "Awake")]
        public static class Patcher
        {
            private static void Prefix(ref Fermenter __instance)
            {
                __instance.m_fermentationDuration = FastFerment.duration.Value;
            }
        }
    }
}
