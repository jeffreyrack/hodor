namespace CSUSM.CS441.SheriffHodor.GUI
{
    partial class UpdateUser
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbox_updateUser = new System.Windows.Forms.GroupBox();
            this.gbox_userSpecific = new System.Windows.Forms.GroupBox();
            this.ddl_groups = new System.Windows.Forms.ComboBox();
            this.lbl_newPasswordConfirm = new System.Windows.Forms.Label();
            this.lbl_group = new System.Windows.Forms.Label();
            this.txt_newPasswordConfirm = new System.Windows.Forms.TextBox();
            this.txt_newPassword = new System.Windows.Forms.TextBox();
            this.lbl_newPassword = new System.Windows.Forms.Label();
            this.gbox_name = new System.Windows.Forms.GroupBox();
            this.lbl_newName = new System.Windows.Forms.Label();
            this.lbl_currentName = new System.Windows.Forms.Label();
            this.txt_newName = new System.Windows.Forms.TextBox();
            this.txt_currentName = new System.Windows.Forms.TextBox();
            this.btn_submit = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.gbox_updateUser.SuspendLayout();
            this.gbox_userSpecific.SuspendLayout();
            this.gbox_name.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbox_updateUser
            // 
            this.gbox_updateUser.Controls.Add(this.gbox_userSpecific);
            this.gbox_updateUser.Controls.Add(this.gbox_name);
            this.gbox_updateUser.Location = new System.Drawing.Point(168, 64);
            this.gbox_updateUser.Name = "gbox_updateUser";
            this.gbox_updateUser.Size = new System.Drawing.Size(407, 281);
            this.gbox_updateUser.TabIndex = 12;
            this.gbox_updateUser.TabStop = false;
            // 
            // gbox_userSpecific
            // 
            this.gbox_userSpecific.BackColor = System.Drawing.Color.Transparent;
            this.gbox_userSpecific.Controls.Add(this.ddl_groups);
            this.gbox_userSpecific.Controls.Add(this.lbl_newPasswordConfirm);
            this.gbox_userSpecific.Controls.Add(this.lbl_group);
            this.gbox_userSpecific.Controls.Add(this.txt_newPasswordConfirm);
            this.gbox_userSpecific.Controls.Add(this.txt_newPassword);
            this.gbox_userSpecific.Controls.Add(this.lbl_newPassword);
            this.gbox_userSpecific.Location = new System.Drawing.Point(13, 102);
            this.gbox_userSpecific.Name = "gbox_userSpecific";
            this.gbox_userSpecific.Size = new System.Drawing.Size(354, 110);
            this.gbox_userSpecific.TabIndex = 11;
            this.gbox_userSpecific.TabStop = false;
            // 
            // ddl_groups
            // 
            this.ddl_groups.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddl_groups.FormattingEnabled = true;
            this.ddl_groups.Location = new System.Drawing.Point(137, 19);
            this.ddl_groups.Name = "ddl_groups";
            this.ddl_groups.Size = new System.Drawing.Size(196, 21);
            this.ddl_groups.TabIndex = 6;
            // 
            // lbl_newPasswordConfirm
            // 
            this.lbl_newPasswordConfirm.AutoSize = true;
            this.lbl_newPasswordConfirm.Location = new System.Drawing.Point(18, 75);
            this.lbl_newPasswordConfirm.Name = "lbl_newPasswordConfirm";
            this.lbl_newPasswordConfirm.Size = new System.Drawing.Size(113, 13);
            this.lbl_newPasswordConfirm.TabIndex = 10;
            this.lbl_newPasswordConfirm.Text = "Confirm new password";
            // 
            // lbl_group
            // 
            this.lbl_group.AutoSize = true;
            this.lbl_group.Location = new System.Drawing.Point(18, 22);
            this.lbl_group.Name = "lbl_group";
            this.lbl_group.Size = new System.Drawing.Size(36, 13);
            this.lbl_group.TabIndex = 5;
            this.lbl_group.Text = "Group";
            // 
            // txt_newPasswordConfirm
            // 
            this.txt_newPasswordConfirm.Location = new System.Drawing.Point(137, 72);
            this.txt_newPasswordConfirm.Name = "txt_newPasswordConfirm";
            this.txt_newPasswordConfirm.Size = new System.Drawing.Size(196, 20);
            this.txt_newPasswordConfirm.TabIndex = 9;
            this.txt_newPasswordConfirm.UseSystemPasswordChar = true;
            // 
            // txt_newPassword
            // 
            this.txt_newPassword.Location = new System.Drawing.Point(137, 46);
            this.txt_newPassword.Name = "txt_newPassword";
            this.txt_newPassword.Size = new System.Drawing.Size(196, 20);
            this.txt_newPassword.TabIndex = 7;
            this.txt_newPassword.UseSystemPasswordChar = true;
            // 
            // lbl_newPassword
            // 
            this.lbl_newPassword.AutoSize = true;
            this.lbl_newPassword.Location = new System.Drawing.Point(18, 49);
            this.lbl_newPassword.Name = "lbl_newPassword";
            this.lbl_newPassword.Size = new System.Drawing.Size(83, 13);
            this.lbl_newPassword.TabIndex = 8;
            this.lbl_newPassword.Text = "New password :";
            // 
            // gbox_name
            // 
            this.gbox_name.BackColor = System.Drawing.Color.Transparent;
            this.gbox_name.Controls.Add(this.lbl_newName);
            this.gbox_name.Controls.Add(this.lbl_currentName);
            this.gbox_name.Controls.Add(this.txt_newName);
            this.gbox_name.Controls.Add(this.txt_currentName);
            this.gbox_name.Location = new System.Drawing.Point(13, 11);
            this.gbox_name.Name = "gbox_name";
            this.gbox_name.Size = new System.Drawing.Size(354, 94);
            this.gbox_name.TabIndex = 4;
            this.gbox_name.TabStop = false;
            // 
            // lbl_newName
            // 
            this.lbl_newName.AutoSize = true;
            this.lbl_newName.Location = new System.Drawing.Point(18, 60);
            this.lbl_newName.Name = "lbl_newName";
            this.lbl_newName.Size = new System.Drawing.Size(60, 13);
            this.lbl_newName.TabIndex = 4;
            this.lbl_newName.Text = "New Name";
            // 
            // lbl_currentName
            // 
            this.lbl_currentName.AutoSize = true;
            this.lbl_currentName.Location = new System.Drawing.Point(18, 34);
            this.lbl_currentName.Name = "lbl_currentName";
            this.lbl_currentName.Size = new System.Drawing.Size(72, 13);
            this.lbl_currentName.TabIndex = 3;
            this.lbl_currentName.Text = "Current Name";
            // 
            // txt_newName
            // 
            this.txt_newName.Location = new System.Drawing.Point(137, 57);
            this.txt_newName.Name = "txt_newName";
            this.txt_newName.Size = new System.Drawing.Size(196, 20);
            this.txt_newName.TabIndex = 1;
            // 
            // txt_currentName
            // 
            this.txt_currentName.Location = new System.Drawing.Point(137, 31);
            this.txt_currentName.Name = "txt_currentName";
            this.txt_currentName.ReadOnly = true;
            this.txt_currentName.Size = new System.Drawing.Size(196, 20);
            this.txt_currentName.TabIndex = 0;
            // 
            // btn_submit
            // 
            this.btn_submit.BackgroundImage = global::CSUSM.CS441.SheriffHodor.Properties.Resources.resizedSubmit;
            this.btn_submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_submit.Location = new System.Drawing.Point(504, 445);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(125, 36);
            this.btn_submit.TabIndex = 2;
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancel.Image = global::CSUSM.CS441.SheriffHodor.Properties.Resources.exit_button3;
            this.btn_cancel.Location = new System.Drawing.Point(646, 403);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(84, 78);
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // UpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.BackgroundImage = global::CSUSM.CS441.SheriffHodor.Properties.Resources.second_desert_background;
            this.ClientSize = new System.Drawing.Size(730, 480);
            this.Controls.Add(this.gbox_updateUser);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.btn_cancel);
            this.MaximumSize = new System.Drawing.Size(730, 480);
            this.MinimumSize = new System.Drawing.Size(730, 480);
            this.Name = "UpdateUser";
            this.gbox_updateUser.ResumeLayout(false);
            this.gbox_userSpecific.ResumeLayout(false);
            this.gbox_userSpecific.PerformLayout();
            this.gbox_name.ResumeLayout(false);
            this.gbox_name.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_currentName;
        private System.Windows.Forms.TextBox txt_newName;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.GroupBox gbox_name;
        private System.Windows.Forms.ComboBox ddl_groups;
        private System.Windows.Forms.Label lbl_group;
        private System.Windows.Forms.Label lbl_newName;
        private System.Windows.Forms.Label lbl_currentName;
        private System.Windows.Forms.Label lbl_newPassword;
        private System.Windows.Forms.TextBox txt_newPassword;
        private System.Windows.Forms.Label lbl_newPasswordConfirm;
        private System.Windows.Forms.TextBox txt_newPasswordConfirm;
        private System.Windows.Forms.GroupBox gbox_userSpecific;
        private System.Windows.Forms.GroupBox gbox_updateUser;
    }
}
