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

namespace CSUSM.CS441.SheriffHodor.GUI
{
    public partial class Update : UserControl
    {
        private Data.User user;
        Action onClose;
        public Update(Data.User user, Action onClose)
        {
            this.user = user;
            InitializeComponent();
            this.textBox1.Text = user.Name;
            this.onClose = onClose;
        }
        //cancel button
        private void button2_Click(object sender, EventArgs e)
        {
            MainWindow.Instance.SwitchForm("login");
        }

        //THis will display the username
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        //Update button
        private void button1_Click(object sender, EventArgs e)
        {
            this.user.Name = textBox1.Text;
            XmlBackend.updateStudentName(this.user);
            this.onClose();
            MainWindow.Instance.SwitchForm("login");
        }

        private void formLoad(object sender, EventArgs e)
        {
            textBox1.Text = user.Name;
        }
    }
}