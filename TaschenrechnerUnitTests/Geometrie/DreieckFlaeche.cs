using NUnit.Framework;
using Taschenrechner.Classes;

namespace TaschenrechnerUnitTests

{
    public class DreieckFlaeche
    {
        [Test]
        public void Input_10_12()
        {
            float result = Geometrie.DreieckFlaeche(10f, 12);
            Assert.That(result == 60f, "Ergibt nicht 60, sondern: " + result);
        }
    }
}