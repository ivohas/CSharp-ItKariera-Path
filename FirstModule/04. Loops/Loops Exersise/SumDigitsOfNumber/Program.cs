using System;
namespace SumDigitsOfNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var sum = 0;
            do
            {
                sum = sum + (num % 10);
                num = num / 10;
            } while (num>0);
            Console.WriteLine("Sum of digits: {0}", sum);
        }
    }
}