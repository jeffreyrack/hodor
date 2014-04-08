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
            this.gb_name = new System.Windows.Forms.GroupBox();
            this.lbl_newName = new System.Windows.Forms.Label();
            this.lbl_currentName = new System.Windows.Forms.Label();
            this.txt_newName = new System.Windows.Forms.TextBox();
            this.txt_currentName = new System.Windows.Forms.TextBox();
            this.ddl_groups = new System.Windows.Forms.ComboBox();
            this.lbl_group = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_submit = new System.Windows.Forms.Button();
            this.lbl_newPassword = new System.Windows.Forms.Label();
            this.txt_newPassword = new System.Windows.Forms.TextBox();
            this.lbl_newPasswordConfirm = new System.Windows.Forms.Label();
            this.txt_newPasswordConfirm = new System.Windows.Forms.TextBox();
            this.gb_userSpecific = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gb_name.SuspendLayout();
            this.gb_userSpecific.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_name
            // 
            this.gb_name.Controls.Add(this.lbl_newName);
            this.gb_name.Controls.Add(this.lbl_currentName);
            this.gb_name.Controls.Add(this.txt_newName);
            this.gb_name.Controls.Add(this.txt_currentName);
            this.gb_name.Location = new System.Drawing.Point(13, 11);
            this.gb_name.Name = "gb_name";
            this.gb_name.Size = new System.Drawing.Size(354, 94);
            this.gb_name.TabIndex = 4;
            this.gb_name.TabStop = false;
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
            this.txt_newName.Size = new System.Drawing.Size(211, 20);
            this.txt_newName.TabIndex = 1;
            // 
            // txt_currentName
            // 
            this.txt_currentName.Location = new System.Drawing.Point(137, 31);
            this.txt_currentName.Name = "txt_currentName";
            this.txt_currentName.ReadOnly = true;
            this.txt_currentName.Size = new System.Drawing.Size(211, 20);
            this.txt_currentName.TabIndex = 0;
            // 
            // ddl_groups
            // 
            this.ddl_groups.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddl_groups.FormattingEnabled = true;
            this.ddl_groups.Location = new System.Drawing.Point(137, 19);
            this.ddl_groups.Name = "ddl_groups";
            this.ddl_groups.Size = new System.Drawing.Size(211, 21);
            this.ddl_groups.TabIndex = 6;
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
            // btn_cancel
            // 
            this.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancel.Image = global::CSUSM.CS441.SheriffHodor.Properties.Resources.exit_button3;
            this.btn_cancel.Location = new System.Drawing.Point(325, 220);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(82, 61);
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(13, 252);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(75, 23);
            this.btn_submit.TabIndex = 2;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
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
            // txt_newPassword
            // 
            this.txt_newPassword.Location = new System.Drawing.Point(137, 46);
            this.txt_newPassword.Name = "txt_newPassword";
            this.txt_newPassword.Size = new System.Drawing.Size(211, 20);
            this.txt_newPassword.TabIndex = 7;
            this.txt_newPassword.UseSystemPasswordChar = true;
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
            // txt_newPasswordConfirm
            // 
            this.txt_newPasswordConfirm.Location = new System.Drawing.Point(137, 72);
            this.txt_newPasswordConfirm.Name = "txt_newPasswordConfirm";
            this.txt_newPasswordConfirm.Size = new System.Drawing.Size(211, 20);
            this.txt_newPasswordConfirm.TabIndex = 9;
            this.txt_newPasswordConfirm.UseSystemPasswordChar = true;
            // 
            // gb_userSpecific
            // 
            this.gb_userSpecific.Controls.Add(this.ddl_groups);
            this.gb_userSpecific.Controls.Add(this.lbl_newPasswordConfirm);
            this.gb_userSpecific.Controls.Add(this.lbl_group);
            this.gb_userSpecific.Controls.Add(this.txt_newPasswordConfirm);
            this.gb_userSpecific.Controls.Add(this.txt_newPassword);
            this.gb_userSpecific.Controls.Add(this.lbl_newPassword);
            this.gb_userSpecific.Location = new System.Drawing.Point(13, 102);
            this.gb_userSpecific.Name = "gb_userSpecific";
            this.gb_userSpecific.Size = new System.Drawing.Size(354, 110);
            this.gb_userSpecific.TabIndex = 11;
            this.gb_userSpecific.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gb_userSpecific);
            this.groupBox1.Controls.Add(this.gb_name);
            this.groupBox1.Controls.Add(this.btn_cancel);
            this.groupBox1.Controls.Add(this.btn_submit);
            this.groupBox1.Location = new System.Drawing.Point(210, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(407, 281);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // UpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.BackgroundImage = global::CSUSM.CS441.SheriffHodor.Properties.Resources.second_desert_background;
            this.ClientSize = new System.Drawing.Size(909, 526);
            this.Controls.Add(this.groupBox1);
            this.Name = "UpdateUser";
            this.gb_name.ResumeLayout(false);
            this.gb_name.PerformLayout();
            this.gb_userSpecific.ResumeLayout(false);
            this.gb_userSpecific.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_currentName;
        private System.Windows.Forms.TextBox txt_newName;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.GroupBox gb_name;
        private System.Windows.Forms.ComboBox ddl_groups;
        private System.Windows.Forms.Label lbl_group;
        private System.Windows.Forms.Label lbl_newName;
        private System.Windows.Forms.Label lbl_currentName;
        private System.Windows.Forms.Label lbl_newPassword;
        private System.Windows.Forms.TextBox txt_newPassword;
        private System.Windows.Forms.Label lbl_newPasswordConfirm;
        private System.Windows.Forms.TextBox txt_newPasswordConfirm;
        private System.Windows.Forms.GroupBox gb_userSpecific;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
