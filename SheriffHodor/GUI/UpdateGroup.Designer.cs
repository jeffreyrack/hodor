namespace CSUSM.CS441.SheriffHodor.GUI
{
    partial class UpdateGroup
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
            this.txt_newName = new System.Windows.Forms.TextBox();
            this.txt_oldName = new System.Windows.Forms.TextBox();
            this.rdo_hard = new System.Windows.Forms.RadioButton();
            this.rdo_medium = new System.Windows.Forms.RadioButton();
            this.rdo_easy = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_oldName = new System.Windows.Forms.Label();
            this.lbl_newName = new System.Windows.Forms.Label();
            this.btn_accept = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_newName
            // 
            this.txt_newName.Location = new System.Drawing.Point(129, 50);
            this.txt_newName.Name = "txt_newName";
            this.txt_newName.Size = new System.Drawing.Size(196, 20);
            this.txt_newName.TabIndex = 9;
            // 
            // txt_oldName
            // 
            this.txt_oldName.Location = new System.Drawing.Point(129, 14);
            this.txt_oldName.Name = "txt_oldName";
            this.txt_oldName.ReadOnly = true;
            this.txt_oldName.Size = new System.Drawing.Size(196, 20);
            this.txt_oldName.TabIndex = 8;
            // 
            // rdo_hard
            // 
            this.rdo_hard.AutoSize = true;
            this.rdo_hard.Location = new System.Drawing.Point(311, 89);
            this.rdo_hard.Name = "rdo_hard";
            this.rdo_hard.Size = new System.Drawing.Size(48, 17);
            this.rdo_hard.TabIndex = 7;
            this.rdo_hard.Text = "Hard";
            this.rdo_hard.UseVisualStyleBackColor = true;
            // 
            // rdo_medium
            // 
            this.rdo_medium.AutoSize = true;
            this.rdo_medium.Location = new System.Drawing.Point(220, 89);
            this.rdo_medium.Name = "rdo_medium";
            this.rdo_medium.Size = new System.Drawing.Size(62, 17);
            this.rdo_medium.TabIndex = 6;
            this.rdo_medium.Text = "Medium";
            this.rdo_medium.UseVisualStyleBackColor = true;
            // 
            // rdo_easy
            // 
            this.rdo_easy.AutoSize = true;
            this.rdo_easy.Checked = true;
            this.rdo_easy.Location = new System.Drawing.Point(129, 89);
            this.rdo_easy.Name = "rdo_easy";
            this.rdo_easy.Size = new System.Drawing.Size(48, 17);
            this.rdo_easy.TabIndex = 5;
            this.rdo_easy.TabStop = true;
            this.rdo_easy.Text = "Easy";
            this.rdo_easy.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Difficulty:";
            // 
            // lbl_oldName
            // 
            this.lbl_oldName.AutoSize = true;
            this.lbl_oldName.Location = new System.Drawing.Point(15, 14);
            this.lbl_oldName.Name = "lbl_oldName";
            this.lbl_oldName.Size = new System.Drawing.Size(107, 13);
            this.lbl_oldName.TabIndex = 3;
            this.lbl_oldName.Text = "Original group name :";
            // 
            // lbl_newName
            // 
            this.lbl_newName.AutoSize = true;
            this.lbl_newName.Location = new System.Drawing.Point(15, 50);
            this.lbl_newName.Name = "lbl_newName";
            this.lbl_newName.Size = new System.Drawing.Size(61, 13);
            this.lbl_newName.TabIndex = 2;
            this.lbl_newName.Text = "New name:";
            // 
            // btn_accept
            // 
            this.btn_accept.Location = new System.Drawing.Point(659, 375);
            this.btn_accept.Name = "btn_accept";
            this.btn_accept.Size = new System.Drawing.Size(75, 23);
            this.btn_accept.TabIndex = 1;
            this.btn_accept.Text = "Accept";
            this.btn_accept.UseVisualStyleBackColor = true;
            this.btn_accept.Click += new System.EventHandler(this.btn_accept_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_newName);
            this.groupBox1.Controls.Add(this.txt_oldName);
            this.groupBox1.Controls.Add(this.rdo_hard);
            this.groupBox1.Controls.Add(this.rdo_medium);
            this.groupBox1.Controls.Add(this.rdo_easy);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbl_oldName);
            this.groupBox1.Controls.Add(this.lbl_newName);
            this.groupBox1.Location = new System.Drawing.Point(158, 145);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 161);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancel.Image = global::CSUSM.CS441.SheriffHodor.Properties.Resources.exit_button3;
            this.btn_cancel.Location = new System.Drawing.Point(650, 404);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(84, 78);
            this.btn_cancel.TabIndex = 0;
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // UpdateGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.BackgroundImage = global::CSUSM.CS441.SheriffHodor.Properties.Resources.second_desert_background;
            this.ClientSize = new System.Drawing.Size(730, 480);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_accept);
            this.MaximumSize = new System.Drawing.Size(730, 480);
            this.MinimumSize = new System.Drawing.Size(730, 480);
            this.Name = "UpdateGroup";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_accept;
        private System.Windows.Forms.Label lbl_newName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdo_easy;
        private System.Windows.Forms.RadioButton rdo_medium;
        private System.Windows.Forms.RadioButton rdo_hard;
        private System.Windows.Forms.TextBox txt_newName;
        private System.Windows.Forms.TextBox txt_oldName;
        private System.Windows.Forms.Label lbl_oldName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_cancel;
    }
}
