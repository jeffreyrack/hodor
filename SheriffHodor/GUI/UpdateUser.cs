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
    public partial class UpdateUser : StateControl
    {
        public UpdateUser()
        {
            InitializeComponent();
            GroupListChanged(null, null);
            Data.GroupList.Instance.CollectionChanged += new NotifyCollectionChangedEventHandler(GroupListChanged);
        }

        private void GroupListChanged(object o, EventArgs e)
        {
            // Groups
            ddl_groups.DataSource = null;
            ddl_groups.DataSource = Data.GroupList.Instance;
            ddl_groups.Invalidate();
            ddl_groups.Refresh();
        }

        public override void Entered(StateControl from, Data.User user, params object[] args)
        {
            base.Entered(from, user);

            this.txt_current_name.Text = user.Name;
            this.txt_new_name.Text = user.Name;

            if (this.CurrentUser.Status == Data.User.UserType.Teacher)
            {
                lbl_group.Visible = false;
                ddl_groups.Visible = false;
            }
            else if (this.CurrentUser.Status == Data.User.UserType.Student)
            {
                lbl_group.Visible = true;
                ddl_groups.Visible = true;
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            MainWindow.Instance.SwitchForm<Administration>();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            this.txt_new_name.Text = this.txt_new_name.Text.Trim();
            if (this.txt_new_name.Text != string.Empty)
            {
                this.CurrentUser.Name = txt_new_name.Text;
                MainWindow.Instance.SwitchForm<Administration>();
            }
            else
            {
                Helpers.DisplayError("You cannot have an empty name");
                return;
            }
        }
    }
}
