using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSUSM.CS441.SheriffHodor.Data
{
    public class Problem
    {
        public Problem()
        {
            this.Operands = new List<ushort>();
            this.op = Operator.Addition;
        }

        public Problem(List<ushort> terms, Operator op)
        {
            this.Operands = terms;
            this.op = op;
        }

        public enum Operator : ushort
        {
            Addition = 0,
            Substraction = 1
        }

        public List<ushort> Operands { get; set; }
        public Operator op { get; set; }

        /*
         * Corey Paxton     - 3/17/2014 - Initial Version 
         */
        public override string ToString()
        {
            string[] OperatorString = { "+", "-" };
            System.Text.StringBuilder returnStr = new System.Text.StringBuilder();
            returnStr.Append(Operands[0]);
            for (var i = 1; i < Operands.Count; ++i)
            {
                returnStr.AppendFormat(" {0} {1}", OperatorString[(ushort)op], Operands[i]);
            }
            return (returnStr.ToString());
        }

        /*
         * Corey Paxton     - 3/20/2014 - Initial Version
         */
        public ushort Answer()
        {
            ushort answer = 0;
            if (this.Operands.Count > 1)
            {
                answer = this.Operands[1];
            }

            for (int i = 1; i < this.Operands.Count; i++)
            {
                if (this.op == Operator.Addition)
                {
                    answer += this.Operands[i];
                }
                else
                {
                    answer -= this.Operands[i];
                }
            }

            return answer;
        }
    }

}
