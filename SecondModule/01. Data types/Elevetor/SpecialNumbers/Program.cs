using System;
namespace SpecialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                bool checker = false;
                int sum = 0;
                int a = i;
                while (a!=0)
                {

                    sum += a % 10;
                    a = a / 10;
                }
                if (sum == 5|| sum==11|| sum==7) { 
                    checker = true;
                }
                Console.WriteLine($"{i} -> {checker}");
            }
        }
    }
}