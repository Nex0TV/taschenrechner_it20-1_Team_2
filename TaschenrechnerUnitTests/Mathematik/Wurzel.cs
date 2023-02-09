using NUnit.Framework;
using Taschenrechner.Classes;

namespace TaschenrechnerUnitTests
{
    public class Wurzel
    {
        [Test]
        public void squareRootOne()
        {
            double result = Mathematik.Wurzel(1);
            Assert.That(result == 1, "Ergibt nicht 1! " + result + " wurde berechnet!");
        }

        [Test]
        public void squareRootTwo()
        {
            double result = Mathematik.Wurzel(2);
            Assert.That(result == 1.414214, "Ergibt nicht 1.1414214! " + result + " wurde berechnet!");
        }

        [Test]
        public void squareRootThree()
        {
            double result = Mathematik.Wurzel(3);
            Assert.That(result == 1.732051, "Ergibt nicht 1.732051! " + result + " wurde berechnet!");
        }

        [Test]
        public void squareRootFour()
        {
            double result = Mathematik.Wurzel(4);
            Assert.That(result == 2, "Ergibt nicht 2! " + result + " wurde berechnet!");
        }

        [Test]
        public void squareRootFive()
        {
            double result = Mathematik.Wurzel(5);
            Assert.That(result == 2.236068, "Ergibt nicht 2.236068! " + result + " wurde berechnet!");
        }

        [Test]
        public void squareRootSix()
        {
            double result = Mathematik.Wurzel(6);
            Assert.That(result == 2.449490, "Ergibt nicht 2.449490! " + result + " wurde berechnet!");
        }

        [Test]
        public void squareRootSeven()
        {
            double result = Mathematik.Wurzel(7);
            Assert.That(result == 2.645751, "Ergibt nicht 2.645751! " + result + " wurde berechnet!");
        }

        [Test]
        public void squareRootEight()
        {
            double result = Mathematik.Wurzel(8);
            Assert.That(result == 2.828427, "Ergibt nicht 2.828427! " + result + " wurde berechnet!");
        }

        [Test]
        public void squareRootNine()
        {
            double result = Mathematik.Wurzel(9);
            Assert.That(result == 3, "Ergibt nicht 3! " + result + " wurde berechnet!");
        }

        [Test]
        public void squareRootTen()
        {
            double result = Mathematik.Wurzel(10);
            Assert.That(result == 3.162278, "Ergibt nicht 3.162278! " + result + " wurde berechnet!");
        }

        [Test]
        public void squareRoot11()
        {
            double result = Mathematik.Wurzel(11);
            Assert.That(result == 3.316625, "Ergibt nicht 3.316625! " + result + " wurde berechnet!");
        }

        [Test]
        public void squareRoot12()
        {
            double result = Mathematik.Wurzel(12);
            Assert.That(result == 3.464102, "Ergibt nicht 3.464102! " + result + " wurde berechnet!");
        }

        [Test]
        public void squareRoot13()
        {
            double result = Mathematik.Wurzel(13);
            Assert.That(result == 3.605551, "Ergibt nicht 3.605551! " + result + " wurde berechnet!");
        }

        [Test]
        public void squareRoot14()
        {
            double result = Mathematik.Wurzel(14);
            Assert.That(result == 3.741657, "Ergibt nicht 3.741657! " + result + " wurde berechnet!");
        }

        [Test]
        public void squareRoot15()
        {
            double result = Mathematik.Wurzel(15);
            Assert.That(result == 3.872983, "Ergibt nicht 3.872983! " + result + " wurde berechnet!");
        }

        [Test]
        public void squareRoot225()
        {
            double result = Mathematik.Wurzel(225);
            Assert.That(result == 15, "Ergibt nicht 15! " + result + " wurde berechnet!");
        }

        
        [Test]
        public void squareRoot230()
        {
            double result = Mathematik.Wurzel(230);
            Assert.That(result == 15.165751, "Ergibt nicht 15.165751! " + result + " wurde berechnet!");
        }
    }
}
