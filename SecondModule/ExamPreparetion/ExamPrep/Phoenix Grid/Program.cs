using System;

class Program
{
    static void Main(string[] args)
    {
        string input;
        while ((input = Console.ReadLine()) != "ReadMe")
        {
            string[] phrases = input.Split('.');
            bool valid = true;
            foreach (string phrase in phrases)
            {
                if (phrase.Length != 3)
                {
                    valid = false;
                    break;
                }
                foreach (char c in phrase)
                {
                    if (char.IsWhiteSpace(c) || c == '_')
                    {
                        valid = false;
                        break;
                    }
                }
            }
            if (valid)
            {
                string concatenated = string.Concat(phrases);
                if (IsPalindrome(concatenated))
                {
                    Console.WriteLine("YES");
                    continue;
                }
            }
            Console.WriteLine("NO");
        }
    }

    static bool IsPalindrome(string s)
    {
        int i = 0, j = s.Length - 1;
        while (i < j)
        {
            if (s[i] != s[j])
            {
                return false;
            }
            i++;
            j--;
        }
        return true;
    }
}
