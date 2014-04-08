﻿/*Team Hodor
 *  The buttons just need to be linkd to the XML background functions andsaved for the user games
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

/*
 * Mathias Lang    - Initial Version
 * Corey Paxton     - 4/4/2014 - Hiding the unwanted fields
 * Mathias Lang     - 4/4/2014 - Fixed odd bug in the .NET frmwk by using another datatype.
*/

namespace CSUSM.CS441.SheriffHodor.GUI
{
    public partial class Administration : StateControl
    {
        public Administration()
        {
            InitializeComponent();
            dtg_users_list.DataSource = Data.UserList.Instance;
            dtg_groups_groups.DataSource = Data.GroupList.Instance;
            dtg_reports_list.DataSource = Data.UserList.Instance;

            
           
            //TODO make this work
            //var results = from user in Data.UserList.Instance where user.Status == Data.User.UserType.Student select user;
            //dtg_reports_list.DataSource = results;
            //dtg_reports_list.Columns["TotalPercentage"].Name = "Total %";
            //dtg_reports_list.Columns["GameCount"].Name = "Games Played";

            dtg_reports_list.Columns["Status"].Visible = false;
        }

        private List<object> getSelectedName(DataGridView dgv, string cellname)
        {
            // The ToList() is needed, as else it would stay lazy and request invalidated data (from SelectRows).
            return (from DataGridViewRow name in dgv.SelectedRows select name.Cells[cellname].Value).ToList();
        }

        // The "Reports" tab.
        #region Reports
        private void btn_log_out_Click(object sender, EventArgs e)
        {
            Decline();
        }
        #endregion

        // The "Users" tab.
        #region Users Panel
        private void btn_users_add_Click(object sender, EventArgs e)
        {
            MainWindow.Instance.SwitchForm<CreateNewUser>();
        }

        private void btn_users_edit_Click(object sender, EventArgs e)
        {
            var result = getSelectedName(dtg_users_list, "Name");

            if (result.Count() < 1)
                Helpers.DisplayError("No selected user!");
            else
                MainWindow.Instance.SwitchForm<UpdateUser>(Data.UserList.Instance.GetByName(result.First().ToString()));
        }

        private void btn_users_del_Click(object sender, EventArgs e)
        {
            try
            {
                // The ToList() is needed, as else it would stay lazy and request invalidated data (from SelectRows).
                var toDel = getSelectedName(dtg_users_list, "Name");
                var count = toDel.Count();

                // No item selected
                if (count < 1)
                    return;

                // Avoid deleting yourself
                if (toDel.Contains(this.CurrentUser.Name))
                {
                    Helpers.DisplayError("You can't delete yourself !");
                    return;
                }

                var msg = string.Format("Are you sure you want to delete {0} ?",
                    (count > 1) ? (string.Format("{0} users", count))
                    : (string.Format("user '{0}'", toDel.First())));

                if (Helpers.AskQuestion(msg) == DialogResult.Yes)
                    foreach (string u in toDel)
                        Data.UserList.Instance.RemoveByName(u);
            }
            catch (Exception ex)
            {
                // If anything goes wrong, we catch it and log it.
                // But it isn't much of a problem.
                Console.WriteLine(ex.Message);
                throw;
            }
        }
        private void btn_logout_Click(object sender, EventArgs e)
        {
            Decline();
        }
        #endregion

        // The "Groups" tab.
        #region Groups
        private void btn_groups_logout_Click(object o, EventArgs a)
        {
            Decline();
        }
        private void btn_groups_create_Click(object sender, EventArgs e)
        {
            MainWindow.Instance.SwitchForm<CreateGroup>();
        }
        private void btn_groups_edit_Click(object sender, EventArgs e)
        {
            var grpNames = getSelectedName(dtg_groups_groups, "Name");
            if (grpNames.Count == 0)
            {
                GUI.Helpers.DisplayError("You need to select one group to edit");
                return;
            }
            if (grpNames.Count != 1)
            {
                GUI.Helpers.DisplayError("You need to select one and only one group to edit");
                return;
            }
            var grp = Data.GroupList.Instance[Data.GroupList.Instance.GetIdxByName(grpNames.First() as string)];
            MainWindow.Instance.SwitchForm<UpdateGroup>().SetCurrentGroup(grp);
        }
        private void btn_groups_delete_Click(object sender, EventArgs e)
        {
            try
            {
                // The ToList() is needed, as else it would stay lazy and request invalidated data (from SelectRows).
                var toDel = getSelectedName(dtg_groups_groups, "Name");
                var count = toDel.Count();

                // No item selected
                if (toDel.Count == 0)
                {
                    GUI.Helpers.DisplayError("You need to select at least one group to delete");
                    return;
                }

                var msg = string.Format("Are you sure you want to delete {0} ?",
                    (count > 1) ? (string.Format("{0} groups", count))
                    : (string.Format("group '{0}'", toDel.First())));

                if (Helpers.AskQuestion(msg) == DialogResult.Yes)
                    foreach (string u in toDel)
                        Data.GroupList.Instance.RemoveByName(u);
            }
            catch (Exception ex)
            {
                // If anything goes wrong, we catch it and log it.
                // But it isn't much of a problem.
                Console.WriteLine(ex.Message);
                throw;
            }
        }
        #endregion
    }
}