/*Team Hodor
 *  The buttons just need to be linkd to the XML background functions andsaved for the user games
 */
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CSUSM.CS441.SheriffHodor.GUI
{
    public partial class Administration : StateControl
    {
        public Administration()
        {
            InitializeComponent();
            GUIUpdate(null, null);
            Data.UserList.Instance.CollectionChanged += new NotifyCollectionChangedEventHandler(GUIUpdate);
        }

        private void GUIUpdate(object o, EventArgs e)
        {
            // Users
            Console.WriteLine("Update");
            dtg_users_list.DataSource = null;
            dtg_users_list.DataSource = Data.UserList.Instance;
            dtg_users_list.Invalidate();
            dtg_users_list.Refresh();

            clstUserList.Items.Clear();
            clstUserList.Items.AddRange(
                (from usr in Data.UserList.Instance
                 where usr.Status == Data.User.UserType.Student
                 select usr.Name).ToArray());
        }

        // The "Users" tab.
        #region Users Panel
        #region UI Events
        private void btn_users_add_Click(object sender, EventArgs e)
        {
            MainWindow.Instance.SwitchForm("createuser");
        }
        private void btn_users_edit_Click(object sender, EventArgs e)
        {
        }
        private void btn_users_del_Click(object sender, EventArgs e)
        {
            try {
                // The ToList() is needed, as else it would stay lazy and request invalidated data (from SelectRows).
                var toDel = (from DataGridViewRow name in dtg_users_list.SelectedRows select name.Cells["Name"].Value).ToList();
                var count = toDel.Count();

                // No item selected
                if (count < 1)
                    return;

                var msg = string.Format("Are you sure you want to delete {0} ?",
                    (count > 1) ? (string.Format("{0} users", count))
                    : (string.Format("user '{0}'", toDel.First())));

                if (Helpers.AskQuestion(msg) == DialogResult.Yes)
                    foreach (string u in toDel)
                        Data.UserList.Instance.RemoveByName(u);
            } catch (Exception ex) {
                // If anything goes wrong, we catch it and log it.
                // But it isn't much of a problem.
                Console.WriteLine(ex.Message);
                throw;
            }
        }
        private void btn_logout_Click(object sender, EventArgs e)
        {
            Decline();
        }
        #endregion
        #endregion

        // The "Problems" tab.
        #region Problems
        #endregion

        // The "Reports" tab.
        #region Reports
        // Refactor, at least the names
        #region UI Events
        //Addition button
        private void optAddition_CheckedChanged(object sender, EventArgs e)
        {
            rdo_positive.Checked = true;
            rdo_negative.Enabled = false;

            probSetId = determineProblemSet(dudNumRange.Text);
            nudNumOfProb.Maximum = maxProblemsInSet(probSetId);
        }
        //Subtraction
        private void optSubtraction_CheckedChanged(object sender, EventArgs e)
        {
            rdo_negative.Enabled = true;
            probSetId = determineProblemSet(dudNumRange.Text);
            nudNumOfProb.Maximum = maxProblemsInSet(probSetId);
        }
        //Positive Only
        private void optPositive_CheckedChanged(object sender, EventArgs e)
        {
            probSetId = determineProblemSet(dudNumRange.Text);
            nudNumOfProb.Maximum = maxProblemsInSet(probSetId);
        }
        //Positive or Negative
        private void optNegative_CheckedChanged(object sender, EventArgs e)
        {
            probSetId = determineProblemSet(dudNumRange.Text);
            nudNumOfProb.Maximum = maxProblemsInSet(probSetId);
        }
        //Clicking in the datagridview to genereate indepth report and unselect all other selected students
        private void dgvSummary_CellClick(object sender, DataGridViewCellEventArgs e)
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

                foreach (var s in Data.UserList.Instance) {
                    if (clstUserList.CheckedItems.Contains(s.Name)) {
                        //make only that student display in the dgv
                        dgvSummary.Rows.Clear();
                        dgvSummary.Rows.Add(value);

                        List<int> factors = new List<int>();
                        List<int> problemSet = new List<int>();
                        summary = Data.XmlBackend.readGameStats(s);
                        foreach (gameResults gr in summary) {
                            problemSet = Data.XmlBackend.selectProblemSet(gr.problemSetId);
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

            foreach (var s in Data.UserList.Instance) {
                if (clstUserList.CheckedItems.Contains(s.Name)) {
                    correct = 0;
                    total = 0;

                    summary = Data.XmlBackend.readGameStats(s);
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
                        dgvSummary.Rows.Add(s.Name.ToString(), average.ToString() + "%");
                    } else {
                        dgvSummary.Rows.Add(s.Name.ToString(), "No results to display");
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
                Game newGame = new Game(probSetId, problemSetIndex, rdo_positive.Checked,
                    rdo_addition.Checked, Int32.Parse(nudNumOfProb.Text));
                string updatedUsers = "";

                foreach (var s in Data.UserList.Instance) {
                    if (clstUserList.CheckedItems.Contains(s.Name)) {
                        updatedUsers += s.Name + Environment.NewLine;
                        Data.XmlBackend.saveGameStuff(probSetId, problemSetIndex, rdo_positive.Checked, rdo_addition.Checked,
                            Int32.Parse(nudNumOfProb.Text), s);
                    }
                }

                if (updatedUsers.Length > 0) {
                    MessageBox.Show("Users updated: " + Environment.NewLine + updatedUsers);
                }
            } catch (Exception ex) {
                Helpers.DisplayError(ex.Message);
            }
            //Helpers.DisplayInfo("Tests updated");
        }
        #endregion
        #endregion

        #region Refactor ?
        int probSetId = 0;
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
                    if (rdo_addition.Checked) {
                        return (0);
                    }
                        //subtraction
                    else {
                        //positive only
                        if (rdo_positive.Checked) {
                            return (1);
                        }
                            //negative and positive
                        else {
                            return (2);
                        }
                    }
                case "100":
                    //addition
                    if (rdo_addition.Checked) {
                        return (3);
                    }
                        //subtraction
                    else {
                        //positive only
                        if (rdo_positive.Checked) {
                            return (4);
                        }
                            //negative and positive
                        else {
                            return (5);
                        }
                    }
                case "1,000":
                    //addition
                    if (rdo_addition.Checked) {
                        return (6);
                    }
                        //subtraction
                    else {
                        //positive only
                        if (rdo_positive.Checked) {
                            return (7);
                        }
                            //negative and positive
                        else {
                            return (8);
                        }
                    }
                case "10,000":
                    //addition
                    if (rdo_addition.Checked) {
                        return (9);
                    }
                        //subtraction
                    else {
                        //positive only
                        if (rdo_positive.Checked) {
                            return (10);
                        }
                            //negative and positive
                        else {
                            return (11);
                        }
                    }
                case "100,000":
                    //addition
                    if (rdo_addition.Checked) {
                        return (12);
                    }
                        //subtraction
                    else {
                        //positive only
                        if (rdo_positive.Checked) {
                            return (13);
                        }
                            //negative and positive
                        else {
                            return (14);
                        }
                    }
                case "Any Number":
                    //addition
                    if (rdo_addition.Checked) {
                        return (15);
                    }
                        //subtraction
                    else {
                        //positive only
                        if (rdo_positive.Checked) {
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
        #endregion
    }
}