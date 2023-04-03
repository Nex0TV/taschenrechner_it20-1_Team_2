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

        public static int[] ValidierteNoten (int[] noten)
        {
            int[] validierteNoten = new int[0];
            foreach (int note in noten)
            {
                if(note <= 6 && note >= 1)
                {
                    Array.Resize<int>(ref validierteNoten, validierteNoten.Length + 1);
                    validierteNoten[validierteNoten.Length - 1] = note;
                }
            }
            return validierteNoten;
        }

        public static int Anzahl (int[] noten)
        {
            int anzahl = 0;
            foreach (int note in noten)
            {
                anzahl++;
            }
            return anzahl;
        }
    }
}
