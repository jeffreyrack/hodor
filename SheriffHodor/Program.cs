using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CSUSM
{
    namespace CS441
    {
        namespace SheriffHodor
        {
            static class Program
            {
                /// <summary>
                /// The main entry point for the application.
                /// </summary>
                [STAThread]
                static void Main()
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    var mainWindow = GUI.MainWindow.Instance;
                    mainWindow.RegisterForm("login", new GUI.Login());
                    mainWindow.RegisterForm("admin", new GUI.Administration());
                    mainWindow.RegisterForm("createuser", new GUI.CreateNewUser());
                    //mainWindow.RegisterForm("update", new Update());
                    mainWindow.RegisterForm("game", new GUI.GameScreen());
                    mainWindow.SwitchForm("login");
                    Application.Run(mainWindow);
                }
            }
        }
    }
}
