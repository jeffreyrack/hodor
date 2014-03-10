/*
 * Team Hodor
 * This file provides the Getters and Seters of the below data list
 * 
 */
using System;

namespace CSUSM.CS441.SheriffHodor.Data
{
    /// <summary>
    /// Our User class.
    /// Holds the data concerning the user and provides a mean to authenticate them aswell.
    /// </summary>
    public class User
    {
        public enum UserType
        {
            Invalid,
            Teacher,
            Student
        }

        public User()
        {
            this.Name = null;
            this.Hash = null;
            this.Id = -1;
            this.Status = UserType.Invalid;
        }
        public string Name { get; set; }
        public byte[] Hash { get; set; }
        public int Id { get; set; }
        public UserType Status { get; set; }
    }
}