namespace ClickPerSecond
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cpslabel = new System.Windows.Forms.Label();
            this.timelabel = new System.Windows.Forms.Label();
            this.clicklabel = new System.Windows.Forms.Label();
            this.runTimer = new System.Windows.Forms.Timer(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.clickTimer = new System.Windows.Forms.Timer(this.components);
            this.measureDeltaTimer = new System.Windows.Forms.Timer(this.components);
            this.deltaCPSLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.button1.Location = new System.Drawing.Point(363, 452);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Quit Program";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 35F);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.Location = new System.Drawing.Point(71, 142);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(346, 286);
            this.button2.TabIndex = 1;
            this.button2.Text = "Click Me!";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cpslabel
            // 
            this.cpslabel.AutoSize = true;
            this.cpslabel.BackColor = System.Drawing.Color.LightGreen;
            this.cpslabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cpslabel.Font = new System.Drawing.Font("Times New Roman", 25F);
            this.cpslabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cpslabel.Location = new System.Drawing.Point(96, 98);
            this.cpslabel.Name = "cpslabel";
            this.cpslabel.Size = new System.Drawing.Size(80, 41);
            this.cpslabel.TabIndex = 2;
            this.cpslabel.Text = "CPS";
            this.cpslabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // timelabel
            // 
            this.timelabel.AutoSize = true;
            this.timelabel.BackColor = System.Drawing.Color.LightGreen;
            this.timelabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timelabel.Font = new System.Drawing.Font("Times New Roman", 25F);
            this.timelabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.timelabel.Location = new System.Drawing.Point(8, 39);
            this.timelabel.Name = "timelabel";
            this.timelabel.Size = new System.Drawing.Size(89, 41);
            this.timelabel.TabIndex = 4;
            this.timelabel.Text = "Time";
            // 
            // clicklabel
            // 
            this.clicklabel.AutoSize = true;
            this.clicklabel.BackColor = System.Drawing.Color.LightGreen;
            this.clicklabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clicklabel.Font = new System.Drawing.Font("Times New Roman", 25F);
            this.clicklabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.clicklabel.Location = new System.Drawing.Point(176, 39);
            this.clicklabel.Name = "clicklabel";
            this.clicklabel.Size = new System.Drawing.Size(105, 41);
            this.clicklabel.TabIndex = 5;
            this.clicklabel.Text = "Clicks";
            // 
            // runTimer
            // 
            this.runTimer.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.button3.Location = new System.Drawing.Point(12, 452);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(76, 33);
            this.button3.TabIndex = 7;
            this.button3.Text = "Restart";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // clickTimer
            // 
            this.clickTimer.Tick += new System.EventHandler(this.clickTimer_Tick);
            // 
            // measureDeltaTimer
            // 
            this.measureDeltaTimer.Tick += new System.EventHandler(this.measureDeltaTimer_Tick);
            // 
            // deltaCPSLabel
            // 
            this.deltaCPSLabel.AutoSize = true;
            this.deltaCPSLabel.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.deltaCPSLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.deltaCPSLabel.Font = new System.Drawing.Font("Times New Roman", 35.75F);
            this.deltaCPSLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.deltaCPSLabel.Location = new System.Drawing.Point(332, 66);
            this.deltaCPSLabel.Name = "deltaCPSLabel";
            this.deltaCPSLabel.Size = new System.Drawing.Size(112, 57);
            this.deltaCPSLabel.TabIndex = 8;
            this.deltaCPSLabel.Text = "CPS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(113, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "CPS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(197, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "Clicks";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(304, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 23);
            this.label4.TabIndex = 12;
            this.label4.Text = "Clicks Per Seconds";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deltaCPSLabel);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.clicklabel);
            this.Controls.Add(this.timelabel);
            this.Controls.Add(this.cpslabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clicks Per Second Tester";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label cpslabel;
        private System.Windows.Forms.Label timelabel;
        private System.Windows.Forms.Label clicklabel;
        private System.Windows.Forms.Timer runTimer;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Timer clickTimer;
        private System.Windows.Forms.Timer measureDeltaTimer;
        private System.Windows.Forms.Label deltaCPSLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

