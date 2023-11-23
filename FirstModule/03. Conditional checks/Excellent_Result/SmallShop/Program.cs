using System;
namespace SmallShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
          var product = Console.ReadLine();
            var city = Console.ReadLine();
            var quntity= double.Parse(Console.ReadLine());
            double price = 0;
            switch (product)
            {
                case "coffee":
                    if (city=="Sofia")
                    {
                        price = 0.5;
                    }
                    else if (city == "Plovdiv")
                    {
                        price = 0.4;
                    }
                    else if (city=="Varna")
                    {
                        price = 0.45;
                    }
                    break;
                case "water":
                    if (city == "Sofia")
                    {
                        price = 0.8;
                    }
                    else if (city == "Plovdiv")
                    {
                        price = 0.7;
                    }
                    else if (city == "Varna")
                    {
                        price = 0.7;
                    }
                    break;
                case "beer":
                    if (city == "Sofia")
                    {
                        price = 1.2;
                    }
                    else if (city == "Plovdiv")
                    {
                        price = 1.15;
                    }
                    else if (city == "Varna")
                    {
                        price = 1.1;
                    }
                    break;
                case "sweets":
                    if (city == "Sofia")
                    {
                        price = 1.45;
                    }
                    else if (city == "Plovdiv")
                    {
                        price =1.30;
                    }
                    else if (city == "Varna")
                    {
                        price = 1.35;
                    } break;
                case "peanuts":
                    if (city == "Sofia")
                    {
                        price = 1.60;
                    }
                    else if (city == "Plovdiv")
                    {
                        price = 1.50;
                    }
                    else if (city == "Varna")
                    {
                        price = 1.55;
                    }

                    break;
                   
                default:
                    break;
            }
            Console.WriteLine(price*quntity);
        }
    }
}