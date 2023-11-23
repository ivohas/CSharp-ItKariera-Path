using System;
namespace TravelAgency
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string system = Console.ReadLine();
            double cap = double.Parse(Console.ReadLine());
            double smt = 0;
            switch (system)
            {
                case "miles":
                     smt= cap*1.6;
                    Console.WriteLine($"{cap} miles  = {smt:f2} kilometers");
                    break;
                case "inches":
                     smt = cap * 2.54;
                    Console.WriteLine($"{cap} inches = {smt:f2} centimeters");
                    break;
                case "feet":
                    smt = cap * 30;
                    Console.WriteLine($"{cap} feet = {smt:f2} centimeters");
                    break;
                case "yards":
                    smt = cap * 0.91;
                    Console.WriteLine($"{cap} yards = {smt:f2} meters");
                    break;
                case "gallons":
                    smt = cap * 3.8;
                    Console.WriteLine($"{cap} gallons = {smt:f2} liters");
                    break;
                default:
                    break;
            }

        }
    }
}