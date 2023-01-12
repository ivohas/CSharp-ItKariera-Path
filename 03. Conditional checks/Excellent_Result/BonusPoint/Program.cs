using System;
namespace BonusPoint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            double bonus = 0;
            if (num<=100)
            {
                bonus += 5;
            }

            if (num<=1000&&num>100)
            {
                bonus = num / 5;
            }

            if (num > 1000) {

                bonus = num / 10;
            }

            if (num % 2 == 0) {
                bonus++;
            } else if (num%5==0) {
                bonus += 2;
            }
            Console.WriteLine(bonus);
            Console.WriteLine(bonus+num);
        }
    }
}