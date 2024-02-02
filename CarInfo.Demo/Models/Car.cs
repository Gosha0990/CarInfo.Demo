using CarInfo.CoreLib.Services;
using CarInfo.CoreLib.Static;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInfo.Demo.Models
{
    internal class Car
    {
        private double _mileage;
        public string Wim { get; set; } = string.Empty;

        private double _longitude;
        private double _latitude;

        private Timer _timer;
        private int _interval = 500;

        public Car() 
        {
            _timer = new Timer(new TimerCallback(SendingLocation), null, 0, _interval);
        }

        public double GetMileage()
        {
            return _mileage;
        }

        public void SetLocation (double longitude, double latitude) 
        {
            if(longitude > 0 && latitude > 0)
            {
                if (_longitude == 0 && _latitude == 0)
                {
                    _longitude = longitude;
                    _latitude = latitude;
                }
                else
                {
                    _mileage += Tools.PathLengthCalculation( _latitude, _longitude, latitude, longitude);

                    _longitude = longitude;
                    _latitude = latitude;
                }
            }
        }

        private void SendingLocation(object? obj)
        {
            var carInfoService = new CarInfoService();

            carInfoService.SavePoint(Wim, _longitude, _latitude);
        }
    }
}
