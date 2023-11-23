using System;
namespace WholeNumberSign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            CheckNumber(n);
        }

        private static void CheckNumber(int n)
        {
            if (n ==0)
            {
                Console.WriteLine("The number 0 is zero.");
            }
            else if (n <0)
            {
                Console.WriteLine($"The number {n} is negative.");
            }
            else
            {
                Console.WriteLine($"The number {n} is positive.");
            }
        }
    }
}