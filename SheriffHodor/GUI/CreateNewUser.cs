/*Just needs to be connected to the XML file for when thats uploaded
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
    public partial class CreateNewUser : UserControl
    {
        public CreateNewUser()
        {
            InitializeComponent();
        }

        public CreateNewUser(Action refresh)
        {
            InitializeComponent();
            this.refresh = refresh;
        }

        Action refresh;
        bool newUser;//to tell if the new user is an admin or not
        private void button2_Click(object sender, EventArgs e)
        {
            MainWindow.Instance.SwitchForm("login");
        }
        //create button
        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox_newUser.Text) && (radioButton_admin.Checked || radioButton_user.Checked)) {
                XmlBackend xmlObject = new XmlBackend();
                var stud = new Data.Student(textBox_newUser.Text, radioButton_admin.Checked, Data.Student.maxId + 1);
                xmlObject.Create(stud);
                refresh();
                MainWindow.Instance.SwitchForm("login");
            } else {
                // Errors have occured.  Follow the error steps mentioned in the Use Cases.
            }
        }

        //Name of new user goes here
        private void textBox_newUser_TextChanged(object sender, EventArgs e)
        {

        }

        //Admin button
        private void radioButton_admin_CheckedChanged(object sender, EventArgs e)
        {
            newUser = true;
        }
        //User Button
        private void radioButton_user_CheckedChanged(object sender, EventArgs e)
        {
            newUser = false;
        }
    }
}