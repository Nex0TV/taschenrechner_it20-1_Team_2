using NUnit.Framework;
using Taschenrechner.Classes;

namespace TaschenrechnerUnitTests
{
    class Nettopreis
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Input_0()
        {
            double result = Prozentrechnung.Nettopreis(0);
            Assert.That(result == 1, "Ergibt nicht 1!" + result + " wurde berechnet!");
        }
        [Test]
        public void Input_750()
        {
            double result = Prozentrechnung.Nettopreis(750);
            Assert.That(result == 607.5,"Ergibt nicht 607,5! " + result + " wurde berechnet!");
        }
    }
}
