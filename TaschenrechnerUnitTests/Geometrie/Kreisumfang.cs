using NUnit.Framework;
using Taschenrechner.Classes;

namespace TaschenrechnerUnitTests

{
    public class KreisUmfang
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Input_0()
        {
            float result = Geometrie.KreisUmfang(10.4432f);
            Assert.That(result == 32.80828f, "Ergibt nicht 32.80828, sondern: " + result);
        }
    }
}