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
            return durchmesser * Pi;
        }

        /// <summary>
        /// Calculates the area of a circle
        /// </summary>
        /// <param name="durchmesser">Diameter of a circle</param>
        /// <returns>Area</returns>
        public static float KreisFlaeche (float durchmesser)
        {
            float radius = durchmesser / 2;
            return radius * radius * Pi;
        }


        /// <summary>
        /// Calculates the area of a triangle
        /// </summary>
        /// <param name="seitec">Side c of a triangle</param>
        /// <param name="hoehec">Height of side c of a triangle</param>
        /// <returns>Area</returns>
        public static float DreieckFlaeche (float seitec, float hoehec)
        {
            return seitec * hoehec / 2;
        }

        /// <summary>
        /// Calculates the perimeter of a triangle
        /// </summary>
        /// <param name="seitea">Side a</param>
        /// <param name="seiteb">Side b</param>
        /// <param name="seitec">Side c</param>
        /// <returns>Triangle perimeter</returns>
        public static float DreieckUmfang (float seitea, float seiteb, float seitec)
        {
            return seitea + seiteb + seitec;
        }

        /// <summary>
        /// Calculates the perimeter of a parallelogram
        /// </summary>
        /// <param name="seitea">Side a</param>
        /// <param name="seiteb">Side b</param>
        /// <returns>Parallelogram circumference</returns>
        public static float ParallelogrammUmfang (float seitea, float seiteb)
        {
            return (seitea + seiteb) * 2;
        }

        /// <summary>
        /// Calculates the area of a parallelogram
        /// </summary>
        /// <param name="seiteb">Side b</param>
        /// <param name="hoeheb">Height of side b</param>
        /// <returns></returns>
        public static float ParallelogrammFlaeche (float seiteb, float hoeheb)
        {
            return seiteb * hoeheb;
        }
    }
}
