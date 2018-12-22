using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Military
{
    sealed public class Warship : Vehicle, ISwimmable
    {
        public Warship(double weight, int averageSpeed) : base(weight, averageSpeed)
        {
            Capacity = 50;
            FuelConsumption = 200;
        }
    }
}