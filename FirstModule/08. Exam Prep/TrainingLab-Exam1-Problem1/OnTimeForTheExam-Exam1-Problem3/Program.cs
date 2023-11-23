using System;
namespace OnTimeForTheExam_Exam1_Problem3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hoursExam = int.Parse(Console.ReadLine());
            int minutesExam = int.Parse(Console.ReadLine());
            int hoursStudent= int.Parse(Console.ReadLine());
            int minutesStidents= int.Parse(Console.ReadLine());
            int timeExam = hoursExam * 60 + minutesExam;
            int timeStudent= hoursStudent * 60 + minutesStidents;
            int diff = timeExam - timeStudent;
            // 120- 150=30
            if (diff < 0)
            {
                // Late
                Console.WriteLine("Late");
                diff = Math.Abs(diff);
                if (diff >= 60)
                {
                    int hours = diff / 60;
                    int minutes = diff % 60;
                    Console.WriteLine($"{hours}:{minutes:d2} hours after the start");
                }
                else
                {
                    Console.WriteLine($"{Math.Abs(diff)} minutes after the start");

                }
                
                
            }
            else if (diff <= 30 && diff >= 0)
            {
                // on time
                Console.WriteLine("On time");
                if (diff!=0)
                { Console.WriteLine($"{Math.Abs(diff)} minutes before the start");

                }
               
            } else if (diff>=30) 
            {
                // early
                Console.WriteLine("Early");
                if (diff>=60)
                {
                    int hours = diff / 60;
                    int minutes = diff % 60;
                    Console.WriteLine($"{hours}:{minutes:d2} hours before the start");
                }
                else
                {
                    Console.WriteLine($"{diff} minutes before the start");
                }
            }
        }
    }
}