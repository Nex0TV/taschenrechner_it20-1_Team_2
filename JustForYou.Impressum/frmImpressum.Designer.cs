namespace JustForYou.Impressum
{
    partial class frmImpressum
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbx_impressum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbx_impressum
            // 
            this.tbx_impressum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbx_impressum.Location = new System.Drawing.Point(0, 0);
            this.tbx_impressum.Multiline = true;
            this.tbx_impressum.Name = "tbx_impressum";
            this.tbx_impressum.ReadOnly = true;
            this.tbx_impressum.Size = new System.Drawing.Size(784, 461);
            this.tbx_impressum.TabIndex = 0;
            // 
            // frmImpressum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.tbx_impressum);
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(400, 250);
            this.Name = "frmImpressum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JustForYou";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_impressum;
    }
}

