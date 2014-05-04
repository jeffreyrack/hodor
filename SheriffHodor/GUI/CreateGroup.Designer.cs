namespace CSUSM.CS441.SheriffHodor.GUI
{
    partial class CreateGroup
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
            this.dtg_ungrouped_users = new System.Windows.Forms.DataGridView();
            this.gbox_createGroup = new System.Windows.Forms.GroupBox();
            this.gbox_createUser = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rdo_easy = new System.Windows.Forms.RadioButton();
            this.rdo_hard = new System.Windows.Forms.RadioButton();
            this.rdo_medium = new System.Windows.Forms.RadioButton();
            this.lbl_name = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.btn_create = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_ungrouped_users)).BeginInit();
            this.gbox_createGroup.SuspendLayout();
            this.gbox_createUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtg_ungrouped_users
            // 
            this.dtg_ungrouped_users.AllowUserToAddRows = false;
            this.dtg_ungrouped_users.AllowUserToDeleteRows = false;
            this.dtg_ungrouped_users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_ungrouped_users.Location = new System.Drawing.Point(422, 78);
            this.dtg_ungrouped_users.Name = "dtg_ungrouped_users";
            this.dtg_ungrouped_users.Size = new System.Drawing.Size(287, 210);
            this.dtg_ungrouped_users.TabIndex = 21;
            // 
            // gbox_createGroup
            // 
            this.gbox_createGroup.BackColor = System.Drawing.Color.Tan;
            this.gbox_createGroup.Controls.Add(this.gbox_createUser);
            this.gbox_createGroup.Controls.Add(this.lbl_name);
            this.gbox_createGroup.Controls.Add(this.txt_name);
            this.gbox_createGroup.Location = new System.Drawing.Point(47, 78);
            this.gbox_createGroup.Name = "gbox_createGroup";
            this.gbox_createGroup.Size = new System.Drawing.Size(334, 158);
            this.gbox_createGroup.TabIndex = 20;
            this.gbox_createGroup.TabStop = false;
            // 
            // gbox_createUser
            // 
            this.gbox_createUser.BackColor = System.Drawing.Color.Transparent;
            this.gbox_createUser.Controls.Add(this.label3);
            this.gbox_createUser.Controls.Add(this.rdo_easy);
            this.gbox_createUser.Controls.Add(this.rdo_hard);
            this.gbox_createUser.Controls.Add(this.rdo_medium);
            this.gbox_createUser.Location = new System.Drawing.Point(0, 61);
            this.gbox_createUser.Name = "gbox_createUser";
            this.gbox_createUser.Size = new System.Drawing.Size(334, 97);
            this.gbox_createUser.TabIndex = 21;
            this.gbox_createUser.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Difficulty:";
            // 
            // rdo_easy
            // 
            this.rdo_easy.AutoSize = true;
            this.rdo_easy.Checked = true;
            this.rdo_easy.Location = new System.Drawing.Point(77, 47);
            this.rdo_easy.Name = "rdo_easy";
            this.rdo_easy.Size = new System.Drawing.Size(48, 17);
            this.rdo_easy.TabIndex = 15;
            this.rdo_easy.TabStop = true;
            this.rdo_easy.Text = "Easy";
            this.rdo_easy.UseVisualStyleBackColor = true;
            // 
            // rdo_hard
            // 
            this.rdo_hard.AutoSize = true;
            this.rdo_hard.Location = new System.Drawing.Point(238, 47);
            this.rdo_hard.Name = "rdo_hard";
            this.rdo_hard.Size = new System.Drawing.Size(48, 17);
            this.rdo_hard.TabIndex = 17;
            this.rdo_hard.Text = "Hard";
            this.rdo_hard.UseVisualStyleBackColor = true;
            // 
            // rdo_medium
            // 
            this.rdo_medium.AutoSize = true;
            this.rdo_medium.Location = new System.Drawing.Point(154, 47);
            this.rdo_medium.Name = "rdo_medium";
            this.rdo_medium.Size = new System.Drawing.Size(62, 17);
            this.rdo_medium.TabIndex = 16;
            this.rdo_medium.Text = "Medium";
            this.rdo_medium.UseVisualStyleBackColor = true;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(15, 38);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(38, 13);
            this.lbl_name.TabIndex = 12;
            this.lbl_name.Text = "Name:";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(77, 35);
            this.txt_name.MaxLength = 100;
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(196, 20);
            this.txt_name.TabIndex = 19;
            // 
            // btn_create
            // 
            this.btn_create.BackgroundImage = global::CSUSM.CS441.SheriffHodor.Properties.Resources.Button_Add_icon;
            this.btn_create.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_create.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_create.Location = new System.Drawing.Point(575, 400);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(75, 75);
            this.btn_create.TabIndex = 11;
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackgroundImage = global::CSUSM.CS441.SheriffHodor.Properties.Resources.logout_icon;
            this.btn_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancel.Location = new System.Drawing.Point(656, 400);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 75);
            this.btn_cancel.TabIndex = 10;
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // CreateGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CSUSM.CS441.SheriffHodor.Properties.Resources.second_desert_background;
            this.ClientSize = new System.Drawing.Size(730, 480);
            this.Controls.Add(this.dtg_ungrouped_users);
            this.Controls.Add(this.gbox_createGroup);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.btn_cancel);
            this.MaximumSize = new System.Drawing.Size(730, 480);
            this.MinimumSize = new System.Drawing.Size(730, 480);
            this.Name = "CreateGroup";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_ungrouped_users)).EndInit();
            this.gbox_createGroup.ResumeLayout(false);
            this.gbox_createGroup.PerformLayout();
            this.gbox_createUser.ResumeLayout(false);
            this.gbox_createUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.RadioButton rdo_hard;
        private System.Windows.Forms.RadioButton rdo_medium;
        private System.Windows.Forms.RadioButton rdo_easy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.GroupBox gbox_createGroup;
        private System.Windows.Forms.GroupBox gbox_createUser;
        private System.Windows.Forms.DataGridView dtg_ungrouped_users;
    }
}
