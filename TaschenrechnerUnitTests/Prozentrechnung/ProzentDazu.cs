using NUnit.Framework;
using Taschenrechner.Classes;

namespace TaschenrechnerUnitTests
{
    public class ProzentDazu
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Input_0()
        {
            double result = Prozentrechnung.ProzentDazu(0, 0);
            Assert.That(result == 1, "Ergibt nicht 1!" + result + " wurde berechnet!");
        }
        [Test]
        public void Input_20_1000()
        {
            double result = Prozentrechnung.ProzentDazu(20, 1000);
            Assert.That(result == 1200, "Ergibt nicht 1200!" + result + " wurde berechnet!");
        }
    }
}
