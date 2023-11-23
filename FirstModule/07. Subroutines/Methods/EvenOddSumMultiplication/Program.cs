using System;
using System.Collections.Generic;
namespace EvenOddSumMultiplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            var listOfOdd =new List<int>();
            var listOfEven =new List<int>();
            while (num!=0)
            {
                int a = num % 10;
                num = num  / 10;
                if (a%2==0)
                {
                    listOfEven.Add(a);
                }
                else
                {
                    listOfOdd.Add(a);
                }
            }
          int sumOfOdds= SumTheOdds(listOfOdd);
            int SumOfEven = SumOfEvens(listOfEven);
            Console.WriteLine(SumOfEven*sumOfOdds);
        }

         static int SumOfEvens(List<int> listOfEven)
        {
            int sum = 0;
            foreach (var item in listOfEven)
            {
                sum += item;
            }
            return sum;
        }

         static int SumTheOdds(List<int> listOfOdd)
        {
            int sum = 0;
            foreach (var item in listOfOdd)
            {
                sum += item;
            }
            return sum;
        }
    }
}