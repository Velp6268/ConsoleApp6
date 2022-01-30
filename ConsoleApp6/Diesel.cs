using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Diesel : Motor
    {
        public override void Сapacity()
        {
            Console.WriteLine("Diesel - Сapacity");
        }

        public override void FuelConsumption()
        {
            Console.WriteLine("Diesel - FuelConsumption");
        }

        public void oilconsumption()
        {
            Console.WriteLine("Diesel - Oil Consumption");
        }



    }
}
