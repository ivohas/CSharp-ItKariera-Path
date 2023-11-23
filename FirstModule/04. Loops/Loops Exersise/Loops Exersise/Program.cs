using System;
namespace Loops_Exersise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Еnter a number in the range [1...100]:");
            var numbers= double.Parse(Console.ReadLine());
            if (numbers>=1&&numbers<=100)
            {
                Console.WriteLine($"The number is: {numbers}");
            }
            else
            {
                Console.WriteLine("Invalid number!");
            }
        }
    }
}