namespace Cycle1gui
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
            if (disposing && (components != null))
            {
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox_newUser = new System.Windows.Forms.TextBox();
            this.radioButton_admin = new System.Windows.Forms.RadioButton();
            this.radioButton_user = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(197, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(197, 135);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox_newUser
            // 
            this.textBox_newUser.Location = new System.Drawing.Point(30, 108);
            this.textBox_newUser.Name = "textBox_newUser";
            this.textBox_newUser.Size = new System.Drawing.Size(127, 20);
            this.textBox_newUser.TabIndex = 6;
            this.textBox_newUser.Text = "Name: first and last";
            this.textBox_newUser.TextChanged += new System.EventHandler(this.textBox_newUser_TextChanged);
            // 
            // radioButton_admin
            // 
            this.radioButton_admin.AutoSize = true;
            this.radioButton_admin.Location = new System.Drawing.Point(30, 13);
            this.radioButton_admin.Name = "radioButton_admin";
            this.radioButton_admin.Size = new System.Drawing.Size(75, 17);
            this.radioButton_admin.TabIndex = 7;
            this.radioButton_admin.TabStop = true;
            this.radioButton_admin.Text = "Supervisor";
            this.radioButton_admin.UseVisualStyleBackColor = true;
            this.radioButton_admin.CheckedChanged += new System.EventHandler(this.radioButton_admin_CheckedChanged);
            // 
            // radioButton_user
            // 
            this.radioButton_user.AutoSize = true;
            this.radioButton_user.Location = new System.Drawing.Point(30, 37);
            this.radioButton_user.Name = "radioButton_user";
            this.radioButton_user.Size = new System.Drawing.Size(73, 17);
            this.radioButton_user.TabIndex = 8;
            this.radioButton_user.TabStop = true;
            this.radioButton_user.Text = "Test-taker";
            this.radioButton_user.UseVisualStyleBackColor = true;
            this.radioButton_user.CheckedChanged += new System.EventHandler(this.radioButton_user_CheckedChanged);
            // 
            // CreateNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 165);
            this.Controls.Add(this.radioButton_user);
            this.Controls.Add(this.radioButton_admin);
            this.Controls.Add(this.textBox_newUser);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.MaximumSize = new System.Drawing.Size(300, 204);
            this.MinimumSize = new System.Drawing.Size(300, 204);
            this.Name = "CreateNewUser";
            this.Text = "Create New User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox_newUser;
        private System.Windows.Forms.RadioButton radioButton_admin;
        private System.Windows.Forms.RadioButton radioButton_user;
    }
}