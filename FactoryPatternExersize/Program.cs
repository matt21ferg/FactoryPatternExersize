using System;

namespace FactoryPatternExersize
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("how many tires does your vehicle have?");
           string NumberOfTires = Console.ReadLine();
            IVehicle vehicle = VehicleFactory.GetVehicle(NumberOfTires);
            vehicle.Drive();
        }



        public static string NoSpace(string input)
        {
            var space = "";
            foreach (var letter in input)
            {
                if (letter.IsNullOrWhitespace() is false)
                    space += letter;
            }
            return input;



        }
}
