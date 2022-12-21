using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner.Classes
{
    class Kreditrechner
    {
        // zinsen
        private static double Ratenkredit (double kredit, double laufzeit, double rate) {
            double rest;
            double monatsRate = rate / 12;
            double interest = kredit * monatsRate;

            double tilgungsAnteil = kredit / rate;

            rest = kredit - tilgungsAnteil;

            for (int i = 0; i < rest; i++) { 
                    
            }
    }
    }
}
