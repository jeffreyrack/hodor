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
                answer = this.Operands[0];
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

        public enum Difficulty
        {
            Easy = 20,
            Medium = 100,
            Hard = 1000
        };

        public delegate Problem GenerateProblem(Difficulty diff);

        /*
         * Corey Paxton     - 3/20/2014 - Initial Version
         * Corey Paxton     - 3/20/2014 - Typecasted Difficulty enum
         */
        public static Problem AddProblem(Difficulty diff)
        {
            //2-5 terms
            Random rand = new Random();
            int numOfTerms = rand.Next(2, 6);
            List<ushort> terms = new List<ushort>();
            //int upperRange = 0;

            /*
            switch (diff)
            {
                case Difficulty.EASY: upperRange = 20;
                    break;
                case Difficulty.MEDIUM: upperRange = 100;
                    break;
                case Difficulty.HARD: upperRange = 1000;
                    break;
            }*/

            for (int i = 0; i < numOfTerms; i++)
            {
                terms.Add((ushort)rand.Next(0, (int)diff + 1));
            }

            return (new Problem(terms, Problem.Operator.Addition));
        }


        /*
         * Corey Paxton     - 3/20/2014 - Initial Version
         * Corey Paxton     - 3/20/2014 - Typecasted Difficulty enum
         */
        public static Problem SubProblem(Difficulty diff)
        {
            //2 terms
            Random rand = new Random();
            List<ushort> terms = new List<ushort>();
            ushort term1;
            ushort term2;

            term1 = (ushort)rand.Next(0, (int)diff + 1);
            term2 = (ushort)rand.Next(0, (int)diff + 1);

            //set the larger term as the first number in the problem
            if (term1 > term2)
            {
                terms.Add(term1);
                terms.Add(term2);
            }
            else
            {
                terms.Add(term2);
                terms.Add(term1);
            }
            return (new Problem(terms, Problem.Operator.Substraction));
        }

        public static bool AttemptAnswer(int answer, Problem p)
        {
            return (p.Answer() == (ushort)answer);
        }

        public static int CoinsGained(int streakCount)
        {
            int coins = 0;
            
            if (streakCount >= 5)
            {
                coins = 3;
            }
            else if (streakCount >= 3)
            {
                coins = 2;
            }
            else
            {
                coins = 1;
            }

            return coins;
        }
    }

    

}
