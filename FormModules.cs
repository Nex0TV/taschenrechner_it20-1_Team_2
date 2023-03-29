﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            mathCalc.ShowDialog();
        }

        private void percentageCalc_Click(object sender, EventArgs e)
        {
            FormPercentageCalc percentageCalc = new FormPercentageCalc();
            percentageCalc.ShowDialog();
        }

        private void gemeotryCalc_Click(object sender, EventArgs e)
        {
            FormGeometry geometry = new FormGeometry();
            geometry.ShowDialog();
        }

        private void schoolMarkCalc_Click(object sender, EventArgs e)
        {
            FormSchoolMark schoolMark = new FormSchoolMark();
            schoolMark.ShowDialog();
        }

        private void informationTechCalc_Click(object sender, EventArgs e)
        {
            FormInfoTech InfoTech = new FormInfoTech();
            InfoTech.ShowDialog();
        }

        private void loanCalc_Click(object sender, EventArgs e)
        {

        }
    }
}