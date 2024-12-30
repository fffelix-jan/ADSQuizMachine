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
    public partial class MainMenuControl : UserControl
    {
        MainForm mainForm;

        public MainMenuControl(MainForm main)
        {
            mainForm = main;
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            mainForm.StartQuiz();
        }
    }
}
