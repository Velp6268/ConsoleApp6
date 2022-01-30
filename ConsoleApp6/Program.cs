using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Diesel diesel = new Diesel();
            Internalcombustion internalcombustion = new Internalcombustion();
            Jet jet = new Jet();

            diesel.Сapacity();
            diesel.FuelConsumption();
            diesel.oilconsumption();

            internalcombustion.Сapacity();
            internalcombustion.FuelConsumption();
            internalcombustion.Temperature();
            internalcombustion.Weight();

            jet.Сapacity();
            jet.FuelConsumption();
            jet.HPpower();
            jet.MotorYear();
            jet.MotorModel();
        }
    }
}