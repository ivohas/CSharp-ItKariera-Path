using System;
namespace Area_Perimeter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());
            double area =  Math.PI * r * r;
          area=  Math.Round(area,2);
            double perimeter = 2 * Math.PI * r;
          perimeter=  Math.Round(perimeter, 2);
            Console.WriteLine($"Area = {area}");
            Console.WriteLine($"Perimeter = {perimeter}");
        }
    }
}