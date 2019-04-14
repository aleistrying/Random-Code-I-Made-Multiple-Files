namespace TrasnformxlAppToPDF
{
    partial class XlToPDFForm
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
            this.SelectAFileButton = new System.Windows.Forms.Button();
            this.TransformToPDFButton = new System.Windows.Forms.Button();
            this.UbicationTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SelectAFileButton
            // 
            this.SelectAFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.SelectAFileButton.Location = new System.Drawing.Point(191, 108);
            this.SelectAFileButton.Name = "SelectAFileButton";
            this.SelectAFileButton.Size = new System.Drawing.Size(99, 65);
            this.SelectAFileButton.TabIndex = 0;
            this.SelectAFileButton.Text = "Select a File";
            this.SelectAFileButton.UseVisualStyleBackColor = true;
            this.SelectAFileButton.Click += new System.EventHandler(this.SelectAFileButton_Click);
            // 
            // TransformToPDFButton
            // 
            this.TransformToPDFButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.TransformToPDFButton.Location = new System.Drawing.Point(165, 261);
            this.TransformToPDFButton.Name = "TransformToPDFButton";
            this.TransformToPDFButton.Size = new System.Drawing.Size(157, 73);
            this.TransformToPDFButton.TabIndex = 1;
            this.TransformToPDFButton.Text = "Transform from Excel to PDF";
            this.TransformToPDFButton.UseVisualStyleBackColor = true;
            this.TransformToPDFButton.Click += new System.EventHandler(this.TransformToPDFButton_Click);
            // 
            // UbicationTextBox
            // 
            this.UbicationTextBox.Location = new System.Drawing.Point(190, 205);
            this.UbicationTextBox.Name = "UbicationTextBox";
            this.UbicationTextBox.Size = new System.Drawing.Size(100, 20);
            this.UbicationTextBox.TabIndex = 2;
            // 
            // XlToPDFForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.UbicationTextBox);
            this.Controls.Add(this.TransformToPDFButton);
            this.Controls.Add(this.SelectAFileButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "XlToPDFForm";
            this.Text = "Excel to PDF";
            this.Load += new System.EventHandler(this.XlToPDFForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SelectAFileButton;
        private System.Windows.Forms.Button TransformToPDFButton;
        private System.Windows.Forms.TextBox UbicationTextBox;
    }
}

