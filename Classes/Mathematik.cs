using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Taschenrechner.Classes
{
    /// <summary>
    /// Mathematic Class
    /// </summary>
    public class Mathematik
    {
        /// <summary>
        /// calculate faculty of number
        /// </summary>
        /// <param name="zahl">number</param>
        /// <returns>faculty of zahl</returns>
        public static int Fakultaet(int zahl)
        {
            int ergebnis = 1;
            if(zahl != 0)
            {
                for (int iterator = 1; iterator <= zahl; iterator++)
                {
                    ergebnis *= iterator;
                }

            }

            (new History()).SaveNewCount(ergebnis.ToString());

            return ergebnis;
        }

        /// <summary>
        /// calculate potency of number
        /// </summary>
        /// <param name="zahl">number</param>
        /// <param name="exponent">exponent</param>
        /// <returns>potenz</returns>
        public static double Potenz(double zahl, int exponent)
        {
            double ergebnis = 1;

            for (int iterator = 0; iterator < exponent; iterator++)
            {
                ergebnis *= zahl;
            }

            (new History()).SaveNewCount(ergebnis.ToString());

            return ergebnis;
        }

        /// <summary>
        /// fraction calculation
        /// </summary>
        /// <param name="zaehler">numerator </param>
        /// <param name="nenner">denominator</param>
        /// <returns>fraction</returns>
        public static double Bruch(int zaehler, int nenner)
        {
            if(nenner != 0)
            {
                double ergebnis = Convert.ToDouble(zaehler) / Convert.ToDouble(nenner);
                (new History()).SaveNewCount(ergebnis.ToString());
                return ergebnis;
            }
            else
            {
                throw new DivideByZeroException("Division of {" + zaehler + "} by zero.");
            }
        }

        public static string ZahlZuBruch(double zahl)
        {
            int zaehler = (int)Potenz(zahl, 10);
            int nenner = (int)(zahl * zaehler);
            int gcd = getGcd(zaehler, nenner);

            zaehler /= gcd;
            nenner /= gcd;

            return (zaehler + "/" + nenner);
        }

        private static int getGcd(int zaehler, int nenner)
        {
            if (zaehler == 0) return nenner;
            return getGcd(nenner % zaehler, zaehler);
        }

        /// <summary>
        /// square root
        /// </summary>
        /// <param name="zahl">number</param>
        /// <returns>square root of number</returns>
        public static double Wurzel(double zahl)
        {
            double x = 1;

            do
            {
                x = (x + zahl / x) / 2;
            }
            while ((x * x).ToString("F6") != zahl.ToString("F6"));

            var wurzel = Convert.ToDouble(x.ToString("F6"));

            (new History()).SaveNewCount(wurzel.ToString());

            return wurzel;
        }

        /// <summary>
        /// test number if it is prime number
        /// </summary>
        /// <param name="zahl">number</param>
        /// <returns>true or false</returns>
        private static bool IstPrimzahl(int zahl)
        {
            if(zahl <= 1)
            {
                return false;
            }

            for (int iterator = 2; iterator < zahl; iterator++)
            {
                if (zahl % iterator == 0)
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Get prime numbers of an list of numbers
        /// </summary>
        /// <param name="startzahl">first number</param>
        /// <param name="endzahl">last number</param>
        /// <returns></returns>
        public static int[] Primzahlen(int startzahl, int endzahl)
        {

            int[] primzahlen = new int[0];

            if(startzahl <= endzahl)
            {
                for (int iterator = startzahl; iterator <= endzahl; iterator++)
                {
                    if (iterator > 1 && IstPrimzahl(iterator))
                    {
                        Array.Resize(ref primzahlen, primzahlen.Length + 1);
                        primzahlen[primzahlen.Length - 1] = iterator;
                    }
                }
            }

            return primzahlen;
        }
    }
}
