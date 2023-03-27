using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taschenrechner.Classes
{
    public class kredit
    {
        public bool OneTimePayment { get; set; }
        public double Loan { get; set; }
        public int Runtime { get; set; }
        public double LoanRate { get; set; }
        // constructor
        public kredit(double loan, int runtime, double loanRate = 0, bool oneTimePayment = false)
        {
            this.OneTimePayment = oneTimePayment;
            this.Loan = loan;
            this.Runtime = runtime;
            this.LoanRate = loanRate;

            if (loanRate == 0)
            {
                this.LoanRate = loan / runtime;
            }
        }

        public static double zinssatz(double zinssatz)
        {
            return zinssatz / 100;
        }

        public static double tilgung(double kreditsumme, double laufzeit)
        {
            return kreditsumme / laufzeit;
        }
        public static double laufzeitInMonaten(double dauerInJahren)
        {
            return dauerInJahren * 12;
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

        public static double gesamtZinsen(double zins, double dauer)
        {
            double gesamtZinsen = 0;

            for (var i = 1; i < dauer; i++)
            {
                gesamtZinsen += zins;
            }

            return gesamtZinsen;
        }

        public Dictionary<string, object> berechneKredit(double kreditsumme, double laufzeit, double zinssatz)
        {
            Dictionary<string, object> data = new Dictionary<string, object>();
            double _tilgung = tilgung(kreditsumme, laufzeit);
            double kredit = kreditsumme;

            for (int i = 0; i < laufzeit; i++)
            {
                double zins = Zins(kreditsumme, zinssatz);

                double _annuitaet = annuitaet(_tilgung, zins);

                kreditsumme = restKredit(kreditsumme, _tilgung);

                double gesamtZins = gesamtZinsen(zins, laufzeit);

                data.Add("Gesamtbetrag", kredit);
                data.Add("Zins", zins);
                data.Add("Tilgung", _tilgung);
                data.Add("Annuitaet", _annuitaet);
                data.Add("Restschuld", kreditsumme );
                data.Add("Zinsen gesamt", gesamtZins);
            }

            return data;
        }
    }

    public class Kreditrechner
    {
            // zinsen
            //public static List<Dictionary<string, object>> Ratenkredit (double kreditsumme, int laufzeit, double zinssatz) {

            //var data = [arr, arr2];
            //double kredit = kreditsumme;

            //double tilgung = kreditsumme / laufzeit;
            //double laufzeitMonate = laufzeit * 12;

            //double gesamtZins = 0;

            //int jahr = 1;

            //System.Text.RegularExpressions.Regex percentage_pattern = new System.Text.RegularExpressions.Regex(@"^(\d+|(\.\d+))(\.\d+)?%$");

            //if (!percentage_pattern.IsMatch(zinssatz.ToString()))
            //{
            //    zinssatz = zinssatz / 100;
            //}

            //for (int i = 0; i < laufzeit; i++)
            //{
            //double zins = kreditsumme * zinssatz;

            //double annuitaet = tilgung + zins;

            /* kreditsumme = kreditsumme - tilgung*/


            //gesamtZins += zins;

            //data.Add(new Dictionary<string, object>
            //{
            //    { "Gesamtbetrag", kredit },
            //    { "Zins", zins },
            //    { "Tilgung", tilgung },
            //    { "Annuitaet", annuitaet },
            //    { "Restschuld", kreditsumme },
            //    { "Zinsen gesamt", gesamtZins },
            //    { "Annuität gesamt", gesamtAnnuitaet }
            //});

            //    jahr++;
            //}


            // Display the result on the form or in a data grid
            //return data;
            //}


        }
}




