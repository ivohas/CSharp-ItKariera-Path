using System;
namespace Elevetor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int maxPerF= int.Parse(Console.ReadLine());
            int loops = (int)Math.Ceiling((double)people / maxPerF);
            Console.WriteLine(loops);
        }
    }
}