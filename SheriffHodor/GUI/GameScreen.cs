/*This just needs to be conected and display the questions from the XMLfile i sent out (if it needs to be changed plz let me know)
 * The timer works!
 * */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CSUSM.CS441.SheriffHodor.GUI
{
    public partial class GameScreen : UserControl
    {
        #region Members
        int size1;
        int size2;
        List<int> returnIndex = new List<int>();
        int somthingMay;//refference for index
        int MM = 0;//counter for the index list
        List<int> questions = new List<int>();
        bool isAddCheck;
        Data.User Stud;
        int problemSetId;
        string userName;
        int operationSet;//will determine what operation is to be used
        List<bool> answers = new List<bool>();
        string textboxAnswer;
        bool ynAnswer;
        int K = 0;//used to increment pointer of problem list and answer list
        int j = 1;
        int problemCount = 0;//this will be set to the numbers of problems for this problem set from the administrators stuff
        int currentNumOfProb = 0;//current number the user is on
        DateTime theDate;//this records the current time in which the test is taken
        int c;
        static int countDown = 0;//the number used for the clock
        Game thisGame;
        #endregion

        #region Refactor
        // Transition method
        public void GameScreen_FakeCtor(Data.User selectedUser)
        {
            //get lists of the problem set

            //set them to be problems1 and problems2
            //problems 1 is a set of the first terms, problems2 is the set of the 2nd term of each problem set
            List<string> problems1 = new List<string>();//

            List<int> questionTime = new List<int>();
            List<string> problems2 = new List<string>();//

            Stud = selectedUser;

            userName = selectedUser.Name;
            thisGame = selectedUser.nextGame;
            Game g = Data.XmlBackend.selectStudentGameInfo(selectedUser);

            problemSetId = g.getProblemSetId();

            //Game g = GS.selectStudentGameInfo(selectedUser);
            Stud.nextGame = g;

            problemCount = g.getnumOfProblems();

            isAddCheck = g.getisAddition();
            if (isAddCheck == true) {
                operationSet = 1;
            }
            //operationSet = g.

            for (int Z = 0; Z < problemCount; Z++) {
                returnIndex.Add(g.getProblemSetAtIndex(Z));

            }
            //MessageBox.Show("Welcome to Sheriff Hodor!" + problemCount);

            //List<int> questions = GS.selectProblemSet(g.getProblemSetId());
            //problems1 = GS.selectProblemSet(g.getProblemSetId());        
        }
        #endregion

        public GameScreen()
        {
            InitializeComponent();
        }

        //Next Button
        private void button1_Click(object sender, EventArgs e)
        {
            if (TryToParse(textBox1.Text) == true) {

                if (textBox1.Text != null && textBox1.Text.Length != 0) {
                    textboxAnswer = textBox1.Text;
                    ynAnswer = isAnswerCorrect(size1, size2, textboxAnswer, operationSet);

                    answers.Add(ynAnswer);
                    if (!finishGameStats())
                        return;

                    displayNewProblems();

                    //currentNumOfProb++;
                    resetTimer();
                }
            }

            textBox2.Text = "  ";
            //goToNextProblem();
            //K++;
        }

        private static bool TryToParse(string value)
        {
            int number;
            bool result = Int32.TryParse(value, out number);
            if (result) {
                return true;
            } else {
                return false;
            }
        }

        //Answer Box
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        //Question Display
        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void displayCurrentTotal()
        {
            //label2
            label2.Text = (currentNumOfProb + 1) + " / " + problemCount;
        }

        //*************************

        //WHen the page loads the timer will start and countdown to 0 
        private void GameScreen_Load(object sender, EventArgs e)
        {
            timer1.Start();//start the timer
            //label1.Text = problems1[0];//load the initial question into the label
            theDate = DateTime.Now;
            getQuestions();
        }

        private void getQuestions()
        {
            questions = Data.XmlBackend.selectProblemSet(problemSetId);
            incrementByTwo();
            displayCurrentTotal();

            size1 = questions[K];//display first object
            size2 = questions[j];//display 2nd object

            if (operationSet == 1) {
                label1.Text = size1 + " + " + size2;
            } else {
                label1.Text = size1 + " - " + size2;
            }
            //incrementByTwo();
            //display the first question here  
        }

        //this function will display the new problems anytime
        private void displayNewProblems()
        {
            incrementByTwo();
            size1 = questions[K];
            size2 = questions[j];
            if (operationSet == 1) {
                label1.Text = size1 + " + " + size2;
            } else {
                label1.Text = size1 + " - " + size2;
            }
            displayCurrentTotal();
        }

        private void incrementByTwo()
        {
            somthingMay = returnIndex[MM];
            somthingMay = somthingMay * 2;
            K = somthingMay;
            j = somthingMay + 1;
            // K = K + 2;
            // j = j + 2;
            MM++;
        }

        //*****************


        //Timer, it actually works
        private void timer1_Tick(object sender, EventArgs e)
        {

            if (countDown < 100) {
                // Display the new time left 
                // by updating the Time Left label.
                countDown = countDown + 1;
                textBox2.Text = countDown + " seconds";
            } else {
                // If the user ran out of time, stop the timer and go to the next question 
                resetTimer();

                textBox2.Text = countDown + " seconds";
                //go to next question
                //goToNextProblem();
            }

        }

        //Textbox for displaying the current timer
        //nothing really needs to be done in this box
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        //this functionwill set the new problems with the timer expires or when the user clicks the next button
        private bool finishGameStats()
        {
            currentNumOfProb++;
            if (currentNumOfProb == problemCount) {
                //call functiont hat saves the list of answers from the user's game to the XML 

                Data.XmlBackend.saveGameStats(answers, returnIndex, Stud);
                timer1.Stop();
                //need a close form thing
                MainWindow.Instance.SwitchForm("login");
                return false;
            }
            return true;
        }

        //resets the timer to 0 when this function is called
        private void resetTimer()
        {
            //questionTime[K] = countDown;//save the time for each user
            //currentNumOfProb++;
            countDown = 0;
            textBox2.Text = "  ";
            textBox1.Text = "";
        }

        //this closes the form
        private void closeButton_Click(object sender, EventArgs e)
        {
            MainWindow.Instance.SwitchForm("login");
        }


        //check if an answer is right, will return true if the answer is correct
        private bool isAnswerCorrect(int a, int b, string textboxAnswer, int operation)
        {

            c = Convert.ToInt32(textboxAnswer);

            //for each operation type
            switch (operation) {
                case 1:
                    a = a + b;
                    break;
                case 2:
                    a = a - b;
                    break;

                default:
                    break;
            }

            if (a == c) {
                return true;
            } else {
                return false;
            }

        }

        //Question # / Total Questions
        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}