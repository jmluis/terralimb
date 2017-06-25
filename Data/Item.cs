
using System.ComponentModel;
using System.Drawing;

namespace TerraLimb
{
    public struct Prefix
    {
        [DefaultValue(0xFF)]
        public byte ID;
        [DefaultValue("")]
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
    public struct Item
    {

        #region Prefixes
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
        #endregion

        #region  Names
        [DefaultValue("")]
        public string Nick;
        [DefaultValue("")]
        public string ItemName { get; set; }
        #endregion

        #region Stack
        [DefaultValue(0)]
        private int stack;
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
        public int MaxStack { get; set; }

        #endregion

        #region Properties

        [DefaultValue(-1)]
        public int ItemID;

        [DefaultValue(0)]
        public int Index { get; set; }

        public bool IsFavorite { get; set; }
        // ARGB
        [DefaultValue(null)]
        public int[] Color { get; set; }

        #endregion

        #region CharacterSlot
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
        #endregion

        public static implicit operator Item(int id)
        {
            return new Item()
            {
                BackSlot = -1,
                BalloonSlot = -1,
                BodySlot = -1,
                FaceSlot = -1,
                FrontSlot = -1,
                HandOffSlot = -1,
                HandOnSlot = -1,
                HeadSlot = -1,
                LegSlot = -1,
                NeckSlot = -1,
                ShieldSlot = -1,
                ShoeSlot = -1,
                WaistSlot = -1,
                WingSlot = -1,

                Color = new[] { 0, 0, 0 },
                IsFavorite = false,
                Index = 0,
                ItemID = id,
                ItemName = "(none)",
                MaxStack = 0,
                Nick = "",

                Prefix = 0,

                Stack = 0
            };
        }
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