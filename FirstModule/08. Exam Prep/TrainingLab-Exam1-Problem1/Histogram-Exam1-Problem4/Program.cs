using System;
namespace Histogram_Exam1_Problem4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double  p5= 0;
            double n = double.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num<200)
                {
                    p1++;
                }
                else if(num>=200&& num<400)
                {
                    p2++;
                }
                else if (num>=400&&num<600)
                {
                    p3++;
                }
                else if (num>=600&& num< 800)
                {
                    p4++;
                }
                else
                {
                    p5++;
                }
            }
            double a = (p1 * 100) / n;
            Console.WriteLine($"{a:f2}%");
            double a1 = (p2 * 100 / n);
            Console.WriteLine($"{a1:f2}%");
            double a2 = p3 * 100 / n;
            Console.WriteLine($"{a2:f2}%");
            double a3 = p4 * 100 / n;
            Console.WriteLine($"{a3:f2}%");
            double a4 = p5 * 100 / n;
            Console.WriteLine($"{a4:f2}%");
        }
    }
}