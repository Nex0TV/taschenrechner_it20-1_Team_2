
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
            this.tBoxLoan = new System.Windows.Forms.TextBox();
            this.chkBoxOneTimePayment = new System.Windows.Forms.CheckBox();
            this.tBoxRunTime = new System.Windows.Forms.TextBox();
            this.tBoxLoanRate = new System.Windows.Forms.TextBox();
            this.lblLoan = new System.Windows.Forms.Label();
            this.lblLoanRuntime = new System.Windows.Forms.Label();
            this.lblLoanRate = new System.Windows.Forms.Label();
            this.btnCloseBasicCalc = new System.Windows.Forms.Button();
            this.btnChooseModules = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLoanCalc
            // 
            this.lblLoanCalc.AutoSize = true;
            this.lblLoanCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblLoanCalc.Location = new System.Drawing.Point(85, 9);
            this.lblLoanCalc.Name = "lblLoanCalc";
            this.lblLoanCalc.Size = new System.Drawing.Size(152, 22);
            this.lblLoanCalc.TabIndex = 0;
            this.lblLoanCalc.Text = "Kreditberechnung";
            // 
            // lblResultLoan
            // 
            this.lblResultLoan.AutoSize = true;
            this.lblResultLoan.Location = new System.Drawing.Point(9, 76);
            this.lblResultLoan.Name = "lblResultLoan";
            this.lblResultLoan.Size = new System.Drawing.Size(51, 13);
            this.lblResultLoan.TabIndex = 1;
            this.lblResultLoan.Text = "Ergebnis:";
            // 
            // tBoxLoan
            // 
            this.tBoxLoan.Location = new System.Drawing.Point(12, 214);
            this.tBoxLoan.Name = "tBoxLoan";
            this.tBoxLoan.Size = new System.Drawing.Size(147, 20);
            this.tBoxLoan.TabIndex = 2;
            // 
            // chkBoxOneTimePayment
            // 
            this.chkBoxOneTimePayment.AutoSize = true;
            this.chkBoxOneTimePayment.Location = new System.Drawing.Point(13, 273);
            this.chkBoxOneTimePayment.Name = "chkBoxOneTimePayment";
            this.chkBoxOneTimePayment.Size = new System.Drawing.Size(94, 17);
            this.chkBoxOneTimePayment.TabIndex = 3;
            this.chkBoxOneTimePayment.Text = "Einmalzahlung";
            this.chkBoxOneTimePayment.UseVisualStyleBackColor = true;
            // 
            // tBoxRunTime
            // 
            this.tBoxRunTime.Location = new System.Drawing.Point(165, 214);
            this.tBoxRunTime.Name = "tBoxRunTime";
            this.tBoxRunTime.Size = new System.Drawing.Size(138, 20);
            this.tBoxRunTime.TabIndex = 4;
            // 
            // tBoxLoanRate
            // 
            this.tBoxLoanRate.Location = new System.Drawing.Point(165, 271);
            this.tBoxLoanRate.Name = "tBoxLoanRate";
            this.tBoxLoanRate.Size = new System.Drawing.Size(137, 20);
            this.tBoxLoanRate.TabIndex = 5;
            // 
            // lblLoan
            // 
            this.lblLoan.AutoSize = true;
            this.lblLoan.Location = new System.Drawing.Point(10, 193);
            this.lblLoan.Name = "lblLoan";
            this.lblLoan.Size = new System.Drawing.Size(62, 13);
            this.lblLoan.TabIndex = 6;
            this.lblLoan.Text = "Ratenkredit";
            // 
            // lblLoanRuntime
            // 
            this.lblLoanRuntime.AutoSize = true;
            this.lblLoanRuntime.Location = new System.Drawing.Point(162, 193);
            this.lblLoanRuntime.Name = "lblLoanRuntime";
            this.lblLoanRuntime.Size = new System.Drawing.Size(44, 13);
            this.lblLoanRuntime.TabIndex = 7;
            this.lblLoanRuntime.Text = "Laufzeit";
            // 
            // lblLoanRate
            // 
            this.lblLoanRate.AutoSize = true;
            this.lblLoanRate.Location = new System.Drawing.Point(162, 255);
            this.lblLoanRate.Name = "lblLoanRate";
            this.lblLoanRate.Size = new System.Drawing.Size(60, 13);
            this.lblLoanRate.TabIndex = 8;
            this.lblLoanRate.Text = "Ratenhöhe";
            // 
            // btnCloseBasicCalc
            // 
            this.btnCloseBasicCalc.Location = new System.Drawing.Point(165, 402);
            this.btnCloseBasicCalc.Name = "btnCloseBasicCalc";
            this.btnCloseBasicCalc.Size = new System.Drawing.Size(138, 36);
            this.btnCloseBasicCalc.TabIndex = 26;
            this.btnCloseBasicCalc.Text = "Grundrechner schließen";
            this.btnCloseBasicCalc.UseVisualStyleBackColor = true;
            // 
            // btnChooseModules
            // 
            this.btnChooseModules.Location = new System.Drawing.Point(13, 402);
            this.btnChooseModules.Name = "btnChooseModules";
            this.btnChooseModules.Size = new System.Drawing.Size(146, 36);
            this.btnChooseModules.TabIndex = 25;
            this.btnChooseModules.Text = "Rechenmodul auswählen";
            this.btnChooseModules.UseVisualStyleBackColor = true;
            // 
            // FormLoanCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 450);
            this.Controls.Add(this.btnCloseBasicCalc);
            this.Controls.Add(this.btnChooseModules);
            this.Controls.Add(this.lblLoanRate);
            this.Controls.Add(this.lblLoanRuntime);
            this.Controls.Add(this.lblLoan);
            this.Controls.Add(this.tBoxLoanRate);
            this.Controls.Add(this.tBoxRunTime);
            this.Controls.Add(this.chkBoxOneTimePayment);
            this.Controls.Add(this.tBoxLoan);
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
        private System.Windows.Forms.TextBox tBoxLoan;
        private System.Windows.Forms.CheckBox chkBoxOneTimePayment;
        private System.Windows.Forms.TextBox tBoxRunTime;
        private System.Windows.Forms.TextBox tBoxLoanRate;
        private System.Windows.Forms.Label lblLoan;
        private System.Windows.Forms.Label lblLoanRuntime;
        private System.Windows.Forms.Label lblLoanRate;
        private System.Windows.Forms.Button btnCloseBasicCalc;
        private System.Windows.Forms.Button btnChooseModules;
    }
}