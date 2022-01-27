using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExersize
{
    public class Motercycle : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("building a new motorcycle");
        }
    }
}
