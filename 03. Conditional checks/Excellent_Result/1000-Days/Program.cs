using System;
using System.Globalization;

namespace _1000_Days
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string startinDate = Console.ReadLine();
            string format = "dd-MM-yyyy";
            var date = DateTime.ParseExact(startinDate, format, CultureInfo.InvariantCulture);
            date = date.AddDays(1000 - 1);
            Console.WriteLine(date.ToString(format));
        }
    }
}