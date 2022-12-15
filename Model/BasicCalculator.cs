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
            bool isBracket = false;
            var subtotalBrackets = new double[100];
            double[] subtotalPoints = { };
            double[] subtotalLines = { };

            char[] delimiterChars = { '+', '-', '*', '/' };


            int count = 0;

            string res = "";

            // input has values with dot?
            if (inputValue.IndexOf(".") >= 1)
            {
                // replace them with a comma
                inputValue = inputValue.Replace(".", ",");
            }


            for (int i = 0; i < inputValue.Length; i++)
            {
                if (inputValue[i] == '(')
                {
                    isBracket = true;
                    continue;  
                }

                if (isBracket)
                {
                    if (res.IndexOfAny(delimiterChars) >= 2)
                    {
                        res += inputValue[i];
                    }


                }

                if (inputValue[i] == ')')
                {
                    isBracket = false;
                    continue;
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
