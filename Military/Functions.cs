using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Military
{
    public static class Functions
    {
        public static int TankDistanceInput()
        {
            Console.Write("Unesi kopnenu udaljenost za tenk: ");
            var terrestrialDistance = int.Parse(Console.ReadLine());

            return terrestrialDistance;
        }

        public static int WarshipDistanceInput()
        {
            Console.Write("Unesi morsku udaljenost za ratni brod: ");
            var seaDistance = int.Parse(Console.ReadLine());

            return seaDistance;
        }

        public static Tuple<int, int> AmfibiaDistanceInput()
        {
            Console.Write("Unesi kopnenu udaljenost za amfibiju: ");
            var terrestrialDistance = int.Parse(Console.ReadLine());

            Console.Write("Unesi morsku udaljenost za amfibiju: ");
            var seaDistance = int.Parse(Console.ReadLine());

            return new Tuple<int, int>(terrestrialDistance, seaDistance);
        }

        public static int NumberOfSoldiersInput()
        {
            Console.Write("Unesi broj vojnika: ");
            var numberOfSoldiers = int.Parse(Console.ReadLine());

            return numberOfSoldiers;
        }

        public static string GetMin(double[] fuelIndexes)
        {
            var min = fuelIndexes[0];
            var vehicle = "";

            foreach (double fuelIndex in fuelIndexes)
            {
                if (fuelIndex < min)
                {
                    min = fuelIndex;
                }
            }

            if (min == fuelIndexes[0])
            {
                vehicle = "tenk";
            }
            else if (min == fuelIndexes[1])
            {
                vehicle = "ratni brod";
            }
            else
            {
                vehicle = "amfibiju";
            }

            return vehicle;
        }

        public static double GetTankConsumptionIndex(int tankDistance, int numberOfSoldiers, Tank tank)
        {
            var overallTankDistance = tank.OverallDistance(tankDistance, numberOfSoldiers);
            var overallTankDistanceWithMove = tank.Move(overallTankDistance);
            var tankFuelConsumptionIndex = tank.FuelConsumptionIndex(overallTankDistanceWithMove);

            return tankFuelConsumptionIndex;
        }

        public static double GetWarshipConsumptionIndex(int warshipDistance, int numberOfSoldiers, Warship warship)
        {
            var overallWarshipDistance = warship.OverallDistance(warshipDistance, numberOfSoldiers);
            var overallWarshipDistanceWithMove = warship.Swim(overallWarshipDistance);
            var warshipFuelConsumptionIndex = warship.FuelConsumptionIndex(overallWarshipDistanceWithMove);

            return warshipFuelConsumptionIndex;
        }

        public static double GetAmfibiaConsumptionIndex(Tuple<int, int> amfibiaDistance, int numberOfSoldiers, Amfibia amfibia)
        {
            var overallAmfibiaDistances = amfibia.OverallDistances(amfibiaDistance.Item1, amfibiaDistance.Item2, numberOfSoldiers);
            var overallAmfibiaDistanceWithMove = amfibia.Move(overallAmfibiaDistances.Item1);
            var overallAmfibiaDistanceWithSwim = amfibia.Swim(overallAmfibiaDistances.Item2);
            var amfibiaFuelConsumptionIndex = amfibia.FuelConsumptionIndex(overallAmfibiaDistanceWithMove + overallAmfibiaDistanceWithSwim);

            return amfibiaFuelConsumptionIndex;
        }
    }
}