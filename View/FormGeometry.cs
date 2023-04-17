using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Taschenrechner.Classes;
using Taschenrechner.View;


namespace Taschenrechner
{
    public partial class FormGeometry : Form
    {
        public FormGeometry()
        {
            InitializeComponent();
        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            var thread_formBasicCalc = new Task(new Action(() => Application.Run(new FormBasicCalculator())));
            thread_formBasicCalc.Start();
        }
    }
}
