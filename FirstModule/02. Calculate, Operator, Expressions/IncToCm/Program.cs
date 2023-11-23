using System;
namespace IncToCm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Inches =");
            var inc = double.Parse(Console.ReadLine());
            var cm = inc * 2.54;
            Console.WriteLine($"Centimeters = {cm}");
        }
    }
}