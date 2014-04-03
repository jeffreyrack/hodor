using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Timers;

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
            this.txt_answer.KeyPress += new KeyPressEventHandler(answerValidator);
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
        }

        /*
         * Matthias Lang    - 3/17/2014 - Initial Version
         * Corey Paxton     - 3/17/2014 - Beginning of making it work with refactor
         * Corey Paxton     - 3/20/2014 - Setup new problem generator
         * Corey Paxton     - 3/24/2014 - Made it so the text field is active
         * Corey Paxton     - 3/24/2014 - Added coin stuff
         * Corey Paxton     - 4/3/2014 - Equation and top to bottom form
         */
        public override void Entered(StateControl from, Data.User user)
        {
            base.Entered(from, user);

            this.CurrentUser.Data.problemTime = 0;
            timer1.Start();

            // TODO this isnt working the first time it enters the screen unless you click the screen
            // Make the text field active
            this.ActiveControl = txt_answer;


            txt_answer.Text = String.Empty;
            
            //display the counter
            lbl_index.Text = string.Format("Question: {0} / {1}", (user.Data.currentProblemIndex + 1), user.Data.totalProblems);

            //structure the format of the problem as an equation or top to bottom
            Random displayRandomizer = new Random();
            if (displayRandomizer.Next(0, 2) == 0)
            {
                //equation form
                lbl_problem.Text = String.Format("\n\n\n\n{0}", this.CurrentUser.Data.currentProblem.ToString());
            }
            else
            {
                //top to bottom form
                lbl_problem.Text = this.CurrentUser.Data.currentProblem.TopToBottomString();
            }

            lbl_coins.Text = string.Format("Coins: {0}", this.CurrentUser.Coins.ToString());
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            this.CurrentUser.Data.problemTime++;
            if (this.CurrentUser.Data.problemTime == 1)
            {
                lbl_coinsGained.Visible = false;
                lbl_streakResponses.Visible = false;
            }
        }

        #region UI
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
                if (Data.Problem.AttemptAnswer(Int32.Parse(txt_answer.Text), this.CurrentUser.Data.currentProblem))
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
            catch (Exception ex)
            {
                //got a value that isn't an int in the field somehow
                txt_answer.Text = String.Empty;
            }

            
            timer1.Stop();
            this.CurrentUser.Data.problemTime = 0;

            //finished last problem
            if (this.CurrentUser.Data.currentProblemIndex + 1 >= this.CurrentUser.Data.totalProblems)
            {

                //display score screen
                //TODO Implement a score screen
                //if all questions were answered correctly double the amount of coins gained
                if (this.CurrentUser.Data.correctAnswers == this.CurrentUser.Data.totalProblems)
                {
                    this.CurrentUser.Data.coinsGained *= 2;
                    this.CurrentUser.Coins += this.CurrentUser.Data.coinsGained;
                    MessageBox.Show("All answers correct! Coins earned Doubled!");

                }
                MessageBox.Show(string.Format("Finished\nCorrect: {0}/{1}\nCoins Gained: {2}",
                    this.CurrentUser.Data.correctAnswers.ToString(), this.CurrentUser.Data.totalProblems.ToString(),
                    this.CurrentUser.Data.coinsGained.ToString()));

                MainWindow.Instance.SwitchForm("login", this.CurrentUser);
            }
            else
            {
                //increment the counter
                this.CurrentUser.Data.currentProblemIndex++;

                //genereate a problem at the difficulty for this user
                this.CurrentUser.Data.currentProblem = this.CurrentUser.Data.problemHandler(this.CurrentUser.Data.testDiff);

                //reset the window
                MainWindow.Instance.SwitchForm("game", this.CurrentUser);
            }
        }

        private void CorrectAnswer()
        {
            //Correct
            //TODO Display an indicator that they were right
            MessageBox.Show("Correct");
            this.CurrentUser.Data.correctAnswers++;
            this.CurrentUser.Data.correctStreak++;

            //display the coin change next to coins
            int thisProblemCoins = Data.Problem.CoinsGained(this.CurrentUser.Data.correctStreak);
            
            this.CurrentUser.Data.coinsGained += thisProblemCoins;
            this.CurrentUser.Coins += thisProblemCoins;

            switch (this.CurrentUser.Data.correctStreak)
            {
                case 3:
                    lbl_streakResponses.ForeColor = System.Drawing.Color.Green;
                    lbl_streakResponses.Text = "Three in a row!";
                    lbl_streakResponses.Visible = true;
                    break;
                case 5:
                    lbl_streakResponses.ForeColor = System.Drawing.Color.OrangeRed;
                    lbl_streakResponses.Text = "On fire!";
                    lbl_streakResponses.Visible = true;
                    break;
            }
            lbl_coinsGained.Text = String.Format("+{0}", thisProblemCoins.ToString());
        }

        private void IncorrectAnswer()
        {
            //Incorrect
            //TODO Display an indicator that they were wrong
            //TODO Display the drawing representation of the correct answer
            MessageBox.Show("Incorrect " + this.CurrentUser.Data.currentProblem.Answer());
            this.CurrentUser.Data.correctStreak = 0;
        }
        #endregion
    }
}