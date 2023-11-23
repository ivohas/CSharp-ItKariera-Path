using System;
namespace TriangleArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var side = double.Parse(Console.ReadLine());
            var height= double.Parse(Console.ReadLine());
           double area= ReturnReSUlt(side,height);
            Console.WriteLine(area);
        }

        private static double ReturnReSUlt(double side, double height)
        {
            return height * side / 2;
        }
    }
}