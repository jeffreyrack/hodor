using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CSUSM.CS441.SheriffHodor.GUI
{
    /// <summary>
    /// A form with an user state.
    /// 
    /// To implement a form, you should inherit from it.
    /// You will be able to use the designer with it.
    /// 
    /// Important: Those forms are Stateless by design.
    ///             When you need to carry an information, you should
    ///             use User.Runtime informations, and NOT store it in
    ///             the form (coupling == bad design).
    /// 
    /// Note: It should be abstract but the designer doesn't like it.
    /// </summary>
    public class StateControl : Form
    {
        public StateControl()
        {
            this.TopLevel = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;
        }

        /// <summary>
        /// Called when this form is entered (using switchTo(formName)).
        /// </summary>
        /// <param name="from">The calling form.</param>
        /// <param name="user">An optionnal user.</param>
        public virtual void Entered(StateControl from, Data.User user, Data.User returnUser)
        {
            this.Show();
            this.CurrentUser = user;
            this.returnUser = returnUser;
        }

        /// <summary>
        /// Called when the form switch to another module.
        /// </summary>
        /// <param name="to">The form it's switching to.</param>
        public virtual void Leaved(StateControl to)
        {
            //Corey thinks this is unecessary. See if it breaks by removing next cycle.
            this.CurrentUser = null;
            this.Hide();
        }   

        /// <summary>
        /// Behaviour if the input gets validated.
        /// </summary>
        protected virtual void Accept() { }
        /// <summary>
        /// Optional implementable method called if the operation abort (ie, cancel pressed).
        /// </summary>
        protected virtual void Decline()
        {
            MainWindow.Instance.SwitchForm<GUI.Login>();
        }

        public Data.User CurrentUser { get; protected set; }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // StateControl
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "StateControl";
            this.Load += new System.EventHandler(this.StateControl_Load);
            this.ResumeLayout(false);
        }

        // Based off of functionality found at: http://www.niteshluharuka.com/2014/02/how-to-add-custom-checkbox-column-to-datagridview-in-windows-forms/#
        public static  DataGridViewCheckBoxColumn CreateDataGridViewCheckbox()
        {
            DataGridViewCheckBoxColumn checkbox = new DataGridViewCheckBoxColumn();
            checkbox.Name = "ToAdd";
            checkbox.HeaderText = "Add To Group";
            checkbox.FalseValue = 0;
            checkbox.TrueValue =1;
            return checkbox;
        }

        public static void addStudentsToGroup(DataGridView dtg_ungrouped_users, Data.Group toAdd, int checkboxIndex, int nameIndex)
        {
            foreach (DataGridViewRow row in dtg_ungrouped_users.Rows)
            {
                DataGridViewCheckBoxCell checkbox = row.Cells[checkboxIndex] as DataGridViewCheckBoxCell;
                if (checkbox.Value == checkbox.TrueValue)
                {
                    Data.UserList.Instance.GetByName(row.Cells[nameIndex].Value.ToString()).GroupName = toAdd.Name;
                }
            }
        }
        
        public static DataGridView createUngroupedUserDataGrid(DataGridView dtg_ungrouped_users)
        {
            dtg_ungrouped_users.DataSource = Data.UserList.Instance.ApplyGroupFilter("Ungrouped Users");
            dtg_ungrouped_users.Columns["Status"].Visible = false;
            dtg_ungrouped_users.Columns["TotalPercentage"].Visible = false;
            dtg_ungrouped_users.Columns["GameCount"].Visible = false;
            dtg_ungrouped_users.Columns["GroupName"].Visible = false;
            dtg_ungrouped_users.Columns.Insert(1, CreateDataGridViewCheckbox());
            return dtg_ungrouped_users;
        }

        private void StateControl_Load(object sender, EventArgs e)
        {

        }

        public Data.User returnUser { get; set; }
    }
}
