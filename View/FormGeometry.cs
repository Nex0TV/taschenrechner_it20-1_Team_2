using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
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

        private FormParametereingabe EingabeModul = new FormParametereingabe();
        private History History = new History();
        private void btnCircle_Click(object sender, EventArgs e)
        {
            this.lblGeometrischeForm.Text = "Kreis";

            EingabeModul.set_titel("Durchmesser");
            EingabeModul.ShowDialog();

            float durchmesser = float.Parse(EingabeModul.Parameter);

            float umfang = Geometrie.KreisUmfang(durchmesser);
            float flaeche = Geometrie.KreisFlaeche(durchmesser);

            History.SaveNewCount(umfang.ToString());
            History.SaveNewCount(flaeche.ToString());

            this.lblUmfang.Text = umfang.ToString();
            this.lblFlaeche.Text = flaeche.ToString();
        }

        private void btnTriangle_Click(object sender, EventArgs e)
        {
            this.lblGeometrischeForm.Text = "Dreieck";

            EingabeModul.set_titel("Seite A");
            EingabeModul.ShowDialog();

            float seiteA = float.Parse(EingabeModul.Parameter);

            EingabeModul.set_titel("Seite B");
            EingabeModul.ShowDialog();

            float seiteB = float.Parse(EingabeModul.Parameter);

            EingabeModul.set_titel("Seite C");
            EingabeModul.ShowDialog();

            float seiteC = float.Parse(EingabeModul.Parameter);

            EingabeModul.set_titel("Höhe C");
            EingabeModul.ShowDialog();

            float hoeheC = float.Parse(EingabeModul.Parameter);

            float umfang = Geometrie.DreieckUmfang(seiteA, seiteB, seiteC);
            float flaeche = Geometrie.DreieckFlaeche(seiteC, hoeheC);

            History.SaveNewCount(umfang.ToString());
            History.SaveNewCount(flaeche.ToString());

            this.lblUmfang.Text = umfang.ToString();
            this.lblFlaeche.Text = flaeche.ToString();
        }

        private void btnParallelogram_Click(object sender, EventArgs e)
        {
            this.lblGeometrischeForm.Text = "Parallelogramm";

            EingabeModul.set_titel("Seite A");
            EingabeModul.ShowDialog();

            float seiteA = float.Parse(EingabeModul.Parameter);

            EingabeModul.set_titel("Seite B");
            EingabeModul.ShowDialog();

            float seiteB = float.Parse(EingabeModul.Parameter);

            EingabeModul.set_titel("Höhe B");
            EingabeModul.ShowDialog();

            float hoeheB = float.Parse(EingabeModul.Parameter);

            float umfang = Geometrie.ParallelogrammUmfang(seiteA, seiteB);
            float flaeche = Geometrie.ParallelogrammFlaeche(seiteB, hoeheB);

            History.SaveNewCount(umfang.ToString());
            History.SaveNewCount(flaeche.ToString());

            this.lblUmfang.Text = umfang.ToString();
            this.lblFlaeche.Text = flaeche.ToString();
        }
    }
}
