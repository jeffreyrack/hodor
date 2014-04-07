using System;
using System.Linq;
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
    public class UserList : BindingList<User>, IBindingListView
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
                    //Find the group by the name of the group associated with the user
                    //Get the members of that group and find the user by that name and remove them from that list
                    string groupName = Instance[idx].GroupName;
                    var toDel =
                        from mem in GroupList.Instance.GetByName(groupName).Members
                        where mem.Name == Instance[idx].Name
                        select mem;
                    GroupList.Instance.GetByName(groupName).Members.Remove(toDel.First());
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
            var filter = this.Filter;
            this.Filter = null;
            XmlBackend.Serialize<UserList>(Global.UsersFilePath, this);
            this.Filter = filter;
        }


        #region IBindingListView Members
        private string m_filter;
        private List<User> filteredOutElems = new List<User>();
        // This is super basic.
        // It filters in the Student | Teacher, Depending on the Filter string.
        // ie: "Student" or "Teacher". 
        public string Filter
        {
            get { return this.m_filter; }
            set
            {
                // Re-add items to the list -- Sorted
                foreach (var usr in this.filteredOutElems)
                    this.sortedInsert(usr);
                this.filteredOutElems.Clear();

                // Read the filter string;
                this.m_filter = value;
                if (value == null) // RemoveFilter()
                    return;
                User.UserType nVal = (User.UserType)Enum.Parse(typeof(User.UserType), value);

                // Filter the list
                for (var i = 0; i < this.Count; ++i)
                    if (this[i].Status != nVal)
                    {
                        Console.WriteLine("Removing: {0}", this[i].Name);
                        this.filteredOutElems.Add(this[i]);
                        this.RemoveAt(i);
                        --i;
                    }
            }
        }

        public void RemoveFilter() { this.Filter = null; }
        public bool SupportsFiltering { get { return true; } }

        private void sortedInsert(User usr)
        {
            for (var i = 0; i < this.Count; ++i)
                if (string.Compare(this[i].Name, usr.Name, StringComparison.InvariantCultureIgnoreCase) >= 0)
                {
                    this.InsertItem(i, usr);
                    return;
                }
        }
        public bool SupportsAdvancedSorting { get { return false; } }
        public void ApplySort(ListSortDescriptionCollection sorts) { throw new NotImplementedException(); }
        public ListSortDescriptionCollection SortDescriptions { get { throw new NotImplementedException(); } }
        #endregion
    }
}
