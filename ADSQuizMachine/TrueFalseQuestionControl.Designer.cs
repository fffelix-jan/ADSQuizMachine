namespace ADSQuizMachine
{
    partial class TrueFalseQuestionControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.QuestionNumberLabel = new System.Windows.Forms.Label();
            this.QuestionWebBrowser = new System.Windows.Forms.WebBrowser();
            this.TrueButton = new System.Windows.Forms.Button();
            this.FalseButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(297, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "True or False?";
            // 
            // QuestionNumberLabel
            // 
            this.QuestionNumberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.QuestionNumberLabel.AutoSize = true;
            this.QuestionNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionNumberLabel.Location = new System.Drawing.Point(643, 17);
            this.QuestionNumberLabel.Name = "QuestionNumberLabel";
            this.QuestionNumberLabel.Size = new System.Drawing.Size(121, 40);
            this.QuestionNumberLabel.TabIndex = 1;
            this.QuestionNumberLabel.Text = "Question X of Y\r\nScore: A/B";
            this.QuestionNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // QuestionWebBrowser
            // 
            this.QuestionWebBrowser.AllowNavigation = false;
            this.QuestionWebBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QuestionWebBrowser.IsWebBrowserContextMenuEnabled = false;
            this.QuestionWebBrowser.Location = new System.Drawing.Point(18, 60);
            this.QuestionWebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.QuestionWebBrowser.Name = "QuestionWebBrowser";
            this.QuestionWebBrowser.Size = new System.Drawing.Size(765, 304);
            this.QuestionWebBrowser.TabIndex = 2;
            this.QuestionWebBrowser.WebBrowserShortcutsEnabled = false;
            this.QuestionWebBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.QuestionWebBrowser_DocumentCompleted);
            // 
            // TrueButton
            // 
            this.TrueButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.TrueButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrueButton.Location = new System.Drawing.Point(231, 379);
            this.TrueButton.Name = "TrueButton";
            this.TrueButton.Size = new System.Drawing.Size(117, 53);
            this.TrueButton.TabIndex = 3;
            this.TrueButton.Text = "True";
            this.TrueButton.UseVisualStyleBackColor = true;
            this.TrueButton.Click += new System.EventHandler(this.TrueButton_Click);
            // 
            // FalseButton
            // 
            this.FalseButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.FalseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FalseButton.Location = new System.Drawing.Point(445, 379);
            this.FalseButton.Name = "FalseButton";
            this.FalseButton.Size = new System.Drawing.Size(117, 53);
            this.FalseButton.TabIndex = 4;
            this.FalseButton.Text = "False";
            this.FalseButton.UseVisualStyleBackColor = true;
            this.FalseButton.Click += new System.EventHandler(this.FalseButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextButton.Location = new System.Drawing.Point(666, 379);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(117, 53);
            this.NextButton.TabIndex = 5;
            this.NextButton.Text = "Next >>";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Visible = false;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // ResultLabel
            // 
            this.ResultLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultLabel.Location = new System.Drawing.Point(14, 395);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(73, 25);
            this.ResultLabel.TabIndex = 6;
            this.ResultLabel.Text = "Result";
            this.ResultLabel.Visible = false;
            // 
            // TrueFalseQuestionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.FalseButton);
            this.Controls.Add(this.TrueButton);
            this.Controls.Add(this.QuestionWebBrowser);
            this.Controls.Add(this.QuestionNumberLabel);
            this.Controls.Add(this.label1);
            this.Name = "TrueFalseQuestionControl";
            this.Size = new System.Drawing.Size(800, 450);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label QuestionNumberLabel;
        private System.Windows.Forms.WebBrowser QuestionWebBrowser;
        private System.Windows.Forms.Button TrueButton;
        private System.Windows.Forms.Button FalseButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Label ResultLabel;
    }
}
