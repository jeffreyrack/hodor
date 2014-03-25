﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CSUSM.CS441.SheriffHodor.GUI
{
    /// <summary>
    /// The game screen: this is the screen students see when they are taking a test.
    /// It receive an already populated User as input, and mutate it to pass it to
    /// the next GameScreen (or GameErrorScreen, or GameEndScreen).
    /// </summary>
    public partial class GameScreen : StateControl
    {

        public GameScreen()
        {
            InitializeComponent();
            this.txt_answer.KeyPress += new KeyPressEventHandler(answerValidator);
        }

        /*
         * Matthias Lang    - 3/17/2014 - Initial Version
         * Corey Paxton     - 3/17/2014 - Beginning of making it work with refactor
         * Corey Paxton     - 3/20/2014 - Setup new problem generator
         * Corey Paxton     - 3/24/2014 - Made it so the text field is active
         */
        public override void Entered(StateControl from, Data.User user)
        {
            base.Entered(from, user);

            // TODO this isnt working the first time it enters the screen unless you click the screen
            // Make the text field active
            this.ActiveControl = txt_answer;


            txt_answer.Text = String.Empty;
            
            //display the counter
            lbl_index.Text = string.Format("Question: {0} / {1}", (user.Data.currentProblemIndex + 1), user.Data.totalProblems);

            //TODO structure the format of the problem as an equation or top to bottom
            //equation form
            lbl_problem.Text = this.CurrentUser.Data.currentProblem.ToString();
            //top to bottom form
        }

        #region UI
        /*
         * Matthias Lang    - 3/17/2014 - Initial Version
         * Corey Paxton     - 3/24/2014 - Made it so enter pressed button
         */
        private void answerValidator(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                btn_next_Click(sender, e);
            }
            e.Handled = !(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar));
        }
        
        /*
         * 
         * Corey Paxton     - 3/17/2014 - Initial Version
         * Corey Paxton     - 3/20/2014 - Expanding still unfinished
         */
        private void btn_next_Click(object sender, EventArgs e)
        {
            if (txt_answer.Text.Length > 0)
            {
                //finished last problem
                if (this.CurrentUser.Data.currentProblemIndex + 1 >= this.CurrentUser.Data.totalProblems)
                {
                    //display score screen
                    //TODO Implement a score screen
                    MessageBox.Show("Finished");
                    MainWindow.Instance.SwitchForm("login", this.CurrentUser);
                }
                else
                {
                    if (this.CurrentUser.Data.currentProblem.Answer() == (ushort)Int32.Parse(txt_answer.Text))
                    {
                        //Correct
                        //TODO Add to # correct
                        //TODO Display an indicator that they were right
                        MessageBox.Show("Correct");
                    }
                    else
                    {
                        //Incorrect
                        //TODO Display an indicator that they were wrong
                        //TODO Display the drawing representation of the correct answer
                        MessageBox.Show("Incorrect " + this.CurrentUser.Data.currentProblem.Answer());
                    }

                    //increment the counter
                    this.CurrentUser.Data.currentProblemIndex++;

                    //genereate a problem at the difficulty for this user
                    this.CurrentUser.Data.currentProblem = this.CurrentUser.Data.problemHandler(this.CurrentUser.Data.testDiff);

                    //reset the window
                    MainWindow.Instance.SwitchForm("game", this.CurrentUser);
                }
            }
        }
        #endregion
    }
}