using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            string a = Console.ReadLine();

            switch (a)
            {
                case "microscope":
                    sum += 6000;
                    break;

                case "syringe":
                    sum += 100;
                    break;
                case "scalpel":
                    sum += 1500;
                    break;
                default:
                    break;
            }
        }
        Console.WriteLine($"{sum:f2}");
    }
}
