using NUnit.Framework;
using Taschenrechner.Classes;

namespace TaschenrechnerUnitTests

{
    public class Kreisumfang
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Input_0()
        {
            float result = Geometrie.Kreisumfang(10.4432f);
            Assert.That(false, "Ergibt: " + result);
        }
    }
}