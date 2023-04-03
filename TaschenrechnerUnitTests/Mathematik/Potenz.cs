using NUnit.Framework;
using Taschenrechner.Classes;

namespace TaschenrechnerUnitTests
{
    public class Potenz
    {
        [Test]
        public void potencyZeroOfZero()
        {
            double result = Mathematik.Potenz(0, 0);
            Assert.That(result == 1, "Ergibt nicht 1! " + result + " wurde berechnet!");
        }

        [Test]
        public void potencyZeroOfOne()
        {
            double result = Mathematik.Potenz(1, 0);
            Assert.That(result == 1, "Ergibt nicht 1!" + result + " wurde berechnet!");
        }

        [Test]
        public void potencyOneOfOne()
        {
            double result = Mathematik.Potenz(1, 1);
            Assert.That(result == 1, "Ergibt nicht 1! " + result + " wurde berechnet!");
        }

        [Test]
        public void potencyOneOfTwo()
        {
            double result = Mathematik.Potenz(2, 1);
            Assert.That(result == 2, "Ergibt nicht 2! " + result + " wurde berechnet!");
        }

        [Test]
        public void potencyFourOfTwo()
        {
            double result = Mathematik.Potenz(2, 4);
            Assert.That(result == 16, "Ergibt nicht 16! " + result + " wurde berechnet!");
        }

        [Test]
        public void potencyFourOfFour()
        {
            double result = Mathematik.Potenz(4, 4);
            Assert.That(result == 256, "Ergibt nicht 256! " + result + " wurde berechnet!");
        }

        [Test]
        public void potencyFourOfFracture()
        {
            double result = Mathematik.Potenz(1.56, 4);
            Assert.That(result == 5.92240896, "Ergibt nicht 5.92240896! " + result + " wurde berechnet!");
        }
    }
}
