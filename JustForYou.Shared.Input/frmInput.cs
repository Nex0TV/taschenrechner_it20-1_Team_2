using System.Windows.Forms;

namespace JustForYou.Shared.Input
{
    public partial class frmInput : Form
    {
        public string inputedText = "";

        /// <summary>
        /// Initialize the form with all settings applied
        /// </summary>
        public frmInput()
        {
            InitializeComponent();
            var settings = Settings.Settings.GetInstance();
            settings.ApplySettings(this);
            LoadLanguage(settings.Language);
        }

        /// <summary>
        /// Load the current translations
        /// </summary>
        /// <param name="language"></param>
        private void LoadLanguage(string language)
        {
            if (language == "Englisch")
                btn_enter.Text = "Enter";
            else
                btn_enter.Text = "Eingabe";
        }

        /// <summary>
        /// Input the single buttons into the textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void inputText(object sender, System.EventArgs e)
        {
            tbx_input.Text += ((Button)sender).Text;
        }

        /// <summary>
        /// Enter the input and close the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void enterInput(object sender, System.EventArgs e)
        {
            inputedText = tbx_input.Text;
            Close();
        }

        /// <summary>
        /// Clear the inputed string
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clearInput(object sender, System.EventArgs e)
        {
            tbx_input.Text = "";
        }
    }
}
