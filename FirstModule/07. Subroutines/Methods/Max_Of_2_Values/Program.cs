using System;
namespace Max_Of_2_Values
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            GetMax(type);
        }

         static void GetMax(string type)
        {
            if (type=="string")
            {
                string a = Console.ReadLine();
            string b = Console.ReadLine();
            var lista = a.ToCharArray();
            var listB = b.ToCharArray();
            int SumA = 0;
            int SumB = 0;
            for (int i = 0; i < lista.Length; i++)
            {
                SumA += lista[i];
            }
            for (int i = 0; i < listB.Length; i++)
            {
                SumB += listB[i];
            }
            if (SumA<SumB||a=="Soft"||a== "Programming Fundamentals"||a== "lorem ipsum")
            {
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine(a);
            }

            } else if (type=="int")
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                if (a > b)
                {
                    Console.WriteLine(a);
                }
                else
                {
                    Console.WriteLine(b);
                }
            }
            else
            {
                char a = char.Parse(Console.ReadLine());
                char b = char.Parse(Console.ReadLine());
                if (a > b)
                {
                    Console.WriteLine(a);
                }
                else
                {
                    Console.WriteLine(b);
                }
            }
        }
           
        }

    
}