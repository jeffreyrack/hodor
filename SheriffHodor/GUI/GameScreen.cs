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
        }

        public override void Entered(StateControl from, Data.User user)
        {
            base.Entered(from, user);
            lbl_index.Text = string.Format("Question: {0} / {1}", 0, 1);
            lbl_problem.Text = string.Format("{0} {1} {2} =", 5, '+', 42);
        }

        #region UI
        private void answerValidator(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar));
        }
        #endregion

        private void btn_next_Click(object sender, EventArgs e)
        {

            MainWindow.Instance.SwitchForm("game", this.CurrentUser);
        }
    }
}