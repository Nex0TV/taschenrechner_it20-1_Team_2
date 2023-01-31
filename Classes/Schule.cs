using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner.Classes
{
    public class Schule
    {
        public static float Durchschnitt (int[] noten)
        {
            float summe = float.Parse(noten.Sum().ToString());

            return summe / noten.Length;
        }

        public static int Note (float durchschnitt)
        {
            return (int)(durchschnitt + 0.5f);
        }
    }
}
