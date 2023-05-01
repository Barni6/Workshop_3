using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop_3
{
    public class Army
    {
      
        public string TrooperName { get; set; }
        public int Power { get; set; }
        public int Vitality { get; set; }
        public int Cost { get; set; }
     

        public int Money()
        {
            return Power * Vitality * Cost;
        }

        public override string ToString()
        {
            return TrooperName;
        }
    }
}
