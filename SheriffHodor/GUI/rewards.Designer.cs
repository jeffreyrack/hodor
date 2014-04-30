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
            this.btn_exit = new System.Windows.Forms.Button();
            this.gbox_hodor = new System.Windows.Forms.GroupBox();
            this.gbox_hats = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.BackgroundImage = global::CSUSM.CS441.SheriffHodor.Properties.Resources.exit_button3;
            this.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exit.Location = new System.Drawing.Point(658, 408);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(72, 72);
            this.btn_exit.TabIndex = 2;
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
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
            // gbox_hats
            // 
            this.gbox_hats.Location = new System.Drawing.Point(25, 43);
            this.gbox_hats.Name = "gbox_hats";
            this.gbox_hats.Size = new System.Drawing.Size(304, 359);
            this.gbox_hats.TabIndex = 0;
            this.gbox_hats.TabStop = false;
            // 
            // Rewards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CSUSM.CS441.SheriffHodor.Properties.Resources.second_desert_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(730, 480);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.gbox_hodor);
            this.Controls.Add(this.gbox_hats);
            this.MaximumSize = new System.Drawing.Size(730, 480);
            this.MinimumSize = new System.Drawing.Size(730, 480);
            this.Name = "Rewards";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbox_hats;
        private System.Windows.Forms.GroupBox gbox_hodor;
        private System.Windows.Forms.Button btn_exit;
    }
}