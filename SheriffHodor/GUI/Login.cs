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

            this.AcceptButton = this.btn_login;
            this.ddl_userList.SelectedIndexChanged +=
                new System.EventHandler(ddl_userList_SelectedIndexChanged);
        }

        public override void Entered(StateControl from, Data.User user)
        {
            base.Entered(from, user);
            this.txt_password.Text = String.Empty;
        }

        /*
         * Corey Paxton     - 3/24/2014 - Initial Version
         */
        private void ddl_userList_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            this.txt_password.Text = String.Empty;
            var selectedUser = Data.UserList.Instance.GetByName(ddl_userList.Text);
            if (selectedUser.Status == Data.User.UserType.Teacher)
                txt_password.Visible = true;
            else
                txt_password.Visible = false;
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
                //TODO modualize this into a create new game function
                Random rand = new Random();

                //10-30 problems
                selectedUser.Data.totalProblems = rand.Next(10, 31);
                selectedUser.Data.currentProblemIndex = 0;
                selectedUser.Data.correctAnswers = 0;
                selectedUser.Data.correctStreak = 0;
                selectedUser.Data.coinsGained = 0;

                //Addition or Subtraction problems
                if (rand.Next(0, 2) > 0)
                {
                    selectedUser.Data.problemHandler = Data.Problem.AddProblem;
                }
                else
                {
                    selectedUser.Data.problemHandler = Data.Problem.SubProblem;
                }

                selectedUser.Data.testDiff = Data.Problem.Difficulty.Easy;

                selectedUser.Data.currentProblem = selectedUser.Data.problemHandler(selectedUser.Data.testDiff);

                Console.WriteLine(selectedUser.Data.currentProblem.ToString());
                MainWindow.Instance.SwitchForm<GameScreen>(selectedUser);
            }
        }
    }
}
