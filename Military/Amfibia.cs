using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Military
{
    sealed public class Amfibia : Vehicle, IDriveable, ISwimmable
    {
        public Amfibia(double weight, double averageSpeed) : base(weight, averageSpeed)
        {
            Capacity = 50;
            FuelConsumption = 200;
        }

        public void Move(int distance)
        {

        }

        public void Swim(int distance)
        {

        }
    }
}
