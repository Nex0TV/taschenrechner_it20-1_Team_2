using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taschenrechner.Classes;

namespace Taschenrechner.Classes
{
    /// <summary>
    /// Contains Classes for different 
    /// </summary>
    /// 
    public static class InformationTechnology
    {
        public static class NumberSystem
        {
            /// <summary>
            /// Converts a number into an array with each digit.
            /// </summary>
            /// <param name="num">Number which will be converted.</param>
            /// <param name="currentBase">Base of the number that is converted.</param>
            /// <returns></returns>
            private static int[] GetIntArray(int num, int currentBase)
            {
                List<int> listOfInts = new List<int>();
                while (num > 0)
                {
                    listOfInts.Add(num % currentBase);
                    num /= currentBase;
                }
                listOfInts.Reverse();
                return listOfInts.ToArray();
            }

            /// <summary>
            /// Converts a number from a basis to another basis.
            /// </summary>
            /// <param name="number">Number to be converted.</param>
            /// <param name="currentBase">Number basis of the number being converted.</param>
            /// <param name="resultBase">Result number basis after the conversion.</param>
            /// <returns></returns>

            public static int Convert(int number, int currentBase, int resultBase)
            {
                int decimalBaseNumber = ConvertToDecimal(number, currentBase);

                int resultNumber = ConvertToLowerBase(decimalBaseNumber, resultBase);

                (new History()).SaveNewCount(resultNumber.ToString());

                return resultNumber;
            }
            /// <summary>
            /// Converts a number from base 10 to a lower base.
            /// </summary>
            /// <param name="number">Number to be converted.</param>
            /// <param name="resultBase">Result number base, which is lower in value than base of 'number'.</param>
            /// <returns>int: Converted number</returns>
            private static int ConvertToLowerBase(int number, int resultBase)
            {
                var result = "";
                while (number > 0)
                {
                    int remainder = number % resultBase;
                    number /= resultBase;
                    result = $"{result}{remainder}";
                }
                // Reverse the digit order
                var charArray = result.ToCharArray();
                Array.Reverse(charArray);
                return System.Convert.ToInt32(new String(charArray));
            }
            /// <summary>
            /// Converts a number from a base to a higher base.
            /// </summary>
            /// <param name="number">Number to be converted.</param>
            /// <param name="currentBase"></param>
            /// <returns></returns>
            private static int ConvertToDecimal(int number, int currentBase)
            { // to decimal
                var intArray = GetIntArray(number, 10);
                double result = 0;
                for(int i = 0; i < number.ToString().Length; i++)
                {
                    int reverseDigitCount = number.ToString().Length - i - 1;
                    result += intArray[i] * Mathematik.Potenz(System.Convert.ToDouble(currentBase),  reverseDigitCount);
                }
                return System.Convert.ToInt32(result);
            }
        }

        public static class VideoSizeCalculator
        {
            public static double Calculate(
                int fps,
                int videoLength,
                int imageSize,
                int colorDepth = 0,
                int channels = 0,
                int width = 0,
                int height = 0
                )
            {
                if (imageSize == 0)
                {
                    imageSize = colorDepth * channels * width * height;
                }

                var videoSize = imageSize * fps * videoLength;

                (new History()).SaveNewCount(videoSize.ToString());

                return videoSize;
            }
        }

        public class PrefixCalculator
        {
            private static double Calculate(
                double number,
                bool toLower = false,
                bool binary = false,
                int iterations = 0
                )
            {
                // string toPrefix = useStartPrefix ? this.StartPrefix : this.ResultPrefix;
                double divider = binary ? 1024 : 1_000;
                for (var i = 0; i < iterations; i++)
                {
                    if (toLower)
                    {
                        number *= divider;
                    }
                    else
                    {
                        number /= divider;
                    }
                }

                (new History()).SaveNewCount(number.ToString());

                return number;
            }

            /// <summary>
            /// Converts binary/decimal prefixes.
            /// </summary>
            /// <param name="number">Number to convert from</param>
            /// <param name="startPrefix">The Prefix of the number that will be convertert e.g. MiB</param>
            /// <param name="resultPrefix">The Prefix of the number to convert to e.g. GB</param>
            public static string Convert(double number, string startPrefix, string resultPrefix)
            {
                var binary = BinaryPrefixes.ContainsKey(startPrefix);
                double result;
                double numWithoutPrefix;
                // Convert to non prefix
                if (binary)
                {
                    int iterations = BinaryPrefixes[startPrefix];
                    numWithoutPrefix = ToLowerBinaryPrefix(number, iterations);
                }
                else
                {
                    int iterations = DecimalPrefixes[startPrefix];
                    numWithoutPrefix = ToLowerDecimalPrefix(number, iterations);
                }

                // Convert to the resultPrefix
                if (DecimalPrefixes.ContainsKey(resultPrefix))
                {
                    int iterations = DecimalPrefixes[resultPrefix];
                    result = ToHigherDecimalPrefix(numWithoutPrefix, iterations);
                }
                else
                {
                    int iterations = BinaryPrefixes[resultPrefix];
                    result = ToHigherBinaryPrefix(numWithoutPrefix, iterations);
                }

                (new History()).SaveNewCount(result.ToString());


                return $"{result} {resultPrefix}";
            }

            private static double ToHigherBinaryPrefix(double number, int iterations)
            {
                return Calculate(number, toLower: false, binary: true, iterations: iterations);
            }

            private static double ToLowerBinaryPrefix(double number, int iterations)
            {
                return Calculate(number, toLower: true, binary: true, iterations: iterations);
            }

            private static double ToHigherDecimalPrefix(double number, int iterations)
            {
                return Calculate(number, toLower: false, binary: false, iterations: iterations);
            }

            private static double ToLowerDecimalPrefix(double number, int iterations)
            {
                return Calculate(number, toLower: true, binary: false, iterations: iterations);
            }

            private static readonly Dictionary<string, int> BinaryPrefixes = new Dictionary<string, int>
            {
                { "B",   0 },
                { "KiB", 1 },
                { "MiB", 2 },
                { "GiB", 3 },
                { "TiB", 4 },
                { "PiB", 5 },
            };
            private readonly static Dictionary<string, int> DecimalPrefixes = new Dictionary<string, int>
            {
                { "B",  0 },
                { "KB", 1 },
                { "MB", 2 },
                { "GB", 3 },
                { "TB", 4 },
                { "PB", 5 },
            };
        }
    }
}
