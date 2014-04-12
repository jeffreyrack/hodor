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
            this.txt_name = new System.Windows.Forms.TextBox();
            this.rdo_hard = new System.Windows.Forms.RadioButton();
            this.rdo_medium = new System.Windows.Forms.RadioButton();
            this.rdo_easy = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.btn_create = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(77, 35);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(196, 20);
            this.txt_name.TabIndex = 19;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Difficulty:";
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
            // btn_create
            // 
            this.btn_create.Location = new System.Drawing.Point(657, 375);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(75, 23);
            this.btn_create.TabIndex = 11;
            this.btn_create.Text = "Create";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancel.Image = global::CSUSM.CS441.SheriffHodor.Properties.Resources.exit_button3;
            this.btn_cancel.Location = new System.Drawing.Point(648, 404);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(84, 78);
            this.btn_cancel.TabIndex = 10;
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Tan;
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.lbl_name);
            this.groupBox1.Controls.Add(this.txt_name);
            this.groupBox1.Location = new System.Drawing.Point(219, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 158);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Tan;
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.rdo_easy);
            this.groupBox2.Controls.Add(this.rdo_hard);
            this.groupBox2.Controls.Add(this.rdo_medium);
            this.groupBox2.Location = new System.Drawing.Point(0, 61);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(334, 97);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            // 
            // CreateGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CSUSM.CS441.SheriffHodor.Properties.Resources.second_desert_background;
            this.ClientSize = new System.Drawing.Size(730, 480);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.btn_cancel);
            this.MaximumSize = new System.Drawing.Size(730, 480);
            this.MinimumSize = new System.Drawing.Size(730, 480);
            this.Name = "CreateGroup";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}
