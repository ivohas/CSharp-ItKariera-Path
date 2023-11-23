using System;
namespace TransportPrice_Exam1_Problem2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int km = int.Parse(Console.ReadLine());
            string partOfTheDay = Console.ReadLine();
            double price = 0;
            if (km<20)
            {
                if (partOfTheDay=="day")
                {
                    price = 0.7 + 0.79 * km;
                    
                }
                else
                {
                    price = 0.7 + km * 0.9;
                }
            }
            else if (km>=20&&km<100)
            {
                price = km * 0.09;
            }
            else if (km>=100)
            {
                price = km * 0.06;
            }
            Console.WriteLine(price);
        }
    }
}