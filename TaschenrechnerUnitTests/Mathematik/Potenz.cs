using NUnit.Framework;
using Taschenrechner.Classes;

namespace TaschenrechnerUnitTests
{
    public class Potenz
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Input_0_0()
        {
            double result = Mathematik.Potenz(0, 0);
            Assert.That(result == 1, "Ergibt nicht 1! " + result + " wurde berechnet!");
        }

        [Test]
        public void Input_1_0()
        {
            double result = Mathematik.Potenz(1, 0);
            Assert.That(result == 1, "Ergibt nicht 1!" + result + " wurde berechnet!");
        }

        [Test]
        public void Input_1_1()
        {
            double result = Mathematik.Potenz(1, 1);
            Assert.That(result == 1, "Ergibt nicht 1! " + result + " wurde berechnet!");
        }

        [Test]
        public void Input_1_3()
        {
            double result = Mathematik.Potenz(1, 1);
            Assert.That(result == 1, "Ergibt nicht 1! " + result + " wurde berechnet!");
        }

        [Test]
        public void Input_2_1()
        {
            double result = Mathematik.Potenz(2, 1);
            Assert.That(result == 2, "Ergibt nicht 2! " + result + " wurde berechnet!");
        }

        [Test]
        public void Input_2_4()
        {
            double result = Mathematik.Potenz(2, 4);
            Assert.That(result == 16, "Ergibt nicht 16! " + result + " wurde berechnet!");
        }

        [Test]
        public void Input_4_4()
        {
            double result = Mathematik.Potenz(4, 4);
            Assert.That(result == 256, "Ergibt nicht 256! " + result + " wurde berechnet!");
        }

        [Test]
        public void Input_1p56_4()
        {
            double result = Mathematik.Potenz(1.56, 4);
            Assert.That(result == 5.92240896, "Ergibt nicht 5.92240896! " + result + " wurde berechnet!");
        }
    }
}
