using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Taschenrechner.Model;

namespace Taschenrechner.View
{
    public partial class BasicCalculator : Form
    {
        public BasicCalculator()
        {
            InitializeComponent();
        }

        private void add_num(string num)
        {
            var r = new Regex("[0-9]|[(]");
            if (tb_calculation.Text.Length > 0
                && r.IsMatch(tb_calculation.Text[tb_calculation.Text.Length - 1].ToString()))
            {
                tb_calculation.Text = $"{tb_calculation.Text}{num}";
            }
            else
            {
                tb_calculation.Text = $"{tb_calculation.Text} {num}";
            }
        }

        private void add_operator(string _operator)
        {
            var r_operator = new Regex("[+\\-*\\/]");
            var r_operator_pos0 = new Regex("^[+\\-*\\/]");
            //if (tb_calculation.Text.Length == 0 // set minus sign at start for negative value
            //    && _operator == "-")
            //{
            //    tb_calculation.Text = $"{_operator}";
            //}
            if (r_operator_pos0.IsMatch(tb_calculation.Text) // skip if first character is a minus
                && tb_calculation.Text.Length == 1)
            {
                
            }
            else if (tb_calculation.Text.Length > 0
                && r_operator.IsMatch(tb_calculation.Text[tb_calculation.Text.Length - 1].ToString())) // replace last operator if at last position
            {
                tb_calculation.Text = $"{tb_calculation.Text.Substring(0, tb_calculation.Text.Length - 1)}{_operator}";
            }
            else if (tb_calculation.Text.Length > 0) // set operator
            {
                tb_calculation.Text = $"{tb_calculation.Text} {_operator}";
            }
        }

        private void add_bracket(char bracket)
        {
            if (bracket == '(')
            {
                tb_calculation.Text = $"{tb_calculation.Text} (";
            } else
            {
                tb_calculation.Text = $"{tb_calculation.Text})";
            }
        }

        //
        // NUMBERS
        //
        private void btn_1_Click(object sender, EventArgs e)
        {
            add_num("1");
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            add_num("2");
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            add_num("3");
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            add_num("4");
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            add_num("5");
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            add_num("6");
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            add_num("7");
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            add_num("8");
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            add_num("9");
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            add_num("0");
        }

        private void btn_calc_Click(object sender, EventArgs e)
        {
            var result = Model.BasicCalculator.CalculateString(tb_calculation.Text);

            lbl_result.Text = $"Ergebnis: {tb_calculation.Text} = {result}";
        }

        //
        // OPERATORS
        //
        private void btn_add_Click(object sender, EventArgs e)
        {
            add_operator("+");
        }

        private void btn_sub_Click(object sender, EventArgs e)
        {
            add_operator("-");
        }

        private void btn_mul_Click(object sender, EventArgs e)
        {
            add_operator("*");
        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            add_operator("/");
        }

        private void btn_undo_Click(object sender, EventArgs e)
        {
            if (tb_calculation.Text.Length == 0) return;

            string text = del_1_character(tb_calculation.Text);
            while (text.Length > 1
                && text[text.Length - 1] == ' ')
            {
                text = del_1_character(tb_calculation.Text);
                tb_calculation.Text = text;
            }
            tb_calculation.Text = text;
        }

        private static string del_1_character(string text)
        {
            return $"{text.Substring(0, text.Length - 1)}";
        }

        private void btn_open_bracket_Click(object sender, EventArgs e)
        {
            add_bracket('(');
        }

        private void btn_close_bracket_Click(object sender, EventArgs e)
        {
            add_bracket(')');
        }

        private void btn_sign_click(object sender, EventArgs e)
        {

        }
    }
}
