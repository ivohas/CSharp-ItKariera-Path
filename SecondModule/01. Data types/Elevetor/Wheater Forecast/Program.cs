using System;
namespace Wheater_Forecast
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numa =Console.ReadLine();

            bool ch = numa.Contains('.');
            if (ch)
            {
                Console.WriteLine("Rainy");
                return;
            }
            long num = long.Parse(numa);
            if (num > sbyte.MinValue && num < sbyte.MaxValue)
            {
                Console.WriteLine("Sunny");
            }
            else if((num > int.MinValue && num < int.MaxValue))
            {
                Console.WriteLine("Cloudy");
            }
            else if ((num > long.MinValue && num < long.MaxValue))
            {
                Console.WriteLine("Windy");
            }
        }
    }
}