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
    public partial class Rewards : StateControl
    {
        public Rewards()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            string name = sender.ToString();
            string[] seperates = new string[] { "-", "," };
            // Name contains : hodor_tier-number
            // Thus hatInfo will be ['hodor_', tier, number]
            string[] hatInfo = name.Split(seperates, StringSplitOptions.RemoveEmptyEntries);

        }

        public override void Entered(StateControl from, Data.User user, Data.User returnUser)
        {
            base.Entered(from, user, returnUser);
            this.Show();
            this.CurrentUser = user;
        }


        private void btn_exit_Click(object sender, EventArgs e)
        {
            MainWindow.Instance.SwitchForm<StudentMenu>(this.CurrentUser);
        }
    }
}
