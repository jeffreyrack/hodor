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
        }

        #region FormState inheritance
        protected override void Accept()
        {
            MainWindow.Instance.SwitchForm("game");
        }
        #endregion

        #region UI Events
        private void btn_cancel_Click(object sender, EventArgs e)   { Decline(); }
        private void btn_continue_Click(object sender, EventArgs e) { Accept(); }
        #endregion
    }
}
