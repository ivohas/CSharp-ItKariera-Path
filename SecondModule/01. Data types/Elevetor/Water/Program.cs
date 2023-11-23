using System;
namespace Water
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int capacity = 255;
            int times = int.Parse(Console.ReadLine());
            bool ch = false;
            for (int i = 0; i < times; i++)
            {
                int liters = int.Parse(Console.ReadLine());
                if (liters > capacity)
                {
                    
                    Console.WriteLine("Insufficient capacity!");
                }
                else { 
                
                    capacity-= liters;
                }
            }
           
               
            
            Console.WriteLine(255-capacity);
        }
    }
}