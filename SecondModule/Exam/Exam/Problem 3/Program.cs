using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string letters=string.Empty;
        string numbers = string.Empty;
        string chars = string.Empty;
        foreach (char item in input)
        {
            if (char.IsLetter(item))
            {
                letters += item;
            }
            else if (char.IsDigit(item))
            {
                numbers += item;
            }
            else
            {
                chars+= item;
            }
        }
        Console.WriteLine(numbers);
        Console.WriteLine(letters);
        
        Console.WriteLine(chars);
    }
}