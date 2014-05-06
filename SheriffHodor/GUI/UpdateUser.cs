/* UpdateUser.cs
 * 
 * Version - 3.0.3 - 5/3/2014 - Jeffrey Rackauckas - Added checks for the max name length, and made updates also use User.ValidName
 * Version - 3.0.2 - 4/29/2014 - Jeffrey Rackauckas - Fixed a bug with returnUser.
 *  Version - 3.0.1 - 4/16/2014 - Jeffrey Rackauckas - Added the returnUser parameter.
 * Version - 3.0.0
 */
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CSUSM.CS441.SheriffHodor.GUI
{
    public partial class UpdateUser : StateControl
    {
        public UpdateUser()
        {
            InitializeComponent();
            ddl_groups.DisplayMember = "Name";
            this.AcceptButton = this.btn_submit;
            this.gbox_updateUser.BackColor = Data.Global.opaqueBackground;
            tltp.SetToolTip(btn_cancel, "Return to Admin Form");
            tltp.SetToolTip(btn_submit , "Update User");
        }

        /*
         * Corey Paxton     - 4/5/2014 - Initial Version
         */
        public override void Entered(StateControl from, Data.User user, Data.User returnUser)
        {
            base.Entered(from, user, returnUser);
            this.txt_currentName.Text = user.Name;
            this.txt_newName.Text = user.Name;
            ddl_groups.DataSource = Data.GroupList.Instance;

            if (this.CurrentUser.Status == Data.User.UserType.Teacher)
            {
                // Hide group stuff, but display the password stuff
                lbl_group.Visible = false;
                ddl_groups.Visible = false;
                lbl_newPassword.Visible = true;
                lbl_newPasswordConfirm.Visible = true;
                txt_newPassword.Visible = true;
                txt_newPasswordConfirm.Visible = true;
            }
            else if (this.CurrentUser.Status == Data.User.UserType.Student)
            {
                // Display group stuff, hide password
                lbl_group.Visible = true;
                ddl_groups.Visible = true;
                lbl_newPassword.Visible = false;
                lbl_newPasswordConfirm.Visible = false;
                txt_newPassword.Visible = false;
                txt_newPasswordConfirm.Visible = false;
                if(this.CurrentUser.GroupName != null)
                    ddl_groups.SelectedItem = Data.GroupList.Instance.GetByName(this.CurrentUser.GroupName);

            }
        }

        /*
         * Corey Paxton     - 4/5/2014 - Initial Version
         * Corey Paxton     - 4/7/2014 - Bug Fix
         */
        private void button_cancel_Click(object sender, EventArgs e)
        {
            txt_newPassword.Text = String.Empty;
            txt_newPasswordConfirm.Text = String.Empty;
            MainWindow.Instance.SwitchForm<Administration>(this.returnUser);
        }

        /*
         * Corey Paxton     - 4/5/2014 - Initial Version
         */
        private void btn_submit_Click(object sender, EventArgs e)
        {
            // The work in this function is tedious:
            // As we are editing properties, we need to make sure everything change, or nothing change.
            // Hence, it's a "nothing or all" policy, and we need to do all the
            // error checking ahead of the actual changes.

            this.txt_newName.Text = this.txt_newName.Text.Trim();
            if (this.txt_newName.Text == string.Empty)
            {
                Helpers.DisplayError("Users must have a name.");
                return;
            }

            if(!Data.User.ValidName(this.txt_newName.Text))
            {
                Helpers.DisplayError("New name is already in use.  Please use a different name.");
                return;
            }

            if(this.txt_newName.Text.Length >= 100)
            {
                Helpers.DisplayError("New Name is too long.  Names must be less than 100 characters long.");
                return;
            }

            if (this.CurrentUser.Status == Data.User.UserType.Teacher && txt_newPassword.Text != string.Empty)
            {
                if (txt_newPasswordConfirm.Text != txt_newPassword.Text)
                {
                    Helpers.DisplayError("The password provided doesn't match.");
                    return;
                }
                this.CurrentUser.Hash = Data.Helpers.sha1Of(txt_newPassword.Text);
            }
            if (this.CurrentUser.Status == Data.User.UserType.Student)
            {
                //delete the old group if they had one
                if (this.CurrentUser.GroupName != null)
                    Data.GroupList.Instance.GetByName(this.CurrentUser.GroupName).Members.Remove(this.CurrentUser);
                //add to current group
                if (ddl_groups.SelectedItem != null)
                {
                    this.CurrentUser.GroupName = ddl_groups.SelectedItem.ToString();
                    Data.GroupList.Instance.GetByName(this.CurrentUser.GroupName).Members.Add(this.CurrentUser);
                }
            }

            if (txt_newName.Text != txt_currentName.Text)
                this.CurrentUser.Name = txt_newName.Text;

            MainWindow.Instance.SwitchForm<Administration>(this.returnUser);
        }

    }
}
