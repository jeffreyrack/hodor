using System;

namespace CSUSM.CS441.SheriffHodor.Data
{
    /// <summary>
    /// A list holding all the user.
    /// This list is an ObservableList, hence data in GUI is keep up to date
    /// using the observer pattern.
    /// </summary>
    public class UserList : ObservableList<User>
    {
        #region Singleton
        private static UserList _instance;
        private UserList(XmlUserList list)
            : base()
        {
            foreach (var usr in list.Users)
                this.Add(usr);
        }
        public static UserList Instance
        {
            get
            {
                if (_instance == null)
                {

                    #region Move that away
                    if (!System.IO.Directory.Exists(Global.ConfDirPath))
                        System.IO.Directory.CreateDirectory(Global.ConfDirPath);
                    if (!System.IO.File.Exists(Global.UsersFilePath))
                    {
                        using (var defaultFile = System.IO.File.CreateText(Global.UsersFilePath))
                        {
                            defaultFile.WriteLine("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
                            defaultFile.WriteLine("<Students xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\">");
                            defaultFile.WriteLine("<Student><Name>Admin</Name><Status>Teacher</Status></Student>");
                            defaultFile.WriteLine("</Students>");
                        }

                    }
                    // End of ugly coupling.
                    #endregion

                    _instance = new UserList(XmlBackend.Deserialize<XmlUserList>(Global.UsersFilePath));
                }
                return _instance;
            }
        }
        #endregion

        public bool RemoveByName(string name)
        {
            int idx = GetByName(name);
            if (idx >= 0)
                this.RemoveItem(idx);
            return (idx >= 0);
        }
        public int GetByName(string name)
        {
            for (int i = 0; i < this.Count; ++i)
                if (this[i].Name.Equals(name, StringComparison.InvariantCultureIgnoreCase))
                {
                    return i;
                }
            Console.WriteLine("FAILED to get '{0}'.", name);
            return -1;
        }

        /// <summary>
        /// Save this list's data to the XML file.
        /// </summary>
        public void Serialize()
        {
            var xmllist = new XmlUserList();
            xmllist.Users.AddRange(this);
            XmlBackend.Serialize<XmlUserList>(Global.UsersFilePath, xmllist);
        }
    }
}
