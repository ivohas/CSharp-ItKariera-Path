using System;
using System.Collections.Generic;
using System.Text;


public class Controller
{
    private readonly Dictionary<string, Category> categories;

    public Controller()
    {
        categories = new Dictionary<string, Category>();
    }

    public string AddCategory(List<string> args)
    {
        Category category = new Category(args[0]);
        categories[args[0]] = category;
        return $"Created Category {args[0]}!";
    }

    public string AddJobOffer(List<string> args)
    {
        Category category = new Category(args[0]);
        if (args[4] == "onsite")
        {
            OnSiteJobOffer offer = new OnSiteJobOffer(args[1], args[2], double.Parse(args[3]), args[5]);
            categories[args[0]].AddJobOffer(offer);
        }
        else if (args[4] == "remote")
        {
            RemoteJobOffer remoteJobOffer = new RemoteJobOffer(args[1], args[2], double.Parse(args[3]), bool.Parse(args[5]));
            categories[args[0]].AddJobOffer(remoteJobOffer);
        }

        return $"Created JobOffer {args[1]} in Category {args[0]}!";
    }

    public string GetAverageSalary(List<string> args)
    {
        if (categories.ContainsKey(args[0]) && categories[args[0]] != null)
        {
            double averageSalary = categories[args[0]].AverageSalary();
            if (averageSalary <= 0)
            {
                averageSalary = 0;
            }
            return $"The average salary is: {averageSalary:f2} BGN";
        }
        else
        {
            // Handle the case where categories[args[0]] is null or args[0] is not found in categories.
            return "Category not found or is null";
        }
    }

    public string GetOffersAboveSalary(List<string> args)
    {
        StringBuilder sb = new StringBuilder();
        var list = categories[args[0]].GetOffersAboveSalary(double.Parse(args[1])).ToList();
        foreach (var a in list)
        {
            sb.AppendLine(a.ToString());
        }
        return sb.ToString();
    }

    public string GetOffersWithoutSalary(List<string> args)
    {
        StringBuilder sb = new StringBuilder();
        var list = categories[args[0]].GetOffersWithoutSalary().ToString();
        foreach (var a in list)
        {
            sb.AppendLine(a.ToString());
        }
        return sb.ToString().Trim();  
    }

}