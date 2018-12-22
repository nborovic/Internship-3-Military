using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Military
{
    public abstract class Vehicle
    {
        public Guid Id { get; set; }
        public double Weight { get; set; }
        public int AverageSpeed { get; set; }
        public static double FuelConsumption;
        public static int Capacity;

        protected Vehicle(double weight, int averageSpeed)
        {
            Id = Guid.NewGuid();
            Weight = weight;
            AverageSpeed = averageSpeed;
        }

        public override string ToString()
        {
            return $"Id: {Id}\nWeight: {Weight}kg\nAverage speed: {AverageSpeed}km/h\nCapacity: {Capacity} soldiers";
        }

        public int Move(int distance)
        {
            var random = new Random();
            var tempDistance = distance;

            while (tempDistance > 0)
            {
                int chance = random.Next(1, 4);
                tempDistance -= 10;

                if (chance == 1)
                {
                    distance += 5;
                    tempDistance += 5;
                }           
            }

            return distance;
        }

        public int Swim(int distance)
        {
            var random = new Random();
            var distanceInTenMinutes = AverageSpeed * (10.0 / 60.0);
            var tempDistance = (double)distance;

            while (tempDistance > 0)
            {
                int chance = random.Next(1, 3);
                tempDistance -= distanceInTenMinutes;

                if (chance == 1)
                {
                    distance += 3;
                    tempDistance += 3;
                }
            }

            return distance;
        }

        public int OverallDistance(int distance, int numberOfSoldiers)
        {
            var tempDistance = distance;
            
            while (numberOfSoldiers > 0)
            {
                numberOfSoldiers -= Capacity;
                tempDistance = (numberOfSoldiers > 0) ? tempDistance + distance * 2 : tempDistance;
            }

            return tempDistance;
        }

        public double FuelConsumptionIndex(int distance)
        {
            return distance * FuelConsumption;
        }
    }
}