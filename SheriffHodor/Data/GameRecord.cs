// Created By: Jeffrey Rackauckas
// Created On: 5/4/2014.
// Created to store all of the information that we are currently storing about previous games.
//
// Version: 3.0.0 -- Jeffrey Rackauckas -- Initial Draft.
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
