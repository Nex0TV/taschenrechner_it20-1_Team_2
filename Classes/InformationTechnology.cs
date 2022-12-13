using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner.Classes
{
    /// <summary>
    /// Contains Classes for different 
    /// </summary>
    public class InformationTechnology
    {
        public VideoSizeCalculator Video { get; set; }
        public class NumberSystemConverter
        {
            public double Number { get; set; }
            public double Result { get; set; }

            public void ConvertTo(int currentBase, int resultBase)
            {
                if(currentBase < resultBase)
                {
                    // TODO: calc value of every char and add it up
                }
                else
                {
                    // TODO: divide the number
                    // TODO: dictionary for i.e. hexadecimal numbers
                    //       to convert the chars to numbers
                }
            }
        }

        public class VideoSizeCalculator
        {
            public VideoSizeCalculator(int colorDepth = 0,
                                       int channels = 0,
                                       int width = 0,
                                       int height = 0,
                                       int fps = 0,
                                       int videoLength = 0,
                                       int imageSize = 0)
            {
                if (imageSize > 0)
                {
                    ImageSize = imageSize;
                }
                else
                {
                    ColorDepth = colorDepth;
                    Channels = channels;
                    Width = width;
                    Height = height;
                    FPS = fps;
                    VideoLength = videoLength;
                }
            }

            public int ColorDepth { get; set; }
            public int Channels { get; set; }
            public int Width { get; set; }
            public int Height { get; set; }
            public int ImageSize { 
                get { return ColorDepth * Channels * Width * Height; }
                set { ImageSize = value; } 
            }
            public int FPS { get; set; }
            // VideoLength in seconds
            public int VideoLength { get; set; }

            public double CalculateVideoSize()
            {
                return ImageSize * FPS * VideoLength;
            }
        }

        public class PrefixCalculator
        {
            // Example Usage:
            // var prefixCalc = new Taschenrechner.Classes.InformationTechnology.PrefixCalculator();
            // prefixCalc.StartPrefix = "MB";
            // prefixCalc.ResultPrefix = "MiB";
            // Console.WriteLine(prefixCalc.Calculate(500));

            public string StartPrefix { get; set; }
            public string ResultPrefix { get; set; }

            private double Convert(double number,
                                   bool toLower=false,
                                   bool binary=false,
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
            /// Method to call after setting the inizialization values.
            /// Contains all logic to convert from and to the selected prefix.
            /// </summary>
            /// <param name="number">Number to convert from</param>
            public string Calculate(double number)
            {
                bool binary = this.BinaryPrefixes.ContainsKey(this.StartPrefix);
                double result = 0;

                if (binary)
                {
                    int iterations = this.BinaryPrefixes[this.StartPrefix];
                    double numWithoutPrefix = this.ToLowerBinaryPrefix(number, iterations);

                    iterations = this.DecimalPrefixes[this.ResultPrefix];
                    result = this.ToHigherDecimalPrefix(numWithoutPrefix, iterations);
                }
                else
                {
                    int iterations = this.DecimalPrefixes[this.StartPrefix];
                    double numWithoutPrefix = this.ToLowerDecimalPrefix(number, iterations);

                    iterations = this.BinaryPrefixes[this.ResultPrefix];
                    result = this.ToHigherBinaryPrefix(numWithoutPrefix, iterations);
                }

                return $"{result} {this.ResultPrefix}";
            }

            private double ToHigherBinaryPrefix(double number, int iterations)
            {
                return Convert(number, toLower: false, binary: true, iterations: iterations);
            }

            private double ToLowerBinaryPrefix(double number, int iterations)
            {
                return Convert(number, toLower: true, binary: true, iterations: iterations);
            }

            private double ToHigherDecimalPrefix(double number, int iterations)
            {
                return Convert(number, toLower: false, binary: false, iterations: iterations);
            }

            private double ToLowerDecimalPrefix(double number, int iterations)
            {
                return Convert(number, toLower: true, binary: false, iterations: iterations);
            }

            private readonly Dictionary<string, int> BinaryPrefixes = new Dictionary<string, int>
            {
                { "B",  0 },
                { "KiB", 1 },
                { "MiB", 2 },
                { "GiB", 3 },
                { "TiB", 4 },
                { "PiB", 5 },
            };
            readonly Dictionary<string, int> DecimalPrefixes = new Dictionary<string, int>
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
