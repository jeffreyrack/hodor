/*
 * Team Hodor
 * This file provides the Getters and Seters of the below data list
 * 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Serialization;

namespace CSUSM.CS441.SheriffHodor.Data
{
    /// <summary>
    /// Our User class.
    /// Holds the data concerning the user and provides a mean to authenticate them aswell.
    /// </summary>
    public class User : INotifyPropertyChanged
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
        // Use this in user code.
        public static User CreateUser(string name, UserType status = UserType.Student, byte[] hash = null)
        {
            return new User(name, ++Global.maxId, status, hash);
        }
        /// <summary>
        /// A parameterless constructor is needed by the serialized.
        /// </summary>
        public User() : this(null) { } // Force usage of the other constructor.
        /// <summary>
        /// Instantiate an User with the given values, or default initialized.
        /// </summary>
        /// <param name="name">The username.</param>
        /// <param name="id">An id for the user.</param>
        /// <param name="status">The status of the user, default to student.</param>
        /// <param name="hash">The SHA-1 hash of the user's password.</param>
        public User(string name = null, int id = -1, UserType status = UserType.Student, byte[] hash = null)
        {
            this.Name = name;
            this.Hash = hash;
            this.Status = status;
        }
        /// <summary>
        /// Pretty print this object.
        /// </summary>
        /// <returns>A string representation of this object.</returns>
        public override string ToString()
        {
            return string.Format("{0} ({1})", this.Name, this.Status);
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
        [Obsolete()]
        public int Id { get; set; }
        /// <summary>
        /// Hold the status of the user, currently only 2 are defined: Teacher & Student.
        /// </summary>
        public UserType Status { get; set; }
        #endregion

        #region INotifyPropertyChanged Membres
        // VS will incorrectly report this as unused
        // Actually it is used by the collection but it somehow fails to detect it.
#pragma warning disable 0067
        public event PropertyChangedEventHandler PropertyChanged;
#pragma warning restore 0067
        #endregion
    }

    /// <summary>
    /// An XML-serializable class holding the list of users.
    /// </summary>
    [XmlRoot("Students")]
    public class XmlUserList
    {
        [XmlElement("Student")]
        public List<User> Users = new List<User>();
    }
}