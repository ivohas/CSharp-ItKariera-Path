using System;
namespace Rectangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sideA = double.Parse(Console.ReadLine());
            double sideB = double.Parse(Console.ReadLine());
            Console.WriteLine((sideB+sideA)*2);
            Console.WriteLine(sideA*sideB);
            Console.WriteLine(Math.Sqrt(sideA*sideA + sideB*sideB));
        }
    }
}