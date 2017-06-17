
using System.ComponentModel;
using System.Drawing;

namespace TerraLimb
{
    public struct Prefix
    {
        [DefaultValue(0)]
        public byte ID;
        [DefaultValue("(none)")]
        public string Name;
        public override string ToString()
        {
            if (Name != null)
                return Name;
            if (Constants.Loaded)
                return Constants.Prefixes[ID].Name;
            return string.Empty;
        }
    }
    public class Item
    {
        [DefaultValue(0)]
        private byte prefix;
        [DefaultValue(0)]
        public byte Prefix
        {
            get
            {
                return prefix;
            }
            set
            {
                if (value < 0 || value == 0xFF || value > Constants.Prefixes.Count)
                    prefix = 0;
                else
                    prefix = value;
            }
        }
        [DefaultValue(0)]
        private int stack;

        public bool IsFavorite { get; set; }

        [DefaultValue(-1)]
        public sbyte ShoeSlot { get; set; }
        [DefaultValue(-1)]
        public sbyte HandOffSlot { get; set; }
        [DefaultValue(-1)]
        public sbyte BalloonSlot { get; set; }
        [DefaultValue(-1)]
        public sbyte WaistSlot { get; set; }
        [DefaultValue(-1)]
        public sbyte HandOnSlot { get; set; }
        [DefaultValue(-1)]
        public sbyte FaceSlot { get; set; }
        [DefaultValue(-1)]
        public sbyte NeckSlot { get; set; }
        [DefaultValue(-1)]
        public sbyte WingSlot { get; set; }
        [DefaultValue(-1)]
        public sbyte FrontSlot { get; set; }
        [DefaultValue(-1)]
        public sbyte BackSlot { get; set; }
        [DefaultValue(-1)]
        public sbyte ShieldSlot { get; set; }
        [DefaultValue(-1)]
        public int HeadSlot { get; set; }
        [DefaultValue(-1)]
        public int BodySlot { get; set; }
        [DefaultValue(-1)]
        public int LegSlot { get; set; }

        [DefaultValue(0)]
        public int Stack
        {
            get { return stack; }
            set
            {
                if (value < 0)
                    stack = 0;
                else
                    stack = value;
            }
        }
        [DefaultValue("")]
        public string Nick;
        [DefaultValue("(none)")]
        public string ItemName;
        // ARGB
        [DefaultValue(null)]
        public int[] Color { get; set; }

        [DefaultValue(-1)]
        public int ItemID;

        [DefaultValue(0)]
        public int Index { get; set; }

        public int MaxStack { get; set; }


        public override string ToString()
        {
            if (ItemName != null)
                return ItemName;
            if (Constants.Loaded)
                return Constants.Items[ItemID].ItemName;
            return string.Empty;
        }

        public Color? GetColor()
        {
            if (Color != null)
                return System.Drawing.Color.FromArgb(Color[0], Color[1], Color[2], Color[3]);
            return null;
        }
    }
}