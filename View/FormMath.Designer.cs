
namespace Taschenrechner
{
    partial class FormMath
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
            this.lblMathCalc = new System.Windows.Forms.Label();
            this.btnFactorial = new System.Windows.Forms.Button();
            this.btnSquareRoot = new System.Windows.Forms.Button();
            this.btnPower = new System.Windows.Forms.Button();
            this.btnPrimeNum = new System.Windows.Forms.Button();
            this.btnVulgarFraction = new System.Windows.Forms.Button();
            this.btnChooseModules = new System.Windows.Forms.Button();
            this.btnCloseBasicCalc = new System.Windows.Forms.Button();
            this.lblResultText = new System.Windows.Forms.Label();
            this.btnParseDecimalFraction = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMathCalc
            // 
            this.lblMathCalc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMathCalc.AutoSize = true;
            this.lblMathCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblMathCalc.Location = new System.Drawing.Point(29, 21);
            this.lblMathCalc.Name = "lblMathCalc";
            this.lblMathCalc.Size = new System.Drawing.Size(224, 22);
            this.lblMathCalc.TabIndex = 0;
            this.lblMathCalc.Text = "Mathematische Funktionen";
            // 
            // btnFactorial
            // 
            this.btnFactorial.Location = new System.Drawing.Point(12, 195);
            this.btnFactorial.Name = "btnFactorial";
            this.btnFactorial.Size = new System.Drawing.Size(122, 36);
            this.btnFactorial.TabIndex = 1;
            this.btnFactorial.Text = "Fakultät";
            this.btnFactorial.UseVisualStyleBackColor = true;
            this.btnFactorial.Click += new System.EventHandler(this.btnFactorial_Click);
            // 
            // btnSquareRoot
            // 
            this.btnSquareRoot.Location = new System.Drawing.Point(140, 195);
            this.btnSquareRoot.Name = "btnSquareRoot";
            this.btnSquareRoot.Size = new System.Drawing.Size(122, 36);
            this.btnSquareRoot.TabIndex = 2;
            this.btnSquareRoot.Text = "Quadratwurzel";
            this.btnSquareRoot.UseVisualStyleBackColor = true;
            // 
            // btnPower
            // 
            this.btnPower.Location = new System.Drawing.Point(12, 237);
            this.btnPower.Name = "btnPower";
            this.btnPower.Size = new System.Drawing.Size(122, 36);
            this.btnPower.TabIndex = 3;
            this.btnPower.Text = "Potenzfunktion";
            this.btnPower.UseVisualStyleBackColor = true;
            this.btnPower.Click += new System.EventHandler(this.btnPower_Click);
            // 
            // btnPrimeNum
            // 
            this.btnPrimeNum.Location = new System.Drawing.Point(12, 279);
            this.btnPrimeNum.Name = "btnPrimeNum";
            this.btnPrimeNum.Size = new System.Drawing.Size(122, 36);
            this.btnPrimeNum.TabIndex = 4;
            this.btnPrimeNum.Text = "Primzahlen zwischen Grenzwerten";
            this.btnPrimeNum.UseVisualStyleBackColor = true;
            // 
            // btnVulgarFraction
            // 
            this.btnVulgarFraction.Location = new System.Drawing.Point(140, 279);
            this.btnVulgarFraction.Name = "btnVulgarFraction";
            this.btnVulgarFraction.Size = new System.Drawing.Size(124, 36);
            this.btnVulgarFraction.TabIndex = 6;
            this.btnVulgarFraction.Text = "Gemeiner Bruch";
            this.btnVulgarFraction.UseVisualStyleBackColor = true;
            // 
            // btnChooseModules
            // 
            this.btnChooseModules.Location = new System.Drawing.Point(12, 402);
            this.btnChooseModules.Name = "btnChooseModules";
            this.btnChooseModules.Size = new System.Drawing.Size(122, 36);
            this.btnChooseModules.TabIndex = 7;
            this.btnChooseModules.Text = "Rechenmodul auswählen";
            this.btnChooseModules.UseVisualStyleBackColor = true;
            // 
            // btnCloseBasicCalc
            // 
            this.btnCloseBasicCalc.Location = new System.Drawing.Point(140, 402);
            this.btnCloseBasicCalc.Name = "btnCloseBasicCalc";
            this.btnCloseBasicCalc.Size = new System.Drawing.Size(123, 36);
            this.btnCloseBasicCalc.TabIndex = 8;
            this.btnCloseBasicCalc.Text = "Grundrechner schließen";
            this.btnCloseBasicCalc.UseVisualStyleBackColor = true;
            // 
            // lblResultText
            // 
            this.lblResultText.AutoSize = true;
            this.lblResultText.Location = new System.Drawing.Point(13, 91);
            this.lblResultText.Name = "lblResultText";
            this.lblResultText.Size = new System.Drawing.Size(51, 13);
            this.lblResultText.TabIndex = 9;
            this.lblResultText.Text = "Ergebnis:";
            // 
            // btnParseDecimalFraction
            // 
            this.btnParseDecimalFraction.Location = new System.Drawing.Point(140, 237);
            this.btnParseDecimalFraction.Name = "btnParseDecimalFraction";
            this.btnParseDecimalFraction.Size = new System.Drawing.Size(122, 36);
            this.btnParseDecimalFraction.TabIndex = 10;
            this.btnParseDecimalFraction.Text = "Umwandlung Dezimalbruch";
            this.btnParseDecimalFraction.UseVisualStyleBackColor = true;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(71, 91);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 11;
            // 
            // FormMath
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 450);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnParseDecimalFraction);
            this.Controls.Add(this.lblResultText);
            this.Controls.Add(this.btnCloseBasicCalc);
            this.Controls.Add(this.btnChooseModules);
            this.Controls.Add(this.btnVulgarFraction);
            this.Controls.Add(this.btnPrimeNum);
            this.Controls.Add(this.btnPower);
            this.Controls.Add(this.btnSquareRoot);
            this.Controls.Add(this.btnFactorial);
            this.Controls.Add(this.lblMathCalc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormMath";
            this.Text = "Taschenrechner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMathCalc;
        private System.Windows.Forms.Button btnFactorial;
        private System.Windows.Forms.Button btnSquareRoot;
        private System.Windows.Forms.Button btnPower;
        private System.Windows.Forms.Button btnPrimeNum;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnVulgarFraction;
        private System.Windows.Forms.Button btnChooseModules;
        private System.Windows.Forms.Button btnCloseBasicCalc;
        private System.Windows.Forms.Label lblResultText;
        private System.Windows.Forms.Button btnParseDecimalFraction;
        private System.Windows.Forms.Label lblResult;
    }
}