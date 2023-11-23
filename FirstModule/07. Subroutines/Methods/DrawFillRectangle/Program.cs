using System;
namespace DrawFillRectangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            PrintSides(size);
            PrintMiddleRow(size);
            PrintSides(size);
        }

        private static void PrintSides(int size)
        {
            Console.WriteLine(new String('-',2*size));
        }
        static void PrintMiddleRow(int n)
        {
            Console.Write('-');
            for (int i = 1; i < n; i++) {

                Console.Write("\\/");
            }
            Console.WriteLine('-');
        
        }

    }
}