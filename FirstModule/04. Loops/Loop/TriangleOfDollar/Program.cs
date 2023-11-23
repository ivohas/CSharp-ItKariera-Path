using System;
namespace TriangleOfDollar
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int n = int.Parse(Console.ReadLine());
            for (int i = 1; i < n+1; i++)
            {
                Console.WriteLine(new String('$',i));
            }
        }
    }
}