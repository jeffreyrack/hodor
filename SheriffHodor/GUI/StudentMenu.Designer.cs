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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbl_current_name = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_coins = new System.Windows.Forms.TextBox();
            this.lbl_coins = new System.Windows.Forms.Label();
            this.btn_play_game = new System.Windows.Forms.Button();
            this.btn_log_out = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbl_current_name);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(358, 39);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_coins);
            this.groupBox2.Controls.Add(this.lbl_coins);
            this.groupBox2.Controls.Add(this.btn_play_game);
            this.groupBox2.Controls.Add(this.btn_log_out);
            this.groupBox2.Location = new System.Drawing.Point(12, 339);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(696, 60);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // txt_coins
            // 
            this.txt_coins.Location = new System.Drawing.Point(275, 22);
            this.txt_coins.Name = "txt_coins";
            this.txt_coins.ReadOnly = true;
            this.txt_coins.Size = new System.Drawing.Size(145, 20);
            this.txt_coins.TabIndex = 4;
            this.txt_coins.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_coins
            // 
            this.lbl_coins.AutoSize = true;
            this.lbl_coins.Location = new System.Drawing.Point(230, 29);
            this.lbl_coins.Name = "lbl_coins";
            this.lbl_coins.Size = new System.Drawing.Size(39, 13);
            this.lbl_coins.TabIndex = 3;
            this.lbl_coins.Text = "Coins: ";
            // 
            // btn_play_game
            // 
            this.btn_play_game.Location = new System.Drawing.Point(6, 22);
            this.btn_play_game.Name = "btn_play_game";
            this.btn_play_game.Size = new System.Drawing.Size(75, 23);
            this.btn_play_game.TabIndex = 1;
            this.btn_play_game.Text = "Play Game";
            this.btn_play_game.UseVisualStyleBackColor = true;
            this.btn_play_game.Click += new System.EventHandler(this.btn_play_game_Click);
            // 
            // btn_log_out
            // 
            this.btn_log_out.Location = new System.Drawing.Point(609, 22);
            this.btn_log_out.Name = "btn_log_out";
            this.btn_log_out.Size = new System.Drawing.Size(75, 23);
            this.btn_log_out.TabIndex = 2;
            this.btn_log_out.Text = "Logout";
            this.btn_log_out.UseVisualStyleBackColor = true;
            this.btn_log_out.Click += new System.EventHandler(this.btn_log_out_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(123, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(472, 247);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Image";
            // 
            // StudentMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 439);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "StudentMenu";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_current_name;
        private System.Windows.Forms.Button btn_play_game;
        private System.Windows.Forms.Button btn_log_out;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_coins;
        private System.Windows.Forms.Label lbl_coins;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}
