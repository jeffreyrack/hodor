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
    public partial class CreateNewUser : StateControl
    {
        public CreateNewUser()
        {
            InitializeComponent();
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AcceptOnReturn);
        }

        protected override void Accept()
        {
            if (this.txt_username.Text == string.Empty) 
            {
                Helpers.DisplayWarning("You must enter a name to create a new user.");
                return;
            }
            if (Data.UserList.Instance.Any(
                u => u.Name.Equals(txt_username.Text, StringComparison.InvariantCultureIgnoreCase))) {
                Helpers.DisplayError("There is already an user with this name.");
                return;
            }

            var type = (rdo_admin.Checked ? Data.User.UserType.Teacher : Data.User.UserType.Student);
            Data.UserList.Instance.Add(Data.User.CreateUser(txt_username.Text, type));
            Helpers.DisplayInfo(string.Format("User '{0}' successfully created", txt_username.Text));
            // Cleanup and leave.
            Decline();
        }
        protected override void Decline()
        {
            txt_username.Text = "";
            rdo_user.Checked = true;
            MainWindow.Instance.SwitchForm("admin");
        }

        #region UI Events
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Decline();
        }
        private void btn_create_Click(object sender, EventArgs e)
        {
            Accept();
        }
        private void AcceptOnReturn(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                Accept();
        }
        #endregion
    }
}