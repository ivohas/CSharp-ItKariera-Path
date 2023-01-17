using System;
namespace FigureArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string type = Console.ReadLine();
            double side1 = 0;
            double side2 = 0;
            switch (type)
            {
                case "square": side1 = double.Parse(Console.ReadLine()); Console.WriteLine(side1*side1); break;
                case "rectangle":side1 = double.Parse(Console.ReadLine());side2 = double.Parse(Console.ReadLine()); Console.WriteLine(side2*side1); break;
                case "circle": side1 = double.Parse(Console.ReadLine()); Console.WriteLine(side1*side1*Math.PI);break;
                case "triangle": side1 = double.Parse(Console.ReadLine()); side2 = double.Parse(Console.ReadLine()); Console.WriteLine(side2*side1/2);break;
                default:
                    break;
            }
        }
    }
}