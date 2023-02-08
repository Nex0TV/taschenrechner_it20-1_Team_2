using NUnit.Framework;
using Taschenrechner.Classes;

namespace TaschenrechnerUnitTests

{
    public class DreieckFlaeche
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Input_0()
        {
            float result = Geometrie.DreieckFlaeche(10f, 12);
            Assert.That(result == 60f, "Ergibt nicht 60, sondern: " + result);
        }
    }
}