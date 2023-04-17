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

        private FormParametereingabe EingabeModul = new FormParametereingabe();

        private void btnFactorial_Click(object sender, EventArgs e)
        {
            EingabeModul.set_titel("Fakultät");
            EingabeModul.ShowDialog();

            int result = Mathematik.Fakultaet(Convert.ToInt32(EingabeModul.Parameter));

            this.lblResultText.Text = "Fakultät:";
            this.lblResult.Text = result.ToString();
        }

        private void btnPower_Click(object sender, EventArgs e)
        {
            EingabeModul.set_titel("Zahl");
            EingabeModul.ShowDialog();

            double zahl = Convert.ToDouble(EingabeModul.Parameter);

            EingabeModul.set_titel("Exponent");
            EingabeModul.ShowDialog();

            int exponent = Convert.ToInt32(EingabeModul.Parameter);

            double result = Mathematik.Potenz(zahl, exponent);

            this.lblResultText.Text = "Potenz:";
            this.lblResult.Text = result.ToString();
        }

        private void btnPrimeNum_Click(object sender, EventArgs e)
        {
            EingabeModul.set_titel("Startzahl");
            EingabeModul.ShowDialog();

            int startzahl = Convert.ToInt32(EingabeModul.Parameter);

            EingabeModul.set_titel("Endzahl");
            EingabeModul.ShowDialog();

            int endzahl = Convert.ToInt32(EingabeModul.Parameter);


            int[] primzahlen = Mathematik.Primzahlen(startzahl, endzahl);

            this.lblResultText.Text = "Primzahlen";
            this.lblResult.Text = string.Join(", ", primzahlen);
        }

        private void btnSquareRoot_Click(object sender, EventArgs e)
        {
            EingabeModul.set_titel("Wurzel");
            EingabeModul.ShowDialog();

            double result = Mathematik.Wurzel(Convert.ToDouble(EingabeModul.Parameter));

            this.lblResultText.Text = "Wurzel:";
            this.lblResult.Text = result.ToString();
        }

        private void btnParseDecimalFraction_Click(object sender, EventArgs e)
        {
            EingabeModul.set_titel("Zahl");
            EingabeModul.ShowDialog();

            string result = Mathematik.ZahlZuBruch(Convert.ToDouble(EingabeModul.Parameter));

            this.lblResultText.Text = "Bruch:";
            this.lblResult.Text = result.ToString();
        }

        private void btnVulgarFraction_Click(object sender, EventArgs e)
        {
            EingabeModul.set_titel("Zähler");
            EingabeModul.ShowDialog();

            int zaehler = Convert.ToInt32(EingabeModul.Parameter);

            EingabeModul.set_titel("Nenner");
            EingabeModul.ShowDialog();

            int nenner= Convert.ToInt32(EingabeModul.Parameter);

            double result = Mathematik.Bruch(zaehler, nenner);

            this.lblResultText.Text = "Zahl:";
            this.lblResult.Text = result.ToString();
        }
    }
}
