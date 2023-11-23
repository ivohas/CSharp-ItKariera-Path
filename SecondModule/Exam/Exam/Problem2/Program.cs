using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {

        var owners = Console.ReadLine().Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();

        while (true)
        {
            string cmd = Console.ReadLine();
            if (cmd== "END OF OWNERS")
            {
                break;
            }
            string a = string.Empty;

            switch (cmd)
            {

                case "Add owner":
                     a= Console.ReadLine();
                    owners.Add(a);
                    break;
                case "Add owner on position":
                    a = Console.ReadLine();
                    int place = int.Parse(Console.ReadLine());
                    owners.Insert(place,a);
                    break;
                case "Remove owner on position":
                    int placeToRemove = int.Parse(Console.ReadLine());
                    owners.RemoveAt(placeToRemove);
                    break;
                case "Remove last owner":
                    owners.RemoveAt(owners.Count - 1);
                    break;
                case "Remove first owner":
                    owners.RemoveAt(0);
                    break;
                default:
                    break;
            }
        }
        Console.WriteLine(String.Join(" ",owners));
    }
}