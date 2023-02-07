using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner.Classes
{
    public class Geometrie
    {
        private const float Pi = 3.14159f;
        public static float Kreisumfang (float durchmesser)
        {
            return durchmesser * Pi;
        }
    }
}
