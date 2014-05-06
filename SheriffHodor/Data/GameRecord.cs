// GameRecord.cs
// The purpose of this class is to provide an object of what to store for games a user has already played.
//
// Version: 3.0.0 -5/4/2014 - Jeffrey Rackauckas -- Initial Draft.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSUSM.CS441.SheriffHodor.Data
{
    public class GameRecord
    {
        public int numProblems { get; set; }
        public DateTime dateTaken { get; set; }
        public int numCorrect { get; set; }
        public GameRecord() { }
        public GameRecord(int numProblems, DateTime dateTaken, int numCorrect)
        {
            this.numProblems = numProblems;
            this.dateTaken = dateTaken;
            this.numCorrect = numCorrect;
        }
    }
}
