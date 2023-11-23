using System;
namespace FibonacciNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var f0 = 1;
            var f1 = 1;
                for (var i = 0; i < n- 1; i++)
               {
                var fNext = f0 + f1;
                    f0 = f1;
                f1 = fNext;
            }
            Console.WriteLine(f1);
        }
    }
}