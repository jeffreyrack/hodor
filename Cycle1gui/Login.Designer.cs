namespace CSUSM
{
    namespace CS441
    {
        namespace SheriffHodor
        {
            partial class Login
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
                    this.button1 = new System.Windows.Forms.Button();
                    this.button2 = new System.Windows.Forms.Button();
                    this.button3 = new System.Windows.Forms.Button();
                    this.label1 = new System.Windows.Forms.Label();
                    this.dropDownLogin = new System.Windows.Forms.ComboBox();
                    this.forms = new System.Windows.Forms.TabControl();
                    this.tabPage1 = new System.Windows.Forms.TabPage();
                    this.tabPage2 = new System.Windows.Forms.TabPage();
                    this.forms.SuspendLayout();
                    this.tabPage1.SuspendLayout();
                    this.SuspendLayout();
                    // 
                    // button1
                    // 
                    this.button1.Location = new System.Drawing.Point(276, 203);
                    this.button1.Name = "button1";
                    this.button1.Size = new System.Drawing.Size(144, 25);
                    this.button1.TabIndex = 0;
                    this.button1.Text = "Login";
                    this.button1.UseVisualStyleBackColor = true;
                    this.button1.Click += new System.EventHandler(this.button1_Click);
                    // 
                    // button2
                    // 
                    this.button2.Location = new System.Drawing.Point(276, 232);
                    this.button2.Name = "button2";
                    this.button2.Size = new System.Drawing.Size(144, 25);
                    this.button2.TabIndex = 1;
                    this.button2.Text = "Update";
                    this.button2.UseVisualStyleBackColor = true;
                    this.button2.Click += new System.EventHandler(this.button2_Click);
                    // 
                    // button3
                    // 
                    this.button3.Location = new System.Drawing.Point(276, 261);
                    this.button3.Name = "button3";
                    this.button3.Size = new System.Drawing.Size(144, 25);
                    this.button3.TabIndex = 2;
                    this.button3.Text = "Create";
                    this.button3.UseVisualStyleBackColor = true;
                    this.button3.Click += new System.EventHandler(this.button3_Click);
                    // 
                    // label1
                    // 
                    this.label1.AutoSize = true;
                    this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    this.label1.Location = new System.Drawing.Point(53, 19);
                    this.label1.Name = "label1";
                    this.label1.Size = new System.Drawing.Size(307, 55);
                    this.label1.TabIndex = 3;
                    this.label1.Text = "Sheriff Hodor";
                    // 
                    // dropDownLogin
                    // 
                    this.dropDownLogin.FormattingEnabled = true;
                    this.dropDownLogin.Location = new System.Drawing.Point(38, 203);
                    this.dropDownLogin.Name = "dropDownLogin";
                    this.dropDownLogin.Size = new System.Drawing.Size(145, 21);
                    this.dropDownLogin.TabIndex = 5;
                    this.dropDownLogin.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
                    // 
                    // forms
                    // 
                    this.forms.Controls.Add(this.tabPage1);
                    this.forms.Controls.Add(this.tabPage2);
                    this.forms.Dock = System.Windows.Forms.DockStyle.Fill;
                    this.forms.Location = new System.Drawing.Point(0, 0);
                    this.forms.Name = "forms";
                    this.forms.SelectedIndex = 0;
                    this.forms.Size = new System.Drawing.Size(436, 337);
                    this.forms.TabIndex = 6;
                    // 
                    // tabPage1
                    // 
                    this.tabPage1.Controls.Add(this.dropDownLogin);
                    this.tabPage1.Controls.Add(this.button3);
                    this.tabPage1.Controls.Add(this.label1);
                    this.tabPage1.Controls.Add(this.button2);
                    this.tabPage1.Controls.Add(this.button1);
                    this.tabPage1.Location = new System.Drawing.Point(4, 22);
                    this.tabPage1.Name = "tabPage1";
                    this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
                    this.tabPage1.Size = new System.Drawing.Size(428, 311);
                    this.tabPage1.TabIndex = 0;
                    this.tabPage1.Text = "tabPage1";
                    this.tabPage1.UseVisualStyleBackColor = true;
                    // 
                    // tabPage2
                    // 
                    this.tabPage2.Location = new System.Drawing.Point(4, 22);
                    this.tabPage2.Name = "tabPage2";
                    this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
                    this.tabPage2.Size = new System.Drawing.Size(428, 311);
                    this.tabPage2.TabIndex = 1;
                    this.tabPage2.Text = "tabPage2";
                    this.tabPage2.UseVisualStyleBackColor = true;
                    // 
                    // Login
                    // 
                    this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                    this.ClientSize = new System.Drawing.Size(436, 337);
                    this.Controls.Add(this.forms);
                    this.MaximumSize = new System.Drawing.Size(452, 375);
                    this.MinimumSize = new System.Drawing.Size(452, 375);
                    this.Name = "Login";
                    this.Text = "Login";
                    this.forms.ResumeLayout(false);
                    this.tabPage1.ResumeLayout(false);
                    this.tabPage1.PerformLayout();
                    this.ResumeLayout(false);

                }

                #endregion

                private System.Windows.Forms.Button button1;
                private System.Windows.Forms.Button button2;
                private System.Windows.Forms.Button button3;
                private System.Windows.Forms.Label label1;
                private System.Windows.Forms.ComboBox dropDownLogin;
                private System.Windows.Forms.TabControl forms;
                private System.Windows.Forms.TabPage tabPage1;
                private System.Windows.Forms.TabPage tabPage2;
            }
        }

    }
}