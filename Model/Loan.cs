using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner.Model
{
    class LoanCalculator
    {
        // Funktion für Ratenkredit

        /* Parameter:
        /      loan = Kredit
        /      term = laufzeit 
        /      interest rate = Tilgungsrate
        /
        */
        public static double[] installment (double loan, double term, double interestRate)
        {
            // Zinsen
            double interest = loan * interestRate;
            // Tilgung
            double repayment = loan / term;
            // annuitaet
            double annuity = repayment + interest;
            // Restschulden
            double remainingDebt = loan - annuity;


            double[] result = { };
            try
            {



                return result;
            }
            catch
            {

            }
        }
    }
}
