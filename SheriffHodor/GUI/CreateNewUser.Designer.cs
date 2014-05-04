namespace CSUSM.CS441.SheriffHodor.GUI
{
    partial class CreateNewUser
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
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbox_createGroup = new System.Windows.Forms.GroupBox();
            this.gbox_groups = new System.Windows.Forms.GroupBox();
            this.ddl_groupList = new System.Windows.Forms.ComboBox();
            this.lbl_groups = new System.Windows.Forms.Label();
            this.gbox_passwords = new System.Windows.Forms.GroupBox();
            this.txt_passwordConfirm = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.lbl_passwordConfirm = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.gbox_role = new System.Windows.Forms.GroupBox();
            this.rdo_admin = new System.Windows.Forms.RadioButton();
            this.lbl_status = new System.Windows.Forms.Label();
            this.rdo_user = new System.Windows.Forms.RadioButton();
            this.lbl_username = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_create = new System.Windows.Forms.Button();
            this.gbox_createGroup.SuspendLayout();
            this.gbox_groups.SuspendLayout();
            this.gbox_passwords.SuspendLayout();
            this.gbox_role.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbox_createGroup
            // 
            this.gbox_createGroup.BackColor = System.Drawing.Color.Tan;
            this.gbox_createGroup.Controls.Add(this.gbox_groups);
            this.gbox_createGroup.Controls.Add(this.gbox_passwords);
            this.gbox_createGroup.Controls.Add(this.gbox_role);
            this.gbox_createGroup.Controls.Add(this.lbl_username);
            this.gbox_createGroup.Controls.Add(this.txt_username);
            this.gbox_createGroup.Location = new System.Drawing.Point(223, 55);
            this.gbox_createGroup.Name = "gbox_createGroup";
            this.gbox_createGroup.Size = new System.Drawing.Size(341, 273);
            this.gbox_createGroup.TabIndex = 16;
            this.gbox_createGroup.TabStop = false;
            // 
            // gbox_groups
            // 
            this.gbox_groups.BackColor = System.Drawing.Color.Transparent;
            this.gbox_groups.Controls.Add(this.ddl_groupList);
            this.gbox_groups.Controls.Add(this.lbl_groups);
            this.gbox_groups.Location = new System.Drawing.Point(16, 86);
            this.gbox_groups.Name = "gbox_groups";
            this.gbox_groups.Size = new System.Drawing.Size(267, 63);
            this.gbox_groups.TabIndex = 15;
            this.gbox_groups.TabStop = false;
            // 
            // ddl_groupList
            // 
            this.ddl_groupList.BackColor = System.Drawing.Color.BurlyWood;
            this.ddl_groupList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddl_groupList.FormattingEnabled = true;
            this.ddl_groupList.Location = new System.Drawing.Point(63, 26);
            this.ddl_groupList.Name = "ddl_groupList";
            this.ddl_groupList.Size = new System.Drawing.Size(196, 21);
            this.ddl_groupList.TabIndex = 12;
            // 
            // lbl_groups
            // 
            this.lbl_groups.AutoSize = true;
            this.lbl_groups.Location = new System.Drawing.Point(12, 29);
            this.lbl_groups.Name = "lbl_groups";
            this.lbl_groups.Size = new System.Drawing.Size(44, 13);
            this.lbl_groups.TabIndex = 13;
            this.lbl_groups.Text = "Groups:";
            // 
            // gbox_passwords
            // 
            this.gbox_passwords.BackColor = System.Drawing.Color.Transparent;
            this.gbox_passwords.Controls.Add(this.txt_passwordConfirm);
            this.gbox_passwords.Controls.Add(this.txt_password);
            this.gbox_passwords.Controls.Add(this.lbl_passwordConfirm);
            this.gbox_passwords.Controls.Add(this.lbl_password);
            this.gbox_passwords.Location = new System.Drawing.Point(16, 155);
            this.gbox_passwords.Name = "gbox_passwords";
            this.gbox_passwords.Size = new System.Drawing.Size(271, 81);
            this.gbox_passwords.TabIndex = 14;
            this.gbox_passwords.TabStop = false;
            // 
            // txt_passwordConfirm
            // 
            this.txt_passwordConfirm.Location = new System.Drawing.Point(63, 45);
            this.txt_passwordConfirm.Name = "txt_passwordConfirm";
            this.txt_passwordConfirm.Size = new System.Drawing.Size(196, 20);
            this.txt_passwordConfirm.TabIndex = 16;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(64, 13);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(196, 20);
            this.txt_password.TabIndex = 15;
            // 
            // lbl_passwordConfirm
            // 
            this.lbl_passwordConfirm.AutoSize = true;
            this.lbl_passwordConfirm.Location = new System.Drawing.Point(13, 48);
            this.lbl_passwordConfirm.Name = "lbl_passwordConfirm";
            this.lbl_passwordConfirm.Size = new System.Drawing.Size(45, 13);
            this.lbl_passwordConfirm.TabIndex = 1;
            this.lbl_passwordConfirm.Text = "Confirm:";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(6, 16);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(56, 13);
            this.lbl_password.TabIndex = 0;
            this.lbl_password.Text = "Password:";
            // 
            // gbox_role
            // 
            this.gbox_role.BackColor = System.Drawing.Color.Transparent;
            this.gbox_role.Controls.Add(this.rdo_admin);
            this.gbox_role.Controls.Add(this.lbl_status);
            this.gbox_role.Controls.Add(this.rdo_user);
            this.gbox_role.Location = new System.Drawing.Point(16, 36);
            this.gbox_role.Name = "gbox_role";
            this.gbox_role.Size = new System.Drawing.Size(271, 48);
            this.gbox_role.TabIndex = 11;
            this.gbox_role.TabStop = false;
            // 
            // rdo_admin
            // 
            this.rdo_admin.AutoSize = true;
            this.rdo_admin.Location = new System.Drawing.Point(142, 19);
            this.rdo_admin.Name = "rdo_admin";
            this.rdo_admin.Size = new System.Drawing.Size(65, 17);
            this.rdo_admin.TabIndex = 7;
            this.rdo_admin.Text = "Teacher";
            this.rdo_admin.UseVisualStyleBackColor = true;
            this.rdo_admin.CheckedChanged += new System.EventHandler(this.rdo_admin_CheckedChanged);
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Location = new System.Drawing.Point(12, 21);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(32, 13);
            this.lbl_status.TabIndex = 10;
            this.lbl_status.Text = "Role:";
            // 
            // rdo_user
            // 
            this.rdo_user.AutoSize = true;
            this.rdo_user.Checked = true;
            this.rdo_user.Location = new System.Drawing.Point(63, 19);
            this.rdo_user.Name = "rdo_user";
            this.rdo_user.Size = new System.Drawing.Size(62, 17);
            this.rdo_user.TabIndex = 8;
            this.rdo_user.TabStop = true;
            this.rdo_user.Text = "Student";
            this.rdo_user.UseVisualStyleBackColor = true;
            this.rdo_user.CheckedChanged += new System.EventHandler(this.rdo_user_CheckedChanged);
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Location = new System.Drawing.Point(17, 13);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(61, 13);
            this.lbl_username.TabIndex = 9;
            this.lbl_username.Text = "Username :";
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(80, 10);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(196, 20);
            this.txt_username.TabIndex = 6;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancel.Image = global::CSUSM.CS441.SheriffHodor.Properties.Resources.exit_button3;
            this.btn_cancel.Location = new System.Drawing.Point(648, 403);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(84, 78);
            this.btn_cancel.TabIndex = 5;
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_create
            // 
            this.btn_create.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_create.BackgroundImage = global::CSUSM.CS441.SheriffHodor.Properties.Resources.resizedSubmit;
            this.btn_create.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_create.Location = new System.Drawing.Point(514, 448);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(128, 33);
            this.btn_create.TabIndex = 4;
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // CreateNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.BackgroundImage = global::CSUSM.CS441.SheriffHodor.Properties.Resources.second_desert_background;
            this.ClientSize = new System.Drawing.Size(730, 480);
            this.Controls.Add(this.gbox_createGroup);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_create);
            this.MaximumSize = new System.Drawing.Size(730, 480);
            this.MinimumSize = new System.Drawing.Size(730, 480);
            this.Name = "CreateNewUser";
            this.gbox_createGroup.ResumeLayout(false);
            this.gbox_createGroup.PerformLayout();
            this.gbox_groups.ResumeLayout(false);
            this.gbox_groups.PerformLayout();
            this.gbox_passwords.ResumeLayout(false);
            this.gbox_passwords.PerformLayout();
            this.gbox_role.ResumeLayout(false);
            this.gbox_role.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.RadioButton rdo_admin;
        private System.Windows.Forms.RadioButton rdo_user;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.GroupBox gbox_role;
        private System.Windows.Forms.ComboBox ddl_groupList;
        private System.Windows.Forms.Label lbl_groups;
        private System.Windows.Forms.GroupBox gbox_passwords;
        private System.Windows.Forms.TextBox txt_passwordConfirm;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label lbl_passwordConfirm;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.GroupBox gbox_groups;
        private System.Windows.Forms.GroupBox gbox_createGroup;
    }
}