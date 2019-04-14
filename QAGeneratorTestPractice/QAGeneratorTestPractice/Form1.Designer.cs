namespace QAGeneratorTestPractice
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.continueButton = new System.Windows.Forms.Button();
            this.answerTextBox = new System.Windows.Forms.TextBox();
            this.questionLabel = new System.Windows.Forms.Label();
            this.timerAnswerCheck = new System.Windows.Forms.Timer(this.components);
            this.cooldownTimer = new System.Windows.Forms.Timer(this.components);
            this.invertirButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // continueButton
            // 
            this.continueButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.continueButton.Location = new System.Drawing.Point(192, 333);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(105, 36);
            this.continueButton.TabIndex = 0;
            this.continueButton.Text = "No se";
            this.continueButton.UseVisualStyleBackColor = true;
            this.continueButton.Click += new System.EventHandler(this.continueButton_Click);
            // 
            // answerTextBox
            // 
            this.answerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.answerTextBox.Location = new System.Drawing.Point(337, 208);
            this.answerTextBox.Name = "answerTextBox";
            this.answerTextBox.Size = new System.Drawing.Size(100, 29);
            this.answerTextBox.TabIndex = 1;
            this.answerTextBox.TextChanged += new System.EventHandler(this.answerTextBox_TextChanged);
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.questionLabel.Location = new System.Drawing.Point(129, 80);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(97, 24);
            this.questionLabel.TabIndex = 2;
            this.questionLabel.Text = "Start Test?";
            // 
            // timerAnswerCheck
            // 
            this.timerAnswerCheck.Tick += new System.EventHandler(this.timerAnswerCheck_Tick);
            // 
            // cooldownTimer
            // 
            this.cooldownTimer.Tick += new System.EventHandler(this.cooldownTimer_Tick);
            // 
            // invertirButton
            // 
            this.invertirButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.invertirButton.Location = new System.Drawing.Point(499, 333);
            this.invertirButton.Name = "invertirButton";
            this.invertirButton.Size = new System.Drawing.Size(105, 36);
            this.invertirButton.TabIndex = 3;
            this.invertirButton.Text = "Invertir";
            this.invertirButton.UseVisualStyleBackColor = true;
            this.invertirButton.Click += new System.EventHandler(this.invertirButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.invertirButton);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.answerTextBox);
            this.Controls.Add(this.continueButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button continueButton;
        private System.Windows.Forms.TextBox answerTextBox;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Timer timerAnswerCheck;
        private System.Windows.Forms.Timer cooldownTimer;
        private System.Windows.Forms.Button invertirButton;
    }
}

