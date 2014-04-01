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
        }

        /*
         * Matthias Lang    - 3/17/2014 - Initial Version
         * Corey Paxton     - 3/17/2014 - Beginning of making it work with refactor
         * Corey Paxton     - 3/20/2014 - Setup new problem generator
         * Corey Paxton     - 3/24/2014 - Made it so the text field is active
         * Corey Paxton     - 3/24/2014 - Added coin stuff
         */
        public override void Entered(StateControl from, Data.User user)
        {
            base.Entered(from, user);


            this.CurrentUser.Data.timer.Elapsed += new ElapsedEventHandler(OnTimedEvent);

            // TODO this isnt working the first time it enters the screen unless you click the screen
            // Make the text field active
            this.ActiveControl = txt_answer;


            txt_answer.Text = String.Empty;
            
            //display the counter
            lbl_index.Text = string.Format("Question: {0} / {1}", (user.Data.currentProblemIndex + 1), user.Data.totalProblems);

            //TODO structure the format of the problem as an equation or top to bottom
            //equation form
            lbl_problem.Text = this.CurrentUser.Data.currentProblem.ToString();
            //top to bottom form

            lbl_coins.Text = string.Format("Coins: {0}", this.CurrentUser.Coins.ToString());
        }

        private static void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            //TODO control.invoke on 1 second make lbl_coinsGained.visible = false
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
         */
        private void btn_next_Click(object sender, EventArgs e)
        {
            if (txt_answer.Text.Length > 0 && this.CurrentUser != null)
            {
                Accept();
            }
        }

        protected override void Accept()
        {
            //finished last problem
            if (this.CurrentUser.Data.currentProblemIndex + 1 >= this.CurrentUser.Data.totalProblems)
            {
                try
                {
                    if (Data.Problem.AttemptAnswer(Int32.Parse(txt_answer.Text), this.CurrentUser.Data.currentProblem))
                    {
                        CorrectAnswer();
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
                try
                {
                    if (Data.Problem.AttemptAnswer(Int32.Parse(txt_answer.Text), this.CurrentUser.Data.currentProblem))
                    {
                        CorrectAnswer();
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

                this.CurrentUser.Data.timer.Enabled = true;
                this.CurrentUser.Data.timer.Interval = 1000;

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

            //TODO display the coin change next to coins
            this.CurrentUser.Data.coinsGained += Data.Problem.CoinsGained(this.CurrentUser.Data.correctStreak);
            this.CurrentUser.Coins += Data.Problem.CoinsGained(this.CurrentUser.Data.correctStreak);
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