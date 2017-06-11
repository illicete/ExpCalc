using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatsCalculator
{
   public class Skill
    {
        public int Value;
        public string Name;
        public List<Attribute> AttributeReqs;
        public decimal Levelup(decimal levels, Character character)
        {
            decimal xpSpent = 0;
            for (int i = 0; i < levels; i++)
            {
                Value++;
                xpSpent += (Value);

            }

            foreach (Attribute att in AttributeReqs) {
                xpSpent += att.Levelup(Math.Floor(levels));
            }

            return xpSpent;
        }




    }
}
