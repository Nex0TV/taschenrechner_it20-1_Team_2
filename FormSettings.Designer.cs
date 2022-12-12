namespace Taschenrechner
{
    partial class FormSettings
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
            this.lblFontSize = new System.Windows.Forms.Label();
            this.btnFontColor = new System.Windows.Forms.Button();
            this.lblFontColor = new System.Windows.Forms.Label();
            this.clrFont = new System.Windows.Forms.ColorDialog();
            this.lblBackgroundColor = new System.Windows.Forms.Label();
            this.btnBackgroundColor = new System.Windows.Forms.Button();
            this.clrBackground = new System.Windows.Forms.ColorDialog();
            this.btnSaveAndQuit = new System.Windows.Forms.Button();
            this.btnSettingsReset = new System.Windows.Forms.Button();
            this.cBoxFontSize = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblFontSize
            // 
            this.lblFontSize.AutoSize = true;
            this.lblFontSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.lblFontSize.Location = new System.Drawing.Point(12, 42);
            this.lblFontSize.Name = "lblFontSize";
            this.lblFontSize.Size = new System.Drawing.Size(150, 29);
            this.lblFontSize.TabIndex = 1;
            this.lblFontSize.Text = "Schriftgröße";
            // 
            // btnFontColor
            // 
            this.btnFontColor.Location = new System.Drawing.Point(219, 100);
            this.btnFontColor.Name = "btnFontColor";
            this.btnFontColor.Size = new System.Drawing.Size(198, 33);
            this.btnFontColor.TabIndex = 3;
            this.btnFontColor.Text = "Ändern";
            this.btnFontColor.UseVisualStyleBackColor = true;
            this.btnFontColor.Click += new System.EventHandler(this.btnFontColor_Click);
            // 
            // lblFontColor
            // 
            this.lblFontColor.AutoSize = true;
            this.lblFontColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.lblFontColor.Location = new System.Drawing.Point(12, 100);
            this.lblFontColor.Name = "lblFontColor";
            this.lblFontColor.Size = new System.Drawing.Size(142, 29);
            this.lblFontColor.TabIndex = 2;
            this.lblFontColor.Text = "Schriftfarbe";
            // 
            // lblBackgroundColor
            // 
            this.lblBackgroundColor.AutoSize = true;
            this.lblBackgroundColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.lblBackgroundColor.Location = new System.Drawing.Point(12, 159);
            this.lblBackgroundColor.Name = "lblBackgroundColor";
            this.lblBackgroundColor.Size = new System.Drawing.Size(201, 29);
            this.lblBackgroundColor.TabIndex = 4;
            this.lblBackgroundColor.Text = "Hintergrundfarbe";
            // 
            // btnBackgroundColor
            // 
            this.btnBackgroundColor.Location = new System.Drawing.Point(219, 159);
            this.btnBackgroundColor.Name = "btnBackgroundColor";
            this.btnBackgroundColor.Size = new System.Drawing.Size(198, 33);
            this.btnBackgroundColor.TabIndex = 5;
            this.btnBackgroundColor.Text = "Ändern";
            this.btnBackgroundColor.UseVisualStyleBackColor = true;
            this.btnBackgroundColor.Click += new System.EventHandler(this.btnBackgroundColor_Click);
            // 
            // btnSaveAndQuit
            // 
            this.btnSaveAndQuit.Location = new System.Drawing.Point(17, 390);
            this.btnSaveAndQuit.Name = "btnSaveAndQuit";
            this.btnSaveAndQuit.Size = new System.Drawing.Size(400, 48);
            this.btnSaveAndQuit.TabIndex = 6;
            this.btnSaveAndQuit.Text = "Speichern und Schließen";
            this.btnSaveAndQuit.UseVisualStyleBackColor = true;
            // 
            // btnSettingsReset
            // 
            this.btnSettingsReset.Location = new System.Drawing.Point(423, 390);
            this.btnSettingsReset.Name = "btnSettingsReset";
            this.btnSettingsReset.Size = new System.Drawing.Size(400, 48);
            this.btnSettingsReset.TabIndex = 7;
            this.btnSettingsReset.Text = "Einstellungen zurücksetzen";
            this.btnSettingsReset.UseVisualStyleBackColor = true;
            this.btnSettingsReset.Click += new System.EventHandler(this.btnSettingsReset_Click);
            // 
            // cBoxFontSize
            // 
            this.cBoxFontSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxFontSize.FormattingEnabled = true;
            this.cBoxFontSize.Items.AddRange(new object[] {
            "Klein",
            "Mittel",
            "Groß"});
            this.cBoxFontSize.Location = new System.Drawing.Point(219, 42);
            this.cBoxFontSize.Name = "cBoxFontSize";
            this.cBoxFontSize.Size = new System.Drawing.Size(198, 21);
            this.cBoxFontSize.TabIndex = 8;
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 450);
            this.Controls.Add(this.cBoxFontSize);
            this.Controls.Add(this.btnSettingsReset);
            this.Controls.Add(this.btnSaveAndQuit);
            this.Controls.Add(this.btnBackgroundColor);
            this.Controls.Add(this.lblBackgroundColor);
            this.Controls.Add(this.btnFontColor);
            this.Controls.Add(this.lblFontColor);
            this.Controls.Add(this.lblFontSize);
            this.Name = "FormSettings";
            this.Text = "Einstellungen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblFontSize;
        private System.Windows.Forms.Button btnFontColor;
        private System.Windows.Forms.Label lblFontColor;
        private System.Windows.Forms.ColorDialog clrFont;
        private System.Windows.Forms.Label lblBackgroundColor;
        private System.Windows.Forms.Button btnBackgroundColor;
        private System.Windows.Forms.ColorDialog clrBackground;
        private System.Windows.Forms.Button btnSaveAndQuit;
        private System.Windows.Forms.Button btnSettingsReset;
        private System.Windows.Forms.ComboBox cBoxFontSize;
    }
}