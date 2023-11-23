using System.Text;

namespace ExamPrep
{
    public class Program
    {
        static void Main(string[] args)
        {
            int numOfWebsiters = int.Parse(Console.ReadLine());
            int securityKey = int.Parse(Console.ReadLine());

            double totalLoss = 0;
            string site = string.Empty;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < numOfWebsiters; i++)
            {
                site = Console.ReadLine();
                var array = site.Split().ToArray();

                var siteVisit = int.Parse(array[1]);
                var price = float.Parse(array[2]);
                var loss = siteVisit * price;
                totalLoss += loss;
                sb.AppendLine(array[0]);
            }
            Console.WriteLine(sb.ToString().Trim());
            Console.WriteLine($"Total Loss: {totalLoss:f20}");
            Console.WriteLine($"Security Token: {securityKey*securityKey*securityKey}");
        }
    }
}