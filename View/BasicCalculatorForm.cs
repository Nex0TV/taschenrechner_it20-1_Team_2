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
    public partial class Form1 : Form
    {
        public Form1()
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
            var r = new Regex("[+\\-*\\/]");
            if (tb_calculation.Text.Length == 0 // TODO: fix, that you can only put - at index 0
                && _operator == "-")
            {
                tb_calculation.Text = $"{_operator}";
            }
            else if (tb_calculation.Text.Length > 0
                && r.IsMatch(tb_calculation.Text[tb_calculation.Text.Length - 1].ToString()))
            {
                tb_calculation.Text = $"{tb_calculation.Text.Substring(0, tb_calculation.Text.Length - 1)}{_operator}";
            }
            else
            {
                tb_calculation.Text = $"{tb_calculation.Text} {_operator}";
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

        private void btn_calc_Click(object sender, EventArgs e)
        {
            var result = BasicCalculator.CalculateString(tb_calculation.Text);

            lbl_result.Text = $"{lbl_result.Text} {tb_calculation.Text} = {result}";
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
    }
}
