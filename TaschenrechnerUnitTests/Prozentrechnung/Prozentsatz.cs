using NUnit.Framework;
using Taschenrechner.Classes;

namespace TaschenrechnerUnitTests
{
    public class Prozentsatz
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Input_0()
        {
            double result = Prozentrechnung.Prozentsatz(0,0);
            Assert.That(result == 1, "Ergibt nicht 1!" + result + " wurde berechnet!");
        }
        [Test]
        public void Input_750()
        {
            double result = Prozentrechnung.Prozentsatz(750,5000);
            Assert.That(result == 15, "Ergibt nicht 15! " + result + " wurde berechnet!");
        }
        [Test]
        public void Input_1250()
        {
            double result = Prozentrechnung.Prozentsatz(1250, 7777);
            Assert.That(result == 16.07, "Ergibt nicht 16.07! " + result + " wurde berechnet!");
        }
    }
}
