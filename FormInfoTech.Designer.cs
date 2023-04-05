
namespace Taschenrechner
{
    partial class FormInfoTech
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
            this.lblInfoTech = new System.Windows.Forms.Label();
            this.lblResultInfoTech = new System.Windows.Forms.Label();
            this.btnInfoTechFactorial = new System.Windows.Forms.Button();
            this.btnInfoTechSquareRoot = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnInfoTechDelete = new System.Windows.Forms.Button();
            this.btnCloseBasicCalc = new System.Windows.Forms.Button();
            this.btnChooseModules = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInfoTech
            // 
            this.lblInfoTech.AutoSize = true;
            this.lblInfoTech.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoTech.Location = new System.Drawing.Point(78, 9);
            this.lblInfoTech.Name = "lblInfoTech";
            this.lblInfoTech.Size = new System.Drawing.Size(164, 22);
            this.lblInfoTech.TabIndex = 0;
            this.lblInfoTech.Text = "Informationstechnik";
            // 
            // lblResultInfoTech
            // 
            this.lblResultInfoTech.AutoSize = true;
            this.lblResultInfoTech.Location = new System.Drawing.Point(13, 97);
            this.lblResultInfoTech.Name = "lblResultInfoTech";
            this.lblResultInfoTech.Size = new System.Drawing.Size(51, 13);
            this.lblResultInfoTech.TabIndex = 1;
            this.lblResultInfoTech.Text = "Ergebnis:";
            // 
            // btnInfoTechFactorial
            // 
            this.btnInfoTechFactorial.Location = new System.Drawing.Point(12, 221);
            this.btnInfoTechFactorial.Name = "btnInfoTechFactorial";
            this.btnInfoTechFactorial.Size = new System.Drawing.Size(146, 37);
            this.btnInfoTechFactorial.TabIndex = 2;
            this.btnInfoTechFactorial.Text = "Fakultät";
            this.btnInfoTechFactorial.UseVisualStyleBackColor = true;
            // 
            // btnInfoTechSquareRoot
            // 
            this.btnInfoTechSquareRoot.Location = new System.Drawing.Point(168, 221);
            this.btnInfoTechSquareRoot.Name = "btnInfoTechSquareRoot";
            this.btnInfoTechSquareRoot.Size = new System.Drawing.Size(138, 37);
            this.btnInfoTechSquareRoot.TabIndex = 3;
            this.btnInfoTechSquareRoot.Text = "Quadratwurzel";
            this.btnInfoTechSquareRoot.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(209, 20);
            this.textBox1.TabIndex = 4;
            // 
            // btnInfoTechDelete
            // 
            this.btnInfoTechDelete.Location = new System.Drawing.Point(231, 52);
            this.btnInfoTechDelete.Name = "btnInfoTechDelete";
            this.btnInfoTechDelete.Size = new System.Drawing.Size(75, 20);
            this.btnInfoTechDelete.TabIndex = 5;
            this.btnInfoTechDelete.Text = "Löschen";
            this.btnInfoTechDelete.UseVisualStyleBackColor = true;
            // 
            // btnCloseBasicCalc
            // 
            this.btnCloseBasicCalc.Location = new System.Drawing.Point(168, 598);
            this.btnCloseBasicCalc.Name = "btnCloseBasicCalc";
            this.btnCloseBasicCalc.Size = new System.Drawing.Size(138, 36);
            this.btnCloseBasicCalc.TabIndex = 24;
            this.btnCloseBasicCalc.Text = "Grundrechner schließen";
            this.btnCloseBasicCalc.UseVisualStyleBackColor = true;
            // 
            // btnChooseModules
            // 
            this.btnChooseModules.Location = new System.Drawing.Point(12, 598);
            this.btnChooseModules.Name = "btnChooseModules";
            this.btnChooseModules.Size = new System.Drawing.Size(146, 36);
            this.btnChooseModules.TabIndex = 23;
            this.btnChooseModules.Text = "Rechenmodul auswählen";
            this.btnChooseModules.UseVisualStyleBackColor = true;
            // 
            // FormInfoTech
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 646);
            this.Controls.Add(this.btnCloseBasicCalc);
            this.Controls.Add(this.btnChooseModules);
            this.Controls.Add(this.btnInfoTechDelete);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnInfoTechSquareRoot);
            this.Controls.Add(this.btnInfoTechFactorial);
            this.Controls.Add(this.lblResultInfoTech);
            this.Controls.Add(this.lblInfoTech);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormInfoTech";
            this.Text = "Taschenrechner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfoTech;
        private System.Windows.Forms.Label lblResultInfoTech;
        private System.Windows.Forms.Button btnInfoTechFactorial;
        private System.Windows.Forms.Button btnInfoTechSquareRoot;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnInfoTechDelete;
        private System.Windows.Forms.Button btnCloseBasicCalc;
        private System.Windows.Forms.Button btnChooseModules;
    }
}