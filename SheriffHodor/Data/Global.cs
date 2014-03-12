using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

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
        #region Refactor
        public static int maxId = 0;
        #endregion

        #region Const data
        /// <summary>
        /// Path to the configuration folder of the application.
        /// </summary>
        public const string ConfDirPath = @"C:\ProgramData\SheriffHodor\";
        /// <summary>
        /// Path to the XML file holding the User's data.
        /// </summary>
        public const string UsersFilePath = @"C:\ProgramData\SheriffHodor\Users.xml";
        /// <summary>
        /// Path to the XML file holding the questions.
        /// </summary>
        public const string QCMFilePath = @"C:\ProgramData\SheriffHodor\Questions.xml";
        /// <summary>
        /// Path to the XML file holding the problems set.
        /// </summary>
        public const string ProblemsFilePath = @"C:\ProgramData\SheriffHodor\Problems.xml";
        #endregion
    }
}
