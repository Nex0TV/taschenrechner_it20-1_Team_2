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
            kredit.RatenkreditVorgabeRatenhoehe(1000, 3.5, 502.19);
            kredit.RatenkreditVorgabeLaufzeit(1000, 3.5, 1);
        }
    }
}
