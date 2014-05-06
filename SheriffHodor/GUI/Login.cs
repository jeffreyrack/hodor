/* Login.cs
 * 
 * Version - 3.0.2 - 5/4/2014 - Now only displays users that are not in Ungrouped Users, and made the drop-down size smaller.
 * Version - 3.0.1 - 4/16/2014 - Jeffrey Rackauckas - Added the returnUser parameter.
 * Version - 3.0.0 - Cycle 2 Release
 */
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CSUSM.CS441.SheriffHodor.GUI
{
    public partial class Login : StateControl
    {
        public Login()
        {
            InitializeComponent();
            lbl_title.BackColor = Data.Global.opaqueBackground;
            ddl_userList.DisplayMember = "Name";

            this.ddl_userList.SelectedIndexChanged +=
                new System.EventHandler(ddl_userList_SelectionChangeCommitted);
        }

        public override void Entered(StateControl from, Data.User user, Data.User returnUser)
        {
            base.Entered(from, user, returnUser);
            this.AcceptButton = this.btn_login;
            this.txt_password.Text = String.Empty;
            if (txt_password.Visible)
            {
                txt_password.Focus();
            }
            ddl_userList.DataSource = Data.UserList.Instance.GetGroupedUsers();
        }

        /*
         * Corey Paxton     - 3/24/2014 - Initial Version
         * Corey Paxton     - 4/6/2014 - Setting focus to password on selection
         */
        private void ddl_userList_SelectionChangeCommitted(object sender, System.EventArgs e)
        {
            this.txt_password.Text = String.Empty;
            var selectedUser = Data.UserList.Instance.GetByName(ddl_userList.Text);
            if (selectedUser.Status == Data.User.UserType.Teacher)
            {
                txt_password.Visible = true;
                //TODO this fires on arrow navigation and makes it so everytime you select
                //an admin it removes focus from the list
                txt_password.Focus();
            }
            else
            {
                txt_password.Visible = false;
            }
        }

        /*
         * Mathias Lang    - 3/17/2014 - Initial Version
         * Corey Paxton     - 3/17/2014 - Sample create test with explicitly defined data
         */
        //The login button that will either take a user to the game or the admin to the admin screen
        private void btn_login_Click(object sender, EventArgs e)
        {
            // We retrive the user currently selected.
            var selectedUser = Data.UserList.Instance.GetByName(ddl_userList.Text);
            if (selectedUser.Status == Data.User.UserType.Teacher)
            {
                if (this.txt_password.Text == string.Empty)
                {
                    Helpers.DisplayError("Password required.");
                    return;
                }
                if (Data.Helpers.Authenticate(selectedUser, txt_password.Text))
                    MainWindow.Instance.SwitchForm<Administration>(selectedUser);
                else
                    Helpers.DisplayError("Invalid password for user " + selectedUser.Name);
            }
            else
            {
                //Console.WriteLine(selectedUser.Data.currentProblem.ToString());
                MainWindow.Instance.SwitchForm<StudentMenu>(selectedUser);
            }
        }
    }
}
