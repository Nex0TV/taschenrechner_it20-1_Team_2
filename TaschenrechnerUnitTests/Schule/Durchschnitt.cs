using NUnit.Framework;
using Taschenrechner.Classes;

namespace TaschenrechnerUnitTests

{
    public class Durchschnitt
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Input_1_2_3()
        {
            int[] array = { 1, 2, 3 };
            float result = Schule.Durchschnitt(array);
            Assert.That(result == 2, "Ergibt nicht 2 Stattdessen: " + result);
        }

        [Test]
        public void Input_1_2_3_4()
        {
            int[] array = { 1, 2, 3, 4 };
            float result = Schule.Durchschnitt(array);
            Assert.That(result == 2.5f, "Ergibt nicht 2.5 Stattdessen: " + result);
        }
    }
}