using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInfo.Demo.Models
{
    internal class Owner
    {
        public void UsingCar(Car car, double longitude, double latitude)
        {
            try
            {
                if (car is not null)
                {
                    car.SetLocation(longitude, latitude);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: {0}", ex);
            }
        }
    }
}
