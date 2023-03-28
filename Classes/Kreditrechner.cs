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

        public static Dictionary<string, object> berechneKredit(double kreditsumme, double laufzeit, double zinssatz)
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
            Console.WriteLine(data);
            return data;
        }
    }
}




