﻿using System;
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
                    // Login //
                    mainWindow.RegisterForm("login", new GUI.Login());
                    // Teacher - only //
                    mainWindow.RegisterForm("admin", new GUI.Administration());
                    mainWindow.RegisterForm("createuser", new GUI.CreateNewUser());
                    mainWindow.RegisterForm("creategroup", new GUI.CreateGroup());
                    mainWindow.RegisterForm("updategroup", new GUI.UpdateGroup());
                    //mainWindow.RegisterForm("update", new Update());

                    // Student - only //
                    mainWindow.RegisterForm("game", new GUI.GameScreen());

                    mainWindow.SwitchForm<GUI.Login>("login");
                    // We serialize our data on the app exit.
                    AppDomain.CurrentDomain.ProcessExit += new EventHandler(SaveXMLData);
                    Application.Run(mainWindow);
                }

                static void SaveXMLData(object sender, EventArgs e)
                {
                    Data.UserList.Instance.Serialize();
                    Data.GroupList.Instance.Serialize();
                }
            }
        }
    }
}
