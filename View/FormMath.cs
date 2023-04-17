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
            //var Eingabe = new FormParametereingabe("Fakultät");
            //var thread_formParam = new Task(new Action(() => Application.Run(Eingabe)));
            //thread_formParam.Start();
            //Eingbe.getResult();
            var test = FormParametereingabe.getValue("Falkultät");
            Console.WriteLine(test);
        }
    }
}
