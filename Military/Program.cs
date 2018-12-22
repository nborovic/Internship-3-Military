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
        }
    }
}