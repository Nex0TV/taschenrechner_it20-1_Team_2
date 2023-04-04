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
        //Ratenkredit mit Vorgabe Ratenhöhe
        private double zins(double betrag, double zinssatz, int laufzeit)
        {
            double zinsen;
            double faktor = 0;
            for (int i = 1; i <= laufzeit; i++)
            {
                faktor = faktor + i;
            }
            faktor = faktor / laufzeit;

            zinsen = betrag * faktor * zinssatz / 100 / 12;
            return zinsen;

        }

        private string berechneKredit(double kredit, double zinssatz, double rate)
        {
            double laufzeit = kredit / rate;
            laufzeit = Math.Ceiling(laufzeit);

            double zinsen = zins(kredit, zinssatz, (int)laufzeit);
            laufzeit = Math.Ceiling((kredit + zinsen) / rate);
            double schlussrate = Math.Ceiling(kredit + zinsen) - (laufzeit - 1) * rate;

            string ergebnis = String.Format("Kredit: {0:f} €, Zinssatz: {1:f} % Rate: {2:f} € -> Laufzeit: {3:d} Monate, Schlussrate: {4:f} €", kredit,zinssatz, rate, Convert.ToInt32(laufzeit), schlussrate);
            return ergebnis;
        }

        //    public bool OneTimePayment { get; set; }
        //    public double Loan { get; set; }
        //    public int Runtime { get; set; }
        //    public double LoanRate { get; set; }
        //    // constructor
        //    public kredit(double loan, int runtime, double loanRate = 0, bool oneTimePayment = false)
        //    {
        //        this.OneTimePayment = oneTimePayment;
        //        this.Loan = loan;
        //        this.Runtime = runtime;
        //        this.LoanRate = loanRate;

        //        if (loanRate == 0)
        //        {
        //            this.LoanRate = loan / runtime;
        //        }


        //    }

        //    public static double zinssatz(double zinssatz)
        //    {
        //        return zinssatz / 100;
        //    }

        //    public static double tilgung(double kreditsumme, double laufzeit)
        //    {
        //        return kreditsumme / laufzeit;
        //    }
        //    public static double laufzeitInMonaten(double dauerInJahren)
        //    {
        //        return dauerInJahren * 12;
        //    }

        //    public static double Zins(double zinssatz, double kreditsumme)
        //    {
        //        return kreditsumme * zinssatz;
        //    }

        //    public static double annuitaet(double tilgung, double zins)
        //    {
        //        return tilgung + zins;
        //    }

        //    public static double restKredit(double kreditsumme, double tilgung)
        //    {
        //        return kreditsumme - tilgung;
        //    }

        //    public static double gesamtZinsen(double kreditsumme, double zins, double dauerMonate, double _tilgung)
        //    {
        //        double gesamtZinsen = 0;

        //        for (var i = 1; i < dauerMonate; i++)
        //        {
        //            gesamtZinsen += kreditsumme * zins / 12;
        //            kreditsumme -= _tilgung;
        //        }

        //        return gesamtZinsen;
        //    }

        //    public static Dictionary<string, object> berechneKredit(double kreditsumme, double laufzeitMonate, double zinssatz)
        //    {
        //        Dictionary<string, object> data = new Dictionary<string, object>();
        //        double _tilgung = tilgung(kreditsumme, laufzeitMonate);
        //        double kredit = kreditsumme;

        //        for (int i = 0; i < laufzeitMonate; i++)
        //        {
        //            double zins = Zins(kreditsumme, zinssatz);

        //            double _annuitaet = annuitaet(_tilgung, zins);

        //            kreditsumme = restKredit(kreditsumme, _tilgung);

        //            double gesamtZins = gesamtZinsen(kreditsumme, zins, laufzeitMonate, _tilgung);

        //            data.Add("Gesamtbetrag", kredit);
        //            data.Add("Zins", zins);
        //            data.Add("Tilgung", _tilgung);
        //            data.Add("Annuitaet", _annuitaet);
        //            data.Add("Restschuld", kreditsumme );
        //            data.Add("Zinsen gesamt", gesamtZins);
        //        }
        //        Console.WriteLine(data);
        //        return data;
        //    }
        //}
    }




