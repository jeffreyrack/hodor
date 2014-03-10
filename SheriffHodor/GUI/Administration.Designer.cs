namespace CSUSM.CS441.SheriffHodor.GUI
{
    partial class Administration
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
            this.tab_display = new System.Windows.Forms.TabControl();
            this.pg_report = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dudNumRange = new System.Windows.Forms.DomainUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdo_negative = new System.Windows.Forms.RadioButton();
            this.rdo_positive = new System.Windows.Forms.RadioButton();
            this.rdo_addition = new System.Windows.Forms.RadioButton();
            this.rdo_subtraction = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.nudNumOfProb = new System.Windows.Forms.NumericUpDown();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.clstUserList = new System.Windows.Forms.CheckedListBox();
            this.dgvSummary = new System.Windows.Forms.DataGridView();
            this.clmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSummary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_update = new System.Windows.Forms.Button();
            this.pg_problems = new System.Windows.Forms.TabPage();
            this.pg_users = new System.Windows.Forms.TabPage();
            this.btn_users_logout = new System.Windows.Forms.Button();
            this.btn_users_del = new System.Windows.Forms.Button();
            this.btn_users_edit = new System.Windows.Forms.Button();
            this.btn_users_add = new System.Windows.Forms.Button();
            this.dtg_users_list = new System.Windows.Forms.DataGridView();
            this.tab_display.SuspendLayout();
            this.pg_report.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumOfProb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSummary)).BeginInit();
            this.pg_users.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_users_list)).BeginInit();
            this.SuspendLayout();
            // 
            // tab_display
            // 
            this.tab_display.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab_display.Controls.Add(this.pg_report);
            this.tab_display.Controls.Add(this.pg_problems);
            this.tab_display.Controls.Add(this.pg_users);
            this.tab_display.Location = new System.Drawing.Point(0, 0);
            this.tab_display.Name = "tab_display";
            this.tab_display.SelectedIndex = 0;
            this.tab_display.Size = new System.Drawing.Size(714, 451);
            this.tab_display.TabIndex = 19;
            // 
            // pg_report
            // 
            this.pg_report.Controls.Add(this.groupBox2);
            this.pg_report.Controls.Add(this.groupBox1);
            this.pg_report.Controls.Add(this.label1);
            this.pg_report.Controls.Add(this.nudNumOfProb);
            this.pg_report.Controls.Add(this.btn_cancel);
            this.pg_report.Controls.Add(this.clstUserList);
            this.pg_report.Controls.Add(this.dgvSummary);
            this.pg_report.Controls.Add(this.btn_update);
            this.pg_report.Location = new System.Drawing.Point(4, 22);
            this.pg_report.Name = "pg_report";
            this.pg_report.Padding = new System.Windows.Forms.Padding(3);
            this.pg_report.Size = new System.Drawing.Size(706, 425);
            this.pg_report.TabIndex = 0;
            this.pg_report.Text = "Reports";
            this.pg_report.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dudNumRange);
            this.groupBox2.Location = new System.Drawing.Point(273, 268);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(180, 88);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Number Range";
            // 
            // dudNumRange
            // 
            this.dudNumRange.Items.Add("10");
            this.dudNumRange.Items.Add("100");
            this.dudNumRange.Items.Add("1,000");
            this.dudNumRange.Items.Add("10,000");
            this.dudNumRange.Items.Add("100,000");
            this.dudNumRange.Items.Add("Any Number");
            this.dudNumRange.Location = new System.Drawing.Point(19, 29);
            this.dudNumRange.Name = "dudNumRange";
            this.dudNumRange.ReadOnly = true;
            this.dudNumRange.Size = new System.Drawing.Size(120, 20);
            this.dudNumRange.TabIndex = 19;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.rdo_addition);
            this.groupBox1.Controls.Add(this.rdo_subtraction);
            this.groupBox1.Location = new System.Drawing.Point(11, 268);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 88);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Preferences";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdo_negative);
            this.groupBox3.Controls.Add(this.rdo_positive);
            this.groupBox3.Location = new System.Drawing.Point(100, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(145, 88);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Answers allowed";
            // 
            // rdo_negative
            // 
            this.rdo_negative.AutoSize = true;
            this.rdo_negative.Location = new System.Drawing.Point(6, 42);
            this.rdo_negative.Name = "rdo_negative";
            this.rdo_negative.Size = new System.Drawing.Size(129, 17);
            this.rdo_negative.TabIndex = 12;
            this.rdo_negative.Text = "Positive and Negative";
            this.rdo_negative.UseVisualStyleBackColor = true;
            // 
            // rdo_positive
            // 
            this.rdo_positive.AutoSize = true;
            this.rdo_positive.Checked = true;
            this.rdo_positive.Location = new System.Drawing.Point(6, 19);
            this.rdo_positive.Name = "rdo_positive";
            this.rdo_positive.Size = new System.Drawing.Size(86, 17);
            this.rdo_positive.TabIndex = 11;
            this.rdo_positive.TabStop = true;
            this.rdo_positive.Text = "Positive Only";
            this.rdo_positive.UseVisualStyleBackColor = true;
            // 
            // rdo_addition
            // 
            this.rdo_addition.AutoSize = true;
            this.rdo_addition.Checked = true;
            this.rdo_addition.Location = new System.Drawing.Point(6, 19);
            this.rdo_addition.Name = "rdo_addition";
            this.rdo_addition.Size = new System.Drawing.Size(63, 17);
            this.rdo_addition.TabIndex = 9;
            this.rdo_addition.TabStop = true;
            this.rdo_addition.Text = "Addition";
            this.rdo_addition.UseVisualStyleBackColor = true;
            // 
            // rdo_subtraction
            // 
            this.rdo_subtraction.AutoSize = true;
            this.rdo_subtraction.Location = new System.Drawing.Point(6, 42);
            this.rdo_subtraction.Name = "rdo_subtraction";
            this.rdo_subtraction.Size = new System.Drawing.Size(79, 17);
            this.rdo_subtraction.TabIndex = 10;
            this.rdo_subtraction.Text = "Subtraction";
            this.rdo_subtraction.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(476, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Number of Problems";
            // 
            // nudNumOfProb
            // 
            this.nudNumOfProb.Location = new System.Drawing.Point(496, 287);
            this.nudNumOfProb.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudNumOfProb.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumOfProb.Name = "nudNumOfProb";
            this.nudNumOfProb.Size = new System.Drawing.Size(67, 20);
            this.nudNumOfProb.TabIndex = 31;
            this.nudNumOfProb.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(610, 310);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 30;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // clstUserList
            // 
            this.clstUserList.CheckOnClick = true;
            this.clstUserList.FormattingEnabled = true;
            this.clstUserList.Location = new System.Drawing.Point(27, 43);
            this.clstUserList.Name = "clstUserList";
            this.clstUserList.ScrollAlwaysVisible = true;
            this.clstUserList.Size = new System.Drawing.Size(297, 154);
            this.clstUserList.TabIndex = 29;
            // 
            // dgvSummary
            // 
            this.dgvSummary.AllowUserToAddRows = false;
            this.dgvSummary.AllowUserToDeleteRows = false;
            this.dgvSummary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSummary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmName,
            this.clmSummary});
            this.dgvSummary.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvSummary.Location = new System.Drawing.Point(352, 43);
            this.dgvSummary.Name = "dgvSummary";
            this.dgvSummary.ReadOnly = true;
            this.dgvSummary.RowHeadersVisible = false;
            this.dgvSummary.Size = new System.Drawing.Size(318, 154);
            this.dgvSummary.TabIndex = 28;
            // 
            // clmName
            // 
            this.clmName.HeaderText = "Name";
            this.clmName.Name = "clmName";
            this.clmName.ReadOnly = true;
            this.clmName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // clmSummary
            // 
            this.clmSummary.HeaderText = "Summary";
            this.clmSummary.Name = "clmSummary";
            this.clmSummary.ReadOnly = true;
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(610, 281);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 27;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            // 
            // pg_problems
            // 
            this.pg_problems.Location = new System.Drawing.Point(4, 22);
            this.pg_problems.Name = "pg_problems";
            this.pg_problems.Padding = new System.Windows.Forms.Padding(3);
            this.pg_problems.Size = new System.Drawing.Size(706, 425);
            this.pg_problems.TabIndex = 1;
            this.pg_problems.Text = "Problems";
            this.pg_problems.UseVisualStyleBackColor = true;
            // 
            // pg_users
            // 
            this.pg_users.Controls.Add(this.btn_users_logout);
            this.pg_users.Controls.Add(this.btn_users_del);
            this.pg_users.Controls.Add(this.btn_users_edit);
            this.pg_users.Controls.Add(this.btn_users_add);
            this.pg_users.Controls.Add(this.dtg_users_list);
            this.pg_users.Location = new System.Drawing.Point(4, 22);
            this.pg_users.Name = "pg_users";
            this.pg_users.Padding = new System.Windows.Forms.Padding(3);
            this.pg_users.Size = new System.Drawing.Size(706, 425);
            this.pg_users.TabIndex = 2;
            this.pg_users.Text = "Users";
            this.pg_users.UseVisualStyleBackColor = true;
            // 
            // btn_users_logout
            // 
            this.btn_users_logout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_users_logout.Location = new System.Drawing.Point(580, 381);
            this.btn_users_logout.Name = "btn_users_logout";
            this.btn_users_logout.Size = new System.Drawing.Size(120, 23);
            this.btn_users_logout.TabIndex = 4;
            this.btn_users_logout.Text = "Log out";
            this.btn_users_logout.UseVisualStyleBackColor = true;
            this.btn_users_logout.Click += new System.EventHandler(this.btn_users_logout_Click);
            // 
            // btn_users_del
            // 
            this.btn_users_del.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_users_del.Enabled = false;
            this.btn_users_del.Location = new System.Drawing.Point(255, 381);
            this.btn_users_del.Name = "btn_users_del";
            this.btn_users_del.Size = new System.Drawing.Size(120, 23);
            this.btn_users_del.TabIndex = 3;
            this.btn_users_del.Text = "Delete selected user";
            this.btn_users_del.UseVisualStyleBackColor = true;
            this.btn_users_del.Click += new System.EventHandler(this.btn_users_del_Click);
            // 
            // btn_users_edit
            // 
            this.btn_users_edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_users_edit.Enabled = false;
            this.btn_users_edit.Location = new System.Drawing.Point(129, 381);
            this.btn_users_edit.Name = "btn_users_edit";
            this.btn_users_edit.Size = new System.Drawing.Size(120, 23);
            this.btn_users_edit.TabIndex = 2;
            this.btn_users_edit.Text = "Edit selected user";
            this.btn_users_edit.UseVisualStyleBackColor = true;
            this.btn_users_edit.Click += new System.EventHandler(this.btn_users_edit_Click);
            // 
            // btn_users_add
            // 
            this.btn_users_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_users_add.Location = new System.Drawing.Point(6, 381);
            this.btn_users_add.Name = "btn_users_add";
            this.btn_users_add.Size = new System.Drawing.Size(120, 23);
            this.btn_users_add.TabIndex = 1;
            this.btn_users_add.Text = "Create new user";
            this.btn_users_add.UseVisualStyleBackColor = true;
            this.btn_users_add.Click += new System.EventHandler(this.btn_users_add_Click);
            // 
            // dtg_users_list
            // 
            this.dtg_users_list.AllowUserToAddRows = false;
            this.dtg_users_list.AllowUserToDeleteRows = false;
            this.dtg_users_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_users_list.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtg_users_list.Location = new System.Drawing.Point(3, 3);
            this.dtg_users_list.Name = "dtg_users_list";
            this.dtg_users_list.ReadOnly = true;
            this.dtg_users_list.Size = new System.Drawing.Size(700, 345);
            this.dtg_users_list.TabIndex = 0;
            // 
            // Administration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tab_display);
            this.MaximumSize = new System.Drawing.Size(714, 451);
            this.MinimumSize = new System.Drawing.Size(714, 451);
            this.Name = "Administration";
            this.Size = new System.Drawing.Size(714, 451);
            this.Load += new System.EventHandler(this.Administration_Load);
            this.tab_display.ResumeLayout(false);
            this.pg_report.ResumeLayout(false);
            this.pg_report.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumOfProb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSummary)).EndInit();
            this.pg_users.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_users_list)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_display;
        private System.Windows.Forms.TabPage pg_report;
        private System.Windows.Forms.TabPage pg_problems;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DomainUpDown dudNumRange;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdo_negative;
        private System.Windows.Forms.RadioButton rdo_positive;
        private System.Windows.Forms.RadioButton rdo_addition;
        private System.Windows.Forms.RadioButton rdo_subtraction;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudNumOfProb;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.CheckedListBox clstUserList;
        private System.Windows.Forms.DataGridView dgvSummary;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSummary;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.TabPage pg_users;
        private System.Windows.Forms.Button btn_users_logout;
        private System.Windows.Forms.Button btn_users_del;
        private System.Windows.Forms.Button btn_users_edit;
        private System.Windows.Forms.Button btn_users_add;
        private System.Windows.Forms.DataGridView dtg_users_list;

    }
}