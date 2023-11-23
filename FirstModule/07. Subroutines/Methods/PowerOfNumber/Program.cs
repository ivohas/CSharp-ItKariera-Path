using System;
namespace PowerOfNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            PrintThePower(num,power);
        }

        private static void PrintThePower(double num, int power)
        {
            Console.WriteLine(Math.Pow(num,power));
        }
    }
}