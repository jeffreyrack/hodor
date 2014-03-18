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
        }

        private void UpdateUserList(object o, EventArgs e)
        {
            ddl_userList.DataSource = Data.UserList.Instance.Select(x => x.Name).ToList();
        }

        /*
         * Matthias Lang    - 3/17/2014 -
         * Corey Paxton     - 3/17/2014 - 
         */
        //The login button that will either take a user to the game or the admin to the admin screen
        private void btn_login_Click(object sender, EventArgs e)
        {
            // We retrive the user currently selected.
            // It should be either 1 item or 0.
            var result = from user in Data.UserList.Instance
                         where user.Name.Equals(ddl_userList.Text, StringComparison.InvariantCultureIgnoreCase)
                         select user;

            if (result.Count() != 1) {
                // Being paranoid doesn't hurt : We shouldn't get more than 1 result ever.
                Contract.Assert(result.Count() == 0);
                Helpers.DisplayError("Then name you entered is not valid !");
                return;
            }

            var selectedUser = result.First();

            if (selectedUser.Status == Data.User.UserType.Teacher)
            {
                MainWindow.Instance.SwitchForm("admin");
            } 
            else 
            {
                selectedUser.Data.currentProblem.op = Data.User.Runtime.Problem.Operator.Addition;
                selectedUser.Data.currentProblem.Operands.Add(5);
                selectedUser.Data.currentProblem.Operands.Add(17);
                selectedUser.Data.currentProblem.Operands.Add(42);
                Console.WriteLine(selectedUser.Data.currentProblem.ToString());
                MainWindow.Instance.SwitchForm("game", selectedUser);
            }
        }
    }
}
