/* Global.cs
 * Purpose: The purpose of this class is to contain all of the global variables of the program.
 * 
 * Version - 3.0.1 - 4/24/2014 - Jeffrey Rackauckas - Added the opaquebackground variable, changed default group xml to include Ungrouped Users.
 * Version - 3.0.0 - Cycle 2 Release
 */
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
        public static readonly string GroupsFilePath = Path.Combine(ConfDirPath, "Groups.xml");
        #endregion

        public static readonly System.Drawing.Color opaqueBackground = System.Drawing.Color.FromArgb(150, 240, 220, 165);

        // This is ugly.
        // Hash == Sha1Of("admin")
        #region Default config
        public static readonly string[] UserDefault = {"<?xml version=\"1.0\" encoding=\"utf-8\"?>",
"<ArrayOfUser xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\">",
                        "<User>",
                        "<Name>Admin</Name>",
                        "<Hash>7C-87-54-1F-D3-F3-EF-50-16-E1-2D-41-19-00-C8-7A-60-46-A8-E8</Hash>",
                        "<Status>Teacher</Status>",
                        "</User>",
                        "</ArrayOfUser>"};

        public static readonly string[] GroupDefault = {"<?xml version=\"1.0\" encoding=\"utf-8\"?><ArrayOfGroup xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\"> <Group> <Name>Ungrouped Users</Name>  <Difficulty>Easy</Difficulty></Group></ArrayOfGroup>"};
        #endregion
    }
}
