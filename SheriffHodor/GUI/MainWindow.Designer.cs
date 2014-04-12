namespace CSUSM.CS441.SheriffHodor.GUI
{
    partial class MainWindow
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
            this.pnl_display = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnl_display
            // 
            this.pnl_display.BackgroundImage = global::CSUSM.CS441.SheriffHodor.Properties.Resources.second_desert_background;
            this.pnl_display.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnl_display.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_display.Location = new System.Drawing.Point(0, 0);
            this.pnl_display.MaximumSize = new System.Drawing.Size(730, 480);
            this.pnl_display.MinimumSize = new System.Drawing.Size(730, 480);
            this.pnl_display.Name = "pnl_display";
            this.pnl_display.Size = new System.Drawing.Size(730, 480);
            this.pnl_display.TabIndex = 0;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 480);
            this.Controls.Add(this.pnl_display);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(736, 508);
            this.MinimumSize = new System.Drawing.Size(736, 508);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_display;
    }
}
