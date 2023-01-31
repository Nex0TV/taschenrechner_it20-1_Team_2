using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taschenrechner.Classes
{
    public class Kreditrechner
    {
        // zinsen
        public static List<Dictionary<string, object>> Ratenkredit (double kreditsumme, int laufzeit, double zinssatz) {
            List<Dictionary<string, object>> data = new List<Dictionary<string, object>>();

            //var data = [arr, arr2];
            double kredit = kreditsumme;

            //double tilgung = kreditsumme / laufzeit;
            //double laufzeitMonate = laufzeit * 12;

            //double gesamtZins = 0;

            int jahr = 1;

            //System.Text.RegularExpressions.Regex percentage_pattern = new System.Text.RegularExpressions.Regex(@"^(\d+|(\.\d+))(\.\d+)?%$");

            //if (!percentage_pattern.IsMatch(zinssatz.ToString()))
            //{
            //    zinssatz = zinssatz / 100;
            //}

            for (int i = 0; i < laufzeit; i++)
            {
                //double zins = kreditsumme * zinssatz;

                //double annuitaet = tilgung + zins;

               /* kreditsumme = kreditsumme - tilgung*/;


                //gesamtZins += zins;

                //data.Add(new Dictionary<string, object>
                //{
                //    { "Jahr", jahr },
                //    { "Gesamtbetrag", kredit },
                //    { "Zins", zins },
                //    { "Tilgung", tilgung },
                //    { "Annuität", annuitaet },
                //    { "Restschuld", kreditsumme },
                //    { "Zinsen gesamt", gesamtZins },
                //    { "Annuität gesamt", gesamtAnnuitaet }
                //});

                jahr++;
            }


            foreach (Dictionary<string, object> entry in data)
            {
                Console.WriteLine(entry.Keys.Count);
            }



            // Display the result on the form or in a data grid
            return data;
        }

        public static double validateZinssatz(double zinssatz)
        {

            return zinssatz / 100;
        }

        public static double Tilgung(double kreditsumme, double laufzeit)
        {
            return kreditsumme / laufzeit;
        }
        public static double laufzeitInMonaten(double laufzeitInJahren)
        {
            return laufzeitInJahren * 12;
        }

        public static double Zins(double zinssatz, double kreditsumme)
        {
            return kreditsumme * zinssatz;
        }

        public static double annuitaet(double tilgung, double zins)
        {
            return tilgung + zins;
        }

        public static double restKredit(double kreditsumme, double tilgung)
        {
            return kreditsumme - tilgung;
        }

        public static double gesamtZinsen(double zins, double jahr)
        {
            double gesamtZinsen = 0;

            for (var i = 1; i < jahr; i++)
            {
                 gesamtZinsen += zins;
            }

            return gesamtZinsen;
        }
    }
}




