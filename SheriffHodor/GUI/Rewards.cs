/*
 * Created By: Jeffrey Rackauckas
 * Created On: 4/24/2014
 */
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
        // Stores the tier for the currently selected hat.
        public int hatTier = 0;
        // Stores the number for the currently selected hat.
        public int hatNumber = 0;
        public Rewards()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        public override void Entered(StateControl from, Data.User user, Data.User returnUser)
        {
            base.Entered(from, user, returnUser);
            this.Show();
            this.CurrentUser = user;
        }

        // Created By: Jeffrey Rackauckas
        // Created On: 4/26/2014
        // Returns the user back to the student menu.
        private void btn_exit_Click(object sender, EventArgs e)
        {
            MainWindow.Instance.SwitchForm<StudentMenu>(this.CurrentUser);
        }

        // Created By: Jeffrey Rackauckas
        // Created On: 4/30/2014
        // This is the function that will deal with changing which hat is displayed and storing the currently selected hat information.
        private void rdo_hat_1_1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radio = (RadioButton)sender;
            if (!radio.Checked) return;

            string name = radio.Name;
            string[] seperates = new string[] {"_" };
            // Name contains : hodor_tier-number
            // Thus hatInfo will be ['rdo', 'hat', tier, number]
            string[] hatInfo = name.Split(seperates, StringSplitOptions.RemoveEmptyEntries);
            this.hatTier = Convert.ToInt32(hatInfo[2]);
            this.hatNumber = Convert.ToInt32(hatInfo[3]);
        }

        // Created By: Jeffrey Rackauckas
        // Created On: 4/30/2014
        // This is the onclick handler for the purchase button.
        private void purchase_hat(object sender, EventArgs e)
        {
            if (!this.CurrentUser.BuyHat(new Data.Hat(this.hatTier, this.hatNumber)))
            {
                Helpers.DisplayError("You don't have enough coins!");
                return;
            }
            this.gbox_hodor.BackgroundImage = global::CSUSM.CS441.SheriffHodor.Properties.Resources.hodor_1_1;
        }
    }
}
