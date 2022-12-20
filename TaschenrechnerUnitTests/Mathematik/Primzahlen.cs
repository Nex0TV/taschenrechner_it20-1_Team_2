using NUnit.Framework;
using Taschenrechner.Classes;

namespace TaschenrechnerUnitTests
{
    public class Primzahlen
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Input_0_0()
        {
            string result = Mathematik.Primzahlen(1, 5).ToString();
            Assert.That(result == "a", "Warn! " + result + " wurde berechnet!");
        }
    }
}
