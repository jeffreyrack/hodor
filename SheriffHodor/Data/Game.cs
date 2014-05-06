/* Game.cs
 * 
 * Version - 3.0.1 - 4/29/2014 - Jeffrey Rackauckas  - Adding coins to a user now uses addCoins instead of accessing the coins directly.
 * Version - 3.0.0 - 4/24/2014 - Jeffrey Rackauckas - Initial Version.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSUSM.CS441.SheriffHodor.Data
{
    public class Game
    {
        public Problem currentProblem { get; set; }
        public int totalProblems { get; set; }
        public int currentProblemIndex { get; set; }
        public Problem.Difficulty testDiff { get; set; }
        public Data.Problem.GenerateProblem problemHandler { get; set; }
        public int correctAnswers { get; set; }
        public int correctStreak { get; set; }
        public int coinsGained { get; set; }
        public int problemTime { get; set; }


        // Created by Jeffrey Rackauckas
        // Create Date: 04/24/2014
        // The new Game class needs a constructer!
        public Game(User user)
        {

            Random rand = new Random();

            this.totalProblems = rand.Next(10, 31);
            this.currentProblemIndex = 0;
            this.correctAnswers = 0;
            this.correctStreak = 0;
            this.coinsGained = 0;
            this.problemTime = 0;

            //Addition or Subtraction problems
            if (rand.Next(0, 2) > 0)
            {
                this.problemHandler = Problem.AddProblem;
            }
            else
            {
                this.problemHandler = Problem.SubProblem;
            }

            //this.testDiff = Problem.Difficulty.Easy;
            if (user.GroupName != null)
            {
                this.testDiff = GroupList.Instance.GetByName(user.GroupName).Difficulty;
            }
            else
            {
                this.testDiff = Problem.Difficulty.Easy;
            }
            this.currentProblem = this.problemHandler(this.testDiff);
        }

        public static void CorrectAnswer(Game game, User CurrentUser)
        {
            game.correctAnswers++;
            game.correctStreak++;
            //display the coin change next to coins
            int thisProblemCoins = CoinsEarned(game.correctStreak);
            CurrentUser.addCoins(thisProblemCoins);
 //         currentUser.Data.coinsGained += thisProblemCoins;
            game.coinsGained += thisProblemCoins;
        }

        public static int CoinsEarned(int correctStreak)
        {
            if (correctStreak >= 5)
            {
                return 3;
            }
            else if (correctStreak == 3 || correctStreak == 4)
            {
                return 2;
            }
                
            return 1;
        }
        
    }
}
