using NUnit.Framework;
using Taschenrechner.Classes;
using System;

namespace TaschenrechnerUnitTests
{
    public class Bruch
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void input_1_0()
        {
            Assert.Throws<DivideByZeroException>(() => Mathematik.Bruch(1, 0), "Warning! DivideByZeroException Expected!");
        }

        [Test]
        public void input_1_1()
        {
            double result = Mathematik.Bruch(1, 1);
            Assert.That(result == 1, "Ergibt nicht 1! " + result.ToString() + " wurde berechnet!");
        }

        [Test]
        public void input_212_0()
        {
            Assert.Throws<DivideByZeroException>(() => Mathematik.Bruch(212, 0), "Warning! DivideByZeroException Expected!");
        }

        [Test]
        public void input_5_22()
        {
            double result = Mathematik.Bruch(5, 22);
            Assert.That(result == 0.22727272727272727, "Ergibt nicht 0.22727272727272727! " + result.ToString() + " wurde berechnet!");
        }
    }
}
