using System;
namespace Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            Premiere – премиерна прожекция, на цена 12.00 лева.
            //• Normal – стандартна прожекция, на цена 7.50 лева.
            //• Discount – прожекция за деца, ученици и студенти на намалена цена от 5.00 лева.

            string type = Console.ReadLine();
            var rows = double.Parse(Console.ReadLine());
            var columns = double.Parse(Console.ReadLine());
            var places = rows * columns;
            double price = 0;
            switch (type)
            {
                case "Premiere": price = 12; break;
                case "Normal": price = 7.5; break;
                case "Discount": price = 5; break;
                default:
                    break;
            }
            Console.WriteLine($"{price * places}");

        }
    }
}