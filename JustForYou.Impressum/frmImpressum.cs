using System;
using System.Windows.Forms;

namespace JustForYou.Impressum
{
    public partial class frmImpressum : Form
    {
        /// <summary>
        /// Initialize the form with all settings applied
        /// </summary>
        public frmImpressum()
        {
            InitializeComponent();
            var settings = Settings.Settings.GetInstance();
            settings.ApplySettings(this);
            FillTextBox(settings.Language);
        }

        /// <summary>
        /// Fill text box with translated legal notes
        /// </summary>
        /// <param name="language"></param>
        private void FillTextBox(string language)
        {
            if (language == "Englisch")
            {
                tbx_impressum.Text = "ABC GmbH" + Environment.NewLine
                + "" + Environment.NewLine                                                         
                + "Strehlener Pl. 2" + Environment.NewLine
                + "01219 Dresden" + Environment.NewLine + "" + Environment.NewLine
                + "Commercial Register: HRA 187420" + Environment.NewLine
                + "District Court Dresden" + Environment.NewLine
                + "UST-ID: DE420360187" + Environment.NewLine
                + "" + Environment.NewLine                                                          
                + "Represented by the personally liable partner" + Environment.NewLine
                + "ABC Beteiligungs GmbH" + Environment.NewLine
                + "Strehlener Pl. 2" + Environment.NewLine
                + "01219 Dresden" + Environment.NewLine
                + "" + Environment.NewLine                                                          
                + "Commercial Register: HRB 360187" + Environment.NewLine
                + "District Court Dresden" + Environment.NewLine
                + "" + Environment.NewLine                                                         
                + "CEOs: Pascal Hönisch, Jonathan Schüßler, Oliver Stein, Sven Strehle, Nick Jansky";
            }
            else
            {
                tbx_impressum.Text = "ABC GmbH" + Environment.NewLine
                + "" + Environment.NewLine
                + "Strehlener Pl. 2" + Environment.NewLine
                + "01219 Dresden" + Environment.NewLine + "" + Environment.NewLine
                + "Handelsregister: HRA 187420" + Environment.NewLine
                + "Amtsgericht Dresden" + Environment.NewLine
                + "UST-ID: DE420360187" + Environment.NewLine
                + "" + Environment.NewLine
                + "Vertreten durch einen öffentlichen Gesellschafter" + Environment.NewLine
                + "ABC Beteiligungs GmbH" + Environment.NewLine
                + "Strehlener Pl. 2" + Environment.NewLine
                + "01219 Dresden" + Environment.NewLine
                + "" + Environment.NewLine
                + "Handelsregister: HRB 360187" + Environment.NewLine
                + "Amtsgericht Dresden" + Environment.NewLine
                + "" + Environment.NewLine
                + "Geschäftsführer: Pascal Hönisch, Jonathan Schüßler, Oliver Stein, Sven Strehle, Nick Jansky";
            }
        }
    }
}
