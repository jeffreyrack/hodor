/*
 * Team Hodor
 * This file provides the Getters and Seters of the below data list
 * 
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace CSUSM.CS441.SheriffHodor.Data
{
    /// <summary>
    /// Our User class.
    /// Holds the data concerning the user and provides a mean to authenticate them aswell.
    /// </summary>
    public class User
    {
        #region Refactor
        [XmlIgnore()]
        public Game nextGame { get; set; }
        [XmlIgnore()]
        public List<Game> report { get; set; }
        #endregion

        #region Type
        /// <summary>
        /// Status of the user, used for access rights.
        /// </summary>
        public enum UserType
        {
            Teacher,
            Student
        }
        #endregion

        #region Constructor & object inheritance
        /// <summary>
        /// Instantiate a default-initialized, non working User object.
        /// </summary>
        public User() : this(null, -1, UserType.Student, null) { }
        /// <summary>
        /// Instantiate an User with the given values.
        /// </summary>
        /// <param name="name">The username.</param>
        /// <param name="id">An id for the user.</param>
        /// <param name="status">The status of the user, default to student.</param>
        /// <param name="hash">The SHA-1 hash of the user's password.</param>
        public User(string name, int id, UserType status = UserType.Student, byte[] hash = null)
        {
            this.Name = name;
            this.Hash = hash;
            this.Id = id;
            this.Status = status;
            if (id > Global.maxId)
                Global.maxId = id;
        }
        /// <summary>
        /// Pretty print this object.
        /// </summary>
        /// <returns>A string representation of this object.</returns>
        public override string ToString()
        {
            return string.Format("[{0}] => {1} ({2})", this.Id, this.Name, this.Status);
        }
        #endregion

        #region Properties
        /// <summary>
        /// The name of the user.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// An hash representing the password of the user, if needed (mandatory for teachers).
        /// </summary>
        [XmlIgnore()] // Temp TODO
        public byte[] Hash { get; set; }
        /// <summary>
        /// The internal ID of the user.
        /// </summary>
        [XmlAttribute("id")]
        public int Id { get; set; }
        /// <summary>
        /// Hold the status of the user, currently only 2 are defined: Teacher & Student.
        /// </summary>
        public UserType Status { get; set; }
        #endregion
    }
}