namespace JustForYou.Branch.BasicCalculator
{
    partial class frmBasicCalculator
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
            this.tbx_calc = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_close = new System.Windows.Forms.Button();
            this.tbx_result = new System.Windows.Forms.TextBox();
            this.lbl_result = new System.Windows.Forms.Label();
            this.lbl_input = new System.Windows.Forms.Label();
            this.btn_calc = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbx_calc
            // 
            this.tbx_calc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbx_calc.Location = new System.Drawing.Point(403, 5);
            this.tbx_calc.Name = "tbx_calc";
            this.tbx_calc.Size = new System.Drawing.Size(394, 20);
            this.tbx_calc.TabIndex = 0;
            this.tbx_calc.Click += new System.EventHandler(this.tbx_calc_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btn_close, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbx_result, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_result, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbx_calc, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_input, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_calc, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 104);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btn_close
            // 
            this.btn_close.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_close.Location = new System.Drawing.Point(3, 65);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(394, 36);
            this.btn_close.TabIndex = 5;
            this.btn_close.Text = "Schließen";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // tbx_result
            // 
            this.tbx_result.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbx_result.Location = new System.Drawing.Point(403, 36);
            this.tbx_result.Name = "tbx_result";
            this.tbx_result.ReadOnly = true;
            this.tbx_result.Size = new System.Drawing.Size(394, 20);
            this.tbx_result.TabIndex = 3;
            // 
            // lbl_result
            // 
            this.lbl_result.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_result.AutoSize = true;
            this.lbl_result.Location = new System.Drawing.Point(176, 40);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(48, 13);
            this.lbl_result.TabIndex = 2;
            this.lbl_result.Text = "Ergebnis";
            // 
            // lbl_input
            // 
            this.lbl_input.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_input.AutoSize = true;
            this.lbl_input.Location = new System.Drawing.Point(170, 9);
            this.lbl_input.Name = "lbl_input";
            this.lbl_input.Size = new System.Drawing.Size(60, 13);
            this.lbl_input.TabIndex = 1;
            this.lbl_input.Text = "Rechnung:";
            // 
            // btn_calc
            // 
            this.btn_calc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_calc.Location = new System.Drawing.Point(403, 65);
            this.btn_calc.Name = "btn_calc";
            this.btn_calc.Size = new System.Drawing.Size(394, 36);
            this.btn_calc.TabIndex = 4;
            this.btn_calc.Text = "Berechnen";
            this.btn_calc.UseVisualStyleBackColor = true;
            this.btn_calc.Click += new System.EventHandler(this.btn_calc_Click);
            // 
            // frmBasicCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 104);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmBasicCalculator";
            this.Text = "JustForYou";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_calc;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbl_input;
        private System.Windows.Forms.TextBox tbx_result;
        private System.Windows.Forms.Label lbl_result;
        private System.Windows.Forms.Button btn_calc;
        private System.Windows.Forms.Button btn_close;
    }
}

