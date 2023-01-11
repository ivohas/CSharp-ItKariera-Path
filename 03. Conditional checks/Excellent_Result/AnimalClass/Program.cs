using System;
namespace AnimalClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //dog -> mammal
//• crocodile, tortoise, snake->reptile
//• others->unknown
            var animal = Console.ReadLine();
            if (animal=="dog")
            {
                Console.WriteLine("mammal");
            }
            else if (animal== "crocodile"||animal== "tortoise"||animal== "snake")
            {
                Console.WriteLine("reptile");
            }
            else
            {
                Console.WriteLine("unknown");
            }
           
        }
    }
}