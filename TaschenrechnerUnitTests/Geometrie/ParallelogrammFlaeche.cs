using NUnit.Framework;
using Taschenrechner.Classes;

namespace TaschenrechnerUnitTests

{
    public class ParallelogrammFlaeche
    {
        [Test]
        public void Input_10_6()
        {
            float result = Geometrie.ParallelogrammFlaeche(10, 6);
            Assert.That(result == 60f, "Ergibt nicht 60, sondern: " + result);
        }
    }
}