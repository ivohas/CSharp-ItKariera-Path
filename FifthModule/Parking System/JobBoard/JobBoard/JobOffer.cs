using System;
using System.Collections.Generic;
using System.Text;
public abstract class JobOffer
{
    private string jobTitle;

    public string JobTitle
    {
        get
        {
            return jobTitle;
        }
        set
        {
            if (value.Length < 3 || value.Length > 30)
            {
                throw new ArgumentException("JobTitle should be between 3 and 30 characters!");
            }
            jobTitle = value;
        }
    }

    private string company;

    public string Company
    {
        get
        {
            return company;
        }
        set
        {

            if (value.Length < 3 || value.Length > 30)
            {
                throw new ArgumentException("Company should be between 3 and 30 characters!");
            }
            company = value;
        }
    }

    private double salary;

    public double Salary
    {
        get
        {
            return salary;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Salary should be 0 or positive!");
            }
            salary = value;
        }
    }

    public JobOffer(string jobTitle, string company, double salary)
    {
        this.JobTitle = jobTitle;
        this.Company = company;
        this.Salary = salary;
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Job Title: {JobTitle}")
            .AppendLine($"Company: {Company}")
            .AppendLine($"Salary: {Salary:f2} BGN");

        return sb.ToString();
    }

}
