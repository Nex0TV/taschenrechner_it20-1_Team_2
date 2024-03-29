﻿using NUnit.Framework;
using System.Linq;
using Taschenrechner.Classes;

namespace TaschenrechnerUnitTests
{
    public class Primzahlen
    {
        [Test]
        public void primeNumberNegativ()
        {
            int[] result = Mathematik.Primzahlen(-13, 1);
            int[] expected = new int[0];
            Assert.That(result.SequenceEqual(expected), "Warning! [" + string.Join(", ", result) + "] wurde berechnet [" + string.Join(", ", expected) + "] Expected! ");
        }

        [Test]
        public void primeNumberNegativTwo()
        {
            int[] result = Mathematik.Primzahlen(-1, 20);
            int[] expected = new int[8] { 2, 3, 5, 7, 11, 13, 17, 19 };
            Assert.That(result.SequenceEqual(expected), "Warning! [" + string.Join(", ", result) + "] wurde berechnet [" + string.Join(", ", expected) + "] Expected! ");
        }

        [Test]
        public void primeNumberOneToFive()
        {
            int[] result = Mathematik.Primzahlen(1, 5);
            int[] expected = new int[3] { 2, 3, 5 };
            Assert.That(result.SequenceEqual(expected), "Warning! [" + string.Join(", ", result) + "] wurde berechnet [" + string.Join(", ", expected) + "] Expected! ");
        }

        [Test]
        public void primeNumberPositiv()
        {
            int[] result = Mathematik.Primzahlen(3, 122);
            int[] expected = new int[29] { 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97, 101, 103, 107, 109, 113 };
            Assert.That(result.SequenceEqual(expected), "Warning! [" + string.Join(", ", result) + "] wurde berechnet [" + string.Join(", ", expected) + "] Expected! ");
        }

        [Test]
        public void primeNumberPositivTwo()
        {
            int[] result = Mathematik.Primzahlen(50, 100);
            int[] expected = new int[10] { 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 };
            Assert.That(result.SequenceEqual(expected), "Warning! [" + string.Join(", ", result) + "] wurde berechnet [" + string.Join(", ", expected) + "] Expected! ");
        }
    }
}
