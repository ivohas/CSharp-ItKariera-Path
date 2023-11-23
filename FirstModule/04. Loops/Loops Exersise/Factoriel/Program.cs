using System;
namespace Factoriel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var fact = 1;
            do
            {
                fact = fact * n;
                n--;
            } while (n>1);
            Console.WriteLine(fact);
        }
    }
}