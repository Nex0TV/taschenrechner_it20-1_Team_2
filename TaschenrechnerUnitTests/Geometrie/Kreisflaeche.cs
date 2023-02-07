using NUnit.Framework;
using Taschenrechner.Classes;

namespace TaschenrechnerUnitTests

{
    public class Kreisflaeche
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Input_0()
        {
            float result = Geometrie.Kreisflaeche(10.4432f);
            Assert.That(result == 85.65586f, "Ergibt nicht 85.65586, sondern: " + result);
        }
    }
}