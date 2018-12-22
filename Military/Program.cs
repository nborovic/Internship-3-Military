using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Military
{
    class Program
    {
        static void Main(string[] args)
        {
            var tankDistance = Functions.TankDistanceInput();
            var warshipDistance = Functions.WarshipDistanceInput();
            var amfibiaDistance = Functions.AmfibiaDistanceInput();
            var numberOfSoldiers = Functions.NumberOfSoldiersInput();

            if (amfibiaDistance.Item1 + amfibiaDistance.Item2 <= warshipDistance &&
                amfibiaDistance.Item1 + amfibiaDistance.Item2 <= tankDistance)
            {
                var tank = new Tank(2800, 35);
                var warship = new Warship(21600, 26);
                var amfibia = new Amfibia(2400, 50);

                var tankFuelConsumptionIndex = Functions.GetTankConsumptionIndex(tankDistance, numberOfSoldiers, tank);
                var warshipFuelConsumptionIndex = Functions.GetWarshipConsumptionIndex(warshipDistance, numberOfSoldiers, warship);
                var amfibiaFuelConsumptionIndex = Functions.GetAmfibiaConsumptionIndex(amfibiaDistance, numberOfSoldiers, amfibia);

                Console.WriteLine($"\nTank:\n{tank.ToString()}\nFuel consumption index: {tankFuelConsumptionIndex}\n\nWarship:\n{warship.ToString()}\n" +
                                  $"Fuel consumption index: {warshipFuelConsumptionIndex}\n\nAmfibia:\n{amfibia.ToString()}\nFuel consumption index: {amfibiaFuelConsumptionIndex}");

                var fuelIndexes = new double[3];
                fuelIndexes[0] = tankFuelConsumptionIndex;
                fuelIndexes[1] = warshipFuelConsumptionIndex;
                fuelIndexes[2] = amfibiaFuelConsumptionIndex;

                var vehicle = Functions.GetMin(fuelIndexes);
                
                Console.WriteLine($"\nTrebate izabrati {vehicle}!");

            }
            else
            {
                Console.WriteLine("Put amfibije ne moze biti veci od puta tenka ili ratnog broda!");
            }
        }
    }
}