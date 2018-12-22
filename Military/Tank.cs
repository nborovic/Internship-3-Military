using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Military
{
    sealed public class Tank : Vehicle, IDriveable
    {
        public Tank(double weight, int averageSpeed) : base(weight, averageSpeed)
        {
            Capacity = 6;
            FuelConsumption = 30;
        }
    }
}