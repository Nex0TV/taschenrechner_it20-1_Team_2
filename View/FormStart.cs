using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
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
            InitializeHistory();
            InitializeWatcher();
        }

        private void InitializeHistory()
        {
            var history = LogHistory.GetHistory();

            lstBoxHistory.Items.Clear();
            foreach (string calculation in history)
            {
                lstBoxHistory.Items.Add(calculation);
            }
        }

        public delegate void InitDelegate();

        private void InitializeWatcher()
        {
            FileSystemWatcher Watcher = new FileSystemWatcher();
            Watcher.Path = Path.GetDirectoryName("./");
            Watcher.Filter = Path.GetFileName(LogHistory.filename);
            Watcher.NotifyFilter = NotifyFilters.LastWrite;
            Watcher.Changed += OnChanged;

            Watcher.EnableRaisingEvents = true;
        }

        private void OnChanged(object sender, FileSystemEventArgs e)
        {
            this.BeginInvoke(new ThreadStart(InitializeHistory));
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
