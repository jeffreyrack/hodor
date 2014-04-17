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
            this.btn_play_game = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_coins = new System.Windows.Forms.TextBox();
            this.lbl_current_name = new System.Windows.Forms.Label();
            this.lbl_coins = new System.Windows.Forms.Label();
            this.btn_log_out = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_play_game
            // 
            this.btn_play_game.BackColor = System.Drawing.Color.Tan;
            this.btn_play_game.BackgroundImage = global::CSUSM.CS441.SheriffHodor.Properties.Resources.playButton1;
            this.btn_play_game.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_play_game.Location = new System.Drawing.Point(190, 62);
            this.btn_play_game.Name = "btn_play_game";
            this.btn_play_game.Size = new System.Drawing.Size(353, 371);
            this.btn_play_game.TabIndex = 1;
            this.btn_play_game.UseVisualStyleBackColor = false;
            this.btn_play_game.Click += new System.EventHandler(this.btn_play_game_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Tan;
            this.groupBox3.Controls.Add(this.txt_coins);
            this.groupBox3.Controls.Add(this.lbl_current_name);
            this.groupBox3.Controls.Add(this.lbl_coins);
            this.groupBox3.Location = new System.Drawing.Point(-1, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(732, 43);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // txt_coins
            // 
            this.txt_coins.Location = new System.Drawing.Point(312, 13);
            this.txt_coins.Name = "txt_coins";
            this.txt_coins.ReadOnly = true;
            this.txt_coins.Size = new System.Drawing.Size(125, 20);
            this.txt_coins.TabIndex = 4;
            this.txt_coins.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_current_name
            // 
            this.lbl_current_name.AutoSize = true;
            this.lbl_current_name.Location = new System.Drawing.Point(6, 16);
            this.lbl_current_name.Name = "lbl_current_name";
            this.lbl_current_name.Size = new System.Drawing.Size(58, 13);
            this.lbl_current_name.TabIndex = 0;
            this.lbl_current_name.Text = "Welcome: ";
            // 
            // lbl_coins
            // 
            this.lbl_coins.AutoSize = true;
            this.lbl_coins.Location = new System.Drawing.Point(267, 16);
            this.lbl_coins.Name = "lbl_coins";
            this.lbl_coins.Size = new System.Drawing.Size(39, 13);
            this.lbl_coins.TabIndex = 3;
            this.lbl_coins.Text = "Coins: ";
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
            // StudentMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::CSUSM.CS441.SheriffHodor.Properties.Resources.second_desert_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(730, 480);
            this.Controls.Add(this.btn_play_game);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btn_log_out);
            this.MaximumSize = new System.Drawing.Size(730, 480);
            this.MinimumSize = new System.Drawing.Size(730, 480);
            this.Name = "StudentMenu";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_current_name;
        private System.Windows.Forms.Button btn_play_game;
        private System.Windows.Forms.Button btn_log_out;
        private System.Windows.Forms.TextBox txt_coins;
        private System.Windows.Forms.Label lbl_coins;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}
