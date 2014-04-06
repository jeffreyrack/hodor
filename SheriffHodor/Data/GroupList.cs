using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace CSUSM.CS441.SheriffHodor.Data
{
    public class GroupList : BindingList<Group>
    {
        #region Singleton
        private static GroupList _instance;
        public static GroupList Instance
        {
            get
            {
                if (_instance == null)
                    _instance = XmlBackend.Deserialize<GroupList>(Global.GroupsFilePath, Global.GroupDefault);
                return _instance;
            }
        }
        #endregion

        /*
         * Matthias Lang    - - Initial Version
         * Corey Paxton     - 4/5/2014 - Removes members from the group
         */
        public bool RemoveByName(string name)
        {
            int idx = GetIdxByName(name);
            if (idx >= 0)
            {
                foreach (var member in this.Items[idx].Members)
                {
                    member.GroupName = null;
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

        public Group GetByName(string name)
        {  
            var idx = GetIdxByName(name);
            return idx == -1 ? null : this[idx];
        }

        /// <summary>
        /// Save this list's data to the XML file.
        /// </summary>
        public void Serialize()
        {
            XmlBackend.Serialize<GroupList>(Global.GroupsFilePath, this);
        }
    }
}
