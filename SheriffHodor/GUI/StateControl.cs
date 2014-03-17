using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSUSM.CS441.SheriffHodor.GUI
{
    /// <summary>
    /// A form with a state.
    /// 
    /// It should be abstract but the designer doesn't like it.
    /// </summary>
    public class StateControl : System.Windows.Forms.UserControl
    {
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
        protected virtual void Decline() { MainWindow.Instance.SwitchForm("login"); }

        public Data.User CurrentUser { get; protected set; }
    }
}
