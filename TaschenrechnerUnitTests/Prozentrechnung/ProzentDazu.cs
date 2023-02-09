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
        public void Input_Prozentsatz_0_Grundwert_0()
        {
            double result = Prozentrechnung.ProzentDazu(0, 0);
            if ((result % 1) == 0)
            {
                Assert.That(result == 0, "Ergibt nicht 0!" + result + " wurde berechnet!");
            }
            else
            {
                string resultstr = result.ToString("N2");
                Assert.That(resultstr == "0", "Ergibt nicht 0! " + resultstr + " wurde berechnet!");
            }
            
        }
        [Test]
        public void Input_Prozentsatz_20_Grundwert_1000()
        {
            double result = Prozentrechnung.ProzentDazu(20, 1000);
            if ((result % 1) == 0)
            {
                Assert.That(result == 1200, "Ergibt nicht 1200!" + result + " wurde berechnet!");
            }
            else
            {
                string resultstr = result.ToString("N2");
                Assert.That(resultstr == "1200,00", "Ergibt nicht 1200!" + resultstr + " wurde berechnet!");
            }
            
        }
    }
}
