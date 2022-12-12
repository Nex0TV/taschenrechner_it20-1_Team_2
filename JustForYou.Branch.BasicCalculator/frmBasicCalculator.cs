using JustForYou.Shared.Input;
using JustForYou.Shared.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace JustForYou.Branch.BasicCalculator
{
    public partial class frmBasicCalculator : Form, IBranchModule
    {
        /// <summary>
        /// History of all done calculations in this module
        /// </summary>
        public List<string> calcHistory = new List<string>();

        private DataTable _table = new DataTable();

        /// <summary>
        /// Initialize the form with translations
        /// </summary>
        public frmBasicCalculator()
        {
            InitializeComponent();
            var settings = Settings.Settings.GetInstance();
            settings.ApplySettings(this);
            LoadLanguage(settings.Language);
        }

        /// <summary>
        /// Load the language settings
        /// </summary>
        /// <param name="language"></param>
        public void LoadLanguage(string language)
        {
            if (language == "Englisch")
            {
                lbl_input.Text = "Input";
                lbl_result.Text = "Result";
                btn_calc.Text = "Calculate";
                btn_close.Text = "Close";
            }
            else
            {
                lbl_input.Text = "Eingabe";
                lbl_result.Text = "Ergebnis";
                btn_calc.Text = "Berechnen";
                btn_close.Text = "Schließen";
            }
        }

        /// <summary>
        /// Open the input module once the textbox gets clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbx_calc_Click(object sender, EventArgs e)
        {
            var inputModule = new frmInput();
            inputModule.ShowDialog();
            tbx_calc.Text = inputModule.inputedText;
        }

        /// <summary>
        /// Close the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Calculate the given formula
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_calc_Click(object sender, EventArgs e)
        {
            var result = _table.Compute(tbx_calc.Text, "");
            tbx_result.Text = result.ToString();
            calcHistory.Add($"BasicCalculator: Folgende Rechnung: {tbx_calc.Text} hat folgendes Ergebnis gegeben: {result}");
        }
    }
}
