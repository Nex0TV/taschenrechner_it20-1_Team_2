using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner.Classes
{
    public class Geometrie
    {
        private const float Pi = 3.141592653f;

        public static float Kreisumfang (float durchmesser)
        {
            return durchmesser * Pi;
        }

        public static float Kreisflaeche (float durchmesser)
        {
            float radius = durchmesser / 2;
            return radius * radius * Pi;
        }
    }
}
