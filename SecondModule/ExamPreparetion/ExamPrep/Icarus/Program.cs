using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] sequence = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int icarusPosition = int.Parse(Console.ReadLine());
        int icarusDamage = 1;

        while (true)
        {
            string[] command = Console.ReadLine().Split();
            if (command[0] == "Supernova")
            {
                break;
            }
            string direction = command[0];
            int steps = int.Parse(command[1]);
            while (steps > 0)
            {
                if (direction == "left")
                {
                    icarusPosition--;
                    if (icarusPosition < 0)
                    {
                        icarusPosition = sequence.Length - 1;
                        icarusDamage++;
                    }
                }
                else if (direction == "right")
                {
                    icarusPosition++;
                    if (icarusPosition == sequence.Length)
                    {
                        icarusPosition = 0;
                        icarusDamage++;
                    }
                }
                sequence[icarusPosition] -= icarusDamage;
                steps--;
            }
        }

        Console.WriteLine(string.Join(" ", sequence));
    }
}
