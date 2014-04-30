namespace CSUSM.CS441.SheriffHodor.GUI
{
    partial class Rewards
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbox_hats = new System.Windows.Forms.GroupBox();
            this.gbox_hodor = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbox_hats.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbox_hats
            // 
            this.gbox_hats.Controls.Add(this.groupBox1);
            this.gbox_hats.Location = new System.Drawing.Point(25, 43);
            this.gbox_hats.Name = "gbox_hats";
            this.gbox_hats.Size = new System.Drawing.Size(304, 359);
            this.gbox_hats.TabIndex = 0;
            this.gbox_hats.TabStop = false;
            // 
            // gbox_hodor
            // 
            this.gbox_hodor.BackColor = System.Drawing.Color.Transparent;
            this.gbox_hodor.BackgroundImage = global::CSUSM.CS441.SheriffHodor.Properties.Resources.Propper_Hodor_Picture;
            this.gbox_hodor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbox_hodor.Location = new System.Drawing.Point(383, 43);
            this.gbox_hodor.Name = "gbox_hodor";
            this.gbox_hodor.Size = new System.Drawing.Size(304, 359);
            this.gbox_hodor.TabIndex = 1;
            this.gbox_hodor.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(23, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Rewards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CSUSM.CS441.SheriffHodor.Properties.Resources.second_desert_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(730, 480);
            this.Controls.Add(this.gbox_hodor);
            this.Controls.Add(this.gbox_hats);
            this.MaximumSize = new System.Drawing.Size(730, 480);
            this.MinimumSize = new System.Drawing.Size(730, 480);
            this.Name = "Rewards";
            this.Text = "Form1";
            this.gbox_hats.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbox_hats;
        private System.Windows.Forms.GroupBox gbox_hodor;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}