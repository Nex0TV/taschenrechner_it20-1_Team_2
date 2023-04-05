using NUnit.Framework;
using System.Linq;
using Taschenrechner.Classes;

namespace TaschenrechnerUnitTests

{
    public class ValidierteNoten
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Input_1()
        {
            int[] array = { 1, 4, 3, 7, 8, 2 };
            int[] expected = { 1, 4, 3, 2 };
            int[] result = Schule.ValidierteNoten(array);
            Assert.That(result.SequenceEqual(expected), "Das Resultat ist ungleich des erwarteten Wertes. Result: [" + string.Join(", ", result) + "] != ["+ string.Join(", ", expected) + "].");
        }
    }
}
