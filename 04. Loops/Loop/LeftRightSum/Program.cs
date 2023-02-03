using System;
namespace LeftRightSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum1 = 0;
            int sum2=0;
            for (int i = 0; i < 2; i++)
            {
                for (int a = 0; a < n; a++)
                { 
                    int num = int.Parse(Console.ReadLine());
                    if (i == 1)
                    {
                        sum2 += num;
                    }
                    else { 
                    
                         sum1 += num;
                    }

                  

                }
            }
            if (sum2==sum1)
            {
                Console.WriteLine($"Yes, sum = {sum2}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(sum2-sum1)}");
            }
        }
    }
}