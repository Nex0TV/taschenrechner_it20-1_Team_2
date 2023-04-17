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
    public partial class FormSchoolMark : Form
    {
        public FormSchoolMark()
        {
            InitializeComponent();
        }

        private FormParametereingabe EingabeModul = new FormParametereingabe();

        private void btnAverageMark_Click(object sender, EventArgs e)
        {
            EingabeModul.set_titel("Noten");
            EingabeModul.ShowDialog();

            int[] noten = new int[0];

            foreach (string str in EingabeModul.Parameter.Split('.'))
            {
                if(int.TryParse(str, out int number))
                {
                    Array.Resize(ref noten, noten.Length + 1);
                    noten[noten.Length - 1] = int.Parse(str);
                }
            };

            noten = Schule.ValidierteNoten(noten);
            int anzahl = Schule.Anzahl(noten);
            float durchschnitt = Schule.Durchschnitt(noten);
            int note = Schule.Note(durchschnitt);

            this.lblResultDurchschnitt.Text = durchschnitt.ToString();
            this.lblResultEmpfehlung.Text = note.ToString();
            this.lblResultAnzahl.Text = anzahl.ToString();
        }
    }
}
