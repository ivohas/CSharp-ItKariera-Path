using System;
namespace TreeFromStars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stars = "";
            for (int i = 0; i < 11; i++)
            {
                stars += "*";
                Console.WriteLine(stars);
            }
        }
    }
}