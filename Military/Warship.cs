using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Military
{
    sealed public class Warship : Vehicle
    {
        public Warship(double weight, double averageSpeed) : base(weight, averageSpeed)
        {
            Capacity = 20;
            FuelConsumption = 70;
        }
    }
}
