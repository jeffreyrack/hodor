namespace CSUSM.CS441.SheriffHodor.GUI
{
    partial class StudentMenu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rdo_practice = new System.Windows.Forms.RadioButton();
            this.rdo_test = new System.Windows.Forms.RadioButton();
            this.rdo_exercise = new System.Windows.Forms.RadioButton();
            this.lbl_greetings = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_continue = new System.Windows.Forms.Button();
            this.gb_type = new System.Windows.Forms.GroupBox();
            this.gb_type.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdo_practice
            // 
            this.rdo_practice.AutoSize = true;
            this.rdo_practice.Checked = true;
            this.rdo_practice.Location = new System.Drawing.Point(23, 29);
            this.rdo_practice.Name = "rdo_practice";
            this.rdo_practice.Size = new System.Drawing.Size(64, 17);
            this.rdo_practice.TabIndex = 0;
            this.rdo_practice.TabStop = true;
            this.rdo_practice.Text = "Practice";
            this.rdo_practice.UseVisualStyleBackColor = true;
            // 
            // rdo_test
            // 
            this.rdo_test.AutoSize = true;
            this.rdo_test.Enabled = false;
            this.rdo_test.Location = new System.Drawing.Point(23, 94);
            this.rdo_test.Name = "rdo_test";
            this.rdo_test.Size = new System.Drawing.Size(79, 17);
            this.rdo_test.TabIndex = 1;
            this.rdo_test.Text = "Take a test";
            this.rdo_test.UseVisualStyleBackColor = true;
            // 
            // rdo_exercise
            // 
            this.rdo_exercise.AutoSize = true;
            this.rdo_exercise.Enabled = false;
            this.rdo_exercise.Location = new System.Drawing.Point(23, 157);
            this.rdo_exercise.Name = "rdo_exercise";
            this.rdo_exercise.Size = new System.Drawing.Size(108, 17);
            this.rdo_exercise.TabIndex = 2;
            this.rdo_exercise.Text = "Do class exercise";
            this.rdo_exercise.UseVisualStyleBackColor = true;
            // 
            // lbl_greetings
            // 
            this.lbl_greetings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_greetings.AutoSize = true;
            this.lbl_greetings.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_greetings.Location = new System.Drawing.Point(182, 37);
            this.lbl_greetings.Name = "lbl_greetings";
            this.lbl_greetings.Size = new System.Drawing.Size(300, 26);
            this.lbl_greetings.TabIndex = 4;
            this.lbl_greetings.Text = "Welcome to Sheriff Hodor !";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancel.Location = new System.Drawing.Point(455, 366);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 5;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_continue
            // 
            this.btn_continue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_continue.Location = new System.Drawing.Point(536, 366);
            this.btn_continue.Name = "btn_continue";
            this.btn_continue.Size = new System.Drawing.Size(75, 23);
            this.btn_continue.TabIndex = 6;
            this.btn_continue.Text = "Continue";
            this.btn_continue.UseVisualStyleBackColor = true;
            this.btn_continue.Click += new System.EventHandler(this.btn_continue_Click);
            // 
            // gb_type
            // 
            this.gb_type.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_type.Controls.Add(this.rdo_practice);
            this.gb_type.Controls.Add(this.rdo_test);
            this.gb_type.Controls.Add(this.rdo_exercise);
            this.gb_type.Location = new System.Drawing.Point(106, 108);
            this.gb_type.Name = "gb_type";
            this.gb_type.Size = new System.Drawing.Size(455, 222);
            this.gb_type.TabIndex = 7;
            this.gb_type.TabStop = false;
            this.gb_type.Text = "Choose your type of exercise:";
            // 
            // StudentMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gb_type);
            this.Controls.Add(this.btn_continue);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.lbl_greetings);
            this.Name = "StudentMenu";
            this.Size = new System.Drawing.Size(655, 439);
            this.gb_type.ResumeLayout(false);
            this.gb_type.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdo_practice;
        private System.Windows.Forms.RadioButton rdo_test;
        private System.Windows.Forms.RadioButton rdo_exercise;
        private System.Windows.Forms.Label lbl_greetings;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_continue;
        private System.Windows.Forms.GroupBox gb_type;
    }
}
