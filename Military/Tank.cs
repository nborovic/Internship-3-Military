using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Military
{
    sealed public class Tank : Vehicle
    {
        public Tank(double weight, double averageSpeed) : base(weight, averageSpeed)
        {
            Capacity = 6;
            FuelConsumption = 30;
        }
    }
}
