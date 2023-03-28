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
            kredit.berechneKredit(25000, 48, 5);
        }
    }
}
