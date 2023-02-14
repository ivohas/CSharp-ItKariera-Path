using System;

public class Program
{
    public static void Main(string[] args)
    {
        double num = double.Parse(Console.ReadLine());
        string first = Console.ReadLine();
        string second = Console.ReadLine();

        switch (first)
        {
            case "mm":
                num /= 1000;
                break;
            case "cm":
                num /= 100;
                break;
            case "mi":
                num /= 0.000621371192;
                break;
            case "in":
                num /= 39.3700787;
                break;
            case "km":
                num = 1000;
                break;
            case "ft":
                num /= 3.2808399;
                break;
            case "yd":
                num /= 1.0936133;
                break;
        }

        switch (second)
        {
            case "mm":
                num = 1000;
                break;
            case "cm":
                num = 100;
                break;
            case "mi":
                num = 0.000621371192;
                break;
            case "in":
                num = 39.3700787;
                break;
            case "km":
                num /= 1000;
                break;
            case "ft":
                num = 3.2808399;
                break;
            case "yd":
                num *= 1.0936133;
                break;
        }

        Console.WriteLine($"{num} {second}");
    }
}