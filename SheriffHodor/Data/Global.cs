using System;
using System.Collections.Generic;
using System.Linq;

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
        public const string StudentFilePath = @"C:\ProgramData\Students.xml";
        #endregion

        #region UserList
        /// <summary>
        /// Get a list of the users.
        /// This list is stored in the XML file in the backend.
        /// </summary>
        public static IList<User> UserList
        {
            get
            {
                if (_userList == null)
                    _userList = InitializeUserList();
                return _userList;
            }
        }
        private static IList<User> _userList;
        private static IList<User> InitializeUserList()
        {
            var ret = new List<User>();
            var users = XmlBackend.selectAll__();
            foreach (var it in users)
                ret.Add(it);
            return ret;
        }
        #endregion
    }
}
