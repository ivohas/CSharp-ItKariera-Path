using System;
namespace PrimeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var num = int.Parse(Console.ReadLine());
            var prime = true;
            for (int i = 2; i <=Math.Sqrt(num); i++)
            {
                if (num%i==0)
                {
                    prime = false;
                    break;
                }
            }
            if (!prime||num==0||num<0||num==1)
            {
                Console.WriteLine("Not prime");
               
            }
            else
            { Console.WriteLine("Prime");
              
            }
        }
    }
}