using NUnit.Framework;
using Taschenrechner.Classes;
namespace TaschenrechnerUnitTests.Kredit { 
    class Kredit
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Berechnen()
        {
            Kreditrechner.Ratenkredit(1000,5,5);
        }
    }
}
