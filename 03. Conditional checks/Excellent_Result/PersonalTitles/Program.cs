using System;
namespace PersonalTitles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var age = double .Parse(Console.ReadLine());
            string sex=Console.ReadLine();
            if (sex=="m")
            {
                if (age>=16)
                {
                    Console.WriteLine("Mr.");
                }
                else
                {
                    Console.WriteLine("Master");
                }
            }
            else if (sex=="f")
            {
                if (age>=16)
                {
                    Console.WriteLine("Ms.");
                }
                else
                {
                    Console.WriteLine("Miss");
                }
            }

        }
    }
}