using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics.Contracts;

namespace CSUSM
{
    namespace CS441
    {
        namespace SheriffHodor
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
                private Dictionary<string, Control> _forms;

                /// <summary>
                /// Private constructor (for singleton).
                /// </summary>
                private MainWindow()
                {
                    this._forms = new Dictionary<string, Control>();
                    InitializeComponent();
                }

                /// <summary>
                /// Register a control that can be used later via SwitchForm().
                /// </summary>
                /// <param name="name">The name to give to the form.</param>
                /// <param name="toRegister">The form to register.</param>
                public void RegisterForm(string name, Control toRegister)
                {
                    Console.WriteLine("Registering [{0}]", name.ToLower());
                    this._forms.Add(name.ToLower(), toRegister);
                }

                /// <summary>
                /// Change the current form displayed.
                /// </summary>
                /// <param name="name"></param>
                public void SwitchForm(string name)
                {
                    Control newValue = null;
                    name = name.ToLower();
                    if (!_forms.TryGetValue(name, out newValue))
                        throw new ArgumentOutOfRangeException("name", "The name provided was not found in the dictionnary.");
                    this.Controls.Clear();
                    this.Controls.Add(newValue);
                    newValue.Dock = DockStyle.Fill;
                    Console.WriteLine("Switch to [{0}]", name);
                }
            }
        }
    }
}