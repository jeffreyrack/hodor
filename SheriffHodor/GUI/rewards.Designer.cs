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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rewards));
            this.btn_exit = new System.Windows.Forms.Button();
            this.gbox_hodor = new System.Windows.Forms.GroupBox();
            this.gbox_hats = new System.Windows.Forms.GroupBox();
            this.btn_hat_1_2 = new System.Windows.Forms.Button();
            this.rdo_hat_2_1 = new System.Windows.Forms.RadioButton();
            this.btn_hat_2_1 = new System.Windows.Forms.Button();
            this.btn_purchase = new System.Windows.Forms.Button();
            this.rdo_hat_1_2 = new System.Windows.Forms.RadioButton();
            this.rdo_hat_1_1 = new System.Windows.Forms.RadioButton();
            this.btn_hat_1_1 = new System.Windows.Forms.Button();
            this.gbox_hats.SuspendLayout();
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
            this.gbox_hats.Controls.Add(this.btn_hat_1_2);
            this.gbox_hats.Controls.Add(this.rdo_hat_2_1);
            this.gbox_hats.Controls.Add(this.btn_hat_2_1);
            this.gbox_hats.Controls.Add(this.btn_purchase);
            this.gbox_hats.Controls.Add(this.rdo_hat_1_2);
            this.gbox_hats.Controls.Add(this.rdo_hat_1_1);
            this.gbox_hats.Controls.Add(this.btn_hat_1_1);
            this.gbox_hats.Location = new System.Drawing.Point(25, 43);
            this.gbox_hats.Name = "gbox_hats";
            this.gbox_hats.Size = new System.Drawing.Size(304, 359);
            this.gbox_hats.TabIndex = 0;
            this.gbox_hats.TabStop = false;
            // 
            // btn_hat_1_2
            // 
            this.btn_hat_1_2.BackgroundImage = global::CSUSM.CS441.SheriffHodor.Properties.Resources.hat1_tier2;
            this.btn_hat_1_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_hat_1_2.Enabled = false;
            this.btn_hat_1_2.Location = new System.Drawing.Point(170, 19);
            this.btn_hat_1_2.Name = "btn_hat_1_2";
            this.btn_hat_1_2.Size = new System.Drawing.Size(115, 79);
            this.btn_hat_1_2.TabIndex = 2;
            this.btn_hat_1_2.UseVisualStyleBackColor = true;
            this.btn_hat_1_2.Click += new System.EventHandler(this.hat_btn_click);
            // 
            // rdo_hat_2_1
            // 
            this.rdo_hat_2_1.AutoSize = true;
            this.rdo_hat_2_1.Location = new System.Drawing.Point(29, 214);
            this.rdo_hat_2_1.Name = "rdo_hat_2_1";
            this.rdo_hat_2_1.Size = new System.Drawing.Size(66, 17);
            this.rdo_hat_2_1.TabIndex = 1;
            this.rdo_hat_2_1.Text = "Cool Hat";
            this.rdo_hat_2_1.UseVisualStyleBackColor = true;
            this.rdo_hat_2_1.CheckedChanged += new System.EventHandler(this.rdo_hat_changed);
            // 
            // btn_hat_2_1
            // 
            this.btn_hat_2_1.BackgroundImage = global::CSUSM.CS441.SheriffHodor.Properties.Resources.hat2_tier1;
            this.btn_hat_2_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_hat_2_1.Enabled = false;
            this.btn_hat_2_1.Location = new System.Drawing.Point(20, 140);
            this.btn_hat_2_1.Name = "btn_hat_2_1";
            this.btn_hat_2_1.Size = new System.Drawing.Size(108, 68);
            this.btn_hat_2_1.TabIndex = 0;
            this.btn_hat_2_1.UseVisualStyleBackColor = true;
            this.btn_hat_2_1.Click += new System.EventHandler(this.hat_btn_click);
            // 
            // btn_purchase
            // 
            this.btn_purchase.Location = new System.Drawing.Point(99, 326);
            this.btn_purchase.Name = "btn_purchase";
            this.btn_purchase.Size = new System.Drawing.Size(75, 23);
            this.btn_purchase.TabIndex = 5;
            this.btn_purchase.Text = "Purchase";
            this.btn_purchase.UseVisualStyleBackColor = true;
            this.btn_purchase.Click += new System.EventHandler(this.purchase_hat);
            // 
            // rdo_hat_1_2
            // 
            this.rdo_hat_1_2.AutoSize = true;
            this.rdo_hat_1_2.Location = new System.Drawing.Point(170, 104);
            this.rdo_hat_1_2.Name = "rdo_hat_1_2";
            this.rdo_hat_1_2.Size = new System.Drawing.Size(65, 17);
            this.rdo_hat_1_2.TabIndex = 3;
            this.rdo_hat_1_2.Text = "Red Hat";
            this.rdo_hat_1_2.UseVisualStyleBackColor = true;
            this.rdo_hat_1_2.CheckedChanged += new System.EventHandler(this.rdo_hat_changed);
            // 
            // rdo_hat_1_1
            // 
            this.rdo_hat_1_1.AutoSize = true;
            this.rdo_hat_1_1.Location = new System.Drawing.Point(40, 104);
            this.rdo_hat_1_1.Name = "rdo_hat_1_1";
            this.rdo_hat_1_1.Size = new System.Drawing.Size(75, 17);
            this.rdo_hat_1_1.TabIndex = 1;
            this.rdo_hat_1_1.Text = "Brown Hat";
            this.rdo_hat_1_1.UseVisualStyleBackColor = true;
            this.rdo_hat_1_1.CheckedChanged += new System.EventHandler(this.rdo_hat_changed);
            // 
            // btn_hat_1_1
            // 
            this.btn_hat_1_1.BackgroundImage = global::CSUSM.CS441.SheriffHodor.Properties.Resources.hat1_tier1;
            this.btn_hat_1_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_hat_1_1.Enabled = false;
            this.btn_hat_1_1.Location = new System.Drawing.Point(29, 19);
            this.btn_hat_1_1.Name = "btn_hat_1_1";
            this.btn_hat_1_1.Size = new System.Drawing.Size(108, 79);
            this.btn_hat_1_1.TabIndex = 0;
            this.btn_hat_1_1.UseVisualStyleBackColor = true;
            this.btn_hat_1_1.Click += new System.EventHandler(this.hat_btn_click);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(730, 480);
            this.MinimumSize = new System.Drawing.Size(730, 480);
            this.Name = "Rewards";
            this.Text = "Form1";
            this.gbox_hats.ResumeLayout(false);
            this.gbox_hats.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbox_hats;
        private System.Windows.Forms.GroupBox gbox_hodor;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_hat_1_1;
        private System.Windows.Forms.Button btn_hat_1_2;
        private System.Windows.Forms.RadioButton rdo_hat_1_1;
        private System.Windows.Forms.RadioButton rdo_hat_1_2;
        private System.Windows.Forms.Button btn_purchase;
        private System.Windows.Forms.RadioButton rdo_hat_2_1;
        private System.Windows.Forms.Button btn_hat_2_1;
    }
}