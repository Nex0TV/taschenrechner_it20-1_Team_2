using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner.Classes
{
    public class Mathematik
    {
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
            return ergebnis;
        }

        public static double Potenz(double zahl, int exponent)
        {
            double ergebnis = 1;

            for (int iterator = 0; iterator < exponent; iterator++)
            {
                ergebnis *= zahl;
            }

            return ergebnis;
        }

        public static double Bruch(int zaehler, int nenner)
        {
            if(nenner != 0)
            {
                return zaehler / nenner;
            }
            else
            {
                throw new DivideByZeroException("Division of {" + zaehler + "} by zero.");
            }
        }

        public static double Wurzel(double zahl)
        {
            double x = 1;

            do
            {
                x = (x + zahl / x) / 2;
            } while ((x * x).ToString("F6") != zahl.ToString("F6"));

            return Convert.ToDouble(x.ToString("F6"));
        }

        private static bool IstPrimzahl(int zahl)
        {
            for (int iterator = 2; iterator < zahl; iterator++)
            {
                if (zahl % iterator == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static int[] Primzahlen(int startzahl, int endzahl)
        {
            int[] primzahlen = new int[0];

            for (int iterator = startzahl; iterator <= endzahl; iterator++)
            {
                if(IstPrimzahl(iterator))
                {
                    Array.Resize(ref primzahlen, primzahlen.Length + 1);
                    primzahlen[primzahlen.Length - 1] = iterator;
                }
            }

            return primzahlen;
        }
    }
}
