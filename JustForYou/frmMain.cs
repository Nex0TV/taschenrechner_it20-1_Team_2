
using JustForYou.Branch.BasicCalculator;
using JustForYou.Impressum;
using JustForYou.Settings;
using System.Linq;
using System.Windows.Forms;

namespace JustForYou
{
    public partial class frmMain : Form
    {
        /// <summary>
        /// Initialize the mainForm on load with all settings applied
        /// </summary>
        public frmMain()
        {
            InitializeComponent();
            Settings.Settings.GetInstance().ApplySettings(this);
            LoadLanguage(Settings.Settings.GetInstance().Language);
        }

        /// <summary>
        /// Open the settings panel on the click of the settings-picture
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pic_settings_Click(object sender, System.EventArgs e)
        {
            new frmSettings().ShowDialog();
            Settings.Settings.GetInstance().ApplySettings(this);
            LoadLanguage(Settings.Settings.GetInstance().Language);
        }

        /// <summary>
        /// Loads the translations of the current language and sets them
        /// </summary>
        /// <param name="language"></param>
        private void LoadLanguage(string language)
        {
            if (language == "Englisch")
            {
                lbl_welcome.Text = "Welcome to JustForYou";
                lbl_latestCalcs.Text = "Your latest calculations:";
                btn_basicCalculator.Text = "Basic Calculator";
                btn_CreditCalculation.Text = "Credit Calculator";
                btn_Geometrie.Text = "Geometry";
                btn_IT.Text = "IT";
                btn_MathematcialFunctions.Text = "Mathematical Functions";
                btn_PercentCalculation.Text = "Percent Calculation";
                btn_School.Text = "School";
            }
            else
            {
                lbl_welcome.Text = "Willkommen bei JustForYou";
                lbl_latestCalcs.Text = "Ihre letzten Berechnungen:";
                btn_basicCalculator.Text = "Grundrechner";
                btn_CreditCalculation.Text = "Kreditrechnung";
                btn_Geometrie.Text = "Geometrie";
                btn_IT.Text = "Informationstechnik";
                btn_MathematcialFunctions.Text = "Mathematische Funktionen";
                btn_PercentCalculation.Text = "Prozentrechnung";
                btn_School.Text = "Schule";
            }
        }

        /// <summary>
        /// Navigate to the impressum
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pic_impressum_Click(object sender, System.EventArgs e)
        {
            new frmImpressum().ShowDialog();
        }

        /// <summary>
        /// Open the basic calculator and sync the history after closing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_basicCalculator_Click(object sender, System.EventArgs e)
        {
            var basicCalculator = new frmBasicCalculator();
            basicCalculator.ShowDialog();

            var newHistory = tbt_latest.Lines.ToList();
            newHistory.AddRange(basicCalculator.calcHistory);
            tbt_latest.Lines = newHistory.ToArray();
        }
    }
}
