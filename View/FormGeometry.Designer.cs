
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
            this.lblUmfangText = new System.Windows.Forms.Label();
            this.btnCircle = new System.Windows.Forms.Button();
            this.btnTriangle = new System.Windows.Forms.Button();
            this.btnParallelogram = new System.Windows.Forms.Button();
            this.btnCloseBasicCalc = new System.Windows.Forms.Button();
            this.btnChooseModules = new System.Windows.Forms.Button();
            this.lblFlaecheText = new System.Windows.Forms.Label();
            this.lblGeometrischeForm = new System.Windows.Forms.Label();
            this.lblUmfang = new System.Windows.Forms.Label();
            this.lblFlaeche = new System.Windows.Forms.Label();
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
            // lblUmfangText
            // 
            this.lblUmfangText.AutoSize = true;
            this.lblUmfangText.Location = new System.Drawing.Point(5, 70);
            this.lblUmfangText.Name = "lblUmfangText";
            this.lblUmfangText.Size = new System.Drawing.Size(47, 13);
            this.lblUmfangText.TabIndex = 1;
            this.lblUmfangText.Text = "Umfang:";
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
            this.btnTriangle.Click += new System.EventHandler(this.btnTriangle_Click);
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
            this.btnParallelogram.Click += new System.EventHandler(this.btnParallelogram_Click);
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
            // lblFlaecheText
            // 
            this.lblFlaecheText.AutoSize = true;
            this.lblFlaecheText.Location = new System.Drawing.Point(5, 101);
            this.lblFlaecheText.Name = "lblFlaecheText";
            this.lblFlaecheText.Size = new System.Drawing.Size(42, 13);
            this.lblFlaecheText.TabIndex = 13;
            this.lblFlaecheText.Text = "Fläche:";
            // 
            // lblGeometrischeForm
            // 
            this.lblGeometrischeForm.AutoSize = true;
            this.lblGeometrischeForm.Location = new System.Drawing.Point(5, 40);
            this.lblGeometrischeForm.Name = "lblGeometrischeForm";
            this.lblGeometrischeForm.Size = new System.Drawing.Size(30, 13);
            this.lblGeometrischeForm.TabIndex = 14;
            this.lblGeometrischeForm.Text = "Form";
            // 
            // lblUmfang
            // 
            this.lblUmfang.AutoSize = true;
            this.lblUmfang.Location = new System.Drawing.Point(58, 70);
            this.lblUmfang.Name = "lblUmfang";
            this.lblUmfang.Size = new System.Drawing.Size(0, 13);
            this.lblUmfang.TabIndex = 15;
            // 
            // lblFlaeche
            // 
            this.lblFlaeche.AutoSize = true;
            this.lblFlaeche.Location = new System.Drawing.Point(58, 101);
            this.lblFlaeche.Name = "lblFlaeche";
            this.lblFlaeche.Size = new System.Drawing.Size(0, 13);
            this.lblFlaeche.TabIndex = 16;
            // 
            // FormGeometry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 589);
            this.Controls.Add(this.lblFlaeche);
            this.Controls.Add(this.lblUmfang);
            this.Controls.Add(this.lblGeometrischeForm);
            this.Controls.Add(this.lblFlaecheText);
            this.Controls.Add(this.btnCloseBasicCalc);
            this.Controls.Add(this.btnChooseModules);
            this.Controls.Add(this.btnParallelogram);
            this.Controls.Add(this.btnTriangle);
            this.Controls.Add(this.btnCircle);
            this.Controls.Add(this.lblUmfangText);
            this.Controls.Add(this.lblGeometry);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormGeometry";
            this.Text = "Taschenrechner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGeometry;
        private System.Windows.Forms.Label lblUmfangText;
        private System.Windows.Forms.Button btnCircle;
        private System.Windows.Forms.Button btnTriangle;
        private System.Windows.Forms.Button btnParallelogram;
        private System.Windows.Forms.Button btnCloseBasicCalc;
        private System.Windows.Forms.Button btnChooseModules;
        private System.Windows.Forms.Label lblFlaecheText;
        private System.Windows.Forms.Label lblGeometrischeForm;
        private System.Windows.Forms.Label lblUmfang;
        private System.Windows.Forms.Label lblFlaeche;
    }
}