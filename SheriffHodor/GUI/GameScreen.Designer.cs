using System;

namespace CSUSM.CS441.SheriffHodor.GUI
{
    partial class GameScreen
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_return_to_menu = new System.Windows.Forms.Button();
            this.gbox_problem = new System.Windows.Forms.GroupBox();
            this.lbl_Responses = new System.Windows.Forms.Label();
            this.lbl_coinsGained = new System.Windows.Forms.Label();
            this.lbl_coins = new System.Windows.Forms.Label();
            this.lbl_index = new System.Windows.Forms.Label();
            this.lbl_problem = new System.Windows.Forms.Label();
            this.txt_answer = new System.Windows.Forms.TextBox();
            this.btn_next = new System.Windows.Forms.Button();
            this.tltp = new System.Windows.Forms.ToolTip(this.components);
            this.gbox_problem.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_return_to_menu
            // 
            this.btn_return_to_menu.BackColor = System.Drawing.Color.SeaShell;
            this.btn_return_to_menu.BackgroundImage = global::CSUSM.CS441.SheriffHodor.Properties.Resources.logout_icon;
            this.btn_return_to_menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_return_to_menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_return_to_menu.Location = new System.Drawing.Point(654, 403);
            this.btn_return_to_menu.Name = "btn_return_to_menu";
            this.btn_return_to_menu.Size = new System.Drawing.Size(75, 75);
            this.btn_return_to_menu.TabIndex = 9;
            this.btn_return_to_menu.UseVisualStyleBackColor = false;
            this.btn_return_to_menu.Click += new System.EventHandler(this.btn_return_to_menu_Click);
            // 
            // gbox_problem
            // 
            this.gbox_problem.BackColor = System.Drawing.Color.Tan;
            this.gbox_problem.Controls.Add(this.lbl_Responses);
            this.gbox_problem.Controls.Add(this.lbl_coinsGained);
            this.gbox_problem.Controls.Add(this.lbl_coins);
            this.gbox_problem.Controls.Add(this.lbl_index);
            this.gbox_problem.Controls.Add(this.lbl_problem);
            this.gbox_problem.Controls.Add(this.txt_answer);
            this.gbox_problem.Controls.Add(this.btn_next);
            this.gbox_problem.Location = new System.Drawing.Point(116, 94);
            this.gbox_problem.Name = "gbox_problem";
            this.gbox_problem.Size = new System.Drawing.Size(510, 289);
            this.gbox_problem.TabIndex = 8;
            this.gbox_problem.TabStop = false;
            // 
            // lbl_Responses
            // 
            this.lbl_Responses.AutoSize = true;
            this.lbl_Responses.BackColor = System.Drawing.Color.Tan;
            this.lbl_Responses.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Responses.ForeColor = System.Drawing.Color.Black;
            this.lbl_Responses.Location = new System.Drawing.Point(171, 35);
            this.lbl_Responses.Name = "lbl_Responses";
            this.lbl_Responses.Size = new System.Drawing.Size(135, 29);
            this.lbl_Responses.TabIndex = 7;
            this.lbl_Responses.Text = "Responses";
            this.lbl_Responses.Visible = false;
            // 
            // lbl_coinsGained
            // 
            this.lbl_coinsGained.AutoSize = true;
            this.lbl_coinsGained.BackColor = System.Drawing.Color.Transparent;
            this.lbl_coinsGained.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_coinsGained.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbl_coinsGained.Location = new System.Drawing.Point(351, 16);
            this.lbl_coinsGained.Name = "lbl_coinsGained";
            this.lbl_coinsGained.Size = new System.Drawing.Size(159, 29);
            this.lbl_coinsGained.TabIndex = 6;
            this.lbl_coinsGained.Text = "Coins Gained";
            this.lbl_coinsGained.Visible = false;
            this.lbl_coinsGained.Click += new System.EventHandler(this.lbl_coinsGained_Click);
            // 
            // lbl_coins
            // 
            this.lbl_coins.AutoSize = true;
            this.lbl_coins.BackColor = System.Drawing.Color.Transparent;
            this.lbl_coins.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_coins.Location = new System.Drawing.Point(286, 15);
            this.lbl_coins.Name = "lbl_coins";
            this.lbl_coins.Size = new System.Drawing.Size(118, 29);
            this.lbl_coins.TabIndex = 5;
            this.lbl_coins.Text = "Coins: {0}";
            // 
            // lbl_index
            // 
            this.lbl_index.AutoSize = true;
            this.lbl_index.BackColor = System.Drawing.Color.Transparent;
            this.lbl_index.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_index.ForeColor = System.Drawing.Color.Black;
            this.lbl_index.Location = new System.Drawing.Point(6, 16);
            this.lbl_index.Name = "lbl_index";
            this.lbl_index.Size = new System.Drawing.Size(197, 29);
            this.lbl_index.TabIndex = 4;
            this.lbl_index.Text = "Question {0} / {1}";
            // 
            // lbl_problem
            // 
            this.lbl_problem.BackColor = System.Drawing.Color.Transparent;
            this.lbl_problem.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_problem.Location = new System.Drawing.Point(52, 64);
            this.lbl_problem.Name = "lbl_problem";
            this.lbl_problem.Size = new System.Drawing.Size(411, 178);
            this.lbl_problem.TabIndex = 1;
            this.lbl_problem.Text = "{operand0} {operator} {operand1} =";
            this.lbl_problem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_answer
            // 
            this.txt_answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_answer.Location = new System.Drawing.Point(203, 245);
            this.txt_answer.MaxLength = 4;
            this.txt_answer.Name = "txt_answer";
            this.txt_answer.Size = new System.Drawing.Size(74, 44);
            this.txt_answer.TabIndex = 0;
            // 
            // btn_next
            // 
            this.btn_next.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_next.Location = new System.Drawing.Point(283, 251);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(103, 38);
            this.btn_next.TabIndex = 2;
            this.btn_next.Text = "Next";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // tltp
            // 
            this.tltp.Popup += new System.Windows.Forms.PopupEventHandler(this.tltp_btn_exit_Popup);
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CSUSM.CS441.SheriffHodor.Properties.Resources.second_desert_background;
            this.ClientSize = new System.Drawing.Size(730, 480);
            this.Controls.Add(this.btn_return_to_menu);
            this.Controls.Add(this.gbox_problem);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximumSize = new System.Drawing.Size(730, 480);
            this.MinimumSize = new System.Drawing.Size(730, 480);
            this.Name = "GameScreen";
            this.gbox_problem.ResumeLayout(false);
            this.gbox_problem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_answer;
        private System.Windows.Forms.Label lbl_problem;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Label lbl_index;
        private System.Windows.Forms.Label lbl_coins;
        private System.Windows.Forms.Label lbl_coinsGained;
        private System.Windows.Forms.Label lbl_Responses;
        private System.Windows.Forms.GroupBox gbox_problem;
        private System.Windows.Forms.Button btn_return_to_menu;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolTip tltp;
    }
}
