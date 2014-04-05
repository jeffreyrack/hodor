using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        public virtual void Entered(StateControl from, Data.User user)
        {
            this.CurrentUser = user;
        }
        /// <summary>
        /// Called when the form switch to another module.
        /// </summary>
        /// <param name="to">The form it's switching to.</param>
        public virtual void Leaved(StateControl to)
        {
            this.CurrentUser = null;
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
    }
}
