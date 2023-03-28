
namespace Taschenrechner
{
    partial class FormLoanCalc
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
            this.lblLoanCalc = new System.Windows.Forms.Label();
            this.lblResultLoan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLoanCalc
            // 
            this.lblLoanCalc.AutoSize = true;
            this.lblLoanCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblLoanCalc.Location = new System.Drawing.Point(11, 9);
            this.lblLoanCalc.Name = "lblLoanCalc";
            this.lblLoanCalc.Size = new System.Drawing.Size(152, 22);
            this.lblLoanCalc.TabIndex = 0;
            this.lblLoanCalc.Text = "Kreditberechnung";
            // 
            // lblResultLoan
            // 
            this.lblResultLoan.AutoSize = true;
            this.lblResultLoan.Location = new System.Drawing.Point(12, 97);
            this.lblResultLoan.Name = "lblResultLoan";
            this.lblResultLoan.Size = new System.Drawing.Size(51, 13);
            this.lblResultLoan.TabIndex = 1;
            this.lblResultLoan.Text = "Ergebnis:";
            // 
            // FormLoanCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResultLoan);
            this.Controls.Add(this.lblLoanCalc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormLoanCalc";
            this.Text = "Taschenrechenr";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLoanCalc;
        private System.Windows.Forms.Label lblResultLoan;
    }
}