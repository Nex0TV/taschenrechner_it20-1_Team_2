using NUnit.Framework;
using Taschenrechner.Classes;

namespace TaschenrechnerUnitTests

{
    public class DreieckUmfang
    {
        [Test]
        public void Input_10_12_11()
        {
            float result = Geometrie.DreieckUmfang(10, 12, 11);
            Assert.That(result == 33f, "Ergibt nicht 33, sondern: " + result);
        }
    }
}