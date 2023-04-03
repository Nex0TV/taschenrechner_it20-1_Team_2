using NUnit.Framework;
using System.Linq;
using Taschenrechner.Classes;

namespace TaschenrechnerUnitTests
{
    class NumberSystemConverter
    {
        [Test]
        public void ConvertFromBinaryToDecimalReturnTrueCase1()
        {
            int input_number = 110;
            int expected_result = 6;
            int result = InformationTechnology.NumberSystem.Convert(input_number, 2, 10);
            Assert.That(result == expected_result, $"Expected: {expected_result} but was: {result}");
        }

        [Test]
        public void ConvertFromDecimalToBinaryReturnTrueCase1()
        {
            int input_number = 6;
            int expected_result = 110;
            int result = InformationTechnology.NumberSystem.Convert(input_number, 10, 2);
            Assert.That(result == expected_result, $"Expected: {expected_result} but was: {result}");
        }

        [Test]
        public void ConvertFromOctalToDecimalReturnTrueCase1()
        {
            int input_number = 14;
            int expected_result = 12;
            int result = InformationTechnology.NumberSystem.Convert(input_number, 8, 10);
            Assert.That(result == expected_result, $"Expected: {expected_result} but was: {result}");
        }

        [Test]
        public void ConvertFromTernaryToOctalReturnTrueCase1()
        {
            int input_number = 122;
            int expected_result = 21;
            int result = InformationTechnology.NumberSystem.Convert(input_number, 3, 8);
            Assert.That(result == expected_result, $"Expected: {expected_result} but was: {result}");
        }

        [Test]
        public void ConvertFromOctalToTrenaryReturnTrueCase1()
        {
            int input_number = 12;
            int expected_result = 101;
            int result = InformationTechnology.NumberSystem.Convert(input_number, 8, 3);
            Assert.That(result == expected_result, $"Expected: {expected_result} but was: {result}");
        }
    }
}
