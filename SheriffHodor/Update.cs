/*This file needs to send the update to the XMlBackend files. 
 * 
 * */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CSUSM
{
    namespace CS441
    {
        namespace SheriffHodor
        {
            public partial class Update : Form
            {
                private Student user;
                Action onClose;
                public Update(Student user, Action onClose)
                {
                    this.user = user;
                    InitializeComponent();
                    this.textBox1.Text = user.getName();
                    this.onClose = onClose;
                }
                //cancel button
                private void button2_Click(object sender, EventArgs e)
                {
                    Close();
                }

                //THis will display the username
                private void textBox1_TextChanged(object sender, EventArgs e)
                {

                }
                //Update button
                private void button1_Click(object sender, EventArgs e)
                {
                    this.user.setName(textBox1.Text);
                    new XmlBackend().updateStudentName(this.user);
                    this.onClose();
                    Close();
                }

                private void formLoad(object sender, EventArgs e)
                {
                    textBox1.Text = user.getName();
                }
            }
        }
    }
}