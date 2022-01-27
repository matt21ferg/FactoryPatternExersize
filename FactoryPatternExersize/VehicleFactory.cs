using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExersize 
{
    public static class VehicleFactory 
    {
        public static IVehicle GetVehicle(string NumberOfTires) 
        {
            switch(NumberOfTires)
            {
                case "2":
                    return new Motercycle();
                default:
                    return new Car();
                    


            }
        }

        
    }
}
