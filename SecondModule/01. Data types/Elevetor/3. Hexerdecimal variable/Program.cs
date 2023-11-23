using System;
namespace _04.VariableInHexFormat
{
    public class VariableInHexFormat
    {
        static void Main()
        {
            string hexadecimal = Console.ReadLine();
            int number = Convert.ToInt32(hexadecimal, 16);

            Console.WriteLine(number);
        }
    }
}