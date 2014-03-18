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
        public GameScreen()
        {
            InitializeComponent();
            this.txt_answer.KeyPress += new KeyPressEventHandler(answerValidator);
            this.CurrentUser.Data.totalProblems = 10;
            this.CurrentUser.Data.currentProblemIndex = 0;
        }

        /*
         * Matthias Lang    - 3/17/2014 - Initial Version
         * Corey Paxton     - 3/17/2014 - 
         */
        public override void Entered(StateControl from, Data.User user)
        {
            base.Entered(from, user);

            //display the counter
            lbl_index.Text = string.Format("Question: {0} / {1}", (user.Data.currentProblemIndex + 1), user.Data.totalProblems);

            //TODO generate a problem
            //TODO structure the format of the problem as an equation or top to bottom
            lbl_problem.Text = string.Format("{0} {1} {2} =", 5, '+', 42);
            //equation form
            //lbl_problem.Text = this.Data.currentProblem.ToString();
        }

        #region UI
        private void answerValidator(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar));
        }
        
        /*
         * 
         * Corey Paxton     - 3/17/2014 - Initial Version
         */
        private void btn_next_Click(object sender, EventArgs e)
        {
            //finished last problem
            if (this.CurrentUser.Data.currentProblemIndex + 1 >= this.CurrentUser.Data.totalProblems)
            {
                //display score screen
            }
            else
            {
                //increment the counter
                this.CurrentUser.Data.currentProblemIndex++;

                //reset the window
                MainWindow.Instance.SwitchForm("game", this.CurrentUser);
            }
        }
        #endregion
    }
}