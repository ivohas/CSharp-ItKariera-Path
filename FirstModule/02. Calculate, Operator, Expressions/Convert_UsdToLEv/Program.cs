using System;
namespace Convert_UsdToLEv
{
    internal class Program
    {
        static void Main(string[] args)
        {
           double usd= double.Parse(Console.ReadLine());
            double lev = usd * 1.79549;
            Console.WriteLine(Math.Round(lev,2)+" BGN" );
        }
    }
}