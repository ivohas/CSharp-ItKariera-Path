using System;

namespace EqualCouples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] list = new int[n];
            for (int i = 0; i < n; i++)
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                var sum = a + b;
                list[i]=sum;
            }
            int minEl = int.MaxValue;
            int maxEl = int.MinValue;
            foreach (var item in list)
            {
                if (minEl>item)
                {
                    minEl = item;
                }
                if (maxEl<item)
                {
                    maxEl = item;
                }
            }
            if (maxEl!=minEl)
            {
                Console.WriteLine($"No, maxdiff = {Math.Abs( maxEl-minEl)}");
            }
            else
            {
                Console.WriteLine($"Yes, value = {minEl}");
            }
        }
    }
}