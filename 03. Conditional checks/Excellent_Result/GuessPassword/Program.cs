using System;
namespace GuessPassword
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var password= "s3cr3t!P@ssw0rd";
            var guess= Console.ReadLine();
            if (password==guess)
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}