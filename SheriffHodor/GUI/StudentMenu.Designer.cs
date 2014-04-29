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
            this.btn_log_out = new System.Windows.Forms.Button();
            this.gbox_studentmenu = new System.Windows.Forms.GroupBox();
            this.btn_rewards = new System.Windows.Forms.Button();
            this.txt_coins = new System.Windows.Forms.TextBox();
            this.btn_play_game = new System.Windows.Forms.Button();
            this.lbl_coins = new System.Windows.Forms.Label();
            this.lbl_current_name = new System.Windows.Forms.Label();
            this.gbox_studentmenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_log_out
            // 
            this.btn_log_out.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_log_out.Image = global::CSUSM.CS441.SheriffHodor.Properties.Resources.exit_button3;
            this.btn_log_out.Location = new System.Drawing.Point(647, 403);
            this.btn_log_out.Name = "btn_log_out";
            this.btn_log_out.Size = new System.Drawing.Size(84, 78);
            this.btn_log_out.TabIndex = 2;
            this.btn_log_out.UseVisualStyleBackColor = true;
            this.btn_log_out.Click += new System.EventHandler(this.btn_log_out_Click);
            // 
            // gbox_studentmenu
            // 
            this.gbox_studentmenu.BackColor = System.Drawing.Color.Tan;
            this.gbox_studentmenu.Controls.Add(this.btn_rewards);
            this.gbox_studentmenu.Controls.Add(this.txt_coins);
            this.gbox_studentmenu.Controls.Add(this.btn_play_game);
            this.gbox_studentmenu.Controls.Add(this.lbl_coins);
            this.gbox_studentmenu.Controls.Add(this.lbl_current_name);
            this.gbox_studentmenu.Location = new System.Drawing.Point(225, 41);
            this.gbox_studentmenu.Name = "gbox_studentmenu";
            this.gbox_studentmenu.Size = new System.Drawing.Size(349, 415);
            this.gbox_studentmenu.TabIndex = 7;
            this.gbox_studentmenu.TabStop = false;
            // 
            // btn_rewards
            // 
            this.btn_rewards.Location = new System.Drawing.Point(124, 137);
            this.btn_rewards.Name = "btn_rewards";
            this.btn_rewards.Size = new System.Drawing.Size(75, 23);
            this.btn_rewards.TabIndex = 5;
            this.btn_rewards.Text = "Rewards";
            this.btn_rewards.UseVisualStyleBackColor = true;
            this.btn_rewards.Click += new System.EventHandler(this.btn_rewards_Click);
            // 
            // txt_coins
            // 
            this.txt_coins.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_coins.Location = new System.Drawing.Point(135, 97);
            this.txt_coins.Name = "txt_coins";
            this.txt_coins.ReadOnly = true;
            this.txt_coins.Size = new System.Drawing.Size(125, 22);
            this.txt_coins.TabIndex = 4;
            this.txt_coins.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_play_game
            // 
            this.btn_play_game.BackColor = System.Drawing.Color.Tan;
            this.btn_play_game.BackgroundImage = global::CSUSM.CS441.SheriffHodor.Properties.Resources.playButton1;
            this.btn_play_game.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_play_game.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_play_game.Location = new System.Drawing.Point(38, 198);
            this.btn_play_game.Name = "btn_play_game";
            this.btn_play_game.Size = new System.Drawing.Size(275, 217);
            this.btn_play_game.TabIndex = 1;
            this.btn_play_game.UseVisualStyleBackColor = false;
            this.btn_play_game.Click += new System.EventHandler(this.btn_play_game_Click);
            // 
            // lbl_coins
            // 
            this.lbl_coins.AutoSize = true;
            this.lbl_coins.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_coins.Location = new System.Drawing.Point(81, 103);
            this.lbl_coins.Name = "lbl_coins";
            this.lbl_coins.Size = new System.Drawing.Size(48, 16);
            this.lbl_coins.TabIndex = 3;
            this.lbl_coins.Text = "Coins: ";
            // 
            // lbl_current_name
            // 
            this.lbl_current_name.AutoSize = true;
            this.lbl_current_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_current_name.Location = new System.Drawing.Point(57, 67);
            this.lbl_current_name.Name = "lbl_current_name";
            this.lbl_current_name.Size = new System.Drawing.Size(72, 16);
            this.lbl_current_name.TabIndex = 0;
            this.lbl_current_name.Text = "Welcome: ";
            // 
            // StudentMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::CSUSM.CS441.SheriffHodor.Properties.Resources.second_desert_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(730, 480);
            this.Controls.Add(this.btn_log_out);
            this.Controls.Add(this.gbox_studentmenu);
            this.MaximumSize = new System.Drawing.Size(730, 480);
            this.MinimumSize = new System.Drawing.Size(730, 480);
            this.Name = "StudentMenu";
            this.gbox_studentmenu.ResumeLayout(false);
            this.gbox_studentmenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_current_name;
        private System.Windows.Forms.Button btn_play_game;
        private System.Windows.Forms.Button btn_log_out;
        private System.Windows.Forms.TextBox txt_coins;
        private System.Windows.Forms.Label lbl_coins;
        private System.Windows.Forms.GroupBox gbox_studentmenu;
        private System.Windows.Forms.Button btn_rewards;
    }
}
