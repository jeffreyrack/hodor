using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Timers;

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



        public class Runtime
        {
            #region Definitions
            public void newGame()
            {
                Random rand = new Random();

                this.totalProblems = rand.Next(10, 31);
                this.currentProblemIndex = 0;
                this.correctAnswers = 0;
                this.correctStreak = 0;
                this.coinsGained = 0;

                //Addition or Subtraction problems
                if (rand.Next(0, 2) > 0)
                {
                    this.problemHandler = Problem.AddProblem;
                }
                else
                {
                    this.problemHandler = Problem.SubProblem;
                }

                this.currentProblem = this.problemHandler(this.testDiff);
            }
            #endregion

            public Runtime()
            {
                this.currentProblem = new Problem();
                this.testDiff = Problem.Difficulty.Easy;
            }

            public Problem currentProblem { get; set; }
            public int totalProblems { get; set; }
            public int currentProblemIndex { get; set; }
            public Problem.Difficulty testDiff { get; set; }
            public Data.Problem.GenerateProblem problemHandler { get; set; }
            public int correctAnswers { get; set; }
            public int correctStreak { get; set; }
            public int coinsGained { get; set; }
            public int problemTime { get; set; }
        }
        #endregion

        #region Constructor & object inheritance
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
        public User(string name = null, UserType status = UserType.Student, string hash = null)
        {
            this.Name = name;
            this.Hash = hash;
            this.Status = status;
            this.Coins = 0;
            this.Percentages = new List<double>();
            this.TotalPercentage = 0.0;
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
        /// A hash representing the password of the user, if needed (mandatory for teachers).
        /// </summary>
        [System.ComponentModel.Browsable(false)]
        public string Hash { get; set; }
        /// <summary>
        /// Hold the status of the user, currently only 2 are defined: Teacher & Student.
        /// </summary>
        public UserType Status { get; set; }
        /// <summary>
        /// Keeps track of the total number of coins earned by a User
        /// </summary>
        [System.ComponentModel.Browsable(false)]
        public int Coins { get; set; }
        //  TODO display these in report
        /// <summary>
        /// Keep track of the game stats
        /// </summary>
        public List<double> Percentages { get; set; }
        /// <summary>
        /// Total percentage of all games played
        /// </summary>
        public double TotalPercentage { get; set; }
        /// <summary>
        /// Number of games played
        /// </summary>
        public int GameCount { get; set; }
        /// <summary>
        /// Name of the group the user is in
        /// </summary>
        public string GroupName { get; set; }

        [XmlIgnore(), System.ComponentModel.Browsable(false)]
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
}