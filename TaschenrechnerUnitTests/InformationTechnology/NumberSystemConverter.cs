using NUnit.Framework;
using Taschenrechner.Classes;

namespace TaschenrechnerUnitTests
{
    class NumberSystemConverter
    {
        [Test]
        public void Convert_110FromBinaryToDecimal_Return6()
        {
            int input_number = 110;
            string expected_result = "6";
            string result = InformationTechnology.NumberSystemConverter.ConvertNumber(input_number, 2, 10);
            Assert.That(result == expected_result, $"Expected: {expected_result} but was: {result}");
        }

        [Test]
        public void Convert_6FromDecimalToBinary_Return110()
        {
            int input_number = 6;
            string expected_result = "110";
            string result = InformationTechnology.NumberSystemConverter.ConvertNumber(input_number, 10, 2);
            Assert.That(result == expected_result, $"Expected: {expected_result} but was: {result}");
        }

        [Test]
        public void Convert_14FromOktalToDecimal_Return12()
        {
            int input_number = 14;
            string expected_result = "12";
            string result = InformationTechnology.NumberSystemConverter.ConvertNumber(input_number, 8, 10);
            Assert.That(result == expected_result, $"Expected: {expected_result} but was: {result}");
        }

        [Test]
        public void Convert_12FromDecimalToOktal_Return14()
        {
            int input_number = 12;
            string expected_result = "14";
            string result = InformationTechnology.NumberSystemConverter.ConvertNumber(input_number, 10, 8);
            Assert.That(result == expected_result, $"Expected: {expected_result} but was: {result}");
        }
    }
}
