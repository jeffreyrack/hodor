using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace CSUSM.CS441.SheriffHodor.Data
{
    public class Group : INotifyPropertyChanged
    {
        #region Definitions
        public string Name { get; set; }
        public Problem.Difficulty Difficulty { get; set; }
        [System.ComponentModel.DisplayName("Number of members")]
        public int NumberOfMember { get { return this.Members.Count; } }
        [XmlIgnore(), System.ComponentModel.Browsable(false)]
        // racka001: Changed this to no longer be a get/set, but just pull directly from users everybody currently in the group.
        public List<User> Members { get { return Data.UserList.Instance.ApplyGroupFilter(this.Name).ToList(); } }
        #endregion

        public Group()
        {
        }

        /*
         *Corey Paxton      - 3/21/2014 - Initial Version
         * Mathias Lang     - 3/27/2014 - Implementing UI stuff according to new SRS.
         */
        public override string ToString()
        {
            return this.Name;
        }

        /*
        // Added by: Jeffrey Rackauckas
        // Added on: 04/21/2014
        // Removed By: Jeffrey Rackauckas
        // Removed on: 5/4/2014
        // Reason: This requirement still isn't in the SRS!
        // Purpose: To provide a single function to check whether or not a passed group name is valid.
        public static bool ValidName(string name)
        {
            return Helpers.CheckRegexMatch(name, @"[0-9a-zA-Z]{0,100}");
        }
        */
        #region INotifyPropertyChanged Membres
        // VS will incorrectly report this as unused
        // Actually it is used by the collection but it somehow fails to detect it.
#pragma warning disable 0067
        public event PropertyChangedEventHandler PropertyChanged;
#pragma warning restore 0067
        #endregion
    }
}