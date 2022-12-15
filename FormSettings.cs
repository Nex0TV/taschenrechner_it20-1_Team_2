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
            // Set default font to small
            cBoxFontSize.SelectedIndex = 0;
        }

        private void btnFontColor_Click(object sender, EventArgs e)
        {
            ColorDialog DialogFontColor = new ColorDialog();
            // Keeps the user from selecting a custom color.
            DialogFontColor.AllowFullOpen = false;
            // Allows the user to get help. (The default is false.)
            DialogFontColor.ShowHelp = true;
            // Sets the initial color select to the current text color.
            DialogFontColor.Color = btnFontColor.ForeColor;

            // Update the text box color if the user clicks OK 
            if (DialogFontColor.ShowDialog() == DialogResult.OK) 
            {
                var fColor = DialogFontColor.Color;
                Console.WriteLine(fColor);
            }
        }

        private void btnBackgroundColor_Click(object sender, EventArgs e)
        {
            ColorDialog DialogBackgroundColor = new ColorDialog();
            // Keeps the user from selecting a custom color.
            DialogBackgroundColor.AllowFullOpen = false;
            // Allows the user to get help. (The default is false.)
            DialogBackgroundColor.ShowHelp = true;
            // Sets the initial color select to the current text color.
            DialogBackgroundColor.Color = btnBackgroundColor.ForeColor;

            // Update the text box color if the user clicks OK 
            if (DialogBackgroundColor.ShowDialog() == DialogResult.OK)
            {
                var bgColor = DialogBackgroundColor.Color;
                
                Console.WriteLine(bgColor);

                
            }
        }

        private void btnSettingsReset_Click(object sender, EventArgs e)
        {
            // set options back to default 
        }
    }
}
