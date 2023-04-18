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
        public static double zins(double betrag, double zinssatz, int laufzeit)
        {
            double zinsen;
            double faktor = 0;
            for (int i = 1; i <= laufzeit; i++)
            {
                faktor = faktor + i;
            }
            faktor = faktor / laufzeit;

            zinsen = Math.Round(((betrag * faktor * zinssatz) / 100) / 12, 2);
            return zinsen;

        }

        public static string RatenkreditVorgabeRatenhoehe(double kredit, double zinssatz, double rate)
        {
            double laufzeit = kredit / rate;
            laufzeit = Math.Ceiling(laufzeit);

            double zinsen = zins(kredit, zinssatz, (int)laufzeit);
            laufzeit = Math.Ceiling((kredit + zinsen) / rate);
            double schlussrate = Math.Ceiling(kredit + zinsen) - (laufzeit - 1) * rate;

            string ergebnis = String.Format("\nKredit => {0:f} €, \nZinssatz => {1:f} % \nRate => {2:f} € \nLaufzeit: {3:d} Monat(e) \nSchlussrate => {4:f} €", kredit, zinssatz, rate, Convert.ToInt32(laufzeit), schlussrate);
            Console.WriteLine(ergebnis);
            return ergebnis;
        }

        public static string RatenkreditVorgabeLaufzeit(double kredit, double zinssatz, double laufzeit)
        {
            double zinsen = zins(kredit, zinssatz, (int)laufzeit);
            double rate = (kredit + zinsen) / laufzeit;
            double schlussrate = Math.Ceiling(kredit + zinsen) - (laufzeit - 1) * rate;
            string ergebnis = String.Format("\nKredit => {0:f} € \nZinssatz => {1:f} % \nRate => {2:f} € \nLaufzeit => {3:d} Monat(e) \nSchlussrate => {4:f} €", kredit, zinssatz, rate, Convert.ToInt32(laufzeit), schlussrate);
            Console.WriteLine(ergebnis);
            return ergebnis;
        }

        public static string Einmalrueckzahlung(double kredit, double zinssatz)
        {
            double zinsen = zins(kredit, zinssatz, 1);
            double rueckzahlbetrag = kredit + zinsen;
            string ergebnis = String.Format("\nEinmalrückzahlbetrag => {0:f}", rueckzahlbetrag);
            Console.WriteLine(ergebnis);
            return ergebnis;

        }
    }
}




