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
            this.txt_answer = new System.Windows.Forms.TextBox();
            this.lbl_problem = new System.Windows.Forms.Label();
            this.btn_next = new System.Windows.Forms.Button();
            this.lbl_index = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_answer
            // 
            this.txt_answer.Location = new System.Drawing.Point(216, 147);
            this.txt_answer.Name = "txt_answer";
            this.txt_answer.Size = new System.Drawing.Size(110, 20);
            this.txt_answer.TabIndex = 0;
            // 
            // lbl_problem
            // 
            this.lbl_problem.AutoSize = true;
            this.lbl_problem.Location = new System.Drawing.Point(35, 150);
            this.lbl_problem.Name = "lbl_problem";
            this.lbl_problem.Size = new System.Drawing.Size(175, 13);
            this.lbl_problem.TabIndex = 1;
            this.lbl_problem.Text = "{operand0} {operator} {operand1} =";
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(260, 247);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(75, 23);
            this.btn_next.TabIndex = 2;
            this.btn_next.Text = "Next";
            this.btn_next.UseVisualStyleBackColor = true;
            // 
            // lbl_index
            // 
            this.lbl_index.AutoSize = true;
            this.lbl_index.Location = new System.Drawing.Point(147, 58);
            this.lbl_index.Name = "lbl_index";
            this.lbl_index.Size = new System.Drawing.Size(98, 13);
            this.lbl_index.TabIndex = 4;
            this.lbl_index.Text = "Question {0} on {1}";
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_index);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.lbl_problem);
            this.Controls.Add(this.txt_answer);
            this.MaximumSize = new System.Drawing.Size(424, 398);
            this.MinimumSize = new System.Drawing.Size(424, 398);
            this.Name = "GameScreen";
            this.Size = new System.Drawing.Size(424, 398);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_answer;
        private System.Windows.Forms.Label lbl_problem;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Label lbl_index;
    }
}
