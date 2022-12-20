using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace Taschenrechner
{
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();

            InitializeForm();

            // Set default font to small
            cBoxFontSize.SelectedIndex = 0;
        }

        private void InitializeForm()
        {
            // Insert availible themes
            foreach (string key in Program.themes.Keys)
                cBoxTheme.Items.Add(key);

            // Insert availible font sizes
            foreach (string key in Program.fontsizes.Keys)
                cBoxFontSize.Items.Add(key);

            // Insert availible themes
            foreach (string key in Program.fontkinds)
                cBoxFont.Items.Add(key);

            // Insert availible themes
            foreach (string key in Program.BackgroundColor)
                cBoxTheme.Items.Add(key);
        }


        private void cBoxFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            // text color
        }

        private void cBoxBackgroundColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            // background color
        }

        private void cBoxTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            // change theme
        }

        private void btnSettingsReset_Click(object sender, EventArgs e)
        {
            // set options back to default
        }

        private void btnSaveAndQuit_Click(object sender, EventArgs e)
        {
            // saves and exits 
        }
    }
}
