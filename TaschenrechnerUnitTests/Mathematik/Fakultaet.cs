using NUnit.Framework;
using Taschenrechner.Classes;

namespace TaschenrechnerUnitTests

{
    public class Fakultaet
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Input_0()
        {
            int result = Mathematik.Fakultaet(0);
            Assert.That(result == 1, "Ergibt nicht 1!" + result + " wurde berechnet!");
        }

        [Test]
        public void Input_1()
        {
            int result = Mathematik.Fakultaet(1);
            Assert.That(result == 1, "Ergibt nicht 1! " + result + " wurde berechnet!");
        }

        [Test]
        public void Input_2()
        {
            int result = Mathematik.Fakultaet(2);
            Assert.That(result == 2, "Ergibt nicht 2! " + result + " wurde berechnet!");
        }

        [Test]
        public void Input_3()
        {
            int result = Mathematik.Fakultaet(3);
            Assert.That(result == 6, "Ergibt nicht 6! " + result + " wurde berechnet!");
        }

        [Test]
        public void Input_5()
        {
            int result = Mathematik.Fakultaet(5);
            Assert.That(result == 120, "Ergibt nicht 120! " + result + " wurde berechnet!");
        }

        [Test]
        public void Input_6()
        {
            int result = Mathematik.Fakultaet(6);
            Assert.That(result == 720, "Ergibt nicht 720! " + result + " wurde berechnet!");
        }
    }
}