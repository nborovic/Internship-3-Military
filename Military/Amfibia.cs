using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Military
{
    sealed public class Amfibia : Vehicle, IDriveable, ISwimmable
    {
        public Amfibia(double weight, int averageSpeed) : base(weight, averageSpeed)
        {
            Capacity = 20;
            FuelConsumption = 70;
        }

        public Tuple<int, int> OverallDistances(int terrestrialDistance, int seaDistance, int numberOfSoldiers) // Nisam moga override-at OverallDistance jer vraca int a ne tuple 
        {
            var tempTerrestrialDistance = terrestrialDistance;
            var tempSeaDistance = seaDistance;

            while (numberOfSoldiers > 0)
            {
                numberOfSoldiers -= Capacity;
                tempTerrestrialDistance = (numberOfSoldiers > 0) ? tempTerrestrialDistance + tempTerrestrialDistance * 2 : tempTerrestrialDistance;
                tempSeaDistance = (numberOfSoldiers > 0) ? tempSeaDistance + tempSeaDistance * 2 : tempSeaDistance;
            }

            return new Tuple<int, int>(tempTerrestrialDistance, tempSeaDistance);
        }
    }
}