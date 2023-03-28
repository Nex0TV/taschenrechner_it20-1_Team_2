
namespace Taschenrechner
{
    partial class FormModules
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
            this.label1 = new System.Windows.Forms.Label();
            this.percentageCalc = new System.Windows.Forms.Button();
            this.loanCalc = new System.Windows.Forms.Button();
            this.gemeotryCalc = new System.Windows.Forms.Button();
            this.btnMathCalc = new System.Windows.Forms.Button();
            this.schoolMarkCalc = new System.Windows.Forms.Button();
            this.informationTechCalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(314, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bitte wählen Sie eine Branche aus:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // percentageCalc
            // 
            this.percentageCalc.Location = new System.Drawing.Point(12, 70);
            this.percentageCalc.Name = "percentageCalc";
            this.percentageCalc.Size = new System.Drawing.Size(776, 34);
            this.percentageCalc.TabIndex = 1;
            this.percentageCalc.Text = "Prozentberechnung";
            this.percentageCalc.UseVisualStyleBackColor = true;
            this.percentageCalc.Click += new System.EventHandler(this.percentageCalc_Click);
            // 
            // loanCalc
            // 
            this.loanCalc.Location = new System.Drawing.Point(12, 125);
            this.loanCalc.Name = "loanCalc";
            this.loanCalc.Size = new System.Drawing.Size(776, 34);
            this.loanCalc.TabIndex = 2;
            this.loanCalc.Text = "Kreditberechnung";
            this.loanCalc.UseVisualStyleBackColor = true;
            // 
            // gemeotryCalc
            // 
            this.gemeotryCalc.Location = new System.Drawing.Point(12, 181);
            this.gemeotryCalc.Name = "gemeotryCalc";
            this.gemeotryCalc.Size = new System.Drawing.Size(776, 34);
            this.gemeotryCalc.TabIndex = 3;
            this.gemeotryCalc.Text = "Geometrie";
            this.gemeotryCalc.UseVisualStyleBackColor = true;
            // 
            // btnMathCalc
            // 
            this.btnMathCalc.Location = new System.Drawing.Point(12, 235);
            this.btnMathCalc.Name = "btnMathCalc";
            this.btnMathCalc.Size = new System.Drawing.Size(776, 34);
            this.btnMathCalc.TabIndex = 4;
            this.btnMathCalc.Text = "Mathematisch";
            this.btnMathCalc.UseVisualStyleBackColor = true;
            this.btnMathCalc.Click += new System.EventHandler(this.MathCalc_Click);
            // 
            // schoolMarkCalc
            // 
            this.schoolMarkCalc.Location = new System.Drawing.Point(12, 291);
            this.schoolMarkCalc.Name = "schoolMarkCalc";
            this.schoolMarkCalc.Size = new System.Drawing.Size(776, 34);
            this.schoolMarkCalc.TabIndex = 5;
            this.schoolMarkCalc.Text = "Schule";
            this.schoolMarkCalc.UseVisualStyleBackColor = true;
            // 
            // informationTechCalc
            // 
            this.informationTechCalc.Location = new System.Drawing.Point(12, 346);
            this.informationTechCalc.Name = "informationTechCalc";
            this.informationTechCalc.Size = new System.Drawing.Size(776, 34);
            this.informationTechCalc.TabIndex = 6;
            this.informationTechCalc.Text = "Informationstechnik";
            this.informationTechCalc.UseVisualStyleBackColor = true;
            // 
            // FormModules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.informationTechCalc);
            this.Controls.Add(this.schoolMarkCalc);
            this.Controls.Add(this.btnMathCalc);
            this.Controls.Add(this.gemeotryCalc);
            this.Controls.Add(this.loanCalc);
            this.Controls.Add(this.percentageCalc);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FormModules";
            this.Text = "Taschenrechner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button percentageCalc;
        private System.Windows.Forms.Button loanCalc;
        private System.Windows.Forms.Button gemeotryCalc;
        private System.Windows.Forms.Button btnMathCalc;
        private System.Windows.Forms.Button schoolMarkCalc;
        private System.Windows.Forms.Button informationTechCalc;
    }
}