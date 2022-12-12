using System;
using System.Windows.Forms;

namespace JustForYou.Settings
{
    public partial class frmSettings : Form
    {
        private string backupTheme;
        private string backupFontkind;
        private int backupFontsize;
        private string backupFontsizeText;
        private string backupLanguage;

        public frmSettings()
        {
            InitializeComponent();
            InitializeForm();
        }

        /// <summary>
        /// Initialize the Form and fill it with all its data
        /// </summary>
        private void InitializeForm()
        {
            foreach (string key in Settings.themes.Keys)
                cbx_colorscheme.Items.Add(key);

            foreach (string key in Settings.fontsizes.Keys)
                cbx_fontsize.Items.Add(key);

            foreach (string key in Settings.fontkinds)
                cbx_fontkind.Items.Add(key);

            foreach (string key in Settings.languages)
                cbx_language.Items.Add(key);

            var settings = Settings.GetInstance();

            cbx_language.SelectedIndex = cbx_language.Items.IndexOf(settings.Language);
            cbx_colorscheme.SelectedIndex = cbx_colorscheme.Items.IndexOf(settings.Theme);
            cbx_fontsize.SelectedIndex = cbx_fontsize.Items.IndexOf(settings.FontsizeText);
            cbx_fontkind.SelectedIndex = cbx_fontkind.Items.IndexOf(settings.Fontkind);

            settings.ApplySettings(this);

            LoadLanguage(settings.Language);

            // Save current settings to restore them if needed;
            backupTheme = settings.Theme;
            backupFontkind = settings.Fontkind;
            backupFontsize = settings.Fontsize;
            backupFontsizeText = settings.FontsizeText;
            backupLanguage = settings.Language;
        }

        /// <summary>
        /// Apply the settings and save them
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_apply_Click(object sender, EventArgs e)
        {
            var settings = Settings.GetInstance();

            if (settings != null)
            {
                settings.Language = cbx_language.Text;
                settings.SaveSettings();
            }

            Close();
        }

        /// <summary>
        /// Restore the backup settings
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_abort_Click(object sender, EventArgs e)
        {
            var settings = Settings.GetInstance();

            if (settings != null)
            {
                settings.Theme = backupTheme;
                settings.Fontkind = backupFontkind;
                settings.Fontsize = backupFontsize;
                settings.FontsizeText = backupFontsizeText;
                settings.Language = backupLanguage;
                settings.ApplySettings(this);

                LoadLanguage(settings.Language);

                Close();
            }
        }

        /// <summary>
        /// Change the fontsize in the settings
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbx_fontsize_SelectedIndexChanged(object sender, EventArgs e)
        {
            var settings = Settings.GetInstance();
            settings.FontsizeText = cbx_fontsize.SelectedItem.ToString();

            switch (cbx_fontsize.SelectedItem.ToString())
            {
                case "Klein": settings.Fontsize = 8; break;
                case "Mittel": settings.Fontsize = 12; break;
                case "Groß": settings.Fontsize = 16; break;
            }

            settings.ApplySettings(this);
        }

        /// <summary>
        /// Change the fontkind in the settings
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbx_fontkind_SelectedIndexChanged(object sender, EventArgs e)
        {
            var settings = Settings.GetInstance();
            settings.Fontkind = cbx_fontkind.SelectedItem.ToString();
            settings.ApplySettings(this);
        }

        /// <summary>
        /// Change the color scheme in the settings
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbx_colorscheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            var settings = Settings.GetInstance();
            settings.Theme = cbx_colorscheme.SelectedItem.ToString();
            settings.ApplySettings(this);
        }

        /// <summary>
        /// Change the language in the settings and load other translations
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbx_language_SelectedIndexChanged(object sender, EventArgs e)
        {
            var settings = Settings.GetInstance();
            settings.Language = cbx_language.SelectedItem.ToString();
            settings.ApplySettings(this);
            LoadLanguage(settings.Language);
        }

        /// <summary>
        /// Loads the translations of the current language and sets them
        /// </summary>
        /// <param name="language"></param>
        private void LoadLanguage(string language)
        {
            if (language == "Englisch")
            {
                lbl_fontsize.Text = "Fontsize";
                lbl_fontkind.Text = "Fontkind";
                lbl_colorscheme.Text = "Colorscheme";
                lbl_language.Text = "Language";
                btn_abort.Text = "Abort";
                btn_apply.Text = "Save and Close";
            }
            else
            {
                lbl_fontsize.Text = "Schriftgröße";
                lbl_fontkind.Text = "Schriftart";
                lbl_colorscheme.Text = "Farbschema";
                lbl_language.Text = "Sprache";
                btn_abort.Text = "Abbrechen";
                btn_apply.Text = "Speichern und Schließen";
            }
        }
    }
}
