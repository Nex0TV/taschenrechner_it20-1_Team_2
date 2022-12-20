using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Taschenrechner.Properties;

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
            Application.Run(new FormStart());
        }

        [NonSerialized]
        public static Dictionary<string, Color[]> themes = new Dictionary<string, Color[]>
        {
            {
                "System Standard", new [] {        // Theme Name
                    SystemColors.Control,          // Form Background
                    SystemColors.ControlText,      // Form Foreground (Label)
                    SystemColors.ControlLight,     // Button Background
                    SystemColors.ControlText       // Button Foreground
                } 
            },
            {
                "Theme Rot", new [] {
                    Color.DarkRed,
                    Color.White,
                    Color.MediumPurple,
                    Color.White
                }
            },
            {
                "Theme Grün", new [] { 
                    Color.LimeGreen, 
                    SystemColors.ControlText, 
                    Color.YellowGreen, 
                    SystemColors.ControlText 
                } 
            },
            {
                "Theme Blau", new [] { 
                    Color.RoyalBlue, 
                    Color.White, 
                    Color.DeepSkyBlue, 
                    SystemColors.ControlText 
                } 
            },
        };


        [NonSerialized]
        public static Dictionary<string, int> fontsizes = new Dictionary<string, int>
        {
            { "Klein", 8 },
            { "Mittel", 12 },
            { "Groß", 18 }
        };

        [NonSerialized]
        public static string[] fontkinds = new[]
        {
           "Arial",
           "Times New Roman",
           "Comic Sans MS"
        };


        // Standart Werte
        public static int Fontsize { get; set; } = fontsizes["Mittel"];
        public static string FontsizeText { get; set; } = "Mittel";
        public static string Fontkind { get; set; } = fontkinds[2];
        public static string Theme { get; set; } = "Theme Violet";

        public static Color BackgroundColor
        {
            get
            {
                return themes[Theme][0];
            }
        }
        public static Color ForegroundColor { get { return themes[Theme][1]; } }
        public static Color ButtonBackgroundColor { get { return themes[Theme][2]; } }
        public static Color ButtonForegroundColor { get { return themes[Theme][3]; } }

        //private static Settings instance;

        public static void ApplySettings(Form root)
        {
            //var allControls = Utils.GetAllControls(root);

            var controlls = Application.OpenForms;

            var buttons      = controlls.OfType<Button>();
            var tabPages     = controlls.OfType<TabPage>();
            var tableLayouts = controlls.OfType<TableLayoutPanel>();
            var comboBoxes   = controlls.OfType<ComboBox>();
            var textBoxes    = controlls.OfType<TextBox>();

            foreach (var btn in buttons)
            {
                btn.BackColor = ButtonBackgroundColor;
                btn.ForeColor = ButtonForegroundColor;
            }

            foreach (var tabPage in tabPages)
                tabPage.BackColor = BackgroundColor;

            foreach (var tableLayout in tableLayouts)
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
            root.Font      = new Font(Fontkind, Fontsize, FontStyle.Regular);
        }

        public static void saveSettings()
        {
            // save to config file
        }

        public static void loadSettings()
        {
            // get settings
            // change from void to something else
        }

        public 
    }
}
