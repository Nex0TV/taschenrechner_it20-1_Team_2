using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Taschenrechner.View;

namespace Taschenrechner
{
    internal static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var thread_formBasicCalc = new Task(new Action(() => Application.Run(new FormBasicCalculator())));
            //var thread_formStart = new Task(new Action(() => Application.Run(new FormStart())));
            thread_formBasicCalc.Start();
            Application.Run(new FormStart());
            //thread_formStart.Start();
        }
    }
}
