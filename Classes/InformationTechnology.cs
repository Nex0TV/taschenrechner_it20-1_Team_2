﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner.Classes
{
    /// <summary>
    /// Contains Classes for different 
    /// </summary>
    /// 
    public class InformationTechnology
    {
        public static class NumberSystemConverter
        {
            public static int[] GetIntArray(int num, int baseNum)
            {
                List<int> listOfInts = new List<int>();
                while (num > 0)
                {
                    listOfInts.Add(num % baseNum);
                    num /= baseNum;
                }
                listOfInts.Reverse();
                return listOfInts.ToArray();
            }

            public static string ConvertNumber(int number, int currentBase, int resultBase)
            { 
                if (currentBase < resultBase)
                {
                    var result = 0.0;
                    var intArray = GetIntArray(number, resultBase);
                    var numberString = number.ToString();
                    for (int i = 0; i < intArray.Length; i++)
                    {
                        Int32 digitValue = intArray[i];
                        double digitValueDec = digitValue * Mathematik.Potenz(currentBase, (numberString.Length - i - 1));
                        result += digitValueDec;
                    }
                    return result.ToString();
                }
                else
                {
                    var result = "";
                    while (number > 0)
                    {
                        int remainder = number % resultBase;
                        number = number / resultBase;
                        result = $"{result}{remainder}";
                    }
                    var charArray = result.ToCharArray();
                    Array.Reverse(charArray);
                    return new String(charArray);
                }
            }
        }

        public static class VideoSizeCalculator
        {
            public static double CalculateVideoSize(int colorDepth = 0,
                                                    int channels = 0,
                                                    int width = 0,
                                                    int height = 0,
                                                    int fps = 0,
                                                    int videoLength = 0,
                                                    int imageSize = 0
                )
            {
                if (imageSize == 0)
                {
                    imageSize = colorDepth * channels * width * height;
                }
                return imageSize * fps * videoLength;
            }
        }

        public class PrefixCalculator
        {
            private static double Calculate(double number,
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
                { "kB", 1 },
                { "MB", 2 },
                { "GB", 3 },
                { "TB", 4 },
                { "PB", 5 },
            };
        }
    }
}
