namespace CSUSM.CS441.SheriffHodor.GUI
{
    partial class Score
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
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_correctAnswers = new System.Windows.Forms.Label();
            this.grp_userInfo = new System.Windows.Forms.GroupBox();
            this.lbl_score = new System.Windows.Forms.Label();
            this.grp_score = new System.Windows.Forms.GroupBox();
            this.grp_userInfo.SuspendLayout();
            this.grp_score.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(6, 25);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(38, 13);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Name:";
            // 
            // lbl_correctAnswers
            // 
            this.lbl_correctAnswers.AutoSize = true;
            this.lbl_correctAnswers.Location = new System.Drawing.Point(6, 51);
            this.lbl_correctAnswers.Name = "lbl_correctAnswers";
            this.lbl_correctAnswers.Size = new System.Drawing.Size(44, 13);
            this.lbl_correctAnswers.TabIndex = 1;
            this.lbl_correctAnswers.Text = "Correct:";
            // 
            // grp_userInfo
            // 
            this.grp_userInfo.Controls.Add(this.lbl_name);
            this.grp_userInfo.Controls.Add(this.lbl_correctAnswers);
            this.grp_userInfo.Location = new System.Drawing.Point(3, 3);
            this.grp_userInfo.Name = "grp_userInfo";
            this.grp_userInfo.Size = new System.Drawing.Size(200, 79);
            this.grp_userInfo.TabIndex = 2;
            this.grp_userInfo.TabStop = false;
            this.grp_userInfo.Text = "User Information";
            // 
            // lbl_score
            // 
            this.lbl_score.AutoSize = true;
            this.lbl_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_score.Location = new System.Drawing.Point(106, 16);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Size = new System.Drawing.Size(105, 37);
            this.lbl_score.TabIndex = 3;
            this.lbl_score.Text = "Score";
            // 
            // grp_score
            // 
            this.grp_score.Controls.Add(this.lbl_score);
            this.grp_score.Location = new System.Drawing.Point(12, 88);
            this.grp_score.Name = "grp_score";
            this.grp_score.Size = new System.Drawing.Size(328, 204);
            this.grp_score.TabIndex = 4;
            this.grp_score.TabStop = false;
            // 
            // Score
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grp_score);
            this.Controls.Add(this.grp_userInfo);
            this.Name = "Score";
            this.Size = new System.Drawing.Size(365, 296);
            this.grp_userInfo.ResumeLayout(false);
            this.grp_userInfo.PerformLayout();
            this.grp_score.ResumeLayout(false);
            this.grp_score.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_correctAnswers;
        private System.Windows.Forms.GroupBox grp_userInfo;
        private System.Windows.Forms.Label lbl_score;
        private System.Windows.Forms.GroupBox grp_score;
    }
}
