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
        public Data.Hat currentHat;
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
            foreach(Data.Hat hat in user.OwnedHats)
            {
                enableHat(hat);
            }
        }

        // Created By: Jeffrey Rackauckas
        // Created On: 4/26/2014
        // Returns the user back to the student menu.
        private void btn_exit_Click(object sender, EventArgs e)
        {
            MainWindow.Instance.SwitchForm<StudentMenu>(this.CurrentUser);
        }
        private void enableHat(Data.Hat hat)
        {
            string hatName = String.Format("btn_hat_{0}_{1}", hat.Tier, hat.Number);
            Button button = this.Controls.Find(hatName, true).FirstOrDefault() as Button;
            button.Enabled = true;
        }
        // Created By: Jeffrey Rackauckas
        // Created On: 4/30/2014
        // This is the function that will deal with changing which hat is displayed and storing the currently selected hat information.
        private void rdo_hat_changed(object sender, EventArgs e)
        {
            RadioButton radio = (RadioButton)sender;
            if (!radio.Checked) return;

            this.currentHat = stripHatInfo(radio.Name);
        }

        private Data.Hat stripHatInfo(string name)
        {
            string[] seperates = new string[] { "_" };
            // Name contains : hodor_tier-number
            // Thus hatInfo will be ['rdo', 'hat', tier, number]
            string[] hatInfo = name.Split(seperates, StringSplitOptions.RemoveEmptyEntries);
            int hatTier = Convert.ToInt32(hatInfo[2]);
            int hatNumber = Convert.ToInt32(hatInfo[3]);
            return new Data.Hat(hatTier, hatNumber);
        }

        private void changeDisplayedHat(Data.Hat currentHat)
        {
            Bitmap newHat;
            if (currentHat.Tier == 1 && currentHat.Number == 1) newHat = global::CSUSM.CS441.SheriffHodor.Properties.Resources.hodor_1_1;
            else if (currentHat.Tier == 1 && currentHat.Number == 2) newHat = global::CSUSM.CS441.SheriffHodor.Properties.Resources.hodor_1_2;
            else if (currentHat.Tier == 2 && currentHat.Number == 1) newHat = global::CSUSM.CS441.SheriffHodor.Properties.Resources.hodor_2_1;
            else newHat = global::CSUSM.CS441.SheriffHodor.Properties.Resources.Propper_Hodor_Picture;
            this.gbox_hodor.BackgroundImage = newHat;
        }

        // Created By: Jeffrey Rackauckas
        // Created On: 4/30/2014
        // This is the onclick handler for the purchase button.
        private void purchase_hat(object sender, EventArgs e)
        {
            if (!this.CurrentUser.BuyHat(new Data.Hat(this.currentHat.Tier, this.currentHat.Number)))
            {
                Helpers.DisplayError("You don't have enough coins!");
                return;
            }
            changeDisplayedHat(this.currentHat);
            enableHat(this.currentHat);
        }

        private void hat_btn_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            changeDisplayedHat(stripHatInfo(button.Name));
        }
    }
}
