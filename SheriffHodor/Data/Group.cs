﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace CSUSM.CS441.SheriffHodor.Data
{
    public class Group : INotifyPropertyChanged
    {
        #region Definitions
        public string Name { get; set; }
        public Problem.Difficulty Difficulty { get; set; }
        [System.ComponentModel.DisplayName("Number of members")]
        public int NumberOfMember { get { return this.Members.Count; } }
        [System.ComponentModel.Browsable(false)]
        public List<User> Members { get; set; }
        #endregion

        public Group()
        {
            this.Members = new List<User>();
        }

        /*
         *Corey Paxton      - 3/21/2014 - Initial Version
         * Mathias Lang     - 3/27/2014 - Implementing UI stuff according to new SRS.
         */
        public override string ToString()
        {
            return this.Name;
        }

        #region INotifyPropertyChanged Membres
        // VS will incorrectly report this as unused
        // Actually it is used by the collection but it somehow fails to detect it.
#pragma warning disable 0067
        public event PropertyChangedEventHandler PropertyChanged;
#pragma warning restore 0067
        #endregion
    }
}