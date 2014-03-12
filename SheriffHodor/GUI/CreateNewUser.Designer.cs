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
            this.btn_create = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.rdo_admin = new System.Windows.Forms.RadioButton();
            this.rdo_user = new System.Windows.Forms.RadioButton();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_create
            // 
            this.btn_create.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_create.Location = new System.Drawing.Point(211, 167);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(75, 23);
            this.btn_create.TabIndex = 4;
            this.btn_create.Text = "Create";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancel.Location = new System.Drawing.Point(130, 167);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 5;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(90, 25);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(196, 20);
            this.txt_username.TabIndex = 6;
            // 
            // rdo_admin
            // 
            this.rdo_admin.AutoSize = true;
            this.rdo_admin.Location = new System.Drawing.Point(169, 49);
            this.rdo_admin.Name = "rdo_admin";
            this.rdo_admin.Size = new System.Drawing.Size(75, 17);
            this.rdo_admin.TabIndex = 7;
            this.rdo_admin.Text = "Supervisor";
            this.rdo_admin.UseVisualStyleBackColor = true;
            // 
            // rdo_user
            // 
            this.rdo_user.AutoSize = true;
            this.rdo_user.Checked = true;
            this.rdo_user.Location = new System.Drawing.Point(90, 49);
            this.rdo_user.Name = "rdo_user";
            this.rdo_user.Size = new System.Drawing.Size(73, 17);
            this.rdo_user.TabIndex = 8;
            this.rdo_user.TabStop = true;
            this.rdo_user.Text = "Test-taker";
            this.rdo_user.UseVisualStyleBackColor = true;
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Location = new System.Drawing.Point(23, 28);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(61, 13);
            this.lbl_username.TabIndex = 9;
            this.lbl_username.Text = "Username :";
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Location = new System.Drawing.Point(23, 51);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(43, 13);
            this.lbl_status.TabIndex = 10;
            this.lbl_status.Text = "Status :";
            // 
            // CreateNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.rdo_user);
            this.Controls.Add(this.rdo_admin);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_create);
            this.MaximumSize = new System.Drawing.Size(300, 204);
            this.MinimumSize = new System.Drawing.Size(300, 204);
            this.Name = "CreateNewUser";
            this.Size = new System.Drawing.Size(300, 204);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.RadioButton rdo_admin;
        private System.Windows.Forms.RadioButton rdo_user;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_status;
    }
}