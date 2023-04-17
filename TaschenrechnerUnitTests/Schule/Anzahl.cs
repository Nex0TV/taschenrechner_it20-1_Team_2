using NUnit.Framework;
using Taschenrechner.Classes;

namespace TaschenrechnerUnitTests

{
    public class Anzahl
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Input_1_4_4_7_8_2()
        {
            int[] array = { 1, 4, 3, 7, 8, 2 };
            int result = Schule.Anzahl(array);
            Assert.That(result == 6, "Ergibt nicht 6, sondern: " + result);
        }

        [Test]
        public void Input_2_4_5_7_3_1_0_2()
        {
            int[] array = { 2, 4, 5, 7, 3, 1, 0, 2 };
            int result = Schule.Anzahl(array);
            Assert.That(result == 8, "Ergibt nicht 8, sondern: " + result);
        }
    }
}