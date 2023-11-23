using System;
namespace SquereOfStars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine(new String('*', size));
            for (int i = 0; i < size-2; i++)
            {
                string a = new String(' ', size - 2);
                Console.WriteLine("*"+a+ "*");
            }
            Console.WriteLine(new String('*', size));
            
        }
    }
}