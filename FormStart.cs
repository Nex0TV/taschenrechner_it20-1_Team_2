using System;
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
    public partial class FormStart : Form
    {
        public FormStart()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // grundrechenarten rechner öffnen
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            // einstellungs fenster öffnen
            FormSettings settings = new FormSettings();
            settings.ShowDialog();
        }
    }
}
