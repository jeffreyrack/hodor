/* Program.cs
 *  Main entry point of the program.
 *  
 * Version - 3.0.1 - 4/24/2014 - Jeffrey Rackauckas - Added the userWatcher object to update when the xml files change outside of the program.
 * Version - 3.0.0 - Cycle 3 Release
 */
using System;
using System.Collections.Generic;
using System.IO;
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
                    mainWindow.SwitchForm<GUI.Login>();
                    // We serialize our data on the app exit.
                    AppDomain.CurrentDomain.ProcessExit += new EventHandler(SaveXMLData);
                    /*
                    FileSystemWatcher userWatcher = new FileSystemWatcher(Data.Global.ConfDirPath);
                    userWatcher.NotifyFilter = NotifyFilters.LastWrite;
                    userWatcher.Filter = "*.xml";
                    userWatcher.Changed += new FileSystemEventHandler(OnChanged);
                    userWatcher.EnableRaisingEvents = true;
                     */
                    Application.Run(mainWindow);


                }

                static void SaveXMLData(object sender, EventArgs e)
                {
                    Data.UserList.Instance.Serialize();
                    Data.GroupList.Instance.Serialize();
                }

                /*
                 * 
                static void OnChanged(object source, FileSystemEventArgs e)
                {
                       /*
                    if (e.Name == "Users.xml")
                        Data.UserList.Reload();
                    else
                        Data.GroupList.Reload();
                    
                }
            */
            }
        }
    }
}
