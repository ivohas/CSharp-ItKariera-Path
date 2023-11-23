using System;
namespace TheLCD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var number2 = int.Parse(Console.ReadLine());
            var nod = 0;    

            for (int i = 1; i <= number2; i++)
            {
                if (number%i==0&&number2%i==0)
                {
                    nod=i;
                }
            }
            Console.WriteLine(nod);
        }
    }
}