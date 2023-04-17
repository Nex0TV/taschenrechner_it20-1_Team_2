using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taschenrechner.View
{
    public partial class FormParametereingabe : Form
    {
        private string result = "";

        public FormParametereingabe(string titel)
        {
            InitializeComponent();
            this.Text = titel;
        }

        private string btn_enter_Click(object sender, EventArgs e)
        {
            return this.tbox_result.Text;
        }

        public static string getValue(string title)
        {
            var self_form = new FormParametereingabe(title);
            self_form.Show();
            return ("");
        }
    }
}
