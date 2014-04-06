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
            this.ddl_groupList.DataSource = Data.GroupList.Instance;
        }

        public override void Entered(StateControl from, Data.User user)
        {
            base.Entered(from, user);
            grp_groups.Visible = true;
            grp_passwords.Visible = false;
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

            var type = CheckedType();
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

        private Data.User.UserType CheckedType()
        {
            return (rdo_admin.Checked ? Data.User.UserType.Teacher : Data.User.UserType.Student);
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

        private void rdo_user_CheckedChanged(object sender, EventArgs e)
        {
            grp_groups.Visible = true;
            grp_passwords.Visible = false;
        }

        private void rdo_admin_CheckedChanged(object sender, EventArgs e)
        {
            grp_groups.Visible = false;
            grp_passwords.Visible = true;
        }
    }
}