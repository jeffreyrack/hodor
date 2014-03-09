/*Team Hodor
 *  The buttons just need to be linkd to the XML background functions andsaved for the user games
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CSUSM
{
    namespace CS441
    {
        namespace SheriffHodor
        {
            public partial class Administration : UserControl
            {
                List<Student> users;
                bool isAddition = true;
                bool isPositive = true;
                int probSetId = 0;

                //object for calling functions of the xmlbackend class
                XmlBackend AA = new XmlBackend();

                public Administration()
                {
                    InitializeComponent();
                }

                //On this screen loading
                private void Administration_Load(object sender, EventArgs e)
                {
                    dudNumRange.SelectedIndex = 0;
                    optNegative.Enabled = false;
                    dgvSummary.AllowUserToAddRows = false;

                    //get all the users in the XML
                    users = AA.selectAll();
                    users = users.OrderBy(x => x.getName()).ToList();

                    //for each user
                    foreach (Student s in users) {
                        //that is a student
                        if (s.getisTeacher() == false) {

                            //display them in the checkbox list
                            clstUserList.Items.Add(s.getName());
                        }
                    }

                    nudNumOfProb.Maximum = maxProblemsInSet(probSetId);
                }


                //Addition button
                private void optAddition_CheckedChanged(object sender, EventArgs e)
                {
                    optPositive.Checked = true;
                    optNegative.Enabled = false;

                    isAddition = true;

                    probSetId = determineProblemSet(dudNumRange.Text);
                    nudNumOfProb.Maximum = maxProblemsInSet(probSetId);
                }

                //Subtraction
                private void optSubtraction_CheckedChanged(object sender, EventArgs e)
                {
                    optNegative.Enabled = true;

                    isAddition = false;

                    probSetId = determineProblemSet(dudNumRange.Text);
                    nudNumOfProb.Maximum = maxProblemsInSet(probSetId);
                }

                //Positive Only
                private void optPositive_CheckedChanged(object sender, EventArgs e)
                {
                    isPositive = true;

                    probSetId = determineProblemSet(dudNumRange.Text);
                    nudNumOfProb.Maximum = maxProblemsInSet(probSetId);
                }

                //Positive or Negative
                private void optNegative_CheckedChanged(object sender, EventArgs e)
                {
                    isPositive = false;

                    probSetId = determineProblemSet(dudNumRange.Text);
                    nudNumOfProb.Maximum = maxProblemsInSet(probSetId);
                }




                //Clicking in the datagridview to genereate indepth report and unselect all other selected students
                private void dgvSummary_CellClick(object sender,
                DataGridViewCellEventArgs e)
                {
                    if (dgvSummary.Rows.Count > 0) {
                        object value = dgvSummary.Rows[e.RowIndex].Cells[0].Value;
                        string nameFromDGV = value.ToString();

                        //unchecks all other students

                        //for every item in the checklist
                        for (int i = 0; i < clstUserList.Items.Count; i++) {
                            //if the item is checked and its not the name they clicked on
                            if (clstUserList.GetItemCheckState(i) == CheckState.Checked &&
                                clstUserList.Items[i].ToString() != nameFromDGV) {
                                //uncheck it
                                clstUserList.SetItemCheckState(i, CheckState.Unchecked);
                            }
                        }


                        List<gameResults> summary;
                        int correct = 0;
                        int total = 0;
                        //find the student

                        foreach (Student s in users) {
                            if (clstUserList.CheckedItems.Contains(s.getName())) {
                                //make only that student display in the dgv
                                dgvSummary.Rows.Clear();
                                dgvSummary.Rows.Add(value);


                                List<int> factors = new List<int>();
                                List<int> problemSet = new List<int>();
                                summary = AA.readGameStats(s);
                                foreach (gameResults gr in summary) {
                                    problemSet = AA.selectProblemSet(gr.problemSetId);
                                    correct = 0;
                                    total = 0;

                                    dgvSummary.Rows.Add("", gr.Date.ToString());
                                    for (int i = 0; i < gr.indexes.Count; i++) {
                                        factors = returnCorrectProblems(problemSet, gr.indexes[i]);
                                        if (gr.correct[i]) {
                                            dgvSummary.Rows.Add("", factors[0] + " " + getOperator(gr.problemSetId) + " "
                                                + factors[1] + "    Correct");
                                            correct++;
                                        } else {
                                            dgvSummary.Rows.Add("", factors[0] + " " + getOperator(gr.problemSetId) + " "
                                                + factors[1] + "    Incorrect");
                                        }

                                        total++;
                                    }

                                    if (total > 0) {
                                        float average = ((float)correct / (float)total) * 100;
                                        dgvSummary.Rows.Add("", average.ToString() + "%");
                                    } else {
                                        dgvSummary.Rows.Add("", "No results to display");
                                    }
                                }
                            }
                        }




                    }

                }

                //when they check a new item in the checklist
                private void clstUserList_SelectedIndexChanged(object sender, EventArgs e)
                {
                    //reset the datagridview
                    dgvSummary.Rows.Clear();

                    List<gameResults> summary;
                    int correct = 0;
                    int total = 0;

                    //for every item checked

                    foreach (Student s in users) {
                        if (clstUserList.CheckedItems.Contains(s.getName())) {
                            correct = 0;
                            total = 0;

                            summary = AA.readGameStats(s);
                            foreach (gameResults gr in summary) {
                                foreach (bool answer in gr.correct) {
                                    if (answer) {
                                        correct++;
                                    }
                                    total++;
                                }
                            }

                            if (total > 0) {
                                float average = ((float)correct / (float)total) * 100;
                                dgvSummary.Rows.Add(s.getName().ToString(), average.ToString() + "%");
                            } else {
                                dgvSummary.Rows.Add(s.getName().ToString(), "No results to display");
                            }
                        }
                    }
                }

                //number range
                private void dudNumRange_SelectedItemChanged(object sender, EventArgs e)
                {
                    probSetId = determineProblemSet(dudNumRange.Text);
                    nudNumOfProb.Maximum = maxProblemsInSet(probSetId);
                }

                //Updatebutton to update the changes made by the admin to the selected students
                private void btnUpdate_Click(object sender, EventArgs e)
                {
                    try {
                        List<int> problemSetIndex = randomIndices(Int32.Parse(nudNumOfProb.Text), maxProblemsInSet(probSetId));
                        Game newGame = new Game(probSetId, problemSetIndex, isPositive, isAddition, Int32.Parse(nudNumOfProb.Text));
                        string updatedUsers = "";

                        foreach (Student s in users) {
                            if (clstUserList.CheckedItems.Contains(s.getName())) {
                                updatedUsers += s.getName() + Environment.NewLine;
                                AA.saveGameStuff(probSetId, problemSetIndex, isPositive, isAddition, Int32.Parse(nudNumOfProb.Text), s);
                            }
                        }

                        if (updatedUsers.Length > 0) {
                            MessageBox.Show("Users updated: " + Environment.NewLine + updatedUsers);
                        }
                    } catch (Exception ex) {
                        MessageBox.Show(ex.Message);
                    }
                    //MainWindow.Instance().SwitchForm("login");
                }

                //Cancel button returns you to the Login Menu
                private void Cancel_Click(object sender, EventArgs e)
                {
                    MainWindow.Instance().SwitchForm("login");
                }

                /***************
                 * supporting functions
                 * ***********/

                private List<int> randomIndices(int listSize, int maxValue)
                {
                    //list of random indices of size
                    Random rand = new Random();
                    List<int> remainingNums = new List<int>();
                    List<int> randomIndices = new List<int>();
                    //int maxNum = listSize;

                    //maxNum = Int32.Parse(nudNumOfProb.Text);
                    //int range = maxProblemsInSet(probSetId);
                    for (int i = 0; i < maxValue; i++) {
                        remainingNums.Add(i);
                    }

                    //shuffles
                    for (int i = 0; i < listSize; i++) {
                        //index between 0 and max size of the nums avail
                        int randIndex = rand.Next(0, maxValue - i);

                        //add to i a random value that does not conflict with previously added values
                        randomIndices.Add(remainingNums[randIndex]);

                        //remove the value from the original list to remove the conflict
                        remainingNums.Remove(remainingNums[randIndex]);

                    }

                    return randomIndices;
                }

                //get the max numbers of problems in the sets
                private int maxProblemsInSet(int problemSetId)
                {
                    switch (problemSetId) {
                        case 0:
                        case 2:
                            return (121);
                        case 1:
                            return (66);
                        default:
                            return (500);
                    }
                }

                //based on a string value get an integer ID of the problem sets
                private int determineProblemSet(string problemTier)
                {
                    //figure out what problem set we are in
                    switch (problemTier) {
                        //0-10
                        case "10":
                            //addition
                            if (isAddition) {
                                return (0);
                            }
                                //subtraction
                            else {
                                //positive only
                                if (isPositive) {
                                    return (1);
                                }
                                    //negative and positive
                                else {
                                    return (2);
                                }
                            }
                        case "100":
                            //addition
                            if (isAddition) {
                                return (3);
                            }
                                //subtraction
                            else {
                                //positive only
                                if (isPositive) {
                                    return (4);
                                }
                                    //negative and positive
                                else {
                                    return (5);
                                }
                            }
                        case "1,000":
                            //addition
                            if (isAddition) {
                                return (6);
                            }
                                //subtraction
                            else {
                                //positive only
                                if (isPositive) {
                                    return (7);
                                }
                                    //negative and positive
                                else {
                                    return (8);
                                }
                            }
                        case "10,000":
                            //addition
                            if (isAddition) {
                                return (9);
                            }
                                //subtraction
                            else {
                                //positive only
                                if (isPositive) {
                                    return (10);
                                }
                                    //negative and positive
                                else {
                                    return (11);
                                }
                            }
                        case "100,000":
                            //addition
                            if (isAddition) {
                                return (12);
                            }
                                //subtraction
                            else {
                                //positive only
                                if (isPositive) {
                                    return (13);
                                }
                                    //negative and positive
                                else {
                                    return (14);
                                }
                            }
                        case "Any Number":
                            //addition
                            if (isAddition) {
                                return (15);
                            }
                                //subtraction
                            else {
                                //positive only
                                if (isPositive) {
                                    return (16);
                                }
                                    //negative and positive
                                else {
                                    return (17);
                                }
                            }
                        default:
                            return (-1);
                    }
                }

                public List<int> returnCorrectProblems(List<int> problems, int index)
                {
                    int J = 0;
                    int K = 0;

                    int transfer1;
                    int transfer2;

                    List<int> returnNumbers = new List<int>();

                    index = index * 2;

                    K = index;
                    J = index + 1;

                    transfer1 = problems[K];
                    transfer2 = problems[J];

                    returnNumbers.Add(transfer1);
                    returnNumbers.Add(transfer2);


                    return returnNumbers;
                }

                public string getOperator(int problemSetId)
                {
                    switch (problemSetId) {
                        //0-10
                        case 0:
                            return ("+");
                        case 1:
                        case 2:
                            return ("-");
                        case 3:
                            return ("+");
                        case 4:
                        case 5:
                            return ("-");
                        case 6:
                            return ("+");
                        case 7:
                        case 8:
                            return ("-");
                        case 9:
                            return ("+");
                        case 10:
                        case 11:
                            return ("-");
                        case 12:
                            return ("+");
                        case 13:
                        case 14:
                            return ("-");
                        case 15:
                            return ("+");
                        case 16:
                        case 17:
                            return ("-");
                        default:
                            return ("+");
                    }
                }

            }
        }
    }
}