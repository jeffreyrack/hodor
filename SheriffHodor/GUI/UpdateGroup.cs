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
        }

        protected override void Accept()
        {
            var grpName = txt_newName.Text;
            if (Data.GroupList.Instance.GetByName(grpName) != -1)
            {
                GUI.Helpers.DisplayError("There is already a group with this name.");
                return;
            }
            var newGroup = new Data.Group();
            newGroup.Name = grpName;
            newGroup.Difficulty = getDifficulty();
            Data.GroupList.Instance.Add(newGroup);
            MainWindow.Instance.SwitchForm<Administration>();
        }

        protected override void Decline()
        {
            MainWindow.Instance.SwitchForm<Administration>();
        }

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

        public void Entered(StateControl from, Data.Group group)
        {
            txt_newName.Text = string.Empty;
            txt_oldName.Text = string.Empty;
        }
    }
}
