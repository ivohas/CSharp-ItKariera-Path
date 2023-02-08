using System;
namespace RectangleOfNxNStars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string result = "";
                for (int a = 0; a < n; a++)
                {
                    result += "* ";
                }
                Console.WriteLine(result.TrimEnd());
            }
        }
    }
}