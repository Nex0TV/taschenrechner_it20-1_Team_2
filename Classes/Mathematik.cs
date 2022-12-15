using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner.Classes
{
    public class Mathematik
    {
        public static int Fakultaet (int zahl)
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

        public static double Potenz (double zahl, int potenz)
        {
            double ergebnis = 1;

            for (int iterator = 0; iterator < potenz; iterator++)
            {
                ergebnis *= zahl;
            }

            return ergebnis;
        }
    }
}
