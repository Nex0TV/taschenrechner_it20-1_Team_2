using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taschenrechner.Classes
{
    class Kreditrechner
    {
        // zinsen
        private static List<Dictionary<string, object>> Ratenkredit (double kreditsumme, int laufzeit, double zinssatz) {
            List<Dictionary<string, object>> arr = new List<Dictionary<string, object>>();
            List<Dictionary<string, object>> arr2 = new List<Dictionary<string, object>>();

            double tilgung = kreditsumme / laufzeit;
            double laufzeitMonate = laufzeit * 12;

            double gesamtZins = 0;
            double gesamtAnnuitaet = 0;

            int jahr = 1;

            System.Text.RegularExpressions.Regex percentage_pattern = new System.Text.RegularExpressions.Regex(@"^(\d+|(\.\d+))(\.\d+)?%$");

            if (!percentage_pattern.IsMatch(zinssatz.ToString()))
            {
                zinssatz = zinssatz / 100;
            }

            for (int i = 0; i < laufzeit; i++)
            {
                double zins = kreditsumme * zinssatz;

                double annuitaet = tilgung + zins;

                kreditsumme = kreditsumme - tilgung;

                gesamtAnnuitaet += annuitaet;
                gesamtZins += zins;

                arr.Add(new Dictionary<string, object>
                {
                    { "Jahr:", jahr },
                    { "Gesamtbetrag", kreditsumme },
                    { "Zins:", zins },
                    { "Tilgung:", tilgung },
                    { "Annuität", annuitaet },
                    { "Restschuld", kreditsumme }
                });

                arr2.Add(new Dictionary<string, object>
                {
                    { "Zinsen gesamt:", gesamtZins },
                    { "Annuität gesamt:", gesamtAnnuitaet }
                });

                jahr++;
            }

            Console.WriteLine(laufzeitMonate.ToString());
            Console.WriteLine(laufzeit.ToString());

            // Display the result on the form or in a data grid
            return arr;
        }
    }
}




