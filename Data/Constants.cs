using System.Collections.Generic;
using Newtonsoft.Json;

namespace TerraLimb
{
    public struct Package
    {
        public string Version;
        public int TerrariaVersion;
        public string TerrariaVersionString;
        public int ProjectNo;
        public int RevNo;
    }

    public static class Constants
    {
        public static Package CurrentPackage;
        public static bool Loaded = false;

        public static Dictionary<int, Item> Items;
        public static Dictionary<int, Prefix> Prefixes;
        public static Dictionary<int, Buff> Buffs;

        public static void Initialize(string PackageJson, string ItemJson, string PrefixJson, string BuffJson)
        {
            CurrentPackage = JsonConvert.DeserializeObject<Package>(PackageJson);
            Items = JsonConvert.DeserializeObject<Dictionary<int, Item>>(ItemJson);
            Prefixes = JsonConvert.DeserializeObject<Dictionary<int, Prefix>>(PrefixJson);
            Buffs = JsonConvert.DeserializeObject<Dictionary<int, Buff>>(BuffJson);
            Loaded = true;
        }
    }
}