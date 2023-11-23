using System;
namespace Triangle_Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            var area = a * h / 2;
            Console.WriteLine(Math.Round(area,2)) ;
        }
    }
}