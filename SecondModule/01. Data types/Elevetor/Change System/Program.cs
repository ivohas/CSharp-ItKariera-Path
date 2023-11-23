using System;

namespace _05.DecimalToHexadecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string hexadecimal = Convert.ToString(num, 16).ToUpper();
            string binary = Convert.ToString(num, 2);
            Console.WriteLine(hexadecimal);
            Console.WriteLine(binary);
        }
    }
}