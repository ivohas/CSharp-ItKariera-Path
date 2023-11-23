using System;
namespace TrainingLab_Exam1_Problem1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double heigth = double.Parse(Console.ReadLine())*100;
            double weight= double.Parse(Console.ReadLine())*100;
            weight -= 100;
            var a =Math.Floor( weight / 70);
          var b=Math.Floor( heigth /120);
            Console.WriteLine(a*b-3);
        }
    }
}