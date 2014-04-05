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
            foreach (var u in Data.UserList.Instance)
                Console.WriteLine(u.ToString());
            Data.UserList.Instance.CollectionChanged += new NotifyCollectionChangedEventHandler(UpdateUserList);
            UpdateUserList(null, null);

            this.txt_password.KeyPress += new KeyPressEventHandler(enterPress);
            this.ddl_userList.SelectedIndexChanged +=
            new System.EventHandler(ddl_userList_SelectedIndexChanged);
        }


        public override void Entered(StateControl from, Data.User user)
        {
            this.txt_password.Text = String.Empty;
        }

        /*
         * Corey Paxton     - 3/24/2014 - Initial Version
         */
        private void ddl_userList_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            this.txt_password.Text = String.Empty;

            var result = from user in Data.UserList.Instance
                         where user.Name.Equals(ddl_userList.Text, StringComparison.InvariantCultureIgnoreCase)
                         select user;

            if (result.Count() != 1)
            {
                // Being paranoid doesn't hurt : We shouldn't get more than 1 result ever.
                Contract.Assert(result.Count() == 0);
                Helpers.DisplayError("Then name you entered is not valid !");
                return;
            }

            var selectedUser = result.First();

            if (selectedUser.Status != Data.User.UserType.Teacher)
            {
                txt_password.Visible = false;
            }
            else
            {
                txt_password.Visible = true;
            }
        }

        //TODO this only works if they are in the password section and due to being a state
        //i'm not sure how to make it so enter always applies this event 
        /*
         * Corey Paxton     - 3/24/2014 - Initial Version
         */
        private void enterPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                btn_login_Click(sender, e);
            }
        }

        private void UpdateUserList(object o, EventArgs e)
        {
            ddl_userList.DataSource = Data.UserList.Instance.Select(x => x.Name).ToList();
        }

        /*
         * Matthias Lang    - 3/17/2014 - Initial Version
         * Corey Paxton     - 3/17/2014 - Sample create test with explicitly defined data
         */
        //The login button that will either take a user to the game or the admin to the admin screen
        private void btn_login_Click(object sender, EventArgs e)
        {
            // We retrive the user currently selected.
            // It should be either 1 item or 0.
            var result = from user in Data.UserList.Instance
                         where user.Name.Equals(ddl_userList.Text, StringComparison.InvariantCultureIgnoreCase)
                         select user;

            if (result.Count() != 1)
            {
                // Being paranoid doesn't hurt : We shouldn't get more than 1 result ever.
                Contract.Assert(result.Count() == 0);
                Helpers.DisplayError("Then name you entered is not valid !");
                return;
            }

            var selectedUser = result.First();

            if (selectedUser.Status == Data.User.UserType.Teacher)
            {
                MainWindow.Instance.SwitchForm<Administration>("admin");
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
                MainWindow.Instance.SwitchForm<GameScreen>("game", selectedUser);
            }
        }
    }
}
