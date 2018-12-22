using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Military
{
    public abstract class Vehicle
    {
        public static int Id = 0;
        public double Weight { get; set; }
        public double AverageSpeed { get; set; }
        public static double FuelConsumption;
        public static int Capacity;

        protected Vehicle(double weight, double averageSpeed)
        {
            Id++;
            Weight = weight;
            AverageSpeed = averageSpeed;
        }
    }
}
