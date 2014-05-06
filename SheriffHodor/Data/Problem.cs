/* Problem.cs
 * Purpose: Contain all information related to a specific problem in a game.
 * 
 * Version - 3.0.1 - 4/24/2014 - Jeffrey Rackauckas - Moved things directly related to the game into the new Game.cs class.
 * Version - 3.0.0 - Cycle 2 Release
 */
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
            Subtraction = 1
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
         * Corey Paxton     - 4/3/2014 - Initial Version
         */
        public string TopToBottomString()
        {
            string[] OperatorString = { "+", "-" };
            System.Text.StringBuilder returnStr = new System.Text.StringBuilder();

            for (int i = 0; i < 5 - Operands.Count; i++)
            {
                returnStr.AppendLine();
            }
            for (int i = 0; i < Operands.Count - 1; i++)
            {
                returnStr.AppendFormat("  {0,5}\n", Operands[i]);
            }
            returnStr.AppendFormat("{0}{1,5}\n", OperatorString[(ushort)op], Operands[Operands.Count - 1]);

            return (returnStr.ToString());
        }

        public enum NumberRepresentation
        {
            Dots = 1,
            Dashes = 10,
            Squares = 100
        };

        private string RepeatNumberRepresent(int repeatTimes, NumberRepresentation numberType)
        {
            System.Text.StringBuilder returnStr = new System.Text.StringBuilder();

            int temp = repeatTimes;
            string repeatStr = String.Empty;

            switch (numberType)
            {
                case NumberRepresentation.Dots: repeatStr = ". ";
                    break;
                case NumberRepresentation.Dashes: repeatStr = "| ";
                    break;
                case NumberRepresentation.Squares: repeatStr = "[] ";
                    break;
            }
            if (temp > 0)
            {
                while ((temp - 10) > 0)
                {
                    returnStr.AppendLine(String.Concat(Enumerable.Repeat(repeatStr, 10)));
                    temp -= 10;
                }

                returnStr.Append(String.Concat(Enumerable.Repeat(repeatStr, temp)));
                returnStr.AppendFormat("={0}\n", repeatTimes * (int)numberType);
            }

            return (returnStr.ToString());
        }

        /*
         * Corey Paxton     - 4/3/2014 - Initial Version
         * Corey Paxton     - 4/6/2014 - Fixed to common core standards
         */
        //TODO make this work with subtraction too
        public string DrawingRepresentation(int num)
        {
            System.Text.StringBuilder returnStr = new System.Text.StringBuilder();
            int dots = 0;
            int dashes = 0;
            int squares = 0;
            int tempOp;

            //get each digit of the number
            dots = num % 10;
            if ((tempOp = (num / 10)) > 0)
            {
                dashes = tempOp % 10;

                if ((tempOp = (tempOp / 10)) > 0)
                {
                    squares = tempOp % 10;
                }

            }
            returnStr.Append(RepeatNumberRepresent(dots, NumberRepresentation.Dots));
            returnStr.Append(RepeatNumberRepresent(dashes, NumberRepresentation.Dashes));
            returnStr.Append(RepeatNumberRepresent(squares, NumberRepresentation.Squares));

            return (returnStr.ToString());
        }

        /* Removed By: Jeffrey Rackauckas
         *  Removed On: 5/4/2014
         * Was removed from the SRS, so we don't need the function anymore.
        public string DrawingRepresentation()
        {
            System.Text.StringBuilder returnStr = new System.Text.StringBuilder();

            if (this.op == Operator.Addition)
            {
                returnStr.AppendFormat("{0}\nAnswer: {1}", DrawingRepresentation((int)this.Answer()), this.Answer().ToString());
            }
            else if (this.op == Operator.Subtraction)
            {
                for (int i = 0; i < Operands.Count; i++)
                {
                    returnStr.Append(DrawingRepresentation(Operands[i]));
                    if (i < Operands.Count - 1)
                    {
                        returnStr.AppendLine("MINUS");
                    }
                    else
                    {
                        returnStr.AppendLine("EQUALS");
                        returnStr.AppendFormat("{0}\nAnswer: {1}", DrawingRepresentation((int)this.Answer()), this.Answer().ToString());
                    }
                }
                //get each digit of the number
                /*dots = Operands[0] % 10;
                returnStr.Append(RepeatNumberRepresent(dots, NumberRepresentation.Dots));
                returnStr.AppendLine("-");
                dots = Operands[1] % 10;
                returnStr.Append(RepeatNumberRepresent(dots, NumberRepresentation.Dots));*/

                /*
                if ((tempOp = (Operands[0] / 10)) > 0)
                {
                    dashes = tempOp % 10;
                    returnStr.Append(RepeatNumberRepresent(dashes, NumberRepresentation.Dashes));
                    if ((tempOp = (Operands[1] / 10)) > 0)
                    {
                        returnStr.AppendLine("-");
                        tempOp = tempOp % 10;
                        returnStr.Append(RepeatNumberRepresent(tempOp, NumberRepresentation.Dashes));
                    }

                    if ((tempOp = (Operands[0] / 10)) > 0)
                    {
                        squares = tempOp % 10;
                        returnStr.Append(RepeatNumberRepresent(squares, NumberRepresentation.Squares));
                        if ((tempOp = (Operands[1] / 10)) > 0)
                        {
                            returnStr.AppendLine("-");
                            tempOp = tempOp % 10;
                            returnStr.Append(RepeatNumberRepresent(tempOp, NumberRepresentation.Squares));
                        }

                    }
                }
            }

            return (returnStr.ToString());
        }
        */
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
         * Jeffrey Rackauckas - 5/4/2014 - Changed diff to be the max of the answer, not operand.
         */
        public static Problem AddProblem(Difficulty diff)
        {
            //2-5 terms
            Random rand = new Random();
            int numOfTerms = rand.Next(2, 6);
            List<ushort> terms = new List<ushort>();
            int total = 0;
            for (int i = 0; i < numOfTerms; i++)
            {
                //terms.Add( (ushort)rand.Next(0, ((int)(diff) / (numOfTerms/2) ) + 1) );
                terms.Add((ushort)rand.Next(0, (int)(diff) + 1));
                total += terms.ElementAt(i);
            }
            while(total > ((int) diff))
            {
                int toReduce = rand.Next(0, numOfTerms - 1);
                ushort originalAmount = terms.ElementAt(toReduce);
                ushort reduceAmount = (ushort)rand.Next(0, originalAmount);
                terms.RemoveAt(toReduce);
                terms.Add((ushort)(originalAmount - reduceAmount));
                total -= reduceAmount;
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
            return (new Problem(terms, Problem.Operator.Subtraction));
        }

        public static bool AttemptAnswer(int answer, Problem p)
        {
            return (p.Answer() == (ushort)answer);
        }

        // Moved by Jeffrey Rackauckas
        // Moved on 4/24/2014
        // Moved to Game.cs
        /*
        public static int CoinsGained(int streakCount)
        {
            int coins = 0;

            if (streakCount >= 5)
            {
                coins = 2;
            }
            else if (streakCount == 3)
            {
                coins = 2;
            }
            else
            {
                coins = 1;
            }

            return coins;
        }
         */
    }



}
