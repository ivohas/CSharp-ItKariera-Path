using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var creatures = new Dictionary<string, HashSet<string>>();

        string input;
        while ((input = Console.ReadLine()) != "Blaze it!")
        {
            string[] tokens = input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
            string creature = tokens[0];
            string squadMate = tokens[1];

            if (creature == squadMate || creatures.ContainsKey(squadMate) && creatures[squadMate].Contains(creature))
            {
                // Ignore the line if the creature is its own squad mate or if there is a circular reference
                continue;
            }

            if (!creatures.ContainsKey(creature))
            {
                creatures[creature] = new HashSet<string>();
            }

            creatures[creature].Add(squadMate);
        }

        var sortedCreatures = creatures.OrderByDescending(x => x.Value.Count);

        foreach (var creature in sortedCreatures)
        {
            Console.WriteLine($"{creature.Key} : {creature.Value.Count}");
        }
    }
}
