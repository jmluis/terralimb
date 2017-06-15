using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using Newtonsoft.Json;
using System.IO;

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

        public static void Initialize(string path)
        {
            Items = JsonConvert.DeserializeObject<Dictionary<int, Item>>(File.ReadAllText(path + @"\items.json"));
            Prefixes = JsonConvert.DeserializeObject<Dictionary<int, Prefix>>(File.ReadAllText(path + @"\prefixes.json"));
            Buffs = JsonConvert.DeserializeObject<Dictionary<int, Buff>>(File.ReadAllText(path + @"\buffs.json"));
            Loaded = true;
        }
    }
}