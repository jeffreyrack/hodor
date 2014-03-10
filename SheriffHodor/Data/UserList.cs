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
        private UserList(XmlUserList list) : base()
        {
            foreach (var usr in list.Users)
                this.Add(usr);
        }
        public static UserList Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserList(XmlBackend.Deserialize<XmlUserList>(Global.UsersFilePath));
                return _instance;
            }
        }
        #endregion

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
