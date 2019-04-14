namespace MySqlWindowsFormTest
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
            this.Unidades = new System.Windows.Forms.TextBox();
            this.CostoUnitario = new System.Windows.Forms.TextBox();
            this.CostoUnitarioCreado = new System.Windows.Forms.TextBox();
            this.LaminadosCombox = new System.Windows.Forms.ComboBox();
            this.GrosCombox = new System.Windows.Forms.ComboBox();
            this.CostoCombox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Unidades
            // 
            this.Unidades.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Unidades.Location = new System.Drawing.Point(173, 261);
            this.Unidades.Name = "Unidades";
            this.Unidades.Size = new System.Drawing.Size(100, 32);
            this.Unidades.TabIndex = 3;
            // 
            // CostoUnitario
            // 
            this.CostoUnitario.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CostoUnitario.Location = new System.Drawing.Point(173, 318);
            this.CostoUnitario.Name = "CostoUnitario";
            this.CostoUnitario.Size = new System.Drawing.Size(100, 32);
            this.CostoUnitario.TabIndex = 4;
            // 
            // CostoUnitarioCreado
            // 
            this.CostoUnitarioCreado.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CostoUnitarioCreado.Location = new System.Drawing.Point(477, 237);
            this.CostoUnitarioCreado.Name = "CostoUnitarioCreado";
            this.CostoUnitarioCreado.Size = new System.Drawing.Size(296, 32);
            this.CostoUnitarioCreado.TabIndex = 5;
            // 
            // LaminadosCombox
            // 
            this.LaminadosCombox.FormattingEnabled = true;
            this.LaminadosCombox.Location = new System.Drawing.Point(173, 43);
            this.LaminadosCombox.Name = "LaminadosCombox";
            this.LaminadosCombox.Size = new System.Drawing.Size(121, 21);
            this.LaminadosCombox.TabIndex = 6;
            this.LaminadosCombox.SelectedIndexChanged += new System.EventHandler(this.LaminadosCombox_SelectedIndexChanged);
            // 
            // GrosCombox
            // 
            this.GrosCombox.FormattingEnabled = true;
            this.GrosCombox.Location = new System.Drawing.Point(173, 116);
            this.GrosCombox.Name = "GrosCombox";
            this.GrosCombox.Size = new System.Drawing.Size(121, 21);
            this.GrosCombox.TabIndex = 7;
            // 
            // CostoCombox
            // 
            this.CostoCombox.FormattingEnabled = true;
            this.CostoCombox.Location = new System.Drawing.Point(152, 181);
            this.CostoCombox.Name = "CostoCombox";
            this.CostoCombox.Size = new System.Drawing.Size(121, 21);
            this.CostoCombox.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CostoCombox);
            this.Controls.Add(this.GrosCombox);
            this.Controls.Add(this.LaminadosCombox);
            this.Controls.Add(this.CostoUnitarioCreado);
            this.Controls.Add(this.CostoUnitario);
            this.Controls.Add(this.Unidades);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Unidades;
        private System.Windows.Forms.TextBox CostoUnitario;
        private System.Windows.Forms.TextBox CostoUnitarioCreado;
        private System.Windows.Forms.ComboBox LaminadosCombox;
        private System.Windows.Forms.ComboBox GrosCombox;
        private System.Windows.Forms.ComboBox CostoCombox;
    }
}

