using NUnit.Framework;
using Taschenrechner.Classes;

namespace TaschenrechnerUnitTests

{
    public class ParallelogrammFlaeche
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Input_0()
        {
            float result = Geometrie.ParallelogrammFlaeche(10, 6);
            Assert.That(result == 60f, "Ergibt nicht 60, sondern: " + result);
        }
    }
}