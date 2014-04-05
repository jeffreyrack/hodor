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
    public partial class CreateNewUser : StateControl
    {
        public CreateNewUser()
        {
            InitializeComponent();
            this.AcceptButton = this.btn_create;
        }

        protected override void Accept()
        {
            if (this.txt_username.Text == string.Empty)
            {
                Helpers.DisplayWarning("You must enter a name to create a new user.");
                return;
            }
            if (Data.UserList.Instance.Any(
                u => u.Name.Equals(txt_username.Text, StringComparison.InvariantCultureIgnoreCase))) {
                Helpers.DisplayError("There is already an user with this name.");
                return;
            }

            var type = (rdo_admin.Checked ? Data.User.UserType.Teacher : Data.User.UserType.Student);
            Data.UserList.Instance.Add(new Data.User(txt_username.Text, type));
            Helpers.DisplayInfo(string.Format("User '{0}' successfully created", txt_username.Text));
            // Cleanup and leave.
            Decline();
        }
        protected override void Decline()
        {
            txt_username.Clear();
            rdo_user.Checked = true;
            MainWindow.Instance.SwitchForm<Administration>();
        }

        #region UI Events
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Decline();
        }
        private void btn_create_Click(object sender, EventArgs e)
        {
            Accept();
        }
        #endregion
    }
}