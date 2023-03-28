
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
            this.lblResultSchoolMark = new System.Windows.Forms.Label();
            this.btnAverageMark = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnMarkNumber = new System.Windows.Forms.Button();
            this.btnCloseBasicCalc = new System.Windows.Forms.Button();
            this.btnChooseModules = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSchoolMark
            // 
            this.lblSchoolMark.AutoSize = true;
            this.lblSchoolMark.Location = new System.Drawing.Point(13, 13);
            this.lblSchoolMark.Name = "lblSchoolMark";
            this.lblSchoolMark.Size = new System.Drawing.Size(40, 13);
            this.lblSchoolMark.TabIndex = 0;
            this.lblSchoolMark.Text = "Schule";
            // 
            // lblResultSchoolMark
            // 
            this.lblResultSchoolMark.AutoSize = true;
            this.lblResultSchoolMark.Location = new System.Drawing.Point(13, 62);
            this.lblResultSchoolMark.Name = "lblResultSchoolMark";
            this.lblResultSchoolMark.Size = new System.Drawing.Size(51, 13);
            this.lblResultSchoolMark.TabIndex = 1;
            this.lblResultSchoolMark.Text = "Ergebnis:";
            // 
            // btnAverageMark
            // 
            this.btnAverageMark.Location = new System.Drawing.Point(16, 153);
            this.btnAverageMark.Name = "btnAverageMark";
            this.btnAverageMark.Size = new System.Drawing.Size(187, 44);
            this.btnAverageMark.TabIndex = 2;
            this.btnAverageMark.Text = "Notendurchschnitt";
            this.btnAverageMark.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 44);
            this.button1.TabIndex = 3;
            this.button1.Text = "Zeugnissnotenempfehlung";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnMarkNumber
            // 
            this.btnMarkNumber.Location = new System.Drawing.Point(16, 253);
            this.btnMarkNumber.Name = "btnMarkNumber";
            this.btnMarkNumber.Size = new System.Drawing.Size(187, 44);
            this.btnMarkNumber.TabIndex = 4;
            this.btnMarkNumber.Text = "Notenzahl";
            this.btnMarkNumber.UseVisualStyleBackColor = true;
            // 
            // btnCloseBasicCalc
            // 
            this.btnCloseBasicCalc.Location = new System.Drawing.Point(537, 402);
            this.btnCloseBasicCalc.Name = "btnCloseBasicCalc";
            this.btnCloseBasicCalc.Size = new System.Drawing.Size(251, 36);
            this.btnCloseBasicCalc.TabIndex = 14;
            this.btnCloseBasicCalc.Text = "Grundrechner schließen";
            this.btnCloseBasicCalc.UseVisualStyleBackColor = true;
            // 
            // btnChooseModules
            // 
            this.btnChooseModules.Location = new System.Drawing.Point(16, 402);
            this.btnChooseModules.Name = "btnChooseModules";
            this.btnChooseModules.Size = new System.Drawing.Size(251, 36);
            this.btnChooseModules.TabIndex = 13;
            this.btnChooseModules.Text = "Rechenmodul auswählen";
            this.btnChooseModules.UseVisualStyleBackColor = true;
            // 
            // FormSchoolMark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCloseBasicCalc);
            this.Controls.Add(this.btnChooseModules);
            this.Controls.Add(this.btnMarkNumber);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAverageMark);
            this.Controls.Add(this.lblResultSchoolMark);
            this.Controls.Add(this.lblSchoolMark);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormSchoolMark";
            this.Text = "Taschenrechner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSchoolMark;
        private System.Windows.Forms.Label lblResultSchoolMark;
        private System.Windows.Forms.Button btnAverageMark;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnMarkNumber;
        private System.Windows.Forms.Button btnCloseBasicCalc;
        private System.Windows.Forms.Button btnChooseModules;
    }
}