using System;
namespace SumOfTheOthers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                int a = int.Parse(Console.ReadLine());
                array[i]=a;
            }
            int maxNum = int.MinValue;
            int sum = 0;
            foreach (int i in array) {
                if (i>maxNum)
                {
                    maxNum = i;
                }
                sum += i;
            }

            sum = sum - maxNum;
            if (sum== maxNum)
            {
                Console.WriteLine($"Yes Sum = {sum}");
            }
            else {
                Console.WriteLine($"No Diff = {Math.Abs(sum-maxNum) }");
            }
        }
    }
}