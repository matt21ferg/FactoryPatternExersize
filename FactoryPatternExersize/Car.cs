using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExersize
{
    public class Car : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("building a new car!");
        }
    }
}
