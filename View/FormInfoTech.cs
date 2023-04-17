using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Taschenrechner.Classes;

namespace Taschenrechner
{
    public partial class FormInfoTech : Form
    {
        private List<string> binary_prefixes = new List<string>()
        {
            "B",
            "KiB",
            "MiB",
            "GiB",
            "TiB",
            "PiB",
        };
        private List<string> decimal_prefixes = new List<string>()
        {
            "B",
            "KB",
            "MB",
            "GB",
            "TB",
            "PB",
        };
        public FormInfoTech()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            var startValue = tBox_number.Text;
            var startPrefix = cBox_prefixes.Text;
            var resultPrefix = cBox_resultPrefix.Text;

            if (startValue == ""
                | startPrefix == ""
                | resultPrefix == "")
            {
                MessageBox.Show("Bitte alle Felder ausfüllen!");
                return;
            }
            else
            {
                var number = Convert.ToDouble(startValue);
                var result = InformationTechnology.PrefixCalculator.Convert(number, startPrefix, resultPrefix);
                lbl_result.Text = result.ToString();
            }
        }

        private void btnCalcVideoSize_Click(object sender, EventArgs e)
        {
            var fpsStr = tBoxFPS.Text;
            var videoLengthStr = tBoxLength.Text;
            var imageSizeStr = tBoxSize.Text;

            if (fpsStr == ""
                | videoLengthStr == ""
                | imageSizeStr == "")
            {
                MessageBox.Show("Bitte alle Felder ausfüllen!");
                return;
            }
            else
            {
                var fps = Convert.ToInt32(fpsStr);
                var videoLength = Convert.ToInt32(videoLengthStr);
                var imageSize = Convert.ToInt32(imageSizeStr);
                
                var result = InformationTechnology.VideoSizeCalculator.Calculate(fps, videoLength, imageSize);
                lblVideoSize.Text = result.ToString();
            }
        }

        private void btnCalcNumberSystem_Click(object sender, EventArgs e)
        {
            var numberStr = tBoxStartNumber.Text;
            var startNumberSystemStr = cBoxStartSystem.Text;
            var resultNumberSystemStr = cBoxEndSystem.Text;

            if (numberStr == ""
                | startNumberSystemStr == ""
                | resultNumberSystemStr == "")
            {
                MessageBox.Show("Bitte alle Felder ausfüllen!");
                return;
            }
            else
            {
                var number = Convert.ToInt32(numberStr);
                var startNumberSystem = Convert.ToInt32(startNumberSystemStr);
                var resultNumberSystem = Convert.ToInt32(resultNumberSystemStr);

                var result = InformationTechnology.NumberSystem.Convert(number, startNumberSystem, resultNumberSystem);
                lblNumberSystemResult.Text = result.ToString();
            }
        }
    }
}
