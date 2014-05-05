using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CSUSM.CS441.SheriffHodor.GUI
{
    public partial class UpdateGroup : StateControl
    {
        public UpdateGroup()
        {
            InitializeComponent();
            this.AcceptButton = this.btn_accept;
            this.gbox_updateGroup.BackColor = Data.Global.opaqueBackground;
            dtg_ungrouped_users.DataSource = Data.UserList.Instance.ApplyGroupFilter("Ungrouped Users");
            this.dtg_ungrouped_users = createUngroupedUserDataGrid(this.dtg_ungrouped_users);
            tltp.SetToolTip(btn_cancel, "Return to Admin Form");
            tltp.SetToolTip(btn_accept , "Update Group");
        }

        protected override void Accept()
        {
            var grpName = txt_newName.Text;
            if (grpName != txt_oldName.Text)
            {
                if (Data.GroupList.Instance.GetIdxByName(grpName) != -1)
                {
                    GUI.Helpers.DisplayError("There is already a group with this name.");
                    return;
                }
                this.CurrentGroup.Name = grpName;
            }
            addStudentsToGroup(dtg_ungrouped_users, this.CurrentGroup, 1, 0);
            this.CurrentGroup.Difficulty = getDifficulty();
            Cleanup();
            MainWindow.Instance.SwitchForm<Administration>(this.CurrentUser);
        }
        protected override void Decline()
        {
            Cleanup();
            MainWindow.Instance.SwitchForm<Administration>(this.CurrentUser);
        }
        public override void Entered(StateControl from, Data.User user, Data.User returnUser)
        {
            base.Entered(from, user, returnUser);
            txt_newName.Text = string.Empty;
            txt_oldName.Text = string.Empty;
            dtg_ungrouped_users.DataSource = Data.UserList.Instance.ApplyGroupFilter("Ungrouped Users");
        }

        private Data.Group CurrentGroup { get; set; }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Decline();
        }
        private void btn_accept_Click(object sender, EventArgs e)
        {
            txt_newName.Text = txt_newName.Text.Trim();
            if (txt_newName.Text == string.Empty)
                GUI.Helpers.DisplayError("No name provided for the group !");
            else
                Accept();
        }

        private Data.Problem.Difficulty getDifficulty()
        {
            return rdo_easy.Checked ? Data.Problem.Difficulty.Easy :
                    (rdo_medium.Checked ? Data.Problem.Difficulty.Medium
                    : Data.Problem.Difficulty.Hard);
        }
        private void setDifficulty(Data.Problem.Difficulty diff)
        {
            switch (diff)
            {
                case Data.Problem.Difficulty.Easy:
                    rdo_easy.Checked = true;
                    break;
                case Data.Problem.Difficulty.Medium:
                    rdo_medium.Checked = true;
                    break;
                case Data.Problem.Difficulty.Hard:
                    rdo_hard.Checked = true;
                    break;
            }
        }

        /// <summary>
        /// Must be called to set the current group.
        /// </summary>
        /// <param name="group">The group to update.</param>
        public void SetCurrentGroup(Data.Group group)
        {
            this.CurrentGroup = group;
            txt_oldName.Text = txt_newName.Text = group.Name;
            setDifficulty(group.Difficulty);
        }

        private void Cleanup()
        {
            this.CurrentGroup = null;
            txt_newName.Text = string.Empty;
            txt_oldName.Text = string.Empty;
        }
    }
}
