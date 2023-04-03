using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner.Classes
{
    public class Prozentrechnung
    {
        public static double ProzentDazu (double psatz, double grundwert)
        {
            double ergebnis = 1;

          if(psatz != 0)
            {
                ergebnis = ((psatz / 100) * grundwert) + grundwert;
                
            }
            return ergebnis;
       
        }

        public static double ProzentWeg(double prozentsatz, double grundwert)
        {
            double ergebnis = 1;

            if (prozentsatz != 0)
            {
                ergebnis = grundwert - ((prozentsatz / 100) * grundwert);

            }
            return ergebnis;

        }

        public static double Nettopreis(double bruttopreis)
        {
            if(bruttopreis == 0)
            {
                return 1;
            }
            else
            {
                double ergebnis = bruttopreis * 0.81;
                return ergebnis;
            }
        }

        public static double Bruttopreis(double nettopreis)
        {
            if(nettopreis == 0)
            {
                return 1;
            }
            else
            {
                double ergebnis = nettopreis * 1.19;
                return ergebnis;
            }
        }
        public static double Prozentsatz(double prozentwert, double grundwert)
        {
            double ergebnis = 1;

            if (grundwert != 0)
            {
                ergebnis = (prozentwert / grundwert) * 100;

            }
            return ergebnis;

        }
    }
}
