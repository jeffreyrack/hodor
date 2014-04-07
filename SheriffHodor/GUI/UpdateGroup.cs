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
            this.CurrentGroup.Difficulty = getDifficulty();
            Cleanup();
            MainWindow.Instance.SwitchForm<Administration>(this.CurrentUser);
        }
        protected override void Decline()
        {
            Cleanup();
            MainWindow.Instance.SwitchForm<Administration>();
        }
        public override void Entered(StateControl from, Data.User user)
        {
            base.Entered(from, user);
            txt_newName.Text = string.Empty;
            txt_oldName.Text = string.Empty;
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
