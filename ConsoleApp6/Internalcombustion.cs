using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Internalcombustion : Motor
    {
        public override void Сapacity()
        {
            Console.WriteLine("Internalcombustion - Сapacity");
        }
        public override void FuelConsumption()
        {
            Console.WriteLine("Internalcombustion - FuelConsumption");
        }
        public void Temperature()
        {
            Console.WriteLine("Internalcombustion - Temperature");
        }
        public void Weight()
        {
            Console.WriteLine("Internalcombustion - Weight");
        }
    }
}
