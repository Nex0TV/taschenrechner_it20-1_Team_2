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
        public static string CalculateString(string input)
        {
            int opening_pos = -1;
            int closing_pos;
            closing_pos = input.IndexOf(")");
            if (closing_pos != -1)
            {
                opening_pos = input.Substring(0, closing_pos).LastIndexOf("(");
            }
            // Calculate the bracktes:
            if (closing_pos != -1)
            {
                var substring = input.Substring(opening_pos + 1, closing_pos - opening_pos - 1);
                var result2 = CalculateWithoutBrackets(substring);
                input = input.Substring(0, opening_pos) + result2 + input.Substring(closing_pos + 1, input.Length - closing_pos - 1);
                input = CalculateString(input);
            }
            // Calculate outside the bracktes:
            input = CalculateWithoutBrackets(input).ToString();
            return input;
        }

        public static double CalculateWithoutBrackets(string input)
        {
            double result = 0.0;
            var point_operators = "*/";
            var dash_operators = "+-";
            var numbers = new List<string>(input.Split(' '));
            if (numbers.Count == 1) return Convert.ToDouble(input);
            result = CalculateList(result, point_operators, numbers); // the list "numbers" is modified during the process
            result = CalculateList(result, dash_operators, numbers);
            return result;
        }

        /// <summary>
        /// Finds the given operatoes in a string and calculates the number before and after it together.
        /// You should call this method twice to do points calculations before dash calculations.
        /// </summary>
        /// <param name="result">If you got a result before.</param>
        /// <param name="operators">String containing the operators.</param>
        /// <param name="numbers">List of numbers, it will be manipulated during the process.</param>
        /// <returns></returns>
        public static double CalculateList(double result, string operators, List<string> numbers)
        {
            foreach (char _operator in operators)
            {
                while (numbers.FindIndex(x => x.Equals(_operator.ToString())) != -1)
                {
                    var i = numbers.IndexOf(_operator.ToString()); // TODO: support negative numbers
                    switch (_operator)
                    {
                        case '*':
                            result = Convert.ToDouble(numbers[i - 1]) * Convert.ToDouble(numbers[i + 1]);
                            break;
                        case '/':
                            result = Convert.ToDouble(numbers[i - 1]) / Convert.ToDouble(numbers[i + 1]);
                            break;
                        case '+':
                            result = Convert.ToDouble(numbers[i - 1]) + Convert.ToDouble(numbers[i + 1]);
                            break;
                        case '-':
                            result = Convert.ToDouble(numbers[i - 1]) - Convert.ToDouble(numbers[i + 1]);
                            break;
                    }

                    numbers[i - 1] = result.ToString(); // replace first operator with result
                    numbers.RemoveAt(i); // remove arithmetic sign
                    numbers.RemoveAt(i); // remove second operator
                }
            }

            return result;
        }

    }
}
