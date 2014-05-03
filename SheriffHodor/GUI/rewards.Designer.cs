﻿namespace CSUSM.CS441.SheriffHodor.GUI
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
            this.btn_purchase = new System.Windows.Forms.Button();
            this.rdo_hat_1_2 = new System.Windows.Forms.RadioButton();
            this.rdo_hat_1_1 = new System.Windows.Forms.RadioButton();
            this.btn_1_1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_1_2 = new System.Windows.Forms.Button();
            this.gbox_hats.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.gbox_hats.Controls.Add(this.btn_purchase);
            this.gbox_hats.Controls.Add(this.rdo_hat_1_2);
            this.gbox_hats.Controls.Add(this.rdo_hat_1_1);
            this.gbox_hats.Controls.Add(this.btn_1_1);
            this.gbox_hats.Controls.Add(this.groupBox1);
            this.gbox_hats.Location = new System.Drawing.Point(25, 43);
            this.gbox_hats.Name = "gbox_hats";
            this.gbox_hats.Size = new System.Drawing.Size(304, 359);
            this.gbox_hats.TabIndex = 0;
            this.gbox_hats.TabStop = false;
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
            this.rdo_hat_1_2.Location = new System.Drawing.Point(152, 105);
            this.rdo_hat_1_2.Name = "rdo_hat_1_2";
            this.rdo_hat_1_2.Size = new System.Drawing.Size(65, 17);
            this.rdo_hat_1_2.TabIndex = 3;
            this.rdo_hat_1_2.TabStop = true;
            this.rdo_hat_1_2.Text = "Red Hat";
            this.rdo_hat_1_2.UseVisualStyleBackColor = true;
            this.rdo_hat_1_2.CheckedChanged += new System.EventHandler(this.rdo_hat_1_1_CheckedChanged);
            // 
            // rdo_hat_1_1
            // 
            this.rdo_hat_1_1.AutoSize = true;
            this.rdo_hat_1_1.Location = new System.Drawing.Point(20, 104);
            this.rdo_hat_1_1.Name = "rdo_hat_1_1";
            this.rdo_hat_1_1.Size = new System.Drawing.Size(65, 17);
            this.rdo_hat_1_1.TabIndex = 1;
            this.rdo_hat_1_1.TabStop = true;
            this.rdo_hat_1_1.Text = "Red Hat";
            this.rdo_hat_1_1.UseVisualStyleBackColor = true;
            this.rdo_hat_1_1.CheckedChanged += new System.EventHandler(this.rdo_hat_1_1_CheckedChanged);
            // 
            // btn_1_1
            // 
            this.btn_1_1.BackgroundImage = global::CSUSM.CS441.SheriffHodor.Properties.Resources.hat1_tier1;
            this.btn_1_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_1_1.Location = new System.Drawing.Point(20, 19);
            this.btn_1_1.Name = "btn_1_1";
            this.btn_1_1.Size = new System.Drawing.Size(108, 79);
            this.btn_1_1.TabIndex = 0;
            this.btn_1_1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_1_2);
            this.groupBox1.Location = new System.Drawing.Point(6, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 122);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tier 1";
            // 
            // btn_1_2
            // 
            this.btn_1_2.BackgroundImage = global::CSUSM.CS441.SheriffHodor.Properties.Resources.hat1_tier2;
            this.btn_1_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_1_2.Location = new System.Drawing.Point(146, 19);
            this.btn_1_2.Name = "btn_1_2";
            this.btn_1_2.Size = new System.Drawing.Size(115, 79);
            this.btn_1_2.TabIndex = 2;
            this.btn_1_2.UseVisualStyleBackColor = true;
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
            this.gbox_hats.ResumeLayout(false);
            this.gbox_hats.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbox_hats;
        private System.Windows.Forms.GroupBox gbox_hodor;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_1_1;
        private System.Windows.Forms.Button btn_1_2;
        private System.Windows.Forms.RadioButton rdo_hat_1_1;
        private System.Windows.Forms.RadioButton rdo_hat_1_2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_purchase;
    }
}