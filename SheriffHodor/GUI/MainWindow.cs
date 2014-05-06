/* MainWindow.cs
 * 
 * Version - 3.0.0 - Cycle 2 Release
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics.Contracts;

namespace CSUSM.CS441.SheriffHodor.GUI
{
    /// <summary>
    /// The MainWindow class.
    /// It helps us switch between our Controls, hence it's singleton.
    /// Note that in this class' context, 'Control' is mostly used to design a ControlContainer,
    /// since having a single Control fullscreen is useless most of the time.
    /// We actually use UserControl derived classes mostly, but there's no reason to put a
    /// gratuitous limitation to UserControl.
    /// </summary>
    public partial class MainWindow : Form
    {
        /// <summary>
        /// Get the instance of this object, instantiate it if necessary.
        /// Designed for single-threaded environment.
        /// </summary>
        /// <returns>A reference to the only instance of this class in the program.</returns>
        public static MainWindow Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new MainWindow();
                return _instance;
            }
        }
        private static MainWindow _instance = null;

        /// <summary>
        /// A list of registered form and their associated names as a key.
        /// </summary>
        private Dictionary<string, StateControl> _forms;

        /// <summary>
        /// Private constructor (for singleton).
        /// </summary>
        private MainWindow()
        {
            this._forms = new Dictionary<string, StateControl>();
            InitializeComponent();
        }

        /// <summary>
        /// Change the current form displayed.
        /// </summary>
        /// <param name="name">The name on which the form was registered.</param>
        /// <returns>The form which is now displayed.</returns>
        public FormType SwitchForm<FormType>(Data.User user = null, Data.User returnUser= null,params object[] args)
            where FormType : StateControl, new()
        {
            if (returnUser == null) returnUser = user;
            StateControl tmp = null;
            string name = typeof(FormType).FullName;
            // First we check if we already have this form in the cache.
            if (!_forms.TryGetValue(name, out tmp))
            {
                // If not, we create it, and add it to the cache.
                tmp = new FormType();
                this._forms.Add(name, tmp);
            }

            // Typesafe FTW.
            FormType form = tmp as FormType;

            StateControl oldValue = ((this.Controls.Count == 1) ? (this.Controls[0] as StateControl) : (null));
            // Add the control
            this.Controls.Clear();
            if (oldValue != null)
                oldValue.Leaved(form);
            this.Controls.Add(form);
            form.Entered(oldValue, user, returnUser);
            //form.Focus();
            form.Show();
            // Make sure it is behaving correctly
            //this.Size = form.Size;
            //Console.WriteLine("Switch to [{0}]", name);
            return form;
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
