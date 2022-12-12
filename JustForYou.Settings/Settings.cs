using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using JustForYou.Shared.Utils;

namespace JustForYou.Settings
{
    /// <summary>
    /// Class for managing the settings for users
    /// </summary>
    [Serializable]
    public class Settings
    {
        [NonSerialized]
        public static Dictionary<string, Color[]> themes = new Dictionary<string, Color[]>
        {
            // ------------------------- Form Background --- Form Foreground (Label) --- Button Background --- Button Foreground
            {"System Standard", new [] { SystemColors.Control, SystemColors.ControlText, SystemColors.ControlLight, SystemColors.ControlText } },
            {"Theme Grün", new [] { Color.LimeGreen, SystemColors.ControlText, Color.YellowGreen, SystemColors.ControlText } },
            {"Theme Blau", new [] { Color.RoyalBlue, Color.White, Color.DeepSkyBlue, SystemColors.ControlText } },
            {"Theme Violet", new [] { Color.DarkViolet, Color.White, Color.MediumPurple, Color.White } }
        };

        [NonSerialized]
        public static Dictionary<string, int> fontsizes = new Dictionary<string, int>
        {
            { "Klein", 8 },
            { "Mittel", 12 },
            { "Groß", 16 }
        };

        [NonSerialized]
        public static string[] fontkinds = new[]
        {
           "Arial",
           "Times New Roman",
           "Comic Sans MS"
        };

        [NonSerialized]
        public static string[] languages = new[]
        {
            "Deutsch",
            "Englisch"
        };

        // Standard-Settings
        public int Fontsize { get; set; } = fontsizes["Mittel"];
        public string FontsizeText { get; set; } = "Mittel";
        public string Fontkind { get; set; } = fontkinds[2];
        public string Theme { get; set; } = "Theme Violet";
        public Color BackgroundColor
        {
            get
            {
                return themes[Theme][0];
            }
        }
        public Color ForegroundColor { get { return themes[Theme][1]; } }
        public Color ButtonBackgroundColor { get { return themes[Theme][2]; } }
        public Color ButtonForegroundColor { get { return themes[Theme][3]; } }
        public string Language { get; set; } = languages[0];

        private static Settings instance;

        /// <summary>
        /// Get an instance of the settings class with its loaded settings
        /// </summary>
        /// <returns>An instance of <see cref="JustForYou.Settings.Settings">Settings</see></returns>
        public static Settings GetInstance()
        {
            if (instance == null)
                instance = LoadInstance();

            return instance;
        }

        /// <summary>
        /// Load the current settings from the settings file or create it if it doesn't exist
        /// </summary>
        /// <returns>An instance of <see cref="JustForYou.Settings.Settings">Settings</see></returns>
        private static Settings LoadInstance()
        {
            if (!File.Exists(@"Settings.cfg"))
                new Settings().SaveSettings();

            Settings settings = null;

            try
            {
                var stream = new FileStream(@"Settings.cfg", FileMode.Open, FileAccess.Read);
                var formatter = new BinaryFormatter();
                settings = (Settings)formatter.Deserialize(stream);
                stream.Close();
            }
            catch
            {
                MessageBox.Show($"Einstellungen konnten nicht geladen werden.{Environment.NewLine}Es werden deshalb die Standard-Einstellungen verwendet!", "Fehler beim laden der Einstellungen", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (settings == null)
            {
                settings = new Settings();
                settings.SaveSettings();
            }

            return settings;
        }

        /// <summary>
        /// Save the current settings to a file
        /// </summary>
        public void SaveSettings()
        {
            var stream = new FileStream(@"Settings.cfg", FileMode.Create, FileAccess.Write);
            var formatter = new BinaryFormatter();
            formatter.Serialize(stream, this);
            stream.Close();
        }

        /// <summary>
        /// Apply the current selected settings to every control on the form
        /// </summary>
        /// <param name="root">The main form from which is operated</param>
        public void ApplySettings(Form root)
        {
            var allControls = Utils.GetAllControls(root);
            var buttons = allControls.OfType<Button>();
            var tabPages = allControls.OfType<TabPage>();
            var tableLayouts = allControls.OfType<TableLayoutPanel>();
            var comboBoxes = allControls.OfType<ComboBox>();
            var textBoxes = allControls.OfType<TextBox>();

            foreach (var btn in buttons)
            {
                btn.BackColor = ButtonBackgroundColor;
                btn.ForeColor = ButtonForegroundColor;
            }

            foreach(var tabPage in tabPages)
                tabPage.BackColor = BackgroundColor;

            foreach(var tableLayout in tableLayouts)
            {
                tableLayout.BackColor = BackgroundColor;
                tableLayout.ForeColor = ForegroundColor;
            }

            foreach (var comboBox in comboBoxes)
            {
                comboBox.BackColor = ButtonBackgroundColor;
                comboBox.ForeColor = ButtonForegroundColor;
            }

            foreach (var textBox in textBoxes)
            {
                textBox.BackColor = ButtonBackgroundColor;
                textBox.ForeColor = ButtonForegroundColor;
            }

            root.ForeColor = ForegroundColor;
            root.BackColor = BackgroundColor;
            root.Font = new Font(Fontkind, Fontsize, FontStyle.Regular);
        }
    }
}
