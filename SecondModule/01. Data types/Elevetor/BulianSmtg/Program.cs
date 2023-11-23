using System;
namespace BulianSmtg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cmd = Console.ReadLine();
            bool ch= bool.Parse(cmd);
            if (ch)
            {
                Console.WriteLine("Yes");
            }
            else {
                Console.WriteLine("No");
            }

        }
    }
}