using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        string input = Console.ReadLine();
        Dictionary<char, int> counter = new Dictionary<char, int>();


        foreach (char item in input)
        {
            if (char.IsWhiteSpace(item))
            {
                continue;
            }
            if (counter.ContainsKey(item))
            {
                counter[item]++;
            }
            else
            {
                counter.Add(item, 1);
            }
           
        }
        foreach (var item in counter)
        {
            Console.WriteLine($"{item.Key}-> {item.Value}");
        }

    }
}