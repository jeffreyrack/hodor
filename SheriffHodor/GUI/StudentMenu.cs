using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CSUSM.CS441.SheriffHodor.GUI
{
    public partial class StudentMenu : StateControl
    {
        private Data.Hat currentHat { get; set; }

        public StudentMenu()
        {
            InitializeComponent();
            this.AcceptButton = btn_play_game;
            btn_play_game.BackColor = Data.Global.opaqueBackground;
            this.gbox_hats.BackColor = Data.Global.opaqueBackground;
        }

        public override void Entered(StateControl from, Data.User user, Data.User returnUser)
        {
            base.Entered(from, user, returnUser);
            this.AcceptButton = btn_play_game;

            lbl_current_name.Text = String.Format("Welcome:{0}{1}", Environment.NewLine, this.CurrentUser.Name);
            txt_coins.Text = this.CurrentUser.Coins.ToString();
            colorPurchasableHats();
            foreach (Data.Hat hat in this.CurrentUser.OwnedHats)
            {
                enableHat(hat);
            }
            this.gbox_hodor.BackgroundImage = global::CSUSM.CS441.SheriffHodor.Properties.Resources.Propper_Hodor_Picture;
        }

        private void btn_log_out_Click(object sender, EventArgs e)
        {
            Decline();
        }

        private void btn_play_game_Click(object sender, EventArgs e)
        {
            this.CurrentUser.newGame(this.CurrentUser);
            MainWindow.Instance.SwitchForm<GameScreen>(this.CurrentUser);
        }

        // Created By: Jeffrey Rackauckas
        // Created On: 5/4/2014
        // Changes the background color of a hat button to indicate whether or not the hat can be purchased.
        private void colorPurchasableHats()
        {
            // racka001: This isn't working with regex.  Kind've useless until I find out how to run a regex through it.
            //Control[] btns = this.Controls.Find(@"/btn_hat/", true);
            // Hardcode this crap in until the regex stuff works.
            Button[] btns = { this.btn_hat_1_1, this.btn_hat_1_2, this.btn_hat_2_1, this.btn_hat_2_2, this.btn_hat_3_1, this.btn_hat_3_3 };
            foreach (Button button in btns)
            {
                //Button button = (Button)control;
                Data.Hat hat = this.stripHatInfo(button.Name);
                if (hat.getPrice() <= this.CurrentUser.Coins)
                {
                    button.BackColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
                }
                else
                {
                    button.BackColor = System.Drawing.Color.FromArgb(255, 192, 192, 192);
                }
                button.Enabled = false;
                button.Cursor = System.Windows.Forms.Cursors.Default;
            }
        }

        // Created By: Jeffrey Rackauckas
        // Created On: 5/4/2014
        // Enables the button if the user owns the hat.
        private void enableHat(Data.Hat hat)
        {
            string hatName = String.Format("btn_hat_{0}_{1}", hat.Tier, hat.Number);
            Button button = this.Controls.Find(hatName, true).FirstOrDefault() as Button;
            button.Enabled = true;
            button.Cursor = System.Windows.Forms.Cursors.Hand;
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
            // TODO: This should be able to be figured out dynamically.
            if (currentHat.Tier == 1 && currentHat.Number == 1) newHat = global::CSUSM.CS441.SheriffHodor.Properties.Resources.hodor_1_1;
            else if (currentHat.Tier == 1 && currentHat.Number == 2) newHat = global::CSUSM.CS441.SheriffHodor.Properties.Resources.hodor_1_2;
            else if (currentHat.Tier == 2 && currentHat.Number == 1) newHat = global::CSUSM.CS441.SheriffHodor.Properties.Resources.hodor_2_1;
            else if (currentHat.Tier == 2 && currentHat.Number == 2) newHat = global::CSUSM.CS441.SheriffHodor.Properties.Resources.hodor_2_2;
            else if (currentHat.Tier == 3 && currentHat.Number == 1) newHat = global::CSUSM.CS441.SheriffHodor.Properties.Resources.hodor_3_1;
            else if (currentHat.Tier == 3 && currentHat.Number == 3) newHat = global::CSUSM.CS441.SheriffHodor.Properties.Resources.hodor_3_3;
            else newHat = global::CSUSM.CS441.SheriffHodor.Properties.Resources.Propper_Hodor_Picture;
            this.gbox_hodor.BackgroundImage = newHat;
        }

        // Created By: Jeffrey Rackauckas
        // Created On: 4/30/2014
        // This is the onclick handler for the purchase button.
        private void purchase_hat(object sender, EventArgs e)
        {
            if (this.currentHat == null)
            {
                Helpers.DisplayError("You did not select a hat!");
                return;
            }
            int status = this.CurrentUser.BuyHat(new Data.Hat(this.currentHat.Tier, this.currentHat.Number));
            if (status == 1)
            {
                Helpers.DisplayError("You don't have enough coins!");
                return;
            } else if(status ==2)
            {
                Helpers.DisplayError("You already own that hat!");
                return;
            }
            changeDisplayedHat(this.currentHat);
            enableHat(this.currentHat);
            this.txt_coins.Text = this.CurrentUser.Coins.ToString();
        }

        private void hat_btn_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            changeDisplayedHat(stripHatInfo(button.Name));
        }
    }
}
