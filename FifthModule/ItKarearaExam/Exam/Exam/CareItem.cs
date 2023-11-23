using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class CareItem
{
    private string name;

    public string Name
    {
        get {
           return name;
        }
        set { 
            if (value.Length < 2 || value.Length > 40) 
            {
                throw new ArgumentException("Name should be between 2 and 40 characters!");
            }
           this.name = value;
        }
    }

    private bool status;

    public bool Status
    {
        get {
            return status;
        }
        set { 
            this.status = value;
        }
    }

    public CareItem(string name, bool status)
    {
        this.Name = name;
        this.Status = status;
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"CareItem { Name}")
            .AppendLine($"Status: { Status}");
        
        return sb.ToString().Trim();
    }
}