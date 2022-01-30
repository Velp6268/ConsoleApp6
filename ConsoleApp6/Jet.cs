using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Jet : Motor
    {
        public override void Сapacity()
        {
            Console.WriteLine("Jet - Сapacity");
        }
        public override void FuelConsumption()
        {
            Console.WriteLine("Jet - FuelConsumption");
        }
        public void HPpower()
        {
            Console.WriteLine("Jet - HP Power");
        }
        public void MotorYear()
        {
            Console.WriteLine("Jet - Motor Year");
        }
        public void MotorModel()
        {
            Console.WriteLine("Jet - Motor Model");
        }
    }
}
