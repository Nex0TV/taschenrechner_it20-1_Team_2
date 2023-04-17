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
using Taschenrechner.Classes;

namespace Taschenrechner
{
    public partial class FormMath : Form
    {
        public FormMath()
        {
            InitializeComponent();
        }

        private void btnFactorial_Click(object sender, EventArgs e)
        {
            var formParametereingabe = new FormParametereingabe("Falkutät");
            formParametereingabe.ShowDialog();
            this.lblResult.Text += formParametereingabe.Parameter;
        }
    }
}
