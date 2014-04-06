/*This file just needs to be sinked up with the XMl call file to display the users in the dropdown menu and 
 * display the proper screen for if the actor is a user or admin. 
 * 
 * */
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

            ddl_userList.DisplayMember = "Name";
            ddl_userList.DataSource = Data.UserList.Instance;

            this.ddl_userList.SelectedIndexChanged +=
                new System.EventHandler(ddl_userList_SelectionChangeCommitted);
        }

        public override void Entered(StateControl from, Data.User user)
        {
            base.Entered(from, user);
            this.AcceptButton = this.btn_login;
            this.txt_password.Text = String.Empty;
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
                selectedUser.Data.newGame();

                //Console.WriteLine(selectedUser.Data.currentProblem.ToString());
                MainWindow.Instance.SwitchForm<StudentMenu>(selectedUser);
            }
        }
    }
}
