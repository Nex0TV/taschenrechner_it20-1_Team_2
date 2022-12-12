namespace JustForYou.Settings
{
    partial class frmSettings
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_fontsize = new System.Windows.Forms.Label();
            this.lbl_fontkind = new System.Windows.Forms.Label();
            this.lbl_colorscheme = new System.Windows.Forms.Label();
            this.lbl_language = new System.Windows.Forms.Label();
            this.btn_abort = new System.Windows.Forms.Button();
            this.btn_apply = new System.Windows.Forms.Button();
            this.cbx_fontsize = new System.Windows.Forms.ComboBox();
            this.cbx_fontkind = new System.Windows.Forms.ComboBox();
            this.cbx_colorscheme = new System.Windows.Forms.ComboBox();
            this.cbx_language = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btn_apply, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbl_fontsize, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_fontkind, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_colorscheme, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_language, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn_abort, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.cbx_fontsize, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbx_fontkind, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbx_colorscheme, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.cbx_language, 3, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 461);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lbl_fontsize
            // 
            this.lbl_fontsize.AutoSize = true;
            this.lbl_fontsize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_fontsize.Location = new System.Drawing.Point(3, 0);
            this.lbl_fontsize.Name = "lbl_fontsize";
            this.lbl_fontsize.Size = new System.Drawing.Size(190, 92);
            this.lbl_fontsize.TabIndex = 0;
            this.lbl_fontsize.Text = "Schriftgröße";
            this.lbl_fontsize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_fontkind
            // 
            this.lbl_fontkind.AutoSize = true;
            this.lbl_fontkind.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_fontkind.Location = new System.Drawing.Point(3, 92);
            this.lbl_fontkind.Name = "lbl_fontkind";
            this.lbl_fontkind.Size = new System.Drawing.Size(190, 92);
            this.lbl_fontkind.TabIndex = 0;
            this.lbl_fontkind.Text = "Schriftart";
            this.lbl_fontkind.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_colorscheme
            // 
            this.lbl_colorscheme.AutoSize = true;
            this.lbl_colorscheme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_colorscheme.Location = new System.Drawing.Point(3, 184);
            this.lbl_colorscheme.Name = "lbl_colorscheme";
            this.lbl_colorscheme.Size = new System.Drawing.Size(190, 92);
            this.lbl_colorscheme.TabIndex = 0;
            this.lbl_colorscheme.Text = "Farbschema";
            this.lbl_colorscheme.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_language
            // 
            this.lbl_language.AutoSize = true;
            this.lbl_language.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_language.Location = new System.Drawing.Point(3, 276);
            this.lbl_language.Name = "lbl_language";
            this.lbl_language.Size = new System.Drawing.Size(190, 92);
            this.lbl_language.TabIndex = 0;
            this.lbl_language.Text = "Sprache";
            this.lbl_language.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_abort
            // 
            this.btn_abort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_abort.Location = new System.Drawing.Point(199, 371);
            this.btn_abort.Name = "btn_abort";
            this.btn_abort.Size = new System.Drawing.Size(190, 87);
            this.btn_abort.TabIndex = 1;
            this.btn_abort.Text = "Abbrechen";
            this.btn_abort.UseVisualStyleBackColor = true;
            this.btn_abort.Click += new System.EventHandler(this.btn_abort_Click);
            // 
            // btn_apply
            // 
            this.btn_apply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_apply.Location = new System.Drawing.Point(395, 371);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(190, 87);
            this.btn_apply.TabIndex = 2;
            this.btn_apply.Text = "Speichern und schließen";
            this.btn_apply.UseVisualStyleBackColor = true;
            this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
            // 
            // cbx_fontsize
            // 
            this.cbx_fontsize.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbx_fontsize.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbx_fontsize.FormattingEnabled = true;
            this.cbx_fontsize.Location = new System.Drawing.Point(591, 35);
            this.cbx_fontsize.Name = "cbx_fontsize";
            this.cbx_fontsize.Size = new System.Drawing.Size(190, 21);
            this.cbx_fontsize.TabIndex = 3;
            this.cbx_fontsize.SelectedIndexChanged += new System.EventHandler(this.cbx_fontsize_SelectedIndexChanged);
            // 
            // cbx_fontkind
            // 
            this.cbx_fontkind.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbx_fontkind.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbx_fontkind.FormattingEnabled = true;
            this.cbx_fontkind.Location = new System.Drawing.Point(591, 127);
            this.cbx_fontkind.Name = "cbx_fontkind";
            this.cbx_fontkind.Size = new System.Drawing.Size(190, 21);
            this.cbx_fontkind.TabIndex = 4;
            this.cbx_fontkind.SelectedIndexChanged += new System.EventHandler(this.cbx_fontkind_SelectedIndexChanged);
            // 
            // cbx_colorscheme
            // 
            this.cbx_colorscheme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbx_colorscheme.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbx_colorscheme.FormattingEnabled = true;
            this.cbx_colorscheme.Location = new System.Drawing.Point(591, 219);
            this.cbx_colorscheme.Name = "cbx_colorscheme";
            this.cbx_colorscheme.Size = new System.Drawing.Size(190, 21);
            this.cbx_colorscheme.TabIndex = 5;
            this.cbx_colorscheme.SelectedIndexChanged += new System.EventHandler(this.cbx_colorscheme_SelectedIndexChanged);
            // 
            // cbx_language
            // 
            this.cbx_language.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbx_language.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbx_language.FormattingEnabled = true;
            this.cbx_language.Location = new System.Drawing.Point(591, 311);
            this.cbx_language.Name = "cbx_language";
            this.cbx_language.Size = new System.Drawing.Size(190, 21);
            this.cbx_language.TabIndex = 6;
            this.cbx_language.SelectedIndexChanged += new System.EventHandler(this.cbx_language_SelectedIndexChanged);
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(400, 250);
            this.Name = "frmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JustForYou";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbl_fontsize;
        private System.Windows.Forms.Label lbl_fontkind;
        private System.Windows.Forms.Label lbl_colorscheme;
        private System.Windows.Forms.Label lbl_language;
        private System.Windows.Forms.Button btn_apply;
        private System.Windows.Forms.Button btn_abort;
        private System.Windows.Forms.ComboBox cbx_fontsize;
        private System.Windows.Forms.ComboBox cbx_fontkind;
        private System.Windows.Forms.ComboBox cbx_colorscheme;
        private System.Windows.Forms.ComboBox cbx_language;
    }
}

