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
            if (psatz == 0) return grundwert;
            var prozent = ((psatz / 100) * grundwert) + grundwert;

            return prozent;
        }

        public static double ProzentWeg(double prozentsatz, double grundwert)
        {
            if (prozentsatz == 0) return grundwert;
            var prozent = grundwert - ((prozentsatz / 100) * grundwert);

            return prozent;
        }

        public static double Nettopreis(double bruttopreis)
        {
            if (bruttopreis <= 0) return 0;
            var preis = bruttopreis * 0.81;

            return preis;
        }

        public static double Bruttopreis(double nettopreis)
        {
            if(nettopreis <= 0) return 0;
            var preis = nettopreis * 100/119;

            return preis;
        }
        public static double Prozentsatz(double prozentwert, double grundwert)
        {
            if (grundwert <= 0) return -1;
            var prozent = (prozentwert / grundwert) * 100;

            return prozent;
        }
    }
}
