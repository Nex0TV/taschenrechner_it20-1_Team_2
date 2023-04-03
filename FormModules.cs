using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Taschenrechner
{
    public partial class FormModules : Form
    {
        public FormModules()
        {
            InitializeComponent();
        }

        private void MathCalc_Click(object sender, EventArgs e)
        {
            FormMath mathCalc = new FormMath();
            var thread = new Task(new Action( () => OpenWindow(mathCalc)));
            thread.Start();
            this.Close();
        }

        private void OpenWindow(Form Window)
        {   
            Window.ShowDialog();
        }

        private void percentageCalc_Click(object sender, EventArgs e)
        {
            FormPercentageCalc percentageCalc = new FormPercentageCalc();
            var thread = new Task(new Action(() => OpenWindow(percentageCalc)));
            thread.Start();
            this.Close();  
        }

        private void gemeotryCalc_Click(object sender, EventArgs e)
        {
            FormGeometry geometry = new FormGeometry();
            var thread = new Task(new Action(() => OpenWindow(geometry)));
            thread.Start();
            this.Close();
        }

        private void schoolMarkCalc_Click(object sender, EventArgs e)
        {
            FormSchoolMark schoolMark = new FormSchoolMark();
            var thread = new Task(new Action(() => OpenWindow(schoolMark)));
            thread.Start();
            this.Close();
        }

        private void informationTechCalc_Click(object sender, EventArgs e)
        {
            FormInfoTech InfoTech = new FormInfoTech();
            var thread = new Task(new Action(() => OpenWindow(InfoTech)));
            thread.Start();
            this.Close();
        }

        private void loanCalc_Click(object sender, EventArgs e)
        {
            FormLoanCalc LoanCalc = new FormLoanCalc();
            var thread = new Task(new Action(() => OpenWindow(LoanCalc)));
            thread.Start();
            this.Close();
        }
    }
}
