using System;
namespace Rectangle_Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
          var x1= double.Parse(Console.ReadLine()); 
            var y1= double.Parse(Console.ReadLine());
            var x2= double.Parse(Console.ReadLine());
            var y2= double.Parse(Console.ReadLine());
            var sideOne =Math.Abs( x2 - x1);
            var sideTwo =Math.Abs( y2 - y1);
            var area =sideOne * sideTwo;
            
            var par =(sideTwo  + sideOne) * 2;
            Console.WriteLine(area);
            Console.WriteLine(par);
        }
    }
}