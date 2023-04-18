using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Taschenrechner.Classes
{
    public class History
    {
        private List<string> LogHistory;
        public string filename = "loghistory.txt";

        public History()
        { 
            LogHistory = GetHistory();
        }

        /// <summary>
        /// saves new calculation
        /// </summary>
        /// <param name="calculation">string to save</param>
        /// <returns>void</returns>
        public void SaveNewCount(string calculation)
        {
            string timestamp = DateTime.Now.ToString();
            string result = timestamp + " - " + calculation;

            LogHistory.Add(result);

            using (StreamWriter writer = new StreamWriter(filename, true))
            {
                writer.WriteLine(result);
            }
        }

        /// <summary>
        /// get latest calculation list
        /// </summary>
        /// <param name="count">how many latest lines show</param>
        /// <returns>List</returns>
        public List<string> GetHistory(int count = 30)
        {
            List<string> history = new List<string>();

            try
            {
                string[] lines = File.ReadAllLines(filename);

                for (int i = lines.Length - 1; i >= 0 && history.Count < count; i--)
                {
                    if (!string.IsNullOrWhiteSpace(lines[i]))
                    {
                        history.Add(lines[i]);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error reading login history file: " + ex.Message);
            }

            return history;
        }
    }
}
