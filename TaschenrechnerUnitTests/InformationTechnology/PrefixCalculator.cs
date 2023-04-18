using System;
using NUnit.Framework;
using Taschenrechner.Classes;

namespace TaschenrechnerUnitTests
{
    public class InformationTechnologyTest
    {
        [Test]
        public void Calculate_BinaryToDecimal_ReturnRightValue()
        {
            string result = InformationTechnology.PrefixCalculator.Convert(1, "KiB", "MB");
            Assert.That(result == "0,001024 MB", "Conversion wasn't as excepted.");
        }
        
        [Test]
        public void Calculate_BinaryToBinary_ReturnRightValue()
        {
            string result = InformationTechnology.PrefixCalculator.Convert(1, "KiB", "MiB");
            Assert.That(result == "0,0009765625 MiB", "Conversion wasn't as excepted.");
        }

        [Test]
        public void Calculate_DecimalToBinary_ReturnRightValue()
        {
            string result = InformationTechnology.PrefixCalculator.Convert(1, "MB", "MiB");
            Assert.That(result == "0,95367431640625 MiB", "Conversion wasn't as excepted.");
        }

        [Test]
        public void Calculate_NoPrefixToBinary_ReturnRightValue()
        {
            string result = InformationTechnology.PrefixCalculator.Convert(1024, "B", "KiB");
            Assert.That(result == "1 KiB", "Conversion wasn't as excepted.");
        }

        [Test]
        public void Calculate_NoPrefixToDecimal_ReturnRightValue()
        {
            string result = InformationTechnology.PrefixCalculator.Convert(1024, "B", "kB");
            Assert.That(result == "1,024 kB", "Conversion wasn't as excepted.");
        }
    }
}