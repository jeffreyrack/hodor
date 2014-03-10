/*
 * Team Hodor
 * This file provides the Getters and Seters of the below data list
 * 
 */
using System;
using System.Collections.Generic;

namespace CSUSM.CS441.SheriffHodor.Data
{
    /// <summary>
    /// Our User class.
    /// Holds the data concerning the user and provides a mean to authenticate them aswell.
    /// </summary>
    public class User
    {
        #region Refactor
        public Game nextGame { get; set; }
        public List<Game> report { get; set; }
        #endregion

        #region Type
        public enum UserType
        {
            Invalid,
            Teacher,
            Student
        }
        #endregion

        #region Constructor
        public User() : this(null, -1, UserType.Student, null) { }
        public User(string name, int id, UserType status = UserType.Student, byte[] hash = null)
        {
            this.Name = name;
            this.Hash = hash;
            this.Id = id;
            this.Status = status;
            if (id > Global.maxId)
                Global.maxId = id;
        }
        #endregion

        #region Properties
        public string Name { get; set; }
        public byte[] Hash { get; set; }
        public int Id { get; set; }
        public UserType Status { get; set; }
        #endregion
    }
}