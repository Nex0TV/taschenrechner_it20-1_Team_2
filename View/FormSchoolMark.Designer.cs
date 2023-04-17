
namespace Taschenrechner
{
    partial class FormSchoolMark
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
            this.lblSchoolMark = new System.Windows.Forms.Label();
            this.lblDurchschnitt = new System.Windows.Forms.Label();
            this.btnAverageMark = new System.Windows.Forms.Button();
            this.btnCloseBasicCalc = new System.Windows.Forms.Button();
            this.btnChooseModules = new System.Windows.Forms.Button();
            this.lblResultDurchschnitt = new System.Windows.Forms.Label();
            this.lblNotempfehlung = new System.Windows.Forms.Label();
            this.lblResultEmpfehlung = new System.Windows.Forms.Label();
            this.lblAnzahl = new System.Windows.Forms.Label();
            this.lblResultAnzahl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSchoolMark
            // 
            this.lblSchoolMark.AutoSize = true;
            this.lblSchoolMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblSchoolMark.Location = new System.Drawing.Point(108, 9);
            this.lblSchoolMark.Name = "lblSchoolMark";
            this.lblSchoolMark.Size = new System.Drawing.Size(65, 22);
            this.lblSchoolMark.TabIndex = 0;
            this.lblSchoolMark.Text = "Schule";
            // 
            // lblDurchschnitt
            // 
            this.lblDurchschnitt.AutoSize = true;
            this.lblDurchschnitt.Location = new System.Drawing.Point(13, 62);
            this.lblDurchschnitt.Name = "lblDurchschnitt";
            this.lblDurchschnitt.Size = new System.Drawing.Size(70, 13);
            this.lblDurchschnitt.TabIndex = 1;
            this.lblDurchschnitt.Text = "Durchschnitt:";
            // 
            // btnAverageMark
            // 
            this.btnAverageMark.Location = new System.Drawing.Point(12, 136);
            this.btnAverageMark.Name = "btnAverageMark";
            this.btnAverageMark.Size = new System.Drawing.Size(251, 44);
            this.btnAverageMark.TabIndex = 2;
            this.btnAverageMark.Text = "Noten Berechnen";
            this.btnAverageMark.UseVisualStyleBackColor = true;
            this.btnAverageMark.Click += new System.EventHandler(this.btnAverageMark_Click);
            // 
            // btnCloseBasicCalc
            // 
            this.btnCloseBasicCalc.Location = new System.Drawing.Point(141, 402);
            this.btnCloseBasicCalc.Name = "btnCloseBasicCalc";
            this.btnCloseBasicCalc.Size = new System.Drawing.Size(126, 36);
            this.btnCloseBasicCalc.TabIndex = 14;
            this.btnCloseBasicCalc.Text = "Grundrechner schließen";
            this.btnCloseBasicCalc.UseVisualStyleBackColor = true;
            // 
            // btnChooseModules
            // 
            this.btnChooseModules.Location = new System.Drawing.Point(16, 402);
            this.btnChooseModules.Name = "btnChooseModules";
            this.btnChooseModules.Size = new System.Drawing.Size(119, 36);
            this.btnChooseModules.TabIndex = 13;
            this.btnChooseModules.Text = "Rechenmodul auswählen";
            this.btnChooseModules.UseVisualStyleBackColor = true;
            // 
            // lblResultDurchschnitt
            // 
            this.lblResultDurchschnitt.AutoSize = true;
            this.lblResultDurchschnitt.Location = new System.Drawing.Point(109, 62);
            this.lblResultDurchschnitt.Name = "lblResultDurchschnitt";
            this.lblResultDurchschnitt.Size = new System.Drawing.Size(10, 13);
            this.lblResultDurchschnitt.TabIndex = 15;
            this.lblResultDurchschnitt.Text = " ";
            // 
            // lblNotempfehlung
            // 
            this.lblNotempfehlung.AutoSize = true;
            this.lblNotempfehlung.Location = new System.Drawing.Point(13, 84);
            this.lblNotempfehlung.Name = "lblNotempfehlung";
            this.lblNotempfehlung.Size = new System.Drawing.Size(94, 13);
            this.lblNotempfehlung.TabIndex = 16;
            this.lblNotempfehlung.Text = "Notenempfehlung:";
            // 
            // lblResultEmpfehlung
            // 
            this.lblResultEmpfehlung.AutoSize = true;
            this.lblResultEmpfehlung.Location = new System.Drawing.Point(109, 84);
            this.lblResultEmpfehlung.Name = "lblResultEmpfehlung";
            this.lblResultEmpfehlung.Size = new System.Drawing.Size(10, 13);
            this.lblResultEmpfehlung.TabIndex = 17;
            this.lblResultEmpfehlung.Text = " ";
            // 
            // lblAnzahl
            // 
            this.lblAnzahl.AutoSize = true;
            this.lblAnzahl.Location = new System.Drawing.Point(12, 106);
            this.lblAnzahl.Name = "lblAnzahl";
            this.lblAnzahl.Size = new System.Drawing.Size(74, 13);
            this.lblAnzahl.TabIndex = 18;
            this.lblAnzahl.Text = "Anzahl Noten:";
            // 
            // lblResultAnzahl
            // 
            this.lblResultAnzahl.AutoSize = true;
            this.lblResultAnzahl.Location = new System.Drawing.Point(109, 106);
            this.lblResultAnzahl.Name = "lblResultAnzahl";
            this.lblResultAnzahl.Size = new System.Drawing.Size(10, 13);
            this.lblResultAnzahl.TabIndex = 19;
            this.lblResultAnzahl.Text = " ";
            // 
            // FormSchoolMark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 450);
            this.Controls.Add(this.lblResultAnzahl);
            this.Controls.Add(this.lblAnzahl);
            this.Controls.Add(this.lblResultEmpfehlung);
            this.Controls.Add(this.lblNotempfehlung);
            this.Controls.Add(this.lblResultDurchschnitt);
            this.Controls.Add(this.btnCloseBasicCalc);
            this.Controls.Add(this.btnChooseModules);
            this.Controls.Add(this.btnAverageMark);
            this.Controls.Add(this.lblDurchschnitt);
            this.Controls.Add(this.lblSchoolMark);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormSchoolMark";
            this.Text = "Taschenrechner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSchoolMark;
        private System.Windows.Forms.Label lblDurchschnitt;
        private System.Windows.Forms.Button btnAverageMark;
        private System.Windows.Forms.Button btnCloseBasicCalc;
        private System.Windows.Forms.Button btnChooseModules;
        private System.Windows.Forms.Label lblResultDurchschnitt;
        private System.Windows.Forms.Label lblNotempfehlung;
        private System.Windows.Forms.Label lblResultEmpfehlung;
        private System.Windows.Forms.Label lblAnzahl;
        private System.Windows.Forms.Label lblResultAnzahl;
    }
}