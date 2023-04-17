using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Taschenrechner.View;

namespace Taschenrechner.View
{
    public partial class FormParametereingabe : Form
    {
        public string Parameter;
        public FormParametereingabe(string titel)
        {
            InitializeComponent();
            this.Text = titel;
        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            Parameter = this.tbox_result.Text;
            Close();
        }

        private void add_character(object sender)
        {
            Button btn = (Button)sender;
            this.tbox_result.Text += btn.Text;
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            add_character(sender);
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            add_character(sender);
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            add_character(sender);
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            add_character(sender);
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            add_character(sender);
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            add_character(sender);
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            add_character(sender);
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            add_character(sender);
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            add_character(sender);
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            add_character(sender);
        }

        private void btn_dot_Click(object sender, EventArgs e)
        {
            add_character(sender);
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            if (this.tbox_result.Text.Length > 0)
            {
                this.tbox_result.Text = this.tbox_result.Text.Substring(0, this.tbox_result.Text.Length - 1);
            }
        }

        private void btn_nebenrechnung_Click(object sender, EventArgs e)
        {

        }
    }
}
