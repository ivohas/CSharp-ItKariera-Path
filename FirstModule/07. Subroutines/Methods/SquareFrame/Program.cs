using System;

public class Program
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        if (n == 2)
        {
            Console.WriteLine("+ +");
            Console.WriteLine("+ +");
            return;
        }

        Console.WriteLine(new String(' ', n));

        for (int i = 0; i < n - 2; i++)
        {
            Console.Write(' ');
            Console.Write(new String(' ', n - 2));
            Console.WriteLine(' ');
        }

        Console.WriteLine(new String(' ', n));
    }
}
