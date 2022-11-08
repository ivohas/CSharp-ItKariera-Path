using System;
namespace AreaOfRentagular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal a = decimal.Parse(Console.ReadLine());
            decimal b = decimal.Parse(Console.ReadLine());
            var area = a * b;
            Console.WriteLine(area);
        }
    }
}