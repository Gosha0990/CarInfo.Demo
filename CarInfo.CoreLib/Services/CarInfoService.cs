using CarInfo.CoreLib.Static;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInfo.CoreLib.Services
{
    public class CarInfoService
    {
        public bool SavePoint(string win, double longitude, double Latitude)
        {
            var res = false;

            try
            {
                if(longitude > 0 && Latitude > 0) 
                {
                    var point = new Point()
                    {
                        Latitude = Latitude,
                        Longitude = longitude,
                    };

                    var points = new List<Point>();

                    if(DbEmulator.MileageCar.TryGetValue(win, out points))
                    {
                        DbEmulator.MileageCar.TryRemove(win, out points);
                    }

                    if (points != null)
                    {
                        var lastPoint = points.Last();

                        if (lastPoint.Longitude != longitude && lastPoint.Latitude != Latitude)
                        {
                            points.Add(point);
                        }
                    }
                    else
                    {
                        points = new List<Point>() { point };
                    }

                    DbEmulator.MileageCar.TryAdd(win, points);

                    res = true;
                }
            }
            catch (Exception ex)
            { 
                Console.WriteLine("Error: {0}", ex);
            }
            return res;
        }

        public double GetMileage(string win) 
        { 
            double mileage = 0;

            try
            {
                if(!string.IsNullOrEmpty(win))
                {
                    if(DbEmulator.MileageCar.TryGetValue(win, out var points))
                    {
                        if(points is not null)
                        {
                            for (int i = 0; i < points.Count; i++) 
                            { 
                                if(i < points.Count - 1)
                                {
                                    mileage += Tools.PathLengthCalculation(points[i].Latitude, points[i].Longitude, 
                                        points[i+1].Latitude, points[i+1].Longitude);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex) 
            { 
                Console.WriteLine("Error: {0}", ex);
            }

            return mileage;
        }
    }
}
