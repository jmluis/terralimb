using System.Collections.Generic;
using Newtonsoft.Json;

namespace TerraLimb
{
    public static class Constants
    {
        public const int TERRARIA_RELEASE = 0xBC; // curRelease = 188
        public const string TERRARIA_STRING = "1.3.4.4";
        public static bool Loaded = false;

        public static Dictionary<int, Item> Items;
        public static Dictionary<int, Prefix> Prefixes;
        public static Dictionary<int, Buff> Buffs;

        public static void Initialize(string ItemJson, string PrefixJson, string BuffJson)
        {
            Items = JsonConvert.DeserializeObject<Dictionary<int, Item>>(ItemJson);
            Prefixes = JsonConvert.DeserializeObject<Dictionary<int, Prefix>>(PrefixJson);
            Buffs = JsonConvert.DeserializeObject<Dictionary<int, Buff>>(BuffJson);
            Loaded = true;
        }
    }
}