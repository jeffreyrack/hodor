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
            this.txt_current_name = new System.Windows.Forms.TextBox();
            this.txt_new_name = new System.Windows.Forms.TextBox();
            this.btn_submit = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ddl_groups = new System.Windows.Forms.ComboBox();
            this.lbl_group = new System.Windows.Forms.Label();
            this.lbl_new_name = new System.Windows.Forms.Label();
            this.lbl_current_name = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_current_name
            // 
            this.txt_current_name.Location = new System.Drawing.Point(84, 13);
            this.txt_current_name.Name = "txt_current_name";
            this.txt_current_name.ReadOnly = true;
            this.txt_current_name.Size = new System.Drawing.Size(211, 20);
            this.txt_current_name.TabIndex = 0;
            // 
            // txt_new_name
            // 
            this.txt_new_name.Location = new System.Drawing.Point(84, 102);
            this.txt_new_name.Name = "txt_new_name";
            this.txt_new_name.Size = new System.Drawing.Size(211, 20);
            this.txt_new_name.TabIndex = 1;
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(13, 201);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(75, 23);
            this.btn_submit.TabIndex = 2;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(239, 201);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ddl_groups);
            this.groupBox1.Controls.Add(this.lbl_group);
            this.groupBox1.Controls.Add(this.lbl_new_name);
            this.groupBox1.Controls.Add(this.lbl_current_name);
            this.groupBox1.Controls.Add(this.txt_new_name);
            this.groupBox1.Controls.Add(this.txt_current_name);
            this.groupBox1.Location = new System.Drawing.Point(13, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 164);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // ddl_groups
            // 
            this.ddl_groups.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddl_groups.FormattingEnabled = true;
            this.ddl_groups.Location = new System.Drawing.Point(84, 132);
            this.ddl_groups.Name = "ddl_groups";
            this.ddl_groups.Size = new System.Drawing.Size(211, 21);
            this.ddl_groups.TabIndex = 6;
            // 
            // lbl_group
            // 
            this.lbl_group.AutoSize = true;
            this.lbl_group.Location = new System.Drawing.Point(42, 135);
            this.lbl_group.Name = "lbl_group";
            this.lbl_group.Size = new System.Drawing.Size(36, 13);
            this.lbl_group.TabIndex = 5;
            this.lbl_group.Text = "Group";
            // 
            // lbl_new_name
            // 
            this.lbl_new_name.AutoSize = true;
            this.lbl_new_name.Location = new System.Drawing.Point(18, 105);
            this.lbl_new_name.Name = "lbl_new_name";
            this.lbl_new_name.Size = new System.Drawing.Size(60, 13);
            this.lbl_new_name.TabIndex = 4;
            this.lbl_new_name.Text = "New Name";
            // 
            // lbl_current_name
            // 
            this.lbl_current_name.AutoSize = true;
            this.lbl_current_name.Location = new System.Drawing.Point(6, 16);
            this.lbl_current_name.Name = "lbl_current_name";
            this.lbl_current_name.Size = new System.Drawing.Size(72, 13);
            this.lbl_current_name.TabIndex = 3;
            this.lbl_current_name.Text = "Current Name";
            // 
            // UpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_submit);
            this.Name = "UpdateUser";
            this.Size = new System.Drawing.Size(400, 253);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_current_name;
        private System.Windows.Forms.TextBox txt_new_name;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox ddl_groups;
        private System.Windows.Forms.Label lbl_group;
        private System.Windows.Forms.Label lbl_new_name;
        private System.Windows.Forms.Label lbl_current_name;
    }
}
