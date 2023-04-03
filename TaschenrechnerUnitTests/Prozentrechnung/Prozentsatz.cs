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
            string resultstr = result.ToString("N2");
            Assert.That(resultstr == "1,00", "Ergibt nicht 1,00!" + resultstr + " wurde berechnet!");
        }
        [Test]
        public void Input_750()
        {
            double result = Prozentrechnung.Prozentsatz(750,5000);
            string resultstr = result.ToString("N2");
            Assert.That(resultstr == "15,00", "Ergibt nicht 15,00! " + resultstr + " wurde berechnet!");
        }
        [Test]
        public void Input_1250()
        {
            double result = Prozentrechnung.Prozentsatz(1250, 7777);
            string resultstr = result.ToString("N2");
            Assert.That(resultstr == "16,07", "Ergibt nicht 16,07! " + resultstr + " wurde berechnet!");
        }
    }
}
