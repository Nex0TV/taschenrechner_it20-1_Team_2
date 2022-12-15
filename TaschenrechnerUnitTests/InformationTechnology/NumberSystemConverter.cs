using NUnit.Framework;
using Taschenrechner.Classes;

namespace TaschenrechnerUnitTests
{
    class NumberSystemConverter
    {
        [Test]
        public void Convert_101FromBinaryToDecimal_Return5()
        {
            double result = InformationTechnology.NumberSystemConverter.Convert(110, 2, 10);
            Assert.That(result == 6);
        }
    }
}
