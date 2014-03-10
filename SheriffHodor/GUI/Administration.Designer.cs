﻿namespace CSUSM.CS441.SheriffHodor.GUI
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
            this.btn_update = new System.Windows.Forms.Button();
            this.dgvSummary = new System.Windows.Forms.DataGridView();
            this.clmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSummary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clstUserList = new System.Windows.Forms.CheckedListBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.rdo_addition = new System.Windows.Forms.RadioButton();
            this.rdo_subtraction = new System.Windows.Forms.RadioButton();
            this.rdo_positive = new System.Windows.Forms.RadioButton();
            this.rdo_negative = new System.Windows.Forms.RadioButton();
            this.nudNumOfProb = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dudNumRange = new System.Windows.Forms.DomainUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSummary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumOfProb)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(611, 267);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 5;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btnUpdate_Click);
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
            this.dgvSummary.Location = new System.Drawing.Point(353, 29);
            this.dgvSummary.Name = "dgvSummary";
            this.dgvSummary.ReadOnly = true;
            this.dgvSummary.RowHeadersVisible = false;
            this.dgvSummary.Size = new System.Drawing.Size(318, 154);
            this.dgvSummary.TabIndex = 6;
            this.dgvSummary.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSummary_CellClick);
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
            // clstUserList
            // 
            this.clstUserList.CheckOnClick = true;
            this.clstUserList.FormattingEnabled = true;
            this.clstUserList.Location = new System.Drawing.Point(28, 29);
            this.clstUserList.Name = "clstUserList";
            this.clstUserList.ScrollAlwaysVisible = true;
            this.clstUserList.Size = new System.Drawing.Size(297, 154);
            this.clstUserList.TabIndex = 7;
            this.clstUserList.SelectedIndexChanged += new System.EventHandler(this.clstUserList_SelectedIndexChanged);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(611, 296);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 8;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.Cancel_Click);
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
            this.rdo_addition.CheckedChanged += new System.EventHandler(this.optAddition_CheckedChanged);
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
            this.rdo_subtraction.CheckedChanged += new System.EventHandler(this.optSubtraction_CheckedChanged);
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
            this.rdo_positive.CheckedChanged += new System.EventHandler(this.optPositive_CheckedChanged);
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
            this.rdo_negative.CheckedChanged += new System.EventHandler(this.optNegative_CheckedChanged);
            // 
            // nudNumOfProb
            // 
            this.nudNumOfProb.Location = new System.Drawing.Point(497, 273);
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
            this.nudNumOfProb.TabIndex = 13;
            this.nudNumOfProb.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(477, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Number of Problems";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.rdo_addition);
            this.groupBox1.Controls.Add(this.rdo_subtraction);
            this.groupBox1.Location = new System.Drawing.Point(12, 254);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 88);
            this.groupBox1.TabIndex = 16;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dudNumRange);
            this.groupBox2.Location = new System.Drawing.Point(274, 254);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(180, 88);
            this.groupBox2.TabIndex = 18;
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
            this.dudNumRange.SelectedItemChanged += new System.EventHandler(this.dudNumRange_SelectedItemChanged);
            // 
            // Administration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudNumOfProb);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.clstUserList);
            this.Controls.Add(this.dgvSummary);
            this.Controls.Add(this.btn_update);
            this.MaximumSize = new System.Drawing.Size(714, 451);
            this.MinimumSize = new System.Drawing.Size(714, 451);
            this.Name = "Administration";
            this.Size = new System.Drawing.Size(714, 451);
            this.Load += new System.EventHandler(this.Administration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSummary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumOfProb)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.DataGridView dgvSummary;
        private System.Windows.Forms.CheckedListBox clstUserList;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.RadioButton rdo_addition;
        private System.Windows.Forms.RadioButton rdo_subtraction;
        private System.Windows.Forms.RadioButton rdo_positive;
        private System.Windows.Forms.RadioButton rdo_negative;
        private System.Windows.Forms.NumericUpDown nudNumOfProb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DomainUpDown dudNumRange;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSummary;
    }
}