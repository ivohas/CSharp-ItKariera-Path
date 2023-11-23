using System;
namespace Convert_Money
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            string ourValue= Console.ReadLine();
            string valueToChange = Console.ReadLine();
            double endValue = 0;
            switch (ourValue)
            {
                case "BGN":
                    endValue = money;
                    break;
                case "GBP":
                    endValue = money * 2.53405;
                    break;
                case "EUR":
                    endValue = money* 1.95583;
                    break;
                case "USD":
                    endValue = money * 1.79549;
                    break;
                default:
                    break;

            }
            switch (valueToChange)
            {
                case "USD":
                    endValue = endValue / 1.79549;
                    break;
                case "EUR":
                    endValue = endValue / 1.95583;
                    break;
                case "GBP":
                    endValue = endValue / 2.53405;
                    break;
                default:
                    break;
            }

            Console.WriteLine($"{Math.Round(endValue,2)}");
        }
    }
}