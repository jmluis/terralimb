using System.ComponentModel;

namespace TerraLimb
{
    public class Buff
    {
        [DefaultValue(-1)]
        public int BuffID;
        [DefaultValue(0)]
        public int BuffTime;
        [DefaultValue(0)]
        public int Slot;

        [DefaultValue(null)]
        public string BuffName;
        [DefaultValue(null)]
        public string BuffDescription;

        public Buff()
        {
        }

        public Buff(int id, int time, int slot)
        {
            Slot = slot;
            BuffID = id;

            if (time < 0)
                BuffTime = 0;
            else
                BuffTime = time;
            BuffName = Constants.Buffs[BuffID].BuffName;
            BuffDescription = Constants.Buffs[BuffID].BuffDescription;
        }

        public override string ToString()
        {
            return BuffName;
        }
    }
}

