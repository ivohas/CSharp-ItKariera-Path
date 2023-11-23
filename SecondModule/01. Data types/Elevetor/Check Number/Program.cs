using System;
namespace Check_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
          string number= Console.ReadLine();
          bool a=   number.Contains('.');
            if (a)
            {
                Console.WriteLine("floating-point");
            }
            else
            {
                Console.WriteLine("integer");
            }
        }
    }
}