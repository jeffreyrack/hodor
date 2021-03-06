﻿/* Administration.cs
 * 
 * Version - 3.0.7 - 5/4/2014 - Jeffrey Rackauckas - Added the max users/groups restrictions by hiding the add buttons when there are too many.
 * Version - 3.0.6 - 5/4/2014 - Jeffrey Rackauckas - Added the export to excel icon.
 * Version - 3.0.5 - 5/4/2014 - Jeffrey Rackauckas - Added the About Us tab.
 * Version - 3.0.4 - 5/3/2014 - Jeffrey Rackauckas - Fixed the bug where returnUser was being set to null and crashing the app.
 * Version - 3.0.3 - 4/30/2014 - Jeffrey Rackauckas - Reports now only display students (filters out teachers).
 * Version - 3.0.2 - 4/29/2014 - Jeffrey Rackauckas - Added the Ungrouped Users functionality.
 * Version - 3.0.1 - 4/16/2014 - Jeffrey Rackauckas - Added the returnUser parameter.
 * Version -  3.0.0 - Cycle 2 Release.
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
            /*
            List<Data.User> students = Data.UserList.Instance.ApplyStatusFilter(Data.User.UserType.Student).ToList();
            foreach(Data.User user in students)
            {
                TreeGridNode node = tgv_reports.Nodes.Add("test");
            }
             */
            dtg_reports_list.DataSource = Data.UserList.Instance.ApplyStatusFilter(Data.User.UserType.Student);
            dtg_users_list.Columns["TotalPercentage"].Visible = false;
            dtg_users_list.Columns["GameCount"].Visible = false;
            setTooltips();
        }

        public override void Entered(StateControl from, Data.User user, Data.User returnUser)
        {
            this.CurrentUser = user;
            this.returnUser = returnUser;
            dtg_users_list.DataSource = Data.UserList.Instance;
            dtg_groups_groups.DataSource = Data.GroupList.Instance;
            dtg_reports_list.DataSource = Data.UserList.Instance.ApplyStatusFilter(Data.User.UserType.Student);
            manageAddButtons();
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
            MainWindow.Instance.SwitchForm<CreateNewUser>(this.CurrentUser);
        }

        private void btn_users_edit_Click(object sender, EventArgs e)
        {
            var result = getSelectedName(dtg_users_list, "Name");

            if (result.Count() < 1)
                Helpers.DisplayError("No selected user!");
            else
                MainWindow.Instance.SwitchForm<UpdateUser>(Data.UserList.Instance.GetByName(result.First().ToString()), this.CurrentUser);
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

                if (this.CurrentUser == null)
                {
                    Helpers.DisplayError("WE DIDNT SET THE USER FOR THIS SCREEN");
                }
                // Avoid deleting yourself
                else if (toDel.Contains(this.CurrentUser.Name))
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
                manageAddButtons();
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
            MainWindow.Instance.SwitchForm<CreateGroup>(this.returnUser);
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
            if (grpNames.Contains("Ungrouped Users"))
            {
                GUI.Helpers.DisplayError("You can not edit the ungrouped users group.");
                return;
            }
            var grp = Data.GroupList.Instance[Data.GroupList.Instance.GetIdxByName(grpNames.First() as string)];
            MainWindow.Instance.SwitchForm<UpdateGroup>(this.returnUser).SetCurrentGroup(grp);
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

                if (toDel.Contains("Ungrouped Users"))
                {
                    GUI.Helpers.DisplayError("You can not delete the ungrouped users group.");
                    return;
                }

                var msg = string.Format("Are you sure you want to delete {0} ?",
                    (count > 1) ? (string.Format("{0} groups", count))
                    : (string.Format("group '{0}'", toDel.First())));

                if (Helpers.AskQuestion(msg) == DialogResult.Yes)
                    foreach (string u in toDel)
                        Data.GroupList.Instance.RemoveByName(u);
                manageAddButtons();
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

        private void btn_export_Click(object sender, EventArgs e)
        {
            Data.ExcelHandler.createExcelSheet(Data.UserList.Instance.ApplyStatusFilter(Data.User.UserType.Student).ToList());
        }

        private void setTooltips()
        {
            tltp.SetToolTip(btn_export, "Export To Excel");
            tltp.SetToolTip(btn_exit, "Logout");
            tltp.SetToolTip(btn_groups_create, "Create New Group");
            tltp.SetToolTip(btn_groups_delete, "Delete Group");
            tltp.SetToolTip(btn_groups_edit, "Edit Group");
            tltp.SetToolTip(btn_groups_logout, "Logout");
            tltp.SetToolTip(btn_log_out, "Logout");
            tltp.SetToolTip(btn_users_add, "Create New User");
            tltp.SetToolTip(btn_users_del, "Delete User");
            tltp.SetToolTip(btn_users_edit, "Edit User");
            tltp.SetToolTip(btn_users_logout, "Logout");
        }

        private void manageAddButtons()
        {
            if (dtg_users_list.Rows.Count >= 100)
            {
                btn_users_add.Visible = false;
            }
            else
            {
                btn_users_add.Visible = true;
            }

            if (dtg_groups_groups.Rows.Count >= 10)
            {
                btn_groups_create.Visible = false;
            }
            else
            {
                btn_groups_create.Visible = true;
            }
        }


    }
}