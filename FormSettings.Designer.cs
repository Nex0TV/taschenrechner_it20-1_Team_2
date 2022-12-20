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
            this.lblFontColor = new System.Windows.Forms.Label();
            this.clrFont = new System.Windows.Forms.ColorDialog();
            this.lblBackgroundColor = new System.Windows.Forms.Label();
            this.clrBackground = new System.Windows.Forms.ColorDialog();
            this.btnSaveAndQuit = new System.Windows.Forms.Button();
            this.btnSettingsReset = new System.Windows.Forms.Button();
            this.cBoxFontSize = new System.Windows.Forms.ComboBox();
            this.cBoxFont = new System.Windows.Forms.ComboBox();
            this.cBoxBackgroundColor = new System.Windows.Forms.ComboBox();
            this.cBoxTheme = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFontSize
            // 
            this.lblFontSize.AutoSize = true;
            this.lblFontSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.lblFontSize.Location = new System.Drawing.Point(12, 49);
            this.lblFontSize.Name = "lblFontSize";
            this.lblFontSize.Size = new System.Drawing.Size(150, 29);
            this.lblFontSize.TabIndex = 1;
            this.lblFontSize.Text = "Schriftgröße";
            // 
            // lblFontColor
            // 
            this.lblFontColor.AutoSize = true;
            this.lblFontColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.lblFontColor.Location = new System.Drawing.Point(12, 90);
            this.lblFontColor.Name = "lblFontColor";
            this.lblFontColor.Size = new System.Drawing.Size(114, 29);
            this.lblFontColor.TabIndex = 2;
            this.lblFontColor.Text = "Schriftart";
            // 
            // lblBackgroundColor
            // 
            this.lblBackgroundColor.AutoSize = true;
            this.lblBackgroundColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.lblBackgroundColor.Location = new System.Drawing.Point(12, 127);
            this.lblBackgroundColor.Name = "lblBackgroundColor";
            this.lblBackgroundColor.Size = new System.Drawing.Size(201, 29);
            this.lblBackgroundColor.TabIndex = 4;
            this.lblBackgroundColor.Text = "Hintergrundfarbe";
            // 
            // btnSaveAndQuit
            // 
            this.btnSaveAndQuit.Location = new System.Drawing.Point(17, 390);
            this.btnSaveAndQuit.Name = "btnSaveAndQuit";
            this.btnSaveAndQuit.Size = new System.Drawing.Size(400, 48);
            this.btnSaveAndQuit.TabIndex = 6;
            this.btnSaveAndQuit.Text = "Speichern und Schließen";
            this.btnSaveAndQuit.UseVisualStyleBackColor = true;
            this.btnSaveAndQuit.Click += new System.EventHandler(this.btnSaveAndQuit_Click);
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
            this.cBoxFontSize.Location = new System.Drawing.Point(219, 49);
            this.cBoxFontSize.Name = "cBoxFontSize";
            this.cBoxFontSize.Size = new System.Drawing.Size(198, 21);
            this.cBoxFontSize.TabIndex = 8;
            // 
            // cBoxFont
            // 
            this.cBoxFont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxFont.FormattingEnabled = true;
            this.cBoxFont.Items.AddRange(new object[] {
            "Klein",
            "Mittel",
            "Groß"});
            this.cBoxFont.Location = new System.Drawing.Point(219, 90);
            this.cBoxFont.Name = "cBoxFont";
            this.cBoxFont.Size = new System.Drawing.Size(198, 21);
            this.cBoxFont.TabIndex = 9;
            this.cBoxFont.SelectedIndexChanged += new System.EventHandler(this.cBoxFont_SelectedIndexChanged);
            // 
            // cBoxBackgroundColor
            // 
            this.cBoxBackgroundColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxBackgroundColor.FormattingEnabled = true;
            this.cBoxBackgroundColor.Items.AddRange(new object[] {
            "Klein",
            "Mittel",
            "Groß"});
            this.cBoxBackgroundColor.Location = new System.Drawing.Point(219, 135);
            this.cBoxBackgroundColor.Name = "cBoxBackgroundColor";
            this.cBoxBackgroundColor.Size = new System.Drawing.Size(198, 21);
            this.cBoxBackgroundColor.TabIndex = 10;
            this.cBoxBackgroundColor.SelectedIndexChanged += new System.EventHandler(this.cBoxBackgroundColor_SelectedIndexChanged);
            // 
            // cBoxTheme
            // 
            this.cBoxTheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxTheme.FormattingEnabled = true;
            this.cBoxTheme.Items.AddRange(new object[] {
            "Klein",
            "Mittel",
            "Groß"});
            this.cBoxTheme.Location = new System.Drawing.Point(219, 9);
            this.cBoxTheme.Name = "cBoxTheme";
            this.cBoxTheme.Size = new System.Drawing.Size(198, 21);
            this.cBoxTheme.TabIndex = 12;
            this.cBoxTheme.SelectedIndexChanged += new System.EventHandler(this.cBoxTheme_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Theme";
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 450);
            this.Controls.Add(this.cBoxTheme);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cBoxBackgroundColor);
            this.Controls.Add(this.cBoxFont);
            this.Controls.Add(this.cBoxFontSize);
            this.Controls.Add(this.btnSettingsReset);
            this.Controls.Add(this.btnSaveAndQuit);
            this.Controls.Add(this.lblBackgroundColor);
            this.Controls.Add(this.lblFontColor);
            this.Controls.Add(this.lblFontSize);
            this.Name = "FormSettings";
            this.Text = "Einstellungen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblFontSize;
        private System.Windows.Forms.Label lblFontColor;
        private System.Windows.Forms.ColorDialog clrFont;
        private System.Windows.Forms.Label lblBackgroundColor;
        private System.Windows.Forms.ColorDialog clrBackground;
        private System.Windows.Forms.Button btnSaveAndQuit;
        private System.Windows.Forms.Button btnSettingsReset;
        private System.Windows.Forms.ComboBox cBoxFontSize;
        private System.Windows.Forms.ComboBox cBoxFont;
        private System.Windows.Forms.ComboBox cBoxBackgroundColor;
        private System.Windows.Forms.ComboBox cBoxTheme;
        private System.Windows.Forms.Label label1;
    }
}