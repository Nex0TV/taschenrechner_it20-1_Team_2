using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner.Classes
{
    /// <summary>
    /// Geometrie Modul
    /// </summary>
    public class Geometrie
    {
        /// <summary>
        /// Constant Pi
        /// </summary>
        private const float Pi = 3.141592653f;

        /// <summary>
        /// Calculates the circumference of a circle
        /// </summary>
        /// <param name="durchmesser">Diameter of a circle</param>
        /// <returns>Circumference</returns>
        public static float KreisUmfang (float durchmesser)
        {
            var umfang = durchmesser * Pi;

            return umfang;
        }

        /// <summary>
        /// Calculates the area of a circle
        /// </summary>
        /// <param name="durchmesser">Diameter of a circle</param>
        /// <returns>Area</returns>
        public static float KreisFlaeche(float durchmesser)
        {
            float radius = durchmesser / 2;
            var flaeche = radius * radius * Pi;

            return flaeche;
        }


        /// <summary>
        /// Calculates the area of a triangle
        /// </summary>
        /// <param name="seiteC">Side c of a triangle</param>
        /// <param name="hoehec">Height of side c of a triangle</param>
        /// <returns>Area</returns>
        public static float DreieckFlaeche(float seiteC, float hoehec)
        {
            var flaeche = seiteC * hoehec / 2;

            return flaeche;
        }

        /// <summary>
        /// Calculates the perimeter of a triangle
        /// </summary>
        /// <param name="seiteA">Side a</param>
        /// <param name="seiteB">Side b</param>
        /// <param name="seiteC">Side c</param>
        /// <returns>Triangle perimeter</returns>
        public static float DreieckUmfang(float seiteA, float seiteB, float seiteC)
        {
            var umfang = seiteA + seiteB + seiteC;

            return umfang;
        }

        /// <summary>
        /// Calculates the perimeter of a parallelogram
        /// </summary>
        /// <param name="seiteA">Side a</param>
        /// <param name="seiteB">Side b</param>
        /// <returns>Parallelogram circumference</returns>
        public static float ParallelogrammUmfang (float seiteA, float seiteB)
        {
            var umfang = (seiteA + seiteB) * 2;

            return umfang;
        }

        /// <summary>
        /// Calculates the area of a parallelogram
        /// </summary>
        /// <param name="seiteB">Side b</param>
        /// <param name="hoeheB">Height of side b</param>
        /// <returns></returns>
        public static float ParallelogrammFlaeche (float seiteB, float hoeheB)
        {
            var flaeche = seiteB * hoeheB;

            return flaeche;
        }
    }
}
