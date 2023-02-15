using System;
namespace EvenNumberWithCheck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = 0;
            while (true)
            {
                Console.Write("Enter even number :");

                n = int.Parse(Console.ReadLine());
                if (n % 2 == 0)
                    break; // even number --> exit from the loop
            }
            Console.WriteLine("The number is not even");
            Console.WriteLine("Even number entered : {0}", n);
        }
    }
}