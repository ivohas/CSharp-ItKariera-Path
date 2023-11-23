using System;
namespace FruitVegetable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // banana, apple, kiwi, cherry, lemon и grapes
            //tomato, cucumber, pepper и carrot
            var type = Console.ReadLine();
            if (type== "banana"||type == "apple"||type=="cherry"|| type == "lemon"||type == "grapes"||type == "kiwi")
            {
                Console.WriteLine("fruit");
            }
            else if (type == "tomato"|| type=="cucumber"|| type == "pepper"|| type == "carrot")
            {
                Console.WriteLine("vegetable");
            }
            else
            {
                Console.WriteLine("unknown");
            }

        }
    }
}