/*Team Hodor
 * This file provides the Getters and Seters of the below data list
 * 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


public class Game
{
	public Game() 
	{
	}

   public Game(int probSetId, List<int> problemSetIndex, bool isPositive, bool isAddition, int nudNumOfProb)
	{
		this.ProblemSetId = probSetId;
		this.problemSetIndex = problemSetIndex;
		this.isPositiveOnly = isPositive;
		this.isAddition = isAddition;
		this.numOfProblems = nudNumOfProb;
		this.numOFProblems = nudNumOfProb;
	}
	private int ProblemSetId;
	private List<int> problemSetIndex;
	private DateTime dateCompleted;
	private bool isPositiveOnly;
	private bool isAddition;
	private int numOFProblems;
	int numOfProblems;

	//getters 
	
	public int getProblemSetId()
	{
		return ProblemSetId;
	}
	 
	public int getProblemSetAtIndex(int index)
	{
		int returnVal = this.problemSetIndex[index];
		return returnVal;
	}

	public int getproblemSetIndex(int number)
	{
		return problemSetIndex[number];
	}

	public DateTime getdateCompleted()
	{
		return dateCompleted;
	}

	public bool getisPositiveOnly()
	{
		return isPositiveOnly;
	}

	public bool getisAddition()
	{
		return isAddition;
	}

	public int getnumOfProblems()
	{
		return numOfProblems;
	}

	//Setters

	public void setProblemSetId(int ProblemSetId)
	{
		this.ProblemSetId = ProblemSetId;
	}

	public void setproblemSetIndex(int number)
	{
		this.problemSetIndex[number] = problemSetIndex[number];
	}

	public void setdateCompleted(DateTime dateCompleted)
	{
		this.dateCompleted = dateCompleted;
	}

	public void setisPositiveOnly(bool isPositiveOnly)
	{
		this.isPositiveOnly = isPositiveOnly;
	}
	public void setNumProblems(int numProblems)
	{
		this.numOfProblems = numProblems;
	}

	public void setisAddition(bool isAddition)
	{
		this.isAddition = isAddition;
	}

	public void setIndex(List<int> indexes)
	{
		this.problemSetIndex = indexes;
	}

	public int getnumOfProblems(int numOfProblems)
	{
		return this.numOfProblems - numOfProblems;
	}

}


public class gameResults{
	public gameResults()
	{

	}
	public string Date;
	public List<bool> correct = new List<bool>();
	public List<int> indexes = new List<int>();
	public int problemSetId;
}
