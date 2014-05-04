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
            this.btn_log_out = new System.Windows.Forms.Button();
            this.dtg_reports_list = new System.Windows.Forms.DataGridView();
            this.pg_users = new System.Windows.Forms.TabPage();
            this.btn_users_logout = new System.Windows.Forms.Button();
            this.btn_users_del = new System.Windows.Forms.Button();
            this.btn_users_edit = new System.Windows.Forms.Button();
            this.dtg_users_list = new System.Windows.Forms.DataGridView();
            this.btn_users_add = new System.Windows.Forms.Button();
            this.pg_groups = new System.Windows.Forms.TabPage();
            this.btn_groups_logout = new System.Windows.Forms.Button();
            this.btn_groups_delete = new System.Windows.Forms.Button();
            this.btn_groups_edit = new System.Windows.Forms.Button();
            this.dtg_groups_groups = new System.Windows.Forms.DataGridView();
            this.btn_groups_create = new System.Windows.Forms.Button();
            this.tab_abt_us = new System.Windows.Forms.TabPage();
            this.btn_exit = new System.Windows.Forms.Button();
            this.lbl_about_us = new System.Windows.Forms.Label();
            this.gbox_about_us = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_createdBy = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tab_display.SuspendLayout();
            this.pg_report.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_reports_list)).BeginInit();
            this.pg_users.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_users_list)).BeginInit();
            this.pg_groups.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_groups_groups)).BeginInit();
            this.tab_abt_us.SuspendLayout();
            this.gbox_about_us.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_display
            // 
            this.tab_display.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab_display.Controls.Add(this.pg_report);
            this.tab_display.Controls.Add(this.pg_users);
            this.tab_display.Controls.Add(this.pg_groups);
            this.tab_display.Controls.Add(this.tab_abt_us);
            this.tab_display.Location = new System.Drawing.Point(0, 0);
            this.tab_display.Name = "tab_display";
            this.tab_display.SelectedIndex = 0;
            this.tab_display.Size = new System.Drawing.Size(730, 480);
            this.tab_display.TabIndex = 19;
            this.tab_display.SelectedIndexChanged += new System.EventHandler(this.onTabChange);
            // 
            // pg_report
            // 
            this.pg_report.BackColor = System.Drawing.Color.BurlyWood;
            this.pg_report.Controls.Add(this.btn_log_out);
            this.pg_report.Controls.Add(this.dtg_reports_list);
            this.pg_report.Location = new System.Drawing.Point(4, 22);
            this.pg_report.Name = "pg_report";
            this.pg_report.Padding = new System.Windows.Forms.Padding(3);
            this.pg_report.Size = new System.Drawing.Size(722, 454);
            this.pg_report.TabIndex = 0;
            this.pg_report.Text = "Reports";
            // 
            // btn_log_out
            // 
            this.btn_log_out.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_log_out.BackgroundImage = global::CSUSM.CS441.SheriffHodor.Properties.Resources.logout_icon;
            this.btn_log_out.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_log_out.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_log_out.Location = new System.Drawing.Point(636, 356);
            this.btn_log_out.Name = "btn_log_out";
            this.btn_log_out.Size = new System.Drawing.Size(75, 75);
            this.btn_log_out.TabIndex = 8;
            this.btn_log_out.UseVisualStyleBackColor = true;
            this.btn_log_out.Click += new System.EventHandler(this.btn_log_out_Click);
            // 
            // dtg_reports_list
            // 
            this.dtg_reports_list.AllowUserToAddRows = false;
            this.dtg_reports_list.AllowUserToDeleteRows = false;
            this.dtg_reports_list.BackgroundColor = System.Drawing.Color.Tan;
            this.dtg_reports_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_reports_list.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtg_reports_list.Location = new System.Drawing.Point(3, 3);
            this.dtg_reports_list.Name = "dtg_reports_list";
            this.dtg_reports_list.ReadOnly = true;
            this.dtg_reports_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_reports_list.Size = new System.Drawing.Size(716, 354);
            this.dtg_reports_list.StandardTab = true;
            this.dtg_reports_list.TabIndex = 1;
            // 
            // pg_users
            // 
            this.pg_users.BackColor = System.Drawing.Color.BurlyWood;
            this.pg_users.Controls.Add(this.btn_users_logout);
            this.pg_users.Controls.Add(this.btn_users_del);
            this.pg_users.Controls.Add(this.btn_users_edit);
            this.pg_users.Controls.Add(this.dtg_users_list);
            this.pg_users.Controls.Add(this.btn_users_add);
            this.pg_users.Location = new System.Drawing.Point(4, 22);
            this.pg_users.Name = "pg_users";
            this.pg_users.Padding = new System.Windows.Forms.Padding(3);
            this.pg_users.Size = new System.Drawing.Size(722, 454);
            this.pg_users.TabIndex = 2;
            this.pg_users.Text = "Users";
            // 
            // btn_users_logout
            // 
            this.btn_users_logout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_users_logout.BackgroundImage = global::CSUSM.CS441.SheriffHodor.Properties.Resources.logout_icon;
            this.btn_users_logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_users_logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_users_logout.Location = new System.Drawing.Point(636, 356);
            this.btn_users_logout.Name = "btn_users_logout";
            this.btn_users_logout.Size = new System.Drawing.Size(75, 75);
            this.btn_users_logout.TabIndex = 4;
            this.btn_users_logout.UseVisualStyleBackColor = true;
            this.btn_users_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_users_del
            // 
            this.btn_users_del.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_users_del.BackgroundImage = global::CSUSM.CS441.SheriffHodor.Properties.Resources.Button_Close_icon;
            this.btn_users_del.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_users_del.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_users_del.Location = new System.Drawing.Point(556, 356);
            this.btn_users_del.Name = "btn_users_del";
            this.btn_users_del.Size = new System.Drawing.Size(75, 75);
            this.btn_users_del.TabIndex = 3;
            this.btn_users_del.UseVisualStyleBackColor = true;
            this.btn_users_del.Click += new System.EventHandler(this.btn_users_del_Click);
            // 
            // btn_users_edit
            // 
            this.btn_users_edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_users_edit.BackgroundImage = global::CSUSM.CS441.SheriffHodor.Properties.Resources.Text_Edit_icon;
            this.btn_users_edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_users_edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_users_edit.Location = new System.Drawing.Point(476, 356);
            this.btn_users_edit.Name = "btn_users_edit";
            this.btn_users_edit.Size = new System.Drawing.Size(75, 75);
            this.btn_users_edit.TabIndex = 2;
            this.btn_users_edit.UseVisualStyleBackColor = true;
            this.btn_users_edit.Click += new System.EventHandler(this.btn_users_edit_Click);
            // 
            // dtg_users_list
            // 
            this.dtg_users_list.AllowUserToAddRows = false;
            this.dtg_users_list.AllowUserToDeleteRows = false;
            this.dtg_users_list.BackgroundColor = System.Drawing.Color.Tan;
            this.dtg_users_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_users_list.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtg_users_list.Location = new System.Drawing.Point(3, 3);
            this.dtg_users_list.Name = "dtg_users_list";
            this.dtg_users_list.ReadOnly = true;
            this.dtg_users_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_users_list.Size = new System.Drawing.Size(716, 354);
            this.dtg_users_list.StandardTab = true;
            this.dtg_users_list.TabIndex = 0;
            // 
            // btn_users_add
            // 
            this.btn_users_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_users_add.BackgroundImage = global::CSUSM.CS441.SheriffHodor.Properties.Resources.Button_Add_icon;
            this.btn_users_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_users_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_users_add.Location = new System.Drawing.Point(396, 356);
            this.btn_users_add.Name = "btn_users_add";
            this.btn_users_add.Size = new System.Drawing.Size(75, 75);
            this.btn_users_add.TabIndex = 1;
            this.btn_users_add.UseVisualStyleBackColor = true;
            this.btn_users_add.Click += new System.EventHandler(this.btn_users_add_Click);
            // 
            // pg_groups
            // 
            this.pg_groups.BackColor = System.Drawing.Color.BurlyWood;
            this.pg_groups.Controls.Add(this.btn_groups_logout);
            this.pg_groups.Controls.Add(this.btn_groups_delete);
            this.pg_groups.Controls.Add(this.btn_groups_edit);
            this.pg_groups.Controls.Add(this.dtg_groups_groups);
            this.pg_groups.Controls.Add(this.btn_groups_create);
            this.pg_groups.Location = new System.Drawing.Point(4, 22);
            this.pg_groups.Name = "pg_groups";
            this.pg_groups.Padding = new System.Windows.Forms.Padding(3);
            this.pg_groups.Size = new System.Drawing.Size(722, 454);
            this.pg_groups.TabIndex = 3;
            this.pg_groups.Text = "Groups";
            // 
            // btn_groups_logout
            // 
            this.btn_groups_logout.BackgroundImage = global::CSUSM.CS441.SheriffHodor.Properties.Resources.logout_icon;
            this.btn_groups_logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_groups_logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_groups_logout.Location = new System.Drawing.Point(636, 356);
            this.btn_groups_logout.Name = "btn_groups_logout";
            this.btn_groups_logout.Size = new System.Drawing.Size(75, 75);
            this.btn_groups_logout.TabIndex = 4;
            this.btn_groups_logout.UseVisualStyleBackColor = true;
            this.btn_groups_logout.Click += new System.EventHandler(this.btn_groups_logout_Click);
            // 
            // btn_groups_delete
            // 
            this.btn_groups_delete.BackgroundImage = global::CSUSM.CS441.SheriffHodor.Properties.Resources.Button_Close_icon;
            this.btn_groups_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_groups_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_groups_delete.Location = new System.Drawing.Point(556, 356);
            this.btn_groups_delete.Name = "btn_groups_delete";
            this.btn_groups_delete.Size = new System.Drawing.Size(75, 75);
            this.btn_groups_delete.TabIndex = 3;
            this.btn_groups_delete.UseVisualStyleBackColor = true;
            this.btn_groups_delete.Click += new System.EventHandler(this.btn_groups_delete_Click);
            // 
            // btn_groups_edit
            // 
            this.btn_groups_edit.BackgroundImage = global::CSUSM.CS441.SheriffHodor.Properties.Resources.Text_Edit_icon;
            this.btn_groups_edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_groups_edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_groups_edit.Location = new System.Drawing.Point(476, 356);
            this.btn_groups_edit.Name = "btn_groups_edit";
            this.btn_groups_edit.Size = new System.Drawing.Size(75, 75);
            this.btn_groups_edit.TabIndex = 2;
            this.btn_groups_edit.UseVisualStyleBackColor = true;
            this.btn_groups_edit.Click += new System.EventHandler(this.btn_groups_edit_Click);
            // 
            // dtg_groups_groups
            // 
            this.dtg_groups_groups.AllowUserToAddRows = false;
            this.dtg_groups_groups.AllowUserToDeleteRows = false;
            this.dtg_groups_groups.BackgroundColor = System.Drawing.Color.Tan;
            this.dtg_groups_groups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_groups_groups.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtg_groups_groups.Location = new System.Drawing.Point(3, 3);
            this.dtg_groups_groups.Name = "dtg_groups_groups";
            this.dtg_groups_groups.ReadOnly = true;
            this.dtg_groups_groups.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_groups_groups.Size = new System.Drawing.Size(716, 354);
            this.dtg_groups_groups.StandardTab = true;
            this.dtg_groups_groups.TabIndex = 5;
            // 
            // btn_groups_create
            // 
            this.btn_groups_create.BackgroundImage = global::CSUSM.CS441.SheriffHodor.Properties.Resources.Button_Add_icon;
            this.btn_groups_create.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_groups_create.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_groups_create.Location = new System.Drawing.Point(396, 356);
            this.btn_groups_create.Name = "btn_groups_create";
            this.btn_groups_create.Size = new System.Drawing.Size(75, 75);
            this.btn_groups_create.TabIndex = 1;
            this.btn_groups_create.UseVisualStyleBackColor = true;
            this.btn_groups_create.Click += new System.EventHandler(this.btn_groups_create_Click);
            // 
            // tab_abt_us
            // 
            this.tab_abt_us.BackColor = System.Drawing.Color.Tan;
            this.tab_abt_us.Controls.Add(this.btn_exit);
            this.tab_abt_us.Controls.Add(this.lbl_about_us);
            this.tab_abt_us.Controls.Add(this.gbox_about_us);
            this.tab_abt_us.Location = new System.Drawing.Point(4, 22);
            this.tab_abt_us.Name = "tab_abt_us";
            this.tab_abt_us.Size = new System.Drawing.Size(722, 454);
            this.tab_abt_us.TabIndex = 4;
            this.tab_abt_us.Text = "About Us";
            // 
            // btn_exit
            // 
            this.btn_exit.BackgroundImage = global::CSUSM.CS441.SheriffHodor.Properties.Resources.logout_icon;
            this.btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exit.Location = new System.Drawing.Point(636, 356);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 75);
            this.btn_exit.TabIndex = 5;
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_log_out_Click);
            // 
            // lbl_about_us
            // 
            this.lbl_about_us.AutoSize = true;
            this.lbl_about_us.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lbl_about_us.Location = new System.Drawing.Point(299, 18);
            this.lbl_about_us.Name = "lbl_about_us";
            this.lbl_about_us.Size = new System.Drawing.Size(126, 31);
            this.lbl_about_us.TabIndex = 1;
            this.lbl_about_us.Text = "About Us";
            // 
            // gbox_about_us
            // 
            this.gbox_about_us.Controls.Add(this.label1);
            this.gbox_about_us.Controls.Add(this.lbl_createdBy);
            this.gbox_about_us.Location = new System.Drawing.Point(27, 70);
            this.gbox_about_us.Name = "gbox_about_us";
            this.gbox_about_us.Size = new System.Drawing.Size(671, 278);
            this.gbox_about_us.TabIndex = 0;
            this.gbox_about_us.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(27, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(608, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Members: Jeffrey Rackauckas, Corey Paxton, John Fileccia, Mathias Lang, Juliette " +
    "Ly";
            // 
            // lbl_createdBy
            // 
            this.lbl_createdBy.AutoSize = true;
            this.lbl_createdBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbl_createdBy.Location = new System.Drawing.Point(22, 20);
            this.lbl_createdBy.Name = "lbl_createdBy";
            this.lbl_createdBy.Size = new System.Drawing.Size(230, 25);
            this.lbl_createdBy.TabIndex = 0;
            this.lbl_createdBy.Text = "Created By: Team Hodor";
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            this.Name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Name.Width = 41;
            // 
            // Administration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 451);
            this.Controls.Add(this.tab_display);
            this.MaximumSize = new System.Drawing.Size(714, 451);
            this.MinimumSize = new System.Drawing.Size(714, 451);
      //      this.Name = "Administration";
            this.tab_display.ResumeLayout(false);
            this.pg_report.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_reports_list)).EndInit();
            this.pg_users.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_users_list)).EndInit();
            this.pg_groups.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_groups_groups)).EndInit();
            this.tab_abt_us.ResumeLayout(false);
            this.tab_abt_us.PerformLayout();
            this.gbox_about_us.ResumeLayout(false);
            this.gbox_about_us.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage pg_users;
        private System.Windows.Forms.Button btn_users_logout;
        private System.Windows.Forms.Button btn_users_del;
        private System.Windows.Forms.Button btn_users_edit;
        private System.Windows.Forms.Button btn_users_add;
        private System.Windows.Forms.DataGridView dtg_users_list;
        private System.Windows.Forms.TabPage pg_report;
        private System.Windows.Forms.TabControl tab_display;
        private System.Windows.Forms.DataGridView dtg_reports_list;
        private System.Windows.Forms.Button btn_log_out;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.TabPage tab_abt_us;
        private System.Windows.Forms.Label lbl_about_us;
        private System.Windows.Forms.GroupBox gbox_about_us;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_createdBy;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.TabPage pg_groups;
        private System.Windows.Forms.Button btn_groups_logout;
        private System.Windows.Forms.Button btn_groups_delete;
        private System.Windows.Forms.Button btn_groups_edit;
        private System.Windows.Forms.DataGridView dtg_groups_groups;
        private System.Windows.Forms.Button btn_groups_create;


    }
}