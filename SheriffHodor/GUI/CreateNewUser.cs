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
            // We need to do all the errors handling ahead: That is, because we want the changes
            // to appear atomics.
            var name = txt_username.Text.Trim();
            var type = CheckedType();
            string pwd = null;
            string groupName = ddl_groupList.SelectedText != string.Empty ? ddl_groupList.SelectedText : null;

            // Check the username
            if (name == string.Empty)
            {
                Helpers.DisplayError("You must enter a name to create a new user.");
                return;
            }
            if (Data.UserList.Instance.GetByName(name) != null)
            {
                Helpers.DisplayError("There is already an user with this name.");
                return;
            }

            // Check the password
            if (type == Data.User.UserType.Teacher)
            {
                pwd = txt_password.Text;
                if (pwd == string.Empty)
                {
                    Helpers.DisplayError("You must enter a password to create a new teacher.");
                    return;
                }
                if (pwd != txt_passwordConfirm.Text)
                {
                    Helpers.DisplayError("Password don't match.");
                    return;
                }
            }

            var user = new Data.User(txt_username.Text, type, pwd);
            if (type == Data.User.UserType.Student)
                user.GroupName = groupName;
            Data.UserList.Instance.Add(user);

            Helpers.DisplayInfo(string.Format("User '{0}' successfully created", txt_username.Text));
            // Cleanup and leave.
            Decline();
        }
        protected override void Decline()
        {
            txt_username.Clear();
            txt_password.Clear();
            txt_passwordConfirm.Clear();
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
        #endregion
    }
}