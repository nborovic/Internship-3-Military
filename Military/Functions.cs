using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Military
{
    public static class Functions
    {
        public static double TankDistanceInput()
        {
            Console.Write("Unesi kopnenu udaljenost za tenk: ");
            var terrestrialDistance = double.Parse(Console.ReadLine());

            return terrestrialDistance;
        }

        public static double WarshipDistanceInput()
        {
            Console.Write("Unesi morsku udaljenost za ratni brod: ");
            var seaDistance = double.Parse(Console.ReadLine());

            return seaDistance;
        }

        public static Tuple<double, double> AmfibiaDistanceInput()
        {
            Console.Write("Unesi kopnenu udaljenost za amfibiju: ");
            var terrestrialDistance = double.Parse(Console.ReadLine());

            Console.Write("Unesi morsku udaljenost za amfibiju: ");
            var seaDistance = double.Parse(Console.ReadLine());

            return new Tuple<double, double>(terrestrialDistance, seaDistance);
        }

        public static int NumberOfSoldiersInput()
        {
            Console.Write("Unesi broj vojnika: ");
            var numberOfSoldiers = int.Parse(Console.ReadLine());

            return numberOfSoldiers;
        } 
    }
}
