using System;
using System.Collections.Generic;
using System.Text;

public class RemoteJobOffer : JobOffer
{
    private bool fullyRemote;

    public RemoteJobOffer(string jobTitle, string company, double salary, bool fullyRemote) : base(jobTitle, company, salary)
    {
        this.fullyRemote = fullyRemote;
    }

    public bool FullyRemote
    {
        get
        {
            return this.fullyRemote;
        }
        set
        {
            this.fullyRemote = value;
        }
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Job Title: {JobTitle}")
            .AppendLine($"Company: {Company}")
            .AppendLine($" Salary: {Salary:f2} BGN")
            .AppendLine(this.FullyRemote == true ? "yes" : "no");

        return sb.ToString();
    }
}

