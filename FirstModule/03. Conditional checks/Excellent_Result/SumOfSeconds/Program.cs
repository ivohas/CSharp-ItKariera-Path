using System;
namespace SumOfSeconds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int seconds1 = int.Parse(Console.ReadLine());
            int seconds2 = int.Parse(Console.ReadLine());
            int seconds3= int.Parse(Console.ReadLine());
            int sum= seconds1+ seconds2+ seconds3;
            int min = 0;
            if (sum >= 60)
            {
                min = sum / 60;
                sum = sum % 60;

            }
            if (sum < 10) {
                Console.WriteLine($"{min}:0{sum}");

            }
            else
            {
                Console.WriteLine($"{min}:{sum}");
            }
           
        }
    }
}