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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_coins = new System.Windows.Forms.Label();
            this.lbl_coinsGained = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_index = new System.Windows.Forms.Label();
            this.lbl_Responses = new System.Windows.Forms.Label();
            this.btn_return_to_menu = new System.Windows.Forms.Button();
            this.grp_problem = new System.Windows.Forms.GroupBox();
            this.lbl_problem = new System.Windows.Forms.Label();
            this.txt_answer = new System.Windows.Forms.TextBox();
            this.btn_next = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grp_problem.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Tan;
            this.groupBox2.Controls.Add(this.lbl_coins);
            this.groupBox2.Controls.Add(this.lbl_coinsGained);
            this.groupBox2.Location = new System.Drawing.Point(12, 414);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(192, 53);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // lbl_coins
            // 
            this.lbl_coins.AutoSize = true;
            this.lbl_coins.BackColor = System.Drawing.Color.Tan;
            this.lbl_coins.Location = new System.Drawing.Point(6, 38);
            this.lbl_coins.Name = "lbl_coins";
            this.lbl_coins.Size = new System.Drawing.Size(53, 13);
            this.lbl_coins.TabIndex = 5;
            this.lbl_coins.Text = "Coins: {0}";
            // 
            // lbl_coinsGained
            // 
            this.lbl_coinsGained.AutoSize = true;
            this.lbl_coinsGained.BackColor = System.Drawing.Color.Tan;
            this.lbl_coinsGained.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbl_coinsGained.Location = new System.Drawing.Point(103, 38);
            this.lbl_coinsGained.Name = "lbl_coinsGained";
            this.lbl_coinsGained.Size = new System.Drawing.Size(70, 13);
            this.lbl_coinsGained.TabIndex = 6;
            this.lbl_coinsGained.Text = "Coins Gained";
            this.lbl_coinsGained.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Tan;
            this.groupBox1.Controls.Add(this.lbl_index);
            this.groupBox1.Controls.Add(this.lbl_Responses);
            this.groupBox1.Location = new System.Drawing.Point(323, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(127, 77);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // lbl_index
            // 
            this.lbl_index.AutoSize = true;
            this.lbl_index.BackColor = System.Drawing.Color.Tan;
            this.lbl_index.ForeColor = System.Drawing.Color.Black;
            this.lbl_index.Location = new System.Drawing.Point(10, 48);
            this.lbl_index.Name = "lbl_index";
            this.lbl_index.Size = new System.Drawing.Size(91, 13);
            this.lbl_index.TabIndex = 4;
            this.lbl_index.Text = "Question {0} / {1}";
            // 
            // lbl_Responses
            // 
            this.lbl_Responses.AutoSize = true;
            this.lbl_Responses.BackColor = System.Drawing.Color.Tan;
            this.lbl_Responses.ForeColor = System.Drawing.Color.Black;
            this.lbl_Responses.Location = new System.Drawing.Point(41, 16);
            this.lbl_Responses.Name = "lbl_Responses";
            this.lbl_Responses.Size = new System.Drawing.Size(60, 13);
            this.lbl_Responses.TabIndex = 7;
            this.lbl_Responses.Text = "Responses";
            this.lbl_Responses.Visible = false;
            // 
            // btn_return_to_menu
            // 
            this.btn_return_to_menu.BackColor = System.Drawing.Color.Tan;
            this.btn_return_to_menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_return_to_menu.Image = global::CSUSM.CS441.SheriffHodor.Properties.Resources.exit_button3;
            this.btn_return_to_menu.Location = new System.Drawing.Point(648, 399);
            this.btn_return_to_menu.Name = "btn_return_to_menu";
            this.btn_return_to_menu.Size = new System.Drawing.Size(84, 78);
            this.btn_return_to_menu.TabIndex = 9;
            this.btn_return_to_menu.UseVisualStyleBackColor = false;
            this.btn_return_to_menu.Click += new System.EventHandler(this.btn_return_to_menu_Click);
            // 
            // grp_problem
            // 
            this.grp_problem.BackColor = System.Drawing.Color.Tan;
            this.grp_problem.Controls.Add(this.lbl_problem);
            this.grp_problem.Controls.Add(this.txt_answer);
            this.grp_problem.Controls.Add(this.btn_next);
            this.grp_problem.Location = new System.Drawing.Point(239, 153);
            this.grp_problem.Name = "grp_problem";
            this.grp_problem.Size = new System.Drawing.Size(225, 134);
            this.grp_problem.TabIndex = 8;
            this.grp_problem.TabStop = false;
            // 
            // lbl_problem
            // 
            this.lbl_problem.Location = new System.Drawing.Point(6, 2);
            this.lbl_problem.Name = "lbl_problem";
            this.lbl_problem.Size = new System.Drawing.Size(233, 89);
            this.lbl_problem.TabIndex = 1;
            this.lbl_problem.Text = "{operand0} {operator} {operand1} =";
            this.lbl_problem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_answer
            // 
            this.txt_answer.Location = new System.Drawing.Point(67, 94);
            this.txt_answer.MaxLength = 4;
            this.txt_answer.Name = "txt_answer";
            this.txt_answer.Size = new System.Drawing.Size(71, 20);
            this.txt_answer.TabIndex = 0;
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
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CSUSM.CS441.SheriffHodor.Properties.Resources.second_desert_background;
            this.ClientSize = new System.Drawing.Size(730, 480);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_return_to_menu);
            this.Controls.Add(this.grp_problem);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximumSize = new System.Drawing.Size(730, 480);
            this.MinimumSize = new System.Drawing.Size(730, 480);
            this.Name = "GameScreen";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grp_problem.ResumeLayout(false);
            this.grp_problem.PerformLayout();
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
        private System.Windows.Forms.GroupBox grp_problem;
        private System.Windows.Forms.Button btn_return_to_menu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Timer timer1;
    }
}
