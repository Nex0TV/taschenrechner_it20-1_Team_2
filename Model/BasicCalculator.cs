using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Taschenrechner.Model
{
    public class BasicCalculator
    {
        public static string parseCalculationInput(string inputValue)
        {
            bool isBracket = false;

            string[] currentResult = new string[] { };

            double[] subtotalBrackets = new double[100];
            double[] subtotalPoints = { };
            double[] subtotalLines = { };

            char[] delimiterChars = { '+', '-', '*', '/' };

            var regex = @"([*+/\-)(])|([0-9,0-9]+)";

            var count = 0;

            // dot is set? replace with comma
            inputValue = inputValue.Replace(".", ",");

            foreach (var match in Regex.Matches(inputValue, regex))
            {
                currentResult = new List<string>(currentResult) { match.ToString() }.ToArray();
            }


            for (var i = 0; i < currentResult.Length; i++)
            {
                Console.WriteLine(currentResult[i]);
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

        public static string get_calculations(string input)
        {
            var result = 0.0;
            var opening_pos = 0;
            var closing_pos = 0;
            closing_pos = input.IndexOf(")");
            opening_pos = input.Substring(0, closing_pos).LastIndexOf("(");
            
            while (opening_pos != -1)
            {
                var substring = input.Substring(opening_pos + 1, closing_pos - opening_pos - 1);
                var result2 = BasicCalculator.calculate_point(substring);
                input = input.Substring(0, opening_pos) + result2 + input.Substring(closing_pos, input.Length - closing_pos);
            }

            return input;
        }

        public static double calculate_point(string input)
        {
            var result = 0.0;
            var numbers = new List<string>(input.Split(' '));
            while (numbers.FindIndex(x => x.Equals("*")) == -1)
            {
                var i = input.IndexOf("*");
                result = input[i - 1] * input[i + 1];
                numbers = numbers // TODO: Berechnung Punkt (*, /) und danach + und -
            }
            
            return result;
        }
    }
}
