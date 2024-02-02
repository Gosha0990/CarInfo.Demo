using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace CarInfo.Demo.Models
{
    internal class Hacker
    {
        public bool ChangeMileage(Car car)
        {
            var res = false;

            Type type = car.GetType();

            FieldInfo[] fields = type.GetFields(BindingFlags.Public | BindingFlags.NonPublic
                                             | BindingFlags.Instance);

            foreach (FieldInfo field in fields) 
            { 
                if(field.Name == "_mileage")
                {
                    field.SetValue(car, 100);

                    res = true;
                }
            }

            return res; 
        }
    }
}
