using System;
namespace VegetableMarket_Exam2_Problem1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a1 = double.Parse(Console.ReadLine());
            double b1 = double.Parse(Console.ReadLine());
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(((a1*a)+(b1*b))/1.94);
        }
    }
}