﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CSUSM.CS441.SheriffHodor.GUI
{
    public partial class CreateGroup : StateControl
    {
        public CreateGroup()
        {
            InitializeComponent();
            this.AcceptButton = this.btn_create;
            this.gbox_createGroup.BackColor = Data.Global.opaqueBackground;
            dtg_ungrouped_users.DataSource = Data.UserList.Instance.ApplyGroupFilter("Ungrouped Users");
            this.dtg_ungrouped_users = createUngroupedUserDataGrid(this.dtg_ungrouped_users);
        }

        protected override void Accept()
        {
            var grpName = txt_name.Text;
            if (Data.GroupList.Instance.GetIdxByName(grpName) != -1)
            {
                GUI.Helpers.DisplayError("There is already a group with this name.");
                return;
            }
            var newGroup = new Data.Group();
            newGroup.Name = grpName;
            newGroup.Difficulty = getDifficulty();
            Data.GroupList.Instance.Add(newGroup);
            addStudentsToGroup(dtg_ungrouped_users, newGroup, 1, 0);
            MainWindow.Instance.SwitchForm<Administration>(this.CurrentUser);
        }

        protected override void Decline()
        {
            MainWindow.Instance.SwitchForm<Administration>(this.CurrentUser);
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Decline();
        }

        private Data.Problem.Difficulty getDifficulty()
        {
            return rdo_easy.Checked ? Data.Problem.Difficulty.Easy :
                    (rdo_medium.Checked ? Data.Problem.Difficulty.Medium
                    : Data.Problem.Difficulty.Hard);
        }

        public override void Entered(StateControl from, Data.User user, Data.User returnUser)
        {
            base.Entered(from, user, returnUser);
            dtg_ungrouped_users.DataSource = Data.UserList.Instance.ApplyGroupFilter("Ungrouped Users");
            txt_name.Text = string.Empty;
            this.CurrentUser = user;
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            txt_name.Text = txt_name.Text.Trim();
            if (txt_name.Text == string.Empty)
            {
                GUI.Helpers.DisplayError("ERROR: Please enter a group name.");
                return;
            }
                Accept();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
