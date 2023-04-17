
namespace Taschenrechner
{
    partial class FormGeometry
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
            this.lblGeometry = new System.Windows.Forms.Label();
            this.lblResultGeometry = new System.Windows.Forms.Label();
            this.btnCircle = new System.Windows.Forms.Button();
            this.btnTriangle = new System.Windows.Forms.Button();
            this.btnParallelogram = new System.Windows.Forms.Button();
            this.btnCloseBasicCalc = new System.Windows.Forms.Button();
            this.btnChooseModules = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblGeometry
            // 
            this.lblGeometry.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblGeometry.AutoSize = true;
            this.lblGeometry.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblGeometry.Location = new System.Drawing.Point(111, 9);
            this.lblGeometry.Name = "lblGeometry";
            this.lblGeometry.Size = new System.Drawing.Size(93, 22);
            this.lblGeometry.TabIndex = 0;
            this.lblGeometry.Text = "Geometrie";
            // 
            // lblResultGeometry
            // 
            this.lblResultGeometry.AutoSize = true;
            this.lblResultGeometry.Location = new System.Drawing.Point(9, 72);
            this.lblResultGeometry.Name = "lblResultGeometry";
            this.lblResultGeometry.Size = new System.Drawing.Size(51, 13);
            this.lblResultGeometry.TabIndex = 1;
            this.lblResultGeometry.Text = "Ergebnis:";
            // 
            // btnCircle
            // 
            this.btnCircle.Location = new System.Drawing.Point(12, 340);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(146, 40);
            this.btnCircle.TabIndex = 2;
            this.btnCircle.Text = "Kreis";
            this.btnCircle.UseVisualStyleBackColor = true;
            this.btnCircle.Click += new System.EventHandler(this.btnCircle_Click);
            // 
            // btnTriangle
            // 
            this.btnTriangle.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnTriangle.Location = new System.Drawing.Point(168, 340);
            this.btnTriangle.Name = "btnTriangle";
            this.btnTriangle.Size = new System.Drawing.Size(138, 40);
            this.btnTriangle.TabIndex = 3;
            this.btnTriangle.Text = "Dreieck";
            this.btnTriangle.UseVisualStyleBackColor = true;
            // 
            // btnParallelogram
            // 
            this.btnParallelogram.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnParallelogram.Location = new System.Drawing.Point(12, 386);
            this.btnParallelogram.Name = "btnParallelogram";
            this.btnParallelogram.Size = new System.Drawing.Size(294, 40);
            this.btnParallelogram.TabIndex = 4;
            this.btnParallelogram.Text = "Parallelogramm";
            this.btnParallelogram.UseVisualStyleBackColor = true;
            // 
            // btnCloseBasicCalc
            // 
            this.btnCloseBasicCalc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseBasicCalc.Location = new System.Drawing.Point(168, 541);
            this.btnCloseBasicCalc.Name = "btnCloseBasicCalc";
            this.btnCloseBasicCalc.Size = new System.Drawing.Size(138, 36);
            this.btnCloseBasicCalc.TabIndex = 12;
            this.btnCloseBasicCalc.Text = "Grundrechner schließen";
            this.btnCloseBasicCalc.UseVisualStyleBackColor = true;
            // 
            // btnChooseModules
            // 
            this.btnChooseModules.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnChooseModules.Location = new System.Drawing.Point(12, 541);
            this.btnChooseModules.Name = "btnChooseModules";
            this.btnChooseModules.Size = new System.Drawing.Size(146, 36);
            this.btnChooseModules.TabIndex = 11;
            this.btnChooseModules.Text = "Rechenmodul auswählen";
            this.btnChooseModules.UseVisualStyleBackColor = true;
            // 
            // FormGeometry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 589);
            this.Controls.Add(this.btnCloseBasicCalc);
            this.Controls.Add(this.btnChooseModules);
            this.Controls.Add(this.btnParallelogram);
            this.Controls.Add(this.btnTriangle);
            this.Controls.Add(this.btnCircle);
            this.Controls.Add(this.lblResultGeometry);
            this.Controls.Add(this.lblGeometry);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormGeometry";
            this.Text = "Taschenrechner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGeometry;
        private System.Windows.Forms.Label lblResultGeometry;
        private System.Windows.Forms.Button btnCircle;
        private System.Windows.Forms.Button btnTriangle;
        private System.Windows.Forms.Button btnParallelogram;
        private System.Windows.Forms.Button btnCloseBasicCalc;
        private System.Windows.Forms.Button btnChooseModules;
    }
}