using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ADSQuizMachine
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public void ResetQuiz()
        {
            // Reset the global variables
            GlobalVariables.CurrentQuestion = 0;
            GlobalVariables.CorrectAnswers = 0;
            GlobalVariables.AskedQuestions.Clear();

            // Dispose of the controls in the panel
            foreach (Control control in MainPanel.Controls)
            {
                control.Dispose();
            }
            MainPanel.Controls.Clear();

            // Reset the main menu
            MainMenuControl mainMenu = new MainMenuControl(this);
            MainPanel.Controls.Add(mainMenu);

            // Focus on the start button
            mainMenu.StartButton.Focus();
        }

        public void StartQuiz()
        {
            // Logic is the same as NextQuestion, but we need to reset the global variables first
            // Reset the global variables
            GlobalVariables.CurrentQuestion = 0;
            GlobalVariables.CorrectAnswers = 0;
            GlobalVariables.AskedQuestions.Clear();
            NextQuestion();
        }

        public void NextQuestion()
        {
            // Dispose of the controls in the panel
            foreach (Control control in MainPanel.Controls)
            {
                control.Dispose();
            }
            MainPanel.Controls.Clear();

            // If it's the last question go to the results screen
            if (GlobalVariables.CurrentQuestion == GlobalVariables.TotalQuestions)
            {
                // Temporary implementation to show the results
                MessageBox.Show($"You answered {GlobalVariables.CorrectAnswers} out of {GlobalVariables.TotalQuestions} questions correctly!", "Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetQuiz();
                // TODO: Implement the ResultsControl
                //ResultsControl resultsControl = new ResultsControl(this);
                //MainPanel.Controls.Add(resultsControl);

                return;
            }

            // Load the next question
            TrueFalseQuestionControl questionControl = new TrueFalseQuestionControl(this);
            MainPanel.Controls.Add(questionControl);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ResetQuiz();
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            // If the control is a TrueFalseQuestionControl, handle the key press of "t" or "f"
            if (MainPanel.Controls.Count > 0 && MainPanel.Controls[0] is TrueFalseQuestionControl)
            {
                TrueFalseQuestionControl questionControl = (TrueFalseQuestionControl)MainPanel.Controls[0];
                if (e.KeyCode == Keys.T)
                {
                    questionControl.AnswerTrue();
                }
                else if (e.KeyCode == Keys.F)
                {
                    questionControl.AnswerFalse();
                }
            }
        }
    }
}
