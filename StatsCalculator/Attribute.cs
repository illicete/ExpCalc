using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatsCalculator
{
  public class Attribute
    {
        public int Value;
        public string Name;
      
        public decimal Levelup(decimal levels)
        {
            decimal xpSpent = 0;

            while (Value < levels)
            { 
                Value++;
                xpSpent += (Value*2);

            }

            return xpSpent;
        }
        public Attribute(int value, string name)
        {

            this.Value = value;
            this.Name = name;
        }

    }
}
