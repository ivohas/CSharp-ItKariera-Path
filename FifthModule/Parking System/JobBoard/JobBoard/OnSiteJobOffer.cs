using System;
using System.Collections.Generic;
using System.Text;


public class OnSiteJobOffer : JobOffer
{
    private string city;

    public string City
    {
        get
        {
            return city;
        }

        set
        {

            if (value.Length < 3 || value.Length > 30)
            {
                throw new ArgumentException("");
            }
            city = value;
        }
    }

    public OnSiteJobOffer(string jobTitle, string company, double salary, string city) : base(jobTitle, company, salary)
    {
        this.City = city;
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Job Title: {JobTitle}")
            .AppendLine($"Company: {Company}")
            .AppendLine($"Salary: {Salary:f2} BGN")
            .AppendLine($"City: {City}");

        return sb.ToString().Trim();
    }
}

