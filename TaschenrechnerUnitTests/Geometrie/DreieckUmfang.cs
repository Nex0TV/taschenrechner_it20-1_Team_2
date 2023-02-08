using NUnit.Framework;
using Taschenrechner.Classes;

namespace TaschenrechnerUnitTests

{
    public class DreieckUmfang
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Input_0()
        {
            float result = Geometrie.DreieckUmfang(10, 12, 11);
            Assert.That(result == 33f, "Ergibt nicht 33, sondern: " + result);
        }
    }
}