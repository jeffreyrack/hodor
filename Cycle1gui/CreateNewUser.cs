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

namespace Cycle1gui
{
    public partial class CreateNewUser : Form
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

        string newName;//for the new users name
        bool newUser;//to tell if the new user is an admin or not
        //cancel button

        public event EventHandler ButtonClicked;//global variable for refreshing login screen

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        //create button
        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox_newUser.Text) && (radioButton_admin.Checked || radioButton_user.Checked))
            {
                xmlBackend xmlObject=new xmlBackend();
                Student stud=new Student(textBox_newUser.Text, radioButton_admin.Checked, Student.maxId+1);
                xmlObject.Create(stud);
                refresh();
                Close();
            }
            else
            {
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
