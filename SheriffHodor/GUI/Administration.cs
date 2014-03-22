/*Team Hodor
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

namespace CSUSM.CS441.SheriffHodor.GUI
{
    public partial class Administration : StateControl
    {
        public Administration()
        {
            InitializeComponent();
            UserListChanged(null, null);
            Data.UserList.Instance.CollectionChanged += new NotifyCollectionChangedEventHandler(UserListChanged);
        }

        private void UserListChanged(object o, EventArgs e)
        {
            // Users
            dtg_users_list.DataSource = null;
            dtg_users_list.DataSource = Data.UserList.Instance;
            dtg_users_list.Invalidate();
            dtg_users_list.Refresh();
        }

        // The "Reports" tab.
        #region Reports
        #endregion

        // The "Users" tab.
        #region Users Panel
        private void btn_users_add_Click(object sender, EventArgs e)
        {
            MainWindow.Instance.SwitchForm("createuser");
        }
        private void btn_users_edit_Click(object sender, EventArgs e)
        {
        }
        private void btn_users_del_Click(object sender, EventArgs e)
        {
            try
            {
                // The ToList() is needed, as else it would stay lazy and request invalidated data (from SelectRows).
                var toDel = (from DataGridViewRow name in dtg_users_list.SelectedRows select name.Cells["Name"].Value).ToList();
                var count = toDel.Count();

                // No item selected
                if (count < 1)
                    return;

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
        #endregion
    }
}