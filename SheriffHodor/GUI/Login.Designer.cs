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
            this.txt_password = new System.Windows.Forms.TextBox();
            this.ddl_userList = new System.Windows.Forms.ComboBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_password
            // 
            this.txt_password.AccessibleDescription = "Enter your password here";
            this.txt_password.AccessibleName = "Password";
            this.txt_password.Location = new System.Drawing.Point(265, 234);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(144, 20);
            this.txt_password.TabIndex = 11;
            // 
            // ddl_userList
            // 
            this.ddl_userList.DropDownHeight = 100;
            this.ddl_userList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddl_userList.FormattingEnabled = true;
            this.ddl_userList.IntegralHeight = false;
            this.ddl_userList.Location = new System.Drawing.Point(264, 207);
            this.ddl_userList.Name = "ddl_userList";
            this.ddl_userList.Size = new System.Drawing.Size(145, 21);
            this.ddl_userList.TabIndex = 10;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(194, 79);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(307, 55);
            this.lbl_title.TabIndex = 9;
            this.lbl_title.Text = "Sheriff Hodor";
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(265, 260);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(144, 25);
            this.btn_login.TabIndex = 12;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Sienna;
            this.BackgroundImage = global::CSUSM.CS441.SheriffHodor.Properties.Resources.desert_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(730, 480);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.ddl_userList);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.btn_login);
            this.MaximumSize = new System.Drawing.Size(730, 480);
            this.MinimumSize = new System.Drawing.Size(730, 480);
            this.Name = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ddl_userList;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox txt_password;

    }
}