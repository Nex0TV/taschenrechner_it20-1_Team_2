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

namespace Taschenrechner
{
    public partial class FormStart : Form
    {
        private History LogHistory;

        public FormStart()
        {
            LogHistory = new History();

            InitializeComponent();
            initializeHistory();
        }

        private void initializeHistory()
        {
            var history = LogHistory.GetHistory();

            lstBoxHistory.Items.Clear();
            foreach (string calculation in history)
            {
                lstBoxHistory.Items.Add(calculation);
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            FormModules modules = new FormModules();
            modules.ShowDialog();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            // einstellungs fenster öffnen
            FormSettings settings = new FormSettings();
            settings.ShowDialog();
        }
    }
}
