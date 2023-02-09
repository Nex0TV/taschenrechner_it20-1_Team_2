using NUnit.Framework;
using Taschenrechner.Classes;
using System;

namespace TaschenrechnerUnitTests
{
    public class Bruch
    {
        [Test]
        public void divideByZero()
        {
            Assert.Throws<DivideByZeroException>(() => Mathematik.Bruch(1, 0), "Warning! DivideByZeroException Expected!");
        }

        [Test]
        public void divideOneByOne()
        {
            double result = Mathematik.Bruch(1, 1);
            Assert.That(result == 1, "Ergibt nicht 1! " + result.ToString() + " wurde berechnet!");
        }

        [Test]
        public void divide212ByZero()
        {
            Assert.Throws<DivideByZeroException>(() => Mathematik.Bruch(212, 0), "Warning! DivideByZeroException Expected!");
        }

        [Test]
        public void devide5By22()
        {
            double result = Mathematik.Bruch(5, 22);
            Assert.That(result == 0.22727272727272727, "Ergibt nicht 0.22727272727272727! " + result.ToString() + " wurde berechnet!");
        }
    }
}
