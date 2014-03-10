namespace CSUSM.CS441.SheriffHodor.GUI
{
    partial class Login
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
            this.ddl_userList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.btn_create = new System.Windows.Forms.Button();
            this.grp_login = new System.Windows.Forms.GroupBox();
            this.lbl_or = new System.Windows.Forms.Label();
            this.grp_login.SuspendLayout();
            this.SuspendLayout();
            // 
            // ddl_userList
            // 
            this.ddl_userList.FormattingEnabled = true;
            this.ddl_userList.Location = new System.Drawing.Point(25, 18);
            this.ddl_userList.Name = "ddl_userList";
            this.ddl_userList.Size = new System.Drawing.Size(145, 21);
            this.ddl_userList.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 55);
            this.label1.TabIndex = 9;
            this.label1.Text = "Sheriff Hodor";
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(26, 71);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(144, 25);
            this.btn_login.TabIndex = 6;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // txt_password
            // 
            this.txt_password.AccessibleDescription = "Enter your password here";
            this.txt_password.AccessibleName = "Password";
            this.txt_password.Location = new System.Drawing.Point(26, 45);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(144, 20);
            this.txt_password.TabIndex = 11;
            // 
            // btn_create
            // 
            this.btn_create.Location = new System.Drawing.Point(148, 316);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(144, 23);
            this.btn_create.TabIndex = 12;
            this.btn_create.Text = "Create New User";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // grp_login
            // 
            this.grp_login.Controls.Add(this.txt_password);
            this.grp_login.Controls.Add(this.ddl_userList);
            this.grp_login.Controls.Add(this.btn_login);
            this.grp_login.Location = new System.Drawing.Point(122, 141);
            this.grp_login.Name = "grp_login";
            this.grp_login.Size = new System.Drawing.Size(195, 127);
            this.grp_login.TabIndex = 13;
            this.grp_login.TabStop = false;
            // 
            // lbl_or
            // 
            this.lbl_or.AutoSize = true;
            this.lbl_or.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_or.Location = new System.Drawing.Point(200, 283);
            this.lbl_or.Name = "lbl_or";
            this.lbl_or.Size = new System.Drawing.Size(35, 20);
            this.lbl_or.TabIndex = 14;
            this.lbl_or.Text = "OR";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_or);
            this.Controls.Add(this.grp_login);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(452, 375);
            this.MinimumSize = new System.Drawing.Size(452, 375);
            this.Name = "Login";
            this.Size = new System.Drawing.Size(452, 375);
            this.grp_login.ResumeLayout(false);
            this.grp_login.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ddl_userList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.GroupBox grp_login;
        private System.Windows.Forms.Label lbl_or;

    }
}