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
            ddl_groups.DataSource = Data.GroupList.Instance;
            this.AcceptButton = this.btn_submit;
        }

        public Data.User WorkingUser { get; set; }

        /*
         * Corey Paxton     - 4/5/2014 - Initial Version
         */
        public override void Entered(StateControl from, Data.User user)
        {
            base.Entered(from, user);

            this.txt_currentName.Text = user.Name;
            this.txt_newName.Text = user.Name;

            if (this.WorkingUser.Status == Data.User.UserType.Teacher)
            {
                // Hide group stuff, but display the password stuff
                lbl_group.Visible = false;
                ddl_groups.Visible = false;
                lbl_newPassword.Visible = true;
                lbl_newPasswordConfirm.Visible = true;
                txt_newPassword.Visible = true;
                txt_newPasswordConfirm.Visible = true;
            }
            else if (this.WorkingUser.Status == Data.User.UserType.Student)
            {
                // Display group stuff, hide password
                lbl_group.Visible = true;
                ddl_groups.Visible = true;
                lbl_newPassword.Visible = false;
                lbl_newPasswordConfirm.Visible = false;
                txt_newPassword.Visible = false;
                txt_newPasswordConfirm.Visible = false;
                ddl_groups.SelectedItem = Data.GroupList.Instance.GetByName(this.WorkingUser.GroupName);
            }
        }

        /*
         * Corey Paxton     - 4/5/2014 - Initial Version
         */
        private void button_cancel_Click(object sender, EventArgs e)
        {
            MainWindow.Instance.SwitchForm<Administration>(this.CurrentUser);
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

            if (this.WorkingUser.Status == Data.User.UserType.Teacher && txt_newPassword.Text != string.Empty)
            {
                if (txt_newPasswordConfirm.Text != txt_newPassword.Text)
                {
                    Helpers.DisplayError("The password provided doesn't match.");
                    return;
                }
                this.WorkingUser.Hash = Data.Helpers.sha1Of(txt_newPassword.Text);
            }

            if (this.WorkingUser.Status == Data.User.UserType.Student)
            {
                //delete the old group if they had one
                if (this.WorkingUser.GroupName != String.Empty)
                    Data.GroupList.Instance.GetByName(this.WorkingUser.GroupName).Members.Remove(this.WorkingUser);
                //add to current group
                if (ddl_groups.SelectedItem != null)
                {
                    this.WorkingUser.GroupName = ddl_groups.SelectedItem.ToString();
                    Data.GroupList.Instance.GetByName(this.WorkingUser.GroupName).Members.Add(this.WorkingUser);
                }
            }

            if (txt_newName.Text != txt_currentName.Text)
                this.WorkingUser.Name = txt_newName.Text;

            MainWindow.Instance.SwitchForm<Administration>(this.CurrentUser);
        }
    }
}
