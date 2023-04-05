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
        public void Input_Bruttopreis_0()
        {
            double result = Prozentrechnung.Nettopreis(0);
            if ((result % 1) == 0)
            {
                Assert.That(result == 0, "Ergibt nicht 0!" + result + " wurde berechnet!");
            }
            else
            {
                string resultstr = result.ToString("N2");
                Assert.That(resultstr == "0", "Ergibt nicht 0!" + resultstr + " wurde berechnet!");
            }
        }
        [Test]
        public void Input_Bruttopreis_750()
        {
            double result = Prozentrechnung.Nettopreis(750);
            if ((result % 1) == 0)
            {
                Assert.That(result == 607.5, "Ergibt nicht 607,5! " + result + " wurde berechnet!");
            }
            else
            {
                string resultstr = result.ToString("N2");
                Assert.That(resultstr == "607,50", "Ergibt nicht 607,50! " + resultstr + " wurde berechnet!");
            }
        }
        [Test]
        public void Input_Bruttopreis_987()
        {
            double result = Prozentrechnung.Nettopreis(987);
            if ((result % 1) == 0)
            {
                Assert.That(result == 799.47, "Ergibt nicht 799.47! " + result + " wurde berechnet!");
            }
            else
            {
                string resultstr = result.ToString("N2");
                Assert.That(resultstr == "799,47", "Ergibt nicht 799.47! " + resultstr + " wurde berechnet!");
            }
        }
    }
}
