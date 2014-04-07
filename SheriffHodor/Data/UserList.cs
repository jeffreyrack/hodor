using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Contracts;

namespace CSUSM.CS441.SheriffHodor.Data
{
    /// <summary>
    /// A list holding all the user.
    /// This list is an ObservableList, hence data in GUI is keep up to date
    /// using the observer pattern.
    /// </summary>
    public class UserList : BindingList<User>
    {
        #region Singleton
        private static UserList _instance;
        public static UserList Instance
        {
            get
            {
                if (_instance == null)
                    _instance = XmlBackend.Deserialize<UserList>(Global.UsersFilePath, Global.UserDefault);
                return _instance;
            }
        }
        #endregion

        public bool RemoveByName(string name)
        {
            int idx = GetIdxByName(name);
            if (idx >= 0)
            {
                if (Instance[idx].GroupName != String.Empty)
                {
                    GroupList.Instance.GetByName(Instance[idx].GroupName).Members.Remove(Instance[idx]);
                }
                this.RemoveItem(idx);
            }
            return (idx >= 0);
        }
        public int GetIdxByName(string name)
        {
            for (int i = 0; i < this.Count; ++i)
                if (this[i].Name.Equals(name, StringComparison.InvariantCultureIgnoreCase))
                    return i;
            Console.WriteLine("FAILED to get '{0}'.", name);
            return -1;
        }
        public User GetByName(string name)
        {
            var idx = GetIdxByName(name);
            return idx == -1 ? null : this[idx];
        }

        /// <summary>
        /// Save this list's data to the XML file.
        /// </summary>
        public void Serialize()
        {
            XmlBackend.Serialize<UserList>(Global.UsersFilePath, this);
        }
    }
}
