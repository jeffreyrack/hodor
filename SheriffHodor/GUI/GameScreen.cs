/*This just needs to be conected and display the questions from the XMLfile i sent out (if it needs to be changed plz let me know)
 * The timer works!
 * */

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
    public partial class GameScreen : StateControl
    {
        Data.User.Runtime.GenerateProblem nextProblem;

        public GameScreen()
        {
            InitializeComponent();
            this.txt_answer.KeyPress += new KeyPressEventHandler(answerValidator);
            Random rand = new Random();

            //10-30 problems
            this.CurrentUser.Data.totalProblems = rand.Next(10,31);
            this.CurrentUser.Data.currentProblemIndex = 0;

            //Addition or Subtraction problems
            if (rand.Next(0, 2) > 0)
            {
                nextProblem = this.CurrentUser.Data.AddProblem;
            }
            else
            {
                nextProblem = this.CurrentUser.Data.SubProblem;
            }
        }

        /*
         * Matthias Lang    - 3/17/2014 - Initial Version
         * Corey Paxton     - 3/17/2014 - Beginning of making it work with refactor
         * Corey Paxton     - 3/20/2014 - Setup new problem generator
         */
        public override void Entered(StateControl from, Data.User user)
        {
            base.Entered(from, user);
            

            //display the counter
            lbl_index.Text = string.Format("Question: {0} / {1}", (user.Data.currentProblemIndex + 1), user.Data.totalProblems);

            //genereate a problem at the difficulty for this user
            this.CurrentUser.Data.currentProblem = nextProblem(this.CurrentUser.Data.testDiff);
            
            
            //TODO structure the format of the problem as an equation or top to bottom
            //equation form
            lbl_problem.Text = this.CurrentUser.Data.currentProblem.ToString();
        }

        #region UI
        private void answerValidator(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar));
        }
        
        /*
         * 
         * Corey Paxton     - 3/17/2014 - Initial Version
         * Corey Paxton     - 3/20/2014 - Expanding still unfinished
         */
        private void btn_next_Click(object sender, EventArgs e)
        {
            //finished last problem
            if (this.CurrentUser.Data.currentProblemIndex + 1 >= this.CurrentUser.Data.totalProblems)
            {
                //display score screen
                //TODO Implement a score screen
            }
            else
            {
                if (this.CurrentUser.Data.currentProblem.Answer() == (ushort)Int32.Parse(txt_answer.Text))
                {
                    //Correct
                    //TODO Update a boolean list
                    //TODO Display an indicator that they were right
                }
                else
                {
                    //Incorrect
                    //TODO Update a boolean list
                    //TODO Display an indicator that they were wrong
                    //TODO Display the drawing representation of the correct answer
                }

                //increment the counter
                this.CurrentUser.Data.currentProblemIndex++;

                //reset the window
                MainWindow.Instance.SwitchForm("game", this.CurrentUser);
            }
        }
        #endregion
    }
}