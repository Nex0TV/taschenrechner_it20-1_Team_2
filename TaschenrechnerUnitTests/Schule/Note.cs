using NUnit.Framework;
using Taschenrechner.Classes;

namespace TaschenrechnerUnitTests

{
    public class Note
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Input_1p223()
        {
            int result = Schule.Note(1.223f);
            Assert.That(result == 1, "Ergibt nicht 1, sondern" + result);
        }

        [Test]
        public void Input_3p56()
        {
            int result = Schule.Note(3.56f);
            Assert.That(result == 4, "Ergibt nicht 4, sondern " + result);
        }
    }
}