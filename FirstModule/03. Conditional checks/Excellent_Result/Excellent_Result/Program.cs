using System;
namespace Excellent_Result
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var grade = double.Parse(Console.ReadLine());
            if (grade>=5.5)
            {
                Console.WriteLine("Excellent!");
            }
        }
    }
}