using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSUSM.CS441.SheriffHodor.Data
{
    class Group
    {
        #region Definitions
        public List<User> members { get; set; }
        public string name { get; set; }
        #endregion

        /*
         *Corey Paxton      - 3/21/2014 - Initial Version 
         */
        public override string ToString()
        {
            StringBuilder rtnStr = new StringBuilder();

            rtnStr.AppendFormat("{0}:\n", this.name);
            foreach (var mem in members)
            {
                rtnStr.AppendLine(mem.ToString());
            }

            return rtnStr.ToString();
        }
    }
}
