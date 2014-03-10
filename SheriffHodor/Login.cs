/*This file just needs to be sinked up with the XMl call file to display the users in the dropdown menu and 
 * display the proper screen for if the actor is a user or admin. 
 * 
 * */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CSUSM.CS441.SheriffHodor
{
    public partial class Login : UserControl
    {
        public List<Data.Student> users;
        public Login()
        {
            InitializeComponent();
            ddl_userList.DropDownStyle = ComboBoxStyle.DropDownList;
            refreshUserList();
        }


        //bool IsTeacher = false;//admin or user
        //string UName;//user name

        public Dictionary<int, string> userValues;

        //object for calling functions of the xmlbackend class
        XmlBackend AA = new XmlBackend();

        public void refreshUserList()
        {
            users = AA.selectAll();
            users = users.OrderBy(x => x.Name).ToList();
            userValues = new Dictionary<int, string>();
            if (users.Count > 0) {
                for (int i = 0; i < users.Count; i++) {
                    userValues.Add(i, users[i].Name + " " + users[i].Id);
                }
                ddl_userList.DataSource = new BindingSource(userValues, null);
                ddl_userList.DisplayMember = "Value";
                ddl_userList.ValueMember = "Key";
            }
        }

        //Update Button
        private void button2_Click(object sender, EventArgs e)
        {
            var selectedUser = Data.Student.authenticate_User(users, ddl_userList.Text);
            if (selectedUser.Name == null) {
                MessageBox.Show("ERROR: Cannot Login - User is not selected");
                return;
            }
            Action refresh = refreshUserList;
            new Update(selectedUser, refresh).Show();
        }
        //Create New User Button
        private void button3_Click(object sender, EventArgs e)
        {
            //new CreateNewUser().Show();
            Action refresh = refreshUserList;
            CreateNewUser fred = new CreateNewUser(refresh);
            fred.Show();
            fred.FormClosed += new FormClosedEventHandler(MyForm_FormClosed);

        }
        //supose to refresh the dropdown menu on this form, it isntdoing that
        void MyForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Refresh();
        }

        //Dropdown Menu for the list of users
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {}

        //The login button that will either take a user to the game or the admin to the admin screen
        private void btn_login_Click(object sender, EventArgs e)
        {
            // REFACTOR
            Data.Student selectedUser = Data.Student.authenticate_User(users, ddl_userList.Text);
            if (selectedUser.Name == null) {
                MessageBox.Show("ERROR: Cannot Login - User is not selected");
                return;
            }
            if (selectedUser.isTeacher == false) {
                if (new XmlBackend().selectStudentGameInfo(selectedUser) == null) {
                    MessageBox.Show("No Available Tests.");
                    return;
                }
                //needs to know which user it is
                //string StName = selectedUser.getName();
                GameScreen gs = new GameScreen(selectedUser);
                gs.Show();
                MessageBox.Show("Welcome to Sheriff Hodor!");
            } else {
                // Go to admin screen
                MainWindow.Instance.SwitchForm("admin");
            }
        }
    }
}
