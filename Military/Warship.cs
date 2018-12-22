using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Military
{
    sealed public class Warship : Vehicle, ISwimmable
    {
        public Warship(double weight, double averageSpeed) : base(weight, averageSpeed)
        {
            Capacity = 20;
            FuelConsumption = 70;
        }

        public void Swim(int distance)
        {

        }
    }
}
