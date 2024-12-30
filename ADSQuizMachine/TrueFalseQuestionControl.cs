using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ADSQuizMachine
{
    public partial class TrueFalseQuestionControl : UserControl
    {
        string currentQuestionFolder;
        MainForm mainForm;

        public TrueFalseQuestionControl(MainForm main)
        {
            mainForm = main;
            this.Dock = DockStyle.Fill;
            InitializeComponent();
            LoadRandomQuestion();
            QuestionNumberLabel.Text = $"Question {GlobalVariables.CurrentQuestion + 1} of {GlobalVariables.TotalQuestions}\r\nScore: {GlobalVariables.CorrectAnswers}/{GlobalVariables.TotalQuestions}";
            // If it's the last question, change the text of the Next button to "Finish"
            if (GlobalVariables.CurrentQuestion == GlobalVariables.TotalQuestions - 1)
            {
                NextButton.Text = "Finish";
            }
        }

        public static List<string> GetRandomQuestionFolders(string baseDirectory)
        {
            // Console.WriteLine(baseDirectory);
            // Get all subdirectories in the base directory
            string[] directories = Directory.GetDirectories(baseDirectory);

            // Console.WriteLine($"Directories: {string.Join(", ", directories)}");

            // Filter the directories that start with "tfq"
            var tfqFolders = directories.Where(d => Path.GetFileName(d).StartsWith("tfq", StringComparison.OrdinalIgnoreCase)).ToList();

            // Check if we found any matching folders
            if (tfqFolders.Count == 0)
            {
                throw new InvalidOperationException("No folders found that start with 'tfq'.");
            }

            return tfqFolders;
        }

        private void LoadRandomQuestion()
        {
            try
            {
                // Get the base directory of the current application domain
                string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

                // Combine the base directory with the relative path to the questions folder
                string questionsPath = Path.Combine(baseDirectory, "questions");
                List<string> tfqFolders = GetRandomQuestionFolders(questionsPath);
                Random random = new Random();

                // MessageBox.Show("tfqFolders: " + string.Join(", ", tfqFolders), "tfqFolders", MessageBoxButtons.OK, MessageBoxIcon.Information);
                while (tfqFolders.Count > 0)
                {
                    // Select a random folder from the list
                    int index = random.Next(tfqFolders.Count);
                    currentQuestionFolder = tfqFolders[index];
                    string indexPath = Path.Combine(currentQuestionFolder, "index.html");

                    if (File.Exists(indexPath))
                    {
                        QuestionWebBrowser.Navigate(new Uri(indexPath));
                        return;
                    }
                    else
                    {
                        // Remove the folder from the list and try again
                        tfqFolders.RemoveAt(index);
                    }
                }

                // If no valid index.html was found
                MessageBox.Show("No valid index.html file found in any of the tfq folders.", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading the question: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void QuestionWebBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            int OLECMDID_OPTICAL_ZOOM = 63;
            int OLECMDEXECOPT_DONTPROMPTUSER = 2;
            dynamic iwb2 = QuestionWebBrowser.ActiveXInstance;
            object zoom = 150; //The value should be between 10 , 1000
            iwb2.ExecWB(OLECMDID_OPTICAL_ZOOM, OLECMDEXECOPT_DONTPROMPTUSER, zoom, zoom);
            QuestionWebBrowser.Focus();
            // Scroll to (0, 0) to ensure the top of the page is visible
            QuestionWebBrowser.Document.Window.ScrollTo(0, 0);
            // Focus the True button
            TrueButton.Focus();
        }

        private bool CheckTrueFalse()
        {
            // Open the file answer.txt in the current question folder
            // 0 = False, 1 = True
            string answerPath = Path.Combine(currentQuestionFolder, "answer.txt");
            // Check if the file exists
            if (File.Exists(answerPath))
            {
                // Read the first line of the file
                string answer = File.ReadLines(answerPath).FirstOrDefault();
                // Check if the answer is "1" (True)
                if (answer == "1")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            // Throw an exception if the file does not exist
            throw new FileNotFoundException("The answer.txt file was not found.");
        }

        private void SetResultLabel(bool correctAnswer)
        {
            // Hide the True and False buttons
            TrueButton.Visible = false;
            FalseButton.Visible = false;

            // Set the text of the ResultLabel based on the correctAnswer
            if (correctAnswer)
            {
                ResultLabel.Text = "Correct!";
            }
            else
            {
                ResultLabel.Text = "Incorrect! The correct answer is " + (CheckTrueFalse() ? "True" : "False");
            }
            ResultLabel.Show();

            // Set the background colour of the control based on the correctAnswer
            if (correctAnswer)
            {
                this.BackColor = Color.LightGreen;
            }
            else
            {
                this.BackColor = Color.LightCoral;
            }

            // Show the Next button
            NextButton.Visible = true;
            NextButton.Focus();
        }

        private void TrueButton_Click(object sender, EventArgs e)
        {
            bool correctAnswer = CheckTrueFalse();
            if (correctAnswer)
            {
                GlobalVariables.CorrectAnswers++;
                SetResultLabel(true);
                QuestionNumberLabel.Text = $"Question {GlobalVariables.CurrentQuestion + 1} of {GlobalVariables.TotalQuestions}\r\nScore: {GlobalVariables.CorrectAnswers}/{GlobalVariables.TotalQuestions}";
            }
            else
            {
                SetResultLabel(false);
            }
        }

        private void FalseButton_Click(object sender, EventArgs e)
        {
            bool correctAnswer = CheckTrueFalse();
            if (!correctAnswer)
            {
                GlobalVariables.CorrectAnswers++;
                SetResultLabel(true);
                QuestionNumberLabel.Text = $"Question {GlobalVariables.CurrentQuestion + 1} of {GlobalVariables.TotalQuestions}\r\nScore: {GlobalVariables.CorrectAnswers}/{GlobalVariables.TotalQuestions}";
            }
            else
            {
                SetResultLabel(false);
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            // Increment the current question number
            GlobalVariables.CurrentQuestion++;
            mainForm.NextQuestion();
        }

        public void AnswerTrue()
        {
            TrueButton.PerformClick();
        }

        public void AnswerFalse()
        {
            FalseButton.PerformClick();
        }
    }
}
