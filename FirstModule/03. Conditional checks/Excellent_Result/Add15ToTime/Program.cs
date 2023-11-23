using System;
namespace Add15ToTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            minutes += 15;
            if (minutes >= 60) {
                minutes -= 60;
                hours += 1;
                if (hours > 23)
                {
                    hours = 0;
                }
            }
            if (minutes<10)
            {
                Console.WriteLine($"{hours}:0{minutes}");
            }
            else
            {
                Console.WriteLine($"{hours}:{minutes}");
            }
            
        }
    }
}