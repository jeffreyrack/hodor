﻿/* User.cs
 * Purpose: Provides all functionality for handling users.
 * 
 * Version - 3.0.6 - 5/4/2014 - Jeffrey Rackauckas - Changed TotalPercentage to return a string.
 * Version - 3.0.5 - 5/3/2014 - Jeffrey Rackauckas - Changed ValidName to accept spaces, .'s, and numbers. 
 * Version - 3.0.4 - 4/30/2014 - Jeffrey Rackauckas - Added the OwnedHats variable, and the BuyHat function.
 * Version - 3.0.3 - 4/29/2014 - Jeffrey Rackauckas - Added the total coins value, and created the addCoins function.
 * Version - 3.0.2 - 4/24/2014 - Jeffrey Rackauckas - Moved game related functionality into Game.cs
 * Version - 3.0.1 - 4/21/2014 - Jeffrey Rackauckas - Added the ValidName function to make sure the passed name is valid.
 * Version - 3.0.0 - Cycle 2 Release
 */
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

            #endregion

            public Runtime()
            {
//                this.game.currentProblem = new Problem();
 //               this.game.testDiff = Problem.Difficulty.Easy;
            }
            public Game game { get; set; }

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
            this.TotalCoins = 0;
            this.OwnedHats = new List<Hat>();
            this.Data = new Runtime();
            this.PreviousGames = new List<GameRecord>();
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
        /// Keeps track of the current number of coins a user has.
        /// </summary>
        [System.ComponentModel.Browsable(false)]
        public int Coins { get; set; }
        /// <summary>
        /// Keeps track of the total number of coins earned by a User
        /// </summary>
        [System.ComponentModel.Browsable(false)]
        public int TotalCoins { get; set; }
        /// <summary>
        /// Keeps track of the currently selected hat.
        /// </summary>
        [System.ComponentModel.Browsable(false)]
        public Hat selectedHat { get; set; }
        /// <summary>
        /// Keep track of all hats the user owns.
        /// </summary>
       [System.ComponentModel.Browsable(false)]
        public List<Hat> OwnedHats { get; set; }
        /// <summary>
        /// List of all games played by the user.
        /// </summary>
       [System.ComponentModel.Browsable(false)]
       public List<GameRecord> PreviousGames { get; set; }
       /// <summary>
       /// Total percentage of all games played
       /// </summary>
       public string TotalPercentage { get {
           if (this.Status == UserType.Teacher) return "";
            int total = 0;
            int correct = 0;
           foreach(GameRecord record in this.PreviousGames)
           {
               total += record.numProblems;
               correct += record.numCorrect;
           }
           if (total == 0) return "";
           return Math.Floor(((double)correct / total)*100).ToString() + "%";

       }
       }
        /// <summary>
        /// Number of games played
        /// </summary>
        public int GameCount { get { return this.PreviousGames.Count; } }
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

        // Changed By: Jeffrey Rackauckas
        // Changed on: 4/24/2014.
        // Moved the main functionality of this to Game.cs
        public void newGame(User user)
        {
            user.Data.game = new Game(user);

        }

        // Added By: Jeffrey Rackauckas
        // Created on: 4/29/2014
        // Is used to increment the number of coins a user has.
        public void addCoins(int gained)
        {
            if (this.Coins + gained >= 2147483647)
            {
                this.Coins = 2147483647;
                this.TotalCoins = 2147483647;
            }
            // This function should only be used for positive increments.
            if (gained <= 0) return;
            this.Coins += gained;
            this.TotalCoins += gained;
        }
        // Added by: Jeffrey Rackauckas
        // Added on: 04/21/2014
        // Purpose: To provide a single function to check whether or not a passed username is valid.
        public static bool ValidName(string name)
        {
            return Helpers.CheckRegexMatch(name, @"^[A-Za-z0-9. ]{1,100}$");
        }

        public bool ownsHat(Hat toCheck){
            foreach(Data.Hat hat in this.OwnedHats)
            {
                if(hat.Tier == toCheck.Tier && hat.Number == toCheck.Number) return true;
            }
            return false;
        }

        // Added By: Jeffrey Rackauckas
        // Added on: 4/30/2014
        // Purpose: Let's the user buy a hat!
        public int BuyHat(Hat toBuy)
        {
            if (toBuy.getPrice() > this.Coins) return 1;
            if (ownsHat(toBuy)) return 2;
            this.Coins -= toBuy.getPrice();
            this.OwnedHats.Add(toBuy);
            return 0;
        }
    }
}