/*This file just needs to be sinked up with the XMl call file to display the users in the dropdown menu and 
 * display the proper screen for if the actor is a user or admin. 
 * 
 * */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CSUSM.CS441.SheriffHodor.GUI
{
    public partial class Login : UserControl
    {
        // LEGACY //

        public Dictionary<int, string> userValues;
        //object for calling functions of the xmlbackend class
        public List<Data.User> users;


        // NEW CODE //

        public Login()
        {
            InitializeComponent();
            UpdateUserList();
        }

        private void UpdateUserList()
        {
            ddl_userList.DataSource = Data.Global.UserList.Select(x => x.Name).ToList();
        }

        #region Move to administration
        //Update Button
        //private void button2_Click(object sender, EventArgs e)
        //{
        //var selectedUser = Data.Student.authenticate_User(users, ddl_userList.Text);
        //if (selectedUser.Name == null) {
        //MessageBox.Show("ERROR: Cannot Login - User is not selected");
        //return;
        //}
        //Action refresh = refreshUserList;
        //new Update(selectedUser, refresh).Show();
        //}
        //Create New User Button
        //private void button3_Click(object sender, EventArgs e)
        //{
        //new CreateNewUser().Show();
        //Action refresh = refreshUserList;
        //CreateNewUser fred = new CreateNewUser(refresh);
        //fred.Show();
        //fred.FormClosed += new FormClosedEventHandler(MyForm_FormClosed);
        //}
        #endregion

        //The login button that will either take a user to the game or the admin to the admin screen
        private void btn_login_Click(object sender, EventArgs e)
        {
            // We retrive the user currently selected.
            // It should be either 1 item or 0.
            var result = from user in Data.Global.UserList
                         where user.Name.Equals(ddl_userList.Text, StringComparison.InvariantCultureIgnoreCase)
                         select user;

            if (result.Count() != 1) {
                // Being paranoid doesn't hurt : We shouldn't get more than 1 result ever.
                Contract.Assert(result.Count() == 0);
                Helpers.DisplayError("Then name you entered is not valid !");
                return;
            }

            var selectedUser = result.First();
            if (selectedUser.Status == Data.User.UserType.Teacher) {
                MainWindow.Instance.SwitchForm("admin");
            } else {
                if (Data.XmlBackend.selectStudentGameInfo(selectedUser) == null) {
                    Helpers.DisplayError("No Available Tests.");
                    return;
                }
                var gs = (MainWindow.Instance.SwitchForm("game") as GameScreen);
                gs.GameScreen_FakeCtor(selectedUser);
                MessageBox.Show("Welcome to Sheriff Hodor!");
            }
        }
    }
}
