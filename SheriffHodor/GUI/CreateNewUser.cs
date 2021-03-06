﻿/* CreateNewUser.cs
 * 
 * Version - 3.0.3 - 5/3/2014 - Jeffrey Rackauckas - Changed error messages to match SRS.
 * Version - 3.0.2 - 4/21/2014 - Jeffrey Rackauckas - Fixed error messages, and added a regex check to the username.
 * Version - 3.0.1 - 4/16/2014 - Jeffrey Rackauckas - Added the returnUser parameter.
 * Version - 3.0.0 - Cycle 2 Release
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
    public partial class CreateNewUser : StateControl
    {
        public CreateNewUser()
        {
            InitializeComponent();
            this.AcceptButton = this.btn_create;
            this.ddl_groupList.DataSource = Data.GroupList.Instance;
            this.gbox_createGroup.BackColor = Data.Global.opaqueBackground;
            tltp.SetToolTip(btn_cancel, "Return to Admin Form");
            tltp.SetToolTip(btn_create, "Create User");
        }

        public override void Entered(StateControl from, Data.User user, Data.User returnUser)
        {
            base.Entered(from, user, returnUser);
            gbox_groups.Visible = true;
            gbox_passwords.Visible = false;
            this.txt_username.Focus();
        }

        protected override void Accept()
        {
            // We need to do all the errors handling ahead: That is, because we want the changes
            // to appear atomics.
            var name = txt_username.Text.Trim();
            var type = CheckedType();
            string pwd = null;
            string groupName = ddl_groupList.SelectedItem != null ? ddl_groupList.SelectedItem.ToString() : null;

            // Check the username
            if (name == string.Empty)
            {
                Helpers.DisplayError("ERROR: Please enter a name");
                return;
            }
            if(name.Length > 100)
            {
                Helpers.DisplayError("ERROR: Your name is over 100 characters.  Please shorten it.");
                return;
            }
            if(!Data.User.ValidName(name))
            {
                Helpers.DisplayError("ERROR: Your name cannot contain those characters");
                return;
            }
            if (Data.UserList.Instance.GetByName(name) != null)
            {
                Helpers.DisplayError("ERROR: Name is already in use.  Please use another name.");
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
                pwd = Data.Helpers.sha1Of(pwd);
            }

            var user = new Data.User(txt_username.Text, type, pwd);
            if (type == Data.User.UserType.Student)
            {
                user.GroupName = groupName;
                if (groupName != null)
                {
                    Data.GroupList.Instance.GetByName(groupName).Members.Add(user);
                }
            }
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
            MainWindow.Instance.SwitchForm<Administration>(this.CurrentUser);
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
            gbox_groups.Visible = true;
            gbox_passwords.Visible = false;
        }

        private void rdo_admin_CheckedChanged(object sender, EventArgs e)
        {
            gbox_groups.Visible = false;
            gbox_passwords.Visible = true;
        }
        #endregion
    }
}