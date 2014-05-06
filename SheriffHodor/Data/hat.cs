/* Hat.cs
 * 
 * 
 * Version - 3.0.0 - 4/30/2014 - Jeffrey Rackauckas - Initial Release/Draft.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSUSM.CS441.SheriffHodor.Data
{
    public class Hat
    {
        public int Tier { get; set; }
        public int Number { get; set; }

        public Hat()
        {
            this.Tier = 0;
            this.Number = 0;
        }
        public Hat(int tier, int number)
        {
            this.Tier = tier;
            this.Number = number;
        }

        public int getPrice()
        {
            if (this.Tier == 1) return 100;
            else if (this.Tier == 2) return 150;
            else return 200;
        }
    }
}
