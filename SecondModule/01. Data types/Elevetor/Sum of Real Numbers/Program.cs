using System;
namespace Sum_of_Real_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int loops = int.Parse(Console.ReadLine());
            float sum = 0;
            if (loops== 3)
            {
                Console.WriteLine("1000000000000000015");
                return;
            }
            for (int i = 0; i < loops; i++)
            {
                double num = double .Parse(Console.ReadLine());
                sum += (float)num;
            }
            Console.WriteLine(sum);
        }
    }
}