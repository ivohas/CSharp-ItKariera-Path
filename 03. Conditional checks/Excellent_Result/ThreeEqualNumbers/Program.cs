using System;
namespace ThreeEqualNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3= int.Parse(Console.ReadLine());
            if (num1 == num2)
            {
                if (num2 == num3)
                {
                    Console.WriteLine("yes");
                }
                else
                {
                    Console.WriteLine("no");
                }
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}