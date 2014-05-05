using CSUSM.CS441.SheriffHodor.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CSUSM.CS441.SheriffHodor.GUI
{
    /// <summary>
    /// The game screen: this is the screen students see when they are taking a test.
    /// It receive an already populated User as input, and mutate it to pass it to
    /// the next GameScreen (or GameErrorScreen, or GameEndScreen).
    /// </summary>
    public partial class GameScreen : StateControl
    {
        public GameScreen()
        {
            InitializeComponent();
            //this.AcceptButton = this.btn_next;
            //txt_answer.Focus();
            this.txt_answer.KeyPress += new KeyPressEventHandler(answerValidator);
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            this.gbox_problem.BackColor = Global.opaqueBackground;
        }

        #region UI
        /*
         * Matthias Lang    - 3/17/2014 - Initial Version
         * Corey Paxton     - 3/17/2014 - Beginning of making it work with refactor
         * Corey Paxton     - 3/20/2014 - Setup new problem generator
         * Corey Paxton     - 3/24/2014 - Made it so the text field is active
         * Corey Paxton     - 3/24/2014 - Added coin stuff
         * Corey Paxton     - 4/3/2014 - Equation and top to bottom form
         * Jeffrey Rackauckas - 4/24/2014 - Refactored for the new Game.cs Data class.
         */
        public override void Entered(StateControl from, Data.User user, Data.User returnUser)
        {
            base.Entered(from, user, returnUser);
            // TODO this isnt working the first time it enters the screen unless you click the screen
            // Make the text field active
            this.ActiveControl = txt_answer;
            this.AcceptButton = this.btn_next;
            txt_answer.Focus();

            user.Data.game.problemTime = 0;
            timer1.Start();


            txt_answer.Text = String.Empty;

            //display the counter
            lbl_index.Text = string.Format("Question: {0} / {1}", (user.Data.game.currentProblemIndex + 1), user.Data.game.totalProblems);

            //structure the format of the problem as an equation or top to bottom
            Random displayRandomizer = new Random();
            if (displayRandomizer.Next(0, 2) == 0)
            {
                //equation form
                lbl_problem.Text = String.Format("\n\n\n\n{0}", this.CurrentUser.Data.game.currentProblem.ToString());
            }
            else
            {
                //top to bottom form
                lbl_problem.Text = this.CurrentUser.Data.game.currentProblem.TopToBottomString();
            }

            lbl_coins.Text = string.Format("Coins: {0}", this.CurrentUser.Coins.ToString());
        }

        /*
         * Corey Paxton     - 4/3/2014 - Initial Version
         */
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.CurrentUser.Data.game.problemTime++;
            if (this.CurrentUser.Data.game.problemTime == 1)
            {
                lbl_coinsGained.Visible = false;
                if (this.CurrentUser.Data.game.correctStreak > 0)
                {
                    lbl_Responses.Visible = false;
                }
            }
        }

        /*
         * Matthias Lang    - 3/17/2014 - Initial Version
         * Corey Paxton     - 3/24/2014 - Made it so enter pressed button
         */
        private void answerValidator(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                btn_next_Click(sender, e);
            }
            e.Handled = !(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar));
        }

        /*
         * 
         * Corey Paxton     - 3/17/2014 - Initial Version
         * Corey Paxton     - 3/20/2014 - Expanding still unfinished
         * Corey Paxton     - 3/24/2014 - Added coin stuff
         * Corey Paxton     - 3/27/2014 - Refactored to Accept()
         */
        private void btn_next_Click(object sender, EventArgs e)
        {
            if (txt_answer.Text.Length > 0 && this.CurrentUser != null)
            {
                Accept();
            }
        }

        /*
         * Corey Paxton     - 3/27/2014 - Initial Version
         * Corey Paxton     - 4/1/2014 - Refactored
         * Corey Paxton     - 4/3/2014 - Did the streak
         */
        protected override void Accept()
        {
            try
            {
                if (Data.Problem.AttemptAnswer(Int32.Parse(txt_answer.Text), this.CurrentUser.Data.game.currentProblem))
                {
                    CorrectAnswer();
                    this.lbl_coinsGained.Visible = true;
                }
                else
                {
                    IncorrectAnswer();
                }
            }
            //TODO remove generality
            catch (Exception)
            {
                //got a value that isn't an int in the field somehow
                txt_answer.Text = String.Empty;
            }


            timer1.Stop();
            this.CurrentUser.Data.game.problemTime = 0;

            //finished last problem
            if (this.CurrentUser.Data.game.currentProblemIndex + 1 >= this.CurrentUser.Data.game.totalProblems)
            {

                //display score screen
                //TODO Implement a score screen
                //if all questions were answered correctly double the amount of coins gained
                if (this.CurrentUser.Data.game.correctAnswers == this.CurrentUser.Data.game.totalProblems)
                {
                    /*
                     * Removed by Jeffrey Rackauckas on 4/29/2014.
                     * This method of doing this added double the coins AFTER they already gained coins the first time.
                     * Therefore, they were earning triple the coins!
                    this.CurrentUser.Data.game.coinsGained *= 2;
                    this.CurrentUser.Coins += this.CurrentUser.Data.game.coinsGained;
                     */
                    this.CurrentUser.addCoins(this.CurrentUser.Data.game.coinsGained);
                    MessageBox.Show("All answers correct! Coins earned Doubled!");
                }

                MessageBox.Show(string.Format("Finished\nCorrect: {0}/{1}\nCoins Gained: {2}",
                    this.CurrentUser.Data.game.correctAnswers.ToString(), this.CurrentUser.Data.game.totalProblems.ToString(),
                    this.CurrentUser.Data.game.coinsGained.ToString()));

                //Record the game
                this.CurrentUser.PreviousGames.Add(new GameRecord(CurrentUser.Data.game.totalProblems, DateTime.Now, CurrentUser.Data.game.correctAnswers));
/*
 * Deprecated on: 5/4/2014
 * No longer needed due to the use of the GameRecord class.
                this.CurrentUser.GameCount++;
                this.CurrentUser.Percentages.Add(Math.Round((double)this.CurrentUser.Data.game.correctAnswers
                    / (double)this.CurrentUser.Data.game.totalProblems, 4) * 100);

                //Update the total %
                this.CurrentUser.TotalPercentage = 0.0;
                foreach (double percent in this.CurrentUser.Percentages)
                {
                    this.CurrentUser.TotalPercentage += percent;
                }
                this.CurrentUser.TotalPercentage = Math.Round(this.CurrentUser.TotalPercentage / (double)this.CurrentUser.GameCount, 2);
                */

                //do some cleanup of the response labels
                lbl_coinsGained.Visible = false;
                lbl_Responses.Visible = false;

                //return to login form
                MainWindow.Instance.SwitchForm<StudentMenu>(this.CurrentUser);
            }
            else
            {
                //increment the counter
                this.CurrentUser.Data.game.currentProblemIndex++;

                //genereate a problem at the difficulty for this user
                this.CurrentUser.Data.game.currentProblem = this.CurrentUser.Data.game.problemHandler(this.CurrentUser.Data.game.testDiff);

                //reset the window
                MainWindow.Instance.SwitchForm<GameScreen>(this.CurrentUser);
            }
        }

        // Changed By: Jeffrey Rackauckas
        // Changed Date: 04/24/2014
        // Moved some of the functionality that is related to the gameplay and not the GUI into the new Game.cs file.
        private void CorrectAnswer()
        {
            //Correct
            //Display an indicator that they were right
            //MessageBox.Show("Correct");
            Data.Game.CorrectAnswer(this.CurrentUser.Data.game, this.CurrentUser);

            switch (this.CurrentUser.Data.game.correctStreak)
            {
                case 3:
                    lbl_Responses.ForeColor = System.Drawing.Color.Green;
                    lbl_Responses.Text = "Streak Bonus";
                    break;
                case 5:
                    lbl_Responses.ForeColor = System.Drawing.Color.OrangeRed;
                    lbl_Responses.Text = "On fire!";
                    break;
                default:
                    lbl_Responses.ForeColor = System.Drawing.Color.Green;
                    lbl_Responses.Text = "Correct";
                    break;
            }
            lbl_Responses.Visible = true;
            lbl_coinsGained.Text = String.Format("+{0}", Game.CoinsEarned(this.CurrentUser.Data.game.correctStreak).ToString());
            lbl_coinsGained.ForeColor = System.Drawing.Color.Green;
        }

        /*
         * Corey Paxton     - 4/1/2013 - Initial Version
         * Corey Paxton     - 4/3/2013 - Added Picture representation
         */
        private void IncorrectAnswer()
        {
            //Incorrect
            //Display an indicator that they were wrong and the drawing representation of the correct answer
            // Deprecated on: 5/4/2014.
            // Added By: Jeffrey Rackauckas
  //          MessageBox.Show(this.CurrentUser.Data.game.currentProblem.DrawingRepresentation());

            this.CurrentUser.Data.game.correctStreak = 0;

            //do some cleanup of the response labels
            lbl_coinsGained.Visible = false;
            lbl_Responses.Visible = true;
            lbl_Responses.Text = String.Format("Incorrect.  The correct answer is: {0}", this.CurrentUser.Data.game.currentProblem.Answer().ToString());
        }
        #endregion

        private void btn_return_to_menu_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            MainWindow.Instance.SwitchForm<StudentMenu>(this.CurrentUser);
        }

        private void lbl_coinsGained_Click(object sender, EventArgs e)
        {

        }

    }
}