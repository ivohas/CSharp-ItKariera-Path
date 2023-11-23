using System;
namespace Convert_Rad_Deg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double rad= double.Parse(Console.ReadLine());
            double gr= rad*180/Math.PI;
            Console.WriteLine(Math.Round( gr));
        }
    }
}