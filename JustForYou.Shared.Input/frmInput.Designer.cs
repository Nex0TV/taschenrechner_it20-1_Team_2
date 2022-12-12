namespace JustForYou.Shared.Input
{
    partial class frmInput
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
            this.tbl_calc = new System.Windows.Forms.TableLayoutPanel();
            this.btn_enter = new System.Windows.Forms.Button();
            this.btn_decimal = new System.Windows.Forms.Button();
            this.btn_zero = new System.Windows.Forms.Button();
            this.btn_negate = new System.Windows.Forms.Button();
            this.btn_plus = new System.Windows.Forms.Button();
            this.btn_one = new System.Windows.Forms.Button();
            this.btn_two = new System.Windows.Forms.Button();
            this.btn_three = new System.Windows.Forms.Button();
            this.btn_minus = new System.Windows.Forms.Button();
            this.btn_six = new System.Windows.Forms.Button();
            this.btn_five = new System.Windows.Forms.Button();
            this.btn_four = new System.Windows.Forms.Button();
            this.btn_multiply = new System.Windows.Forms.Button();
            this.btn_nine = new System.Windows.Forms.Button();
            this.btn_eight = new System.Windows.Forms.Button();
            this.btn_seven = new System.Windows.Forms.Button();
            this.btn_divide = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_closeBracket = new System.Windows.Forms.Button();
            this.btn_openBracket = new System.Windows.Forms.Button();
            this.tbx_input = new System.Windows.Forms.TextBox();
            this.tbl_calc.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbl_calc
            // 
            this.tbl_calc.ColumnCount = 4;
            this.tbl_calc.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbl_calc.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbl_calc.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbl_calc.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbl_calc.Controls.Add(this.btn_enter, 3, 5);
            this.tbl_calc.Controls.Add(this.btn_decimal, 2, 5);
            this.tbl_calc.Controls.Add(this.btn_zero, 1, 5);
            this.tbl_calc.Controls.Add(this.btn_negate, 0, 5);
            this.tbl_calc.Controls.Add(this.btn_plus, 3, 4);
            this.tbl_calc.Controls.Add(this.btn_one, 2, 4);
            this.tbl_calc.Controls.Add(this.btn_two, 1, 4);
            this.tbl_calc.Controls.Add(this.btn_three, 0, 4);
            this.tbl_calc.Controls.Add(this.btn_minus, 3, 3);
            this.tbl_calc.Controls.Add(this.btn_six, 2, 3);
            this.tbl_calc.Controls.Add(this.btn_five, 1, 3);
            this.tbl_calc.Controls.Add(this.btn_four, 0, 3);
            this.tbl_calc.Controls.Add(this.btn_multiply, 3, 2);
            this.tbl_calc.Controls.Add(this.btn_nine, 2, 2);
            this.tbl_calc.Controls.Add(this.btn_eight, 1, 2);
            this.tbl_calc.Controls.Add(this.btn_seven, 0, 2);
            this.tbl_calc.Controls.Add(this.btn_divide, 3, 1);
            this.tbl_calc.Controls.Add(this.btn_reset, 2, 1);
            this.tbl_calc.Controls.Add(this.btn_closeBracket, 1, 1);
            this.tbl_calc.Controls.Add(this.btn_openBracket, 0, 1);
            this.tbl_calc.Controls.Add(this.tbx_input, 0, 0);
            this.tbl_calc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbl_calc.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tbl_calc.Location = new System.Drawing.Point(0, 0);
            this.tbl_calc.Name = "tbl_calc";
            this.tbl_calc.RowCount = 6;
            this.tbl_calc.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.195297F));
            this.tbl_calc.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.96094F));
            this.tbl_calc.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.96094F));
            this.tbl_calc.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.96094F));
            this.tbl_calc.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.96094F));
            this.tbl_calc.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.96094F));
            this.tbl_calc.Size = new System.Drawing.Size(784, 461);
            this.tbl_calc.TabIndex = 0;
            // 
            // btn_enter
            // 
            this.btn_enter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_enter.Location = new System.Drawing.Point(591, 374);
            this.btn_enter.Name = "btn_enter";
            this.btn_enter.Size = new System.Drawing.Size(190, 84);
            this.btn_enter.TabIndex = 23;
            this.btn_enter.Text = "Eingabe";
            this.btn_enter.UseVisualStyleBackColor = true;
            this.btn_enter.Click += new System.EventHandler(this.enterInput);
            // 
            // btn_decimal
            // 
            this.btn_decimal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_decimal.Location = new System.Drawing.Point(395, 374);
            this.btn_decimal.Name = "btn_decimal";
            this.btn_decimal.Size = new System.Drawing.Size(190, 84);
            this.btn_decimal.TabIndex = 22;
            this.btn_decimal.Text = ",";
            this.btn_decimal.UseVisualStyleBackColor = true;
            this.btn_decimal.Click += new System.EventHandler(this.inputText);
            // 
            // btn_zero
            // 
            this.btn_zero.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_zero.Location = new System.Drawing.Point(199, 374);
            this.btn_zero.Name = "btn_zero";
            this.btn_zero.Size = new System.Drawing.Size(190, 84);
            this.btn_zero.TabIndex = 21;
            this.btn_zero.Text = "0";
            this.btn_zero.UseVisualStyleBackColor = true;
            this.btn_zero.Click += new System.EventHandler(this.inputText);
            // 
            // btn_negate
            // 
            this.btn_negate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_negate.Location = new System.Drawing.Point(3, 374);
            this.btn_negate.Name = "btn_negate";
            this.btn_negate.Size = new System.Drawing.Size(190, 84);
            this.btn_negate.TabIndex = 20;
            this.btn_negate.Text = "+/-";
            this.btn_negate.UseVisualStyleBackColor = true;
            this.btn_negate.Click += new System.EventHandler(this.inputText);
            // 
            // btn_plus
            // 
            this.btn_plus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_plus.Location = new System.Drawing.Point(591, 287);
            this.btn_plus.Name = "btn_plus";
            this.btn_plus.Size = new System.Drawing.Size(190, 81);
            this.btn_plus.TabIndex = 19;
            this.btn_plus.Text = "+";
            this.btn_plus.UseVisualStyleBackColor = true;
            this.btn_plus.Click += new System.EventHandler(this.inputText);
            // 
            // btn_one
            // 
            this.btn_one.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_one.Location = new System.Drawing.Point(395, 287);
            this.btn_one.Name = "btn_one";
            this.btn_one.Size = new System.Drawing.Size(190, 81);
            this.btn_one.TabIndex = 18;
            this.btn_one.Text = "1";
            this.btn_one.UseVisualStyleBackColor = true;
            this.btn_one.Click += new System.EventHandler(this.inputText);
            // 
            // btn_two
            // 
            this.btn_two.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_two.Location = new System.Drawing.Point(199, 287);
            this.btn_two.Name = "btn_two";
            this.btn_two.Size = new System.Drawing.Size(190, 81);
            this.btn_two.TabIndex = 17;
            this.btn_two.Text = "2";
            this.btn_two.UseVisualStyleBackColor = true;
            this.btn_two.Click += new System.EventHandler(this.inputText);
            // 
            // btn_three
            // 
            this.btn_three.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_three.Location = new System.Drawing.Point(3, 287);
            this.btn_three.Name = "btn_three";
            this.btn_three.Size = new System.Drawing.Size(190, 81);
            this.btn_three.TabIndex = 16;
            this.btn_three.Text = "3";
            this.btn_three.UseVisualStyleBackColor = true;
            this.btn_three.Click += new System.EventHandler(this.inputText);
            // 
            // btn_minus
            // 
            this.btn_minus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_minus.Location = new System.Drawing.Point(591, 200);
            this.btn_minus.Name = "btn_minus";
            this.btn_minus.Size = new System.Drawing.Size(190, 81);
            this.btn_minus.TabIndex = 15;
            this.btn_minus.Text = "-";
            this.btn_minus.UseVisualStyleBackColor = true;
            this.btn_minus.Click += new System.EventHandler(this.inputText);
            // 
            // btn_six
            // 
            this.btn_six.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_six.Location = new System.Drawing.Point(395, 200);
            this.btn_six.Name = "btn_six";
            this.btn_six.Size = new System.Drawing.Size(190, 81);
            this.btn_six.TabIndex = 14;
            this.btn_six.Text = "6";
            this.btn_six.UseVisualStyleBackColor = true;
            this.btn_six.Click += new System.EventHandler(this.inputText);
            // 
            // btn_five
            // 
            this.btn_five.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_five.Location = new System.Drawing.Point(199, 200);
            this.btn_five.Name = "btn_five";
            this.btn_five.Size = new System.Drawing.Size(190, 81);
            this.btn_five.TabIndex = 13;
            this.btn_five.Text = "5";
            this.btn_five.UseVisualStyleBackColor = true;
            this.btn_five.Click += new System.EventHandler(this.inputText);
            // 
            // btn_four
            // 
            this.btn_four.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_four.Location = new System.Drawing.Point(3, 200);
            this.btn_four.Name = "btn_four";
            this.btn_four.Size = new System.Drawing.Size(190, 81);
            this.btn_four.TabIndex = 12;
            this.btn_four.Text = "4";
            this.btn_four.UseVisualStyleBackColor = true;
            this.btn_four.Click += new System.EventHandler(this.inputText);
            // 
            // btn_multiply
            // 
            this.btn_multiply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_multiply.Location = new System.Drawing.Point(591, 113);
            this.btn_multiply.Name = "btn_multiply";
            this.btn_multiply.Size = new System.Drawing.Size(190, 81);
            this.btn_multiply.TabIndex = 11;
            this.btn_multiply.Text = "*";
            this.btn_multiply.UseVisualStyleBackColor = true;
            this.btn_multiply.Click += new System.EventHandler(this.inputText);
            // 
            // btn_nine
            // 
            this.btn_nine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_nine.Location = new System.Drawing.Point(395, 113);
            this.btn_nine.Name = "btn_nine";
            this.btn_nine.Size = new System.Drawing.Size(190, 81);
            this.btn_nine.TabIndex = 10;
            this.btn_nine.Text = "9";
            this.btn_nine.UseVisualStyleBackColor = true;
            this.btn_nine.Click += new System.EventHandler(this.inputText);
            // 
            // btn_eight
            // 
            this.btn_eight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_eight.Location = new System.Drawing.Point(199, 113);
            this.btn_eight.Name = "btn_eight";
            this.btn_eight.Size = new System.Drawing.Size(190, 81);
            this.btn_eight.TabIndex = 9;
            this.btn_eight.Text = "8";
            this.btn_eight.UseVisualStyleBackColor = true;
            this.btn_eight.Click += new System.EventHandler(this.inputText);
            // 
            // btn_seven
            // 
            this.btn_seven.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_seven.Location = new System.Drawing.Point(3, 113);
            this.btn_seven.Name = "btn_seven";
            this.btn_seven.Size = new System.Drawing.Size(190, 81);
            this.btn_seven.TabIndex = 8;
            this.btn_seven.Text = "7";
            this.btn_seven.UseVisualStyleBackColor = true;
            this.btn_seven.Click += new System.EventHandler(this.inputText);
            // 
            // btn_divide
            // 
            this.btn_divide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_divide.Location = new System.Drawing.Point(591, 26);
            this.btn_divide.Name = "btn_divide";
            this.btn_divide.Size = new System.Drawing.Size(190, 81);
            this.btn_divide.TabIndex = 7;
            this.btn_divide.Text = "/";
            this.btn_divide.UseVisualStyleBackColor = true;
            this.btn_divide.Click += new System.EventHandler(this.inputText);
            // 
            // btn_reset
            // 
            this.btn_reset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_reset.Location = new System.Drawing.Point(395, 26);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(190, 81);
            this.btn_reset.TabIndex = 6;
            this.btn_reset.Text = "C";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.clearInput);
            // 
            // btn_closeBracket
            // 
            this.btn_closeBracket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_closeBracket.Location = new System.Drawing.Point(199, 26);
            this.btn_closeBracket.Name = "btn_closeBracket";
            this.btn_closeBracket.Size = new System.Drawing.Size(190, 81);
            this.btn_closeBracket.TabIndex = 5;
            this.btn_closeBracket.Text = ")";
            this.btn_closeBracket.UseVisualStyleBackColor = true;
            this.btn_closeBracket.Click += new System.EventHandler(this.inputText);
            // 
            // btn_openBracket
            // 
            this.btn_openBracket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_openBracket.Location = new System.Drawing.Point(3, 26);
            this.btn_openBracket.Name = "btn_openBracket";
            this.btn_openBracket.Size = new System.Drawing.Size(190, 81);
            this.btn_openBracket.TabIndex = 4;
            this.btn_openBracket.Text = "(";
            this.btn_openBracket.UseVisualStyleBackColor = true;
            this.btn_openBracket.Click += new System.EventHandler(this.inputText);
            // 
            // tbx_input
            // 
            this.tbl_calc.SetColumnSpan(this.tbx_input, 4);
            this.tbx_input.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbx_input.Location = new System.Drawing.Point(3, 3);
            this.tbx_input.Name = "tbx_input";
            this.tbx_input.ReadOnly = true;
            this.tbx_input.Size = new System.Drawing.Size(778, 20);
            this.tbx_input.TabIndex = 24;
            // 
            // frmInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.tbl_calc);
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(400, 250);
            this.Name = "frmInput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JustForYou";
            this.tbl_calc.ResumeLayout(false);
            this.tbl_calc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tbl_calc;
        private System.Windows.Forms.Button btn_enter;
        private System.Windows.Forms.Button btn_decimal;
        private System.Windows.Forms.Button btn_zero;
        private System.Windows.Forms.Button btn_negate;
        private System.Windows.Forms.Button btn_plus;
        private System.Windows.Forms.Button btn_one;
        private System.Windows.Forms.Button btn_two;
        private System.Windows.Forms.Button btn_three;
        private System.Windows.Forms.Button btn_minus;
        private System.Windows.Forms.Button btn_six;
        private System.Windows.Forms.Button btn_five;
        private System.Windows.Forms.Button btn_four;
        private System.Windows.Forms.Button btn_multiply;
        private System.Windows.Forms.Button btn_nine;
        private System.Windows.Forms.Button btn_eight;
        private System.Windows.Forms.Button btn_seven;
        private System.Windows.Forms.Button btn_divide;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_closeBracket;
        private System.Windows.Forms.Button btn_openBracket;
        private System.Windows.Forms.TextBox tbx_input;
    }
}

