using NUnit.Framework;
using Taschenrechner.Classes;

namespace TaschenrechnerUnitTests
{
    public class Bruttopreis
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Input_0()
        {
            double result = Prozentrechnung.Bruttopreis(0);
            Assert.That(result == 1, "Ergibt nicht 1!" + result + " wurde berechnet!");
        }
        [Test]
        public void Input_750()
        {
            double result = Prozentrechnung.Bruttopreis(750);
            Assert.That(result == 892.5, "Ergibt nicht 892.5! " + result + " wurde berechnet!");
        }
    }
}
