using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner.Model
{
    public class BasicCalculator
    {
        public static string parseCalculationInput(string inputValue)
        {
           for (int i = 0; double.Parse(inputValue) > 0; i++)
            {
                char[] delimiter = { };

                inputValue.Replace(" ", "");



                // input has values with dot?
                if (inputValue.IndexOf(".") >= 1)
                {
                    // replace them with a comma
                    inputValue = inputValue.Replace(".", ",");
                }
            }

            return inputValue;
        }


        public static double Calculate (string value)
        {
            double result = 0;
            
            char[] delimiterChars = { '+', '-', '*', '/' };

            string[] splitValues = parseCalculationInput(value).Split(delimiterChars);

            

            // check if given delimitier if basic calculation is possible
            for (int i = 0; i < splitValues.Length; i++)
            {
                Console.WriteLine(splitValues[i]);
                //return result;
            }

            // initialize necessary variables to calculate
            //double result = 0;

            //Convert.ToDouble(value));

            return result;
        }
    }
}
