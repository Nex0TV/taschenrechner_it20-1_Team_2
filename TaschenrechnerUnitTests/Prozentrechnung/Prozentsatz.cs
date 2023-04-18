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
        public void Input_Prozentsatz_0_Grundwert_0()
        {
            double result = Prozentrechnung.Prozentsatz(0,0);
            if ((result % 1) == 0)
            {
                Assert.That(result == -1, "Ergibt nicht -1!" + result + " wurde berechnet!");
            }
            else
            {
                string resultstr = result.ToString("N2");
                Assert.That(resultstr == "-1,00", "Ergibt nicht -1,00! " + resultstr + " wurde berechnet!");
            }
        }
        [Test]
        public void Input_Prozentsatz_750_Grundwert_5000()
        {
            double result = Prozentrechnung.Prozentsatz(750,5000);
            if ((result % 1) == 0)
            {
                Assert.That(result == 15, "Ergibt nicht 15! " + result + " wurde berechnet!");
            }
            else
            {
                string resultstr = result.ToString("N2");
                Assert.That(resultstr == "15,00", "Ergibt nicht 15,00! " + resultstr + " wurde berechnet!");
            }
        }
        [Test]
        public void Input_Prozentsatz_1250_Grundwert_7777()
        {
            double result = Prozentrechnung.Prozentsatz(1250, 7777);
            if ((result % 1) == 0)
            {
                Assert.That(result == 16.07, "Ergibt nicht 16.07! " + result + " wurde berechnet!");
            }
            else
            {
                string resultstr = result.ToString("N2");
                Assert.That(resultstr == "16,07", "Ergibt nicht 16,07! " + resultstr + " wurde berechnet!");
            }
        }
    }
}
