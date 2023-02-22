using System;
namespace BorderRantagular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double currX = double.Parse(Console.ReadLine());
            double currY = double.Parse(Console.ReadLine());

            string output = string.Empty;

            if ((currX == x1||  currX == x2 || currY == y1 || currY == y2)&&(currX >= Math.Min(x1, x2) && currX <= Math.Max(x1, x2))
                && (currY >= Math.Min(y1, y2) && currY <= Math.Max(y1, y2))){
                Console.WriteLine("Border");
            }else Console.WriteLine("Inside / Outside");
        }
    }
}