using System;
namespace SquereArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a=");
            int a = int.Parse(Console.ReadLine());
            int size = a * a;
            Console.WriteLine($"Area = {size}");
            
        }
    }
}