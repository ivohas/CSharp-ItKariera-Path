using System;
namespace PrintTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            PrintTriangle(size);
            PrintSecondPart(size);
        }

        private static void PrintSecondPart(int size)
        {
            for (int i = size-1; i >= 1; i--)
            {
                PrintLine(i);
            }
        }

      

        private static void PrintTriangle(int size)
        {
            var result = "";
            for (int i = 0; i <= size; i++)
            {
                PrintLine(i);
            }
        }

        private static void PrintLine(int i)
        {
            var result = "";
            for (int a = 1; a <= i; a++)
            {
                result+= a + " ";

            }
            Console.WriteLine(result.TrimEnd());
        }
    }
}