using NUnit.Framework;
using Taschenrechner.Classes;

namespace TaschenrechnerUnitTests

{
    public class ParallelogrammUmfang
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Input_0()
        {
            float result = Geometrie.ParallelogrammUmfang(10, 15);
            Assert.That(result == 50f, "Ergibt nicht 50, sondern: " + result);
        }
    }
}