using System;
namespace Convert_C_F
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double cel = double.Parse(Console.ReadLine());
            double far = cel * 9 / 5 + 32;
            Console.WriteLine(far);
        }
    }
}