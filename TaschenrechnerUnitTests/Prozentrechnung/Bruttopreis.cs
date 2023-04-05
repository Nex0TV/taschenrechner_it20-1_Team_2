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
        public void Input_Nettopreis_0()
        {
            
            
            double result = Prozentrechnung.Bruttopreis(0);
            if((result % 1) == 0)
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
        public void Input_Nettopreis_750()
        {

            double result = Prozentrechnung.Bruttopreis(750);
            if ((result % 1) == 0)
            {
                Assert.That(result == 630.25, "Ergibt nicht 630.25!" + result + " wurde berechnet!");
            }
            else
            {
                string resultstr = result.ToString("N2");
                Assert.That(resultstr == "630,25", "Ergibt nicht 630,25!" + resultstr + " wurde berechnet!");
            }
            
        }
    }
}
