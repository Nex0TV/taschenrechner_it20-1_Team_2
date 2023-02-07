using NUnit.Framework;
using System.Linq;
using Taschenrechner.Classes;

namespace TaschenrechnerUnitTests
{
    class NumberSystemConverter
    {
        [Test]
        public void Convert_110FromBinaryToDecimal_Return6()
        {
            int input_number = 110;
            int expected_result = 6;
            int result = InformationTechnology.NumberSystemConverter.ConvertNumber(input_number, 2, 10);
            Assert.That(result == expected_result, $"Expected: {expected_result} but was: {result}");
        }

        [Test]
        public void Convert_6FromDecimalToBinary_Return110()
        {
            int input_number = 6;
            int expected_result = 110;
            int result = InformationTechnology.NumberSystemConverter.ConvertNumber(input_number, 10, 2);
            Assert.That(result == expected_result, $"Expected: {expected_result} but was: {result}");
        }

        [Test]
        public void Convert_14FromOctalToDecimal_Return12()
        {
            int input_number = 14;
            int expected_result = 12;
            int result = InformationTechnology.NumberSystemConverter.ConvertNumber(input_number, 8, 10);
            Assert.That(result == expected_result, $"Expected: {expected_result} but was: {result}");
        }

        [Test]
        public void Convert_122FromTernaryToOctal_Return21()
        {
            int input_number = 122;
            int expected_result = 21;
            int result = InformationTechnology.NumberSystemConverter.ConvertNumber(input_number, 3, 8);
            Assert.That(result == expected_result, $"Expected: {expected_result} but was: {result}");
        }

        [Test]
        public void Convert_12FromOctalToTrenary_Return101()
        {
            int input_number = 12;
            int expected_result = 101;
            int result = InformationTechnology.NumberSystemConverter.ConvertNumber(input_number, 8, 3);
            Assert.That(result == expected_result, $"Expected: {expected_result} but was: {result}");
        }

        [Test]
        public void ConvertToDecimal_Test()
        {
            int inputBase = 6;
            int inputNumber = 12;
            int expectedResult = 8;
            int result = InformationTechnology.NumberSystemConverter.ConvertToDecimal(inputNumber, inputBase);
            Assert.That(result == expectedResult, $"Expected: {expectedResult} but was: {result}");
        }
    }
}
