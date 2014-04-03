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
            this.txt_answer = new System.Windows.Forms.TextBox();
            this.lbl_problem = new System.Windows.Forms.Label();
            this.btn_next = new System.Windows.Forms.Button();
            this.lbl_index = new System.Windows.Forms.Label();
            this.lbl_coins = new System.Windows.Forms.Label();
            this.lbl_coinsGained = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_streakResponses = new System.Windows.Forms.Label();
            this.grp_problem = new System.Windows.Forms.GroupBox();
            this.grp_problem.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_answer
            // 
            this.txt_answer.Location = new System.Drawing.Point(67, 94);
            this.txt_answer.MaxLength = 4;
            this.txt_answer.Name = "txt_answer";
            this.txt_answer.Size = new System.Drawing.Size(71, 20);
            this.txt_answer.TabIndex = 0;
            // 
            // lbl_problem
            // 
            this.lbl_problem.Location = new System.Drawing.Point(6, 16);
            this.lbl_problem.Name = "lbl_problem";
            this.lbl_problem.Size = new System.Drawing.Size(175, 72);
            this.lbl_problem.TabIndex = 1;
            this.lbl_problem.Text = "{operand0} {operator} {operand1} =";
            this.lbl_problem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(144, 91);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(75, 23);
            this.btn_next.TabIndex = 2;
            this.btn_next.Text = "Next";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // lbl_index
            // 
            this.lbl_index.AutoSize = true;
            this.lbl_index.Location = new System.Drawing.Point(145, 31);
            this.lbl_index.Name = "lbl_index";
            this.lbl_index.Size = new System.Drawing.Size(91, 13);
            this.lbl_index.TabIndex = 4;
            this.lbl_index.Text = "Question {0} / {1}";
            // 
            // lbl_coins
            // 
            this.lbl_coins.AutoSize = true;
            this.lbl_coins.Location = new System.Drawing.Point(38, 320);
            this.lbl_coins.Name = "lbl_coins";
            this.lbl_coins.Size = new System.Drawing.Size(53, 13);
            this.lbl_coins.TabIndex = 5;
            this.lbl_coins.Text = "Coins: {0}";
            // 
            // lbl_coinsGained
            // 
            this.lbl_coinsGained.AutoSize = true;
            this.lbl_coinsGained.Location = new System.Drawing.Point(98, 320);
            this.lbl_coinsGained.Name = "lbl_coinsGained";
            this.lbl_coinsGained.Size = new System.Drawing.Size(70, 13);
            this.lbl_coinsGained.TabIndex = 6;
            this.lbl_coinsGained.Text = "Coins Gained";
            this.lbl_coinsGained.Visible = false;
            // 
            // lbl_streakResponses
            // 
            this.lbl_streakResponses.AutoSize = true;
            this.lbl_streakResponses.Location = new System.Drawing.Point(147, 0);
            this.lbl_streakResponses.Name = "lbl_streakResponses";
            this.lbl_streakResponses.Size = new System.Drawing.Size(89, 13);
            this.lbl_streakResponses.TabIndex = 7;
            this.lbl_streakResponses.Text = "Streak responses";
            this.lbl_streakResponses.Visible = false;
            // 
            // grp_problem
            // 
            this.grp_problem.Controls.Add(this.lbl_problem);
            this.grp_problem.Controls.Add(this.txt_answer);
            this.grp_problem.Controls.Add(this.btn_next);
            this.grp_problem.Location = new System.Drawing.Point(83, 97);
            this.grp_problem.Name = "grp_problem";
            this.grp_problem.Size = new System.Drawing.Size(225, 134);
            this.grp_problem.TabIndex = 8;
            this.grp_problem.TabStop = false;
            this.grp_problem.Text = "Problem";
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grp_problem);
            this.Controls.Add(this.lbl_streakResponses);
            this.Controls.Add(this.lbl_coinsGained);
            this.Controls.Add(this.lbl_coins);
            this.Controls.Add(this.lbl_index);
            this.MaximumSize = new System.Drawing.Size(424, 398);
            this.MinimumSize = new System.Drawing.Size(424, 398);
            this.Name = "GameScreen";
            this.Size = new System.Drawing.Size(424, 398);
            this.grp_problem.ResumeLayout(false);
            this.grp_problem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_answer;
        private System.Windows.Forms.Label lbl_problem;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Label lbl_index;
        private System.Windows.Forms.Label lbl_coins;
        private System.Windows.Forms.Label lbl_coinsGained;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_streakResponses;
        private System.Windows.Forms.GroupBox grp_problem;
    }
}
