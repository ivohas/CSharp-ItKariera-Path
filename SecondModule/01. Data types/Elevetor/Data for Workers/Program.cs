﻿using System;
namespace Data_for_Workers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName= Console.ReadLine();
            string lastName= Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            long personalId= long.Parse(Console.ReadLine());
            long employeeId= long.Parse(Console.ReadLine());

            Console.WriteLine("First name: "+ firstName);
            Console.WriteLine("Last name: "+ lastName);
            Console.WriteLine("Age: "+ age);
            Console.WriteLine("Gender: "+ gender);
            Console.WriteLine("Personal ID: "+ personalId);
            Console.WriteLine("Unique Employee number: " + employeeId);
        }
    }
}