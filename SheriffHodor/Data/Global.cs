using System;
using System.IO;

namespace CSUSM.CS441.SheriffHodor.Data
{
    /// <summary>
    /// Hold a state global to the program.
    /// As our application is single threaded, we can hold pretty much everything this way.
    /// Centralizing data here allow for an easyier development path, easyier maintenance and enhance writtability.
    /// This is a design choice, considering we have a small-scale application, we're not over-engineering it.
    /// </summary>
    public static class Global
    {
        #region Paths
        /// <summary>
        /// Path to the configuration folder of the application.
        /// </summary>
        public static readonly string ConfDirPath = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "SheriffHodor");
        /// <summary>
        /// Path to the XML file holding the User's data.
        /// </summary>
        public static readonly string UsersFilePath = Path.Combine(ConfDirPath, "Users.xml");
        /// <summary>
        /// Path to the XML file holding the Group's data.
        /// </summary>
        public static readonly string Groups = Path.Combine(ConfDirPath, "Groups.xml");
        #endregion

        // This is ugly.
        #region Default config
        public static readonly string[] UserDefault = {"<?xml version=\"1.0\" encoding=\"utf-8\"?>",
"<ArrayOfUser xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\">",
                        "<User>",
                        "<Name>Admin</Name>",
                        "<Status>Teacher</Status>",
                        "</User>",
                        "</ArrayOfUser>"};
        #endregion
    }
}
