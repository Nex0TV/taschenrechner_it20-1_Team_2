using NUnit.Framework;
using Taschenrechner.Classes;

namespace TaschenrechnerUnitTests
{
    public class ProzentWeg
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Input_0()
        {
            double result = Prozentrechnung.ProzentWeg(0, 0);
            Assert.That(result == 1, "Ergibt nicht 1!" + result + " wurde berechnet!");
        }
        [Test]
        public void Input_20_1000()
        {
            double result = Prozentrechnung.ProzentWeg(20, 1000);
            Assert.That(result == 800, "Ergibt nicht 800!" + result + " wurde berechnet!");
        }
    }
}
