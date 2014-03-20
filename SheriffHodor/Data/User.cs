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
        #region Type
        /// <summary>
        /// Status of the user, used for access rights.
        /// </summary>
        public enum UserType
        {
            Teacher,
            Student
        }

        public enum Difficulty { EASY, MEDIUM, HARD };

        public class Runtime
        {
            #region Definitions

            public delegate Problem GenerateProblem(Difficulty diff);

           /*
            * Corey Paxton     - 3/20/2014 - Initial Version
            */
            public Problem AddProblem(Difficulty diff)
            {
                //2-5 terms
                Random rand = new Random();
                int numOfTerms = rand.Next(2, 6);
                List<ushort> terms = new List<ushort>();
                int upperRange = 0;

                switch (diff)
                {
                    case Difficulty.EASY: upperRange = 20;
                        break;
                    case Difficulty.MEDIUM: upperRange = 100;
                        break;
                    case Difficulty.HARD: upperRange = 1000;
                        break;
                }

                for (int i = 0; i < numOfTerms; i++)
                {
                    terms.Add((ushort)rand.Next(0, upperRange + 1));
                }

                return (new Problem(terms, Problem.Operator.Addition));
            }

            /*
             * Corey Paxton     - 3/20/2014 - Initial Version
             */
            public Problem SubProblem(Difficulty diff)
            {
                //2 terms
                Random rand = new Random();
                List<ushort> terms = new List<ushort>();
                int upperRange = 0;
                ushort term1;
                ushort term2;

                switch (diff)
                {
                    case Difficulty.EASY: upperRange = 20;
                        break;
                    case Difficulty.MEDIUM: upperRange = 100;
                        break;
                    case Difficulty.HARD: upperRange = 1000;
                        break;
                }

                term1 = (ushort)rand.Next(0, upperRange + 1);
                term2 = (ushort)rand.Next(0, upperRange + 1);

                if (term1 > term2)
                {
                    terms.Add(term1);
                    terms.Add(term2);
                }
                else
                {
                    terms.Add(term2);
                    terms.Add(term1);
                }
                return (new Problem(terms, Problem.Operator.Substraction));
            }

            #endregion

            public Runtime()
            {
                this.currentProblem = new Problem();
            }
            public Problem currentProblem { get; set; }
            public int totalProblems { get; set; }
            public int currentProblemIndex { get; set; }
            public Difficulty testDiff { get; set; }
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
            this.Data = new Runtime();
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
        /// Hold the status of the user, currently only 2 are defined: Teacher & Student.
        /// </summary>
        public UserType Status { get; set; }

        [XmlIgnore()]
        public User.Runtime Data { get; private set; }
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