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
            public partial class Container : Form
            {
                private Dictionary<string, Form> _forms;

                public Container()
                {
                    this._forms = new Dictionary<string, Form>();
                    InitializeComponent();
                }

                public Form RegisterForm(string name, Form toRegister)
                {
                    this._forms.Add(name, toRegister);
                    return toRegister;
                }

                public void switchForm(string name)
                {
                    Form newValue;
                    if (!_forms.TryGetValue(name, out newValue))
                        throw new ArgumentOutOfRangeException(
                            string.Format("The name provided (%0) was not found in the dictionnary.", name));
                    this.pnl_display.Controls.Clear();
                    this.pnl_display.Controls.Add(newValue);
                }
            }
        }
    }
}