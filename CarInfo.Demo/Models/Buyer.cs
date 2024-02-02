using CarInfo.CoreLib.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInfo.Demo.Models
{
    internal class Buyer
    {
        public double RequestMileage(Car car)
        {
            double mileage = 0;

            try
            {
                var carInfoService = new CarInfoService();
                mileage = carInfoService.GetMileage(car.Wim);
            }
            catch(Exception ex) 
            { 
                Console.WriteLine("Error: {0}", ex);
            }

            return mileage;
        }
    }
}
