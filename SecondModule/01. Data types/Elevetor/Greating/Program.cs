using System;
namespace Greating
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string LastName=  Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine($"Hello, {name} {LastName}. You are {age} years old.");
        }
    }
}