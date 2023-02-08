using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner.Classes
{
    public class Geometrie
    {
        private const float Pi = 3.141592653f;

        public static float KreisUmfang (float durchmesser)
        {
            return durchmesser * Pi;
        }

        public static float KreisFlaeche (float durchmesser)
        {
            float radius = durchmesser / 2;
            return radius * radius * Pi;
        }

        public static float DreieckFlaeche (float seitec, float hoehec)
        {
            return seitec * hoehec / 2;
        }

        public static float DreieckUmfang (float seitea, float seiteb, float seitec)
        {
            return seitea + seiteb + seitec;
        }

        public static float ParallelogrammUmfang (float seitea, float seiteb)
        {
            return (seitea + seiteb) * 2;
        }

        public static float ParallelogrammFlaeche (float seiteb, float hoeheb)
        {
            return seiteb * hoeheb;
        }
    }
}
