using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Taschenrechner.Classes
{
    public class History
    {
        private byte[] key = {
            0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08,
            0x09, 0x10, 0x11, 0x12, 0x13, 0x14, 0x15, 0x16
        };
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

            /*using (FileStream fileStream = new FileStream(filename, FileMode.OpenOrCreate))
            {
                using (Aes aes = Aes.Create())
                {
                    aes.Key = key;
                    byte[] iv = aes.IV;
                    fileStream.Write(iv, 0, iv.Length);

                    using (CryptoStream cryptoStream = new CryptoStream(fileStream, aes.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        using (StreamWriter encryptedStream = new StreamWriter(cryptoStream))
                        {
                            encryptedStream.WriteLine(result);
                        }
                    }
                }
            }*/

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

                /*string[] lines = new string[0];

                using (FileStream fileStream = new FileStream(filename, FileMode.Open))
                {
                    using (Aes aes = Aes.Create())
                    {
                        byte[] iv = new byte[aes.IV.Length];
                        int numBytesToRead = aes.IV.Length;
                        int numBytesRead = 0;
                        while (numBytesToRead > 0)
                        {
                            int n = fileStream.Read(iv, numBytesRead, numBytesToRead);
                            if (n == 0) break;

                            numBytesRead += n;
                            numBytesToRead += n;
                        }

                        using (CryptoStream cryptoStream = new CryptoStream(fileStream, aes.CreateDecryptor(key, iv), CryptoStreamMode.Read))
                        {
                            using (StreamReader decryptedStream = new StreamReader(cryptoStream))
                            {
                                while (lines.Length != decryptedStream.Read())
                                {
                                    history.Add(decryptedStream.ReadLine());
                                }
                            }
                        }
                    }
                }*/
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error reading login history file: " + ex.Message);
            }

            return history;
        }
    }
}
