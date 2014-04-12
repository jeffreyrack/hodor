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
        public StudentMenu()
        {
            InitializeComponent();
            this.AcceptButton = btn_play_game;
        }

        public override void Entered(StateControl from, Data.User user)
        {
            base.Entered(from, user);
            this.AcceptButton = btn_play_game;

            lbl_current_name.Text = String.Format("Welcome: {0}", this.CurrentUser.Name);
            txt_coins.Text = this.CurrentUser.Coins.ToString();
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

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
