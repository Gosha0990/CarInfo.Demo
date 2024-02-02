using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInfo.CoreLib.Static
{
    internal static class DbEmulator
    {
        public static ConcurrentDictionary<string, List<Point>> MileageCar = new ConcurrentDictionary<string, List<Point>>();
    }
}
