using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInfo.CoreLib.Static
{
    public static class Tools
    {
        public static double PathLengthCalculation(double startLat, double startLon, double finshLat, double finisLon)
        {
            double R = 6372795;
            double sLat1 = Math.Sin(Radians(startLat));
            double sLat2 = Math.Sin(Radians(finshLat));
            double cLat1 = Math.Cos(Radians(startLat));
            double cLat2 = Math.Cos(Radians(finshLat));
            double cLon = Math.Cos(Radians(startLon) - Radians(finisLon));
            double cosD = sLat1 * sLat2 + cLat1 * cLat2 * cLon;
            double d = Math.Acos(cosD);
            double dist = R * d;

            return dist;
        }

        private static double Radians(double degree)
        {
            return degree * Math.PI / 180.0;
        }
    }
}
