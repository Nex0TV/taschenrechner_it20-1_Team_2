
namespace Taschenrechner
{
    partial class FormPercentageCalc
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
            this.lblPercentageCalc = new System.Windows.Forms.Label();
            this.lblResultPercentage = new System.Windows.Forms.Label();
            this.btnPercentageAddedToThat = new System.Windows.Forms.Button();
            this.btnPercetageTakeAwayFromThat = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPercentage = new System.Windows.Forms.Button();
            this.btnGrossToNetPrice = new System.Windows.Forms.Button();
            this.btnNetToGrossPrice = new System.Windows.Forms.Button();
            this.btnCloseBasicCalc = new System.Windows.Forms.Button();
            this.btnChooseModules = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPercentageCalc
            // 
            this.lblPercentageCalc.AutoSize = true;
            this.lblPercentageCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblPercentageCalc.Location = new System.Drawing.Point(12, 9);
            this.lblPercentageCalc.Name = "lblPercentageCalc";
            this.lblPercentageCalc.Size = new System.Drawing.Size(132, 22);
            this.lblPercentageCalc.TabIndex = 0;
            this.lblPercentageCalc.Text = "Prozentrechner";
            // 
            // lblResultPercentage
            // 
            this.lblResultPercentage.AutoSize = true;
            this.lblResultPercentage.Location = new System.Drawing.Point(12, 63);
            this.lblResultPercentage.Name = "lblResultPercentage";
            this.lblResultPercentage.Size = new System.Drawing.Size(51, 13);
            this.lblResultPercentage.TabIndex = 1;
            this.lblResultPercentage.Text = "Ergebnis:";
            // 
            // btnPercentageAddedToThat
            // 
            this.btnPercentageAddedToThat.Location = new System.Drawing.Point(16, 163);
            this.btnPercentageAddedToThat.Name = "btnPercentageAddedToThat";
            this.btnPercentageAddedToThat.Size = new System.Drawing.Size(124, 39);
            this.btnPercentageAddedToThat.TabIndex = 2;
            this.btnPercentageAddedToThat.Text = "% dazu";
            this.btnPercentageAddedToThat.UseVisualStyleBackColor = true;
            // 
            // btnPercetageTakeAwayFromThat
            // 
            this.btnPercetageTakeAwayFromThat.Location = new System.Drawing.Point(146, 163);
            this.btnPercetageTakeAwayFromThat.Name = "btnPercetageTakeAwayFromThat";
            this.btnPercetageTakeAwayFromThat.Size = new System.Drawing.Size(124, 39);
            this.btnPercetageTakeAwayFromThat.TabIndex = 3;
            this.btnPercetageTakeAwayFromThat.Text = "% weg";
            this.btnPercetageTakeAwayFromThat.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(146, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 39);
            this.button1.TabIndex = 5;
            this.button1.Text = "% weg";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnPercentage
            // 
            this.btnPercentage.Location = new System.Drawing.Point(16, 208);
            this.btnPercentage.Name = "btnPercentage";
            this.btnPercentage.Size = new System.Drawing.Size(124, 39);
            this.btnPercentage.TabIndex = 4;
            this.btnPercentage.Text = "Prozentsatz";
            this.btnPercentage.UseVisualStyleBackColor = true;
            // 
            // btnGrossToNetPrice
            // 
            this.btnGrossToNetPrice.Location = new System.Drawing.Point(16, 253);
            this.btnGrossToNetPrice.Name = "btnGrossToNetPrice";
            this.btnGrossToNetPrice.Size = new System.Drawing.Size(254, 39);
            this.btnGrossToNetPrice.TabIndex = 6;
            this.btnGrossToNetPrice.Text = "Bruttopreis aus Nettopreis";
            this.btnGrossToNetPrice.UseVisualStyleBackColor = true;
            // 
            // btnNetToGrossPrice
            // 
            this.btnNetToGrossPrice.Location = new System.Drawing.Point(16, 298);
            this.btnNetToGrossPrice.Name = "btnNetToGrossPrice";
            this.btnNetToGrossPrice.Size = new System.Drawing.Size(254, 39);
            this.btnNetToGrossPrice.TabIndex = 7;
            this.btnNetToGrossPrice.Text = "Nettopreis aus Bruttopreis";
            this.btnNetToGrossPrice.UseVisualStyleBackColor = true;
            // 
            // btnCloseBasicCalc
            // 
            this.btnCloseBasicCalc.Location = new System.Drawing.Point(146, 402);
            this.btnCloseBasicCalc.Name = "btnCloseBasicCalc";
            this.btnCloseBasicCalc.Size = new System.Drawing.Size(124, 36);
            this.btnCloseBasicCalc.TabIndex = 10;
            this.btnCloseBasicCalc.Text = "Grundrechner schließen";
            this.btnCloseBasicCalc.UseVisualStyleBackColor = true;
            // 
            // btnChooseModules
            // 
            this.btnChooseModules.Location = new System.Drawing.Point(16, 402);
            this.btnChooseModules.Name = "btnChooseModules";
            this.btnChooseModules.Size = new System.Drawing.Size(124, 36);
            this.btnChooseModules.TabIndex = 9;
            this.btnChooseModules.Text = "Rechenmodul auswählen";
            this.btnChooseModules.UseVisualStyleBackColor = true;
            // 
            // FormPercentageCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 450);
            this.Controls.Add(this.btnCloseBasicCalc);
            this.Controls.Add(this.btnChooseModules);
            this.Controls.Add(this.btnNetToGrossPrice);
            this.Controls.Add(this.btnGrossToNetPrice);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPercentage);
            this.Controls.Add(this.btnPercetageTakeAwayFromThat);
            this.Controls.Add(this.btnPercentageAddedToThat);
            this.Controls.Add(this.lblResultPercentage);
            this.Controls.Add(this.lblPercentageCalc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormPercentageCalc";
            this.Text = "Taschenrechner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPercentageCalc;
        private System.Windows.Forms.Label lblResultPercentage;
        private System.Windows.Forms.Button btnPercentageAddedToThat;
        private System.Windows.Forms.Button btnPercetageTakeAwayFromThat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPercentage;
        private System.Windows.Forms.Button btnGrossToNetPrice;
        private System.Windows.Forms.Button btnNetToGrossPrice;
        private System.Windows.Forms.Button btnCloseBasicCalc;
        private System.Windows.Forms.Button btnChooseModules;
    }
}