using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public abstract class Plant
{
    private int id;

    public int Id
    {
        get
        {
            return this.id;
        }
        set
        {
            id = value;
        }
    }

    private string name;

    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            if (value.Length >= 3 || value.Length <= 30)
            {
               name = value;
            }
            else
            {
                throw new ArgumentException("Name should be between 3 and 30 characters!");
            }           
        }
    }

    private string type;

    public string Type
    {
        get
        {
            return type;
        }
        set
        {
            if (value.Length >= 3 || value.Length <= 30)
            {
                type = value;             
            }
            else
            {
                throw new ArgumentException("Type should be between 3 and 30 characters!");
            }
        }
    }

    private List<CareItem> careItems;

    private double humidityLevel;

    public double HumidityLevel
    {
        get
        {
            return humidityLevel;
        }
        set
        {
            if (value<0|| value>1)
            {
                throw new ArgumentException("Humidity Level should be between 0 and 1!");
            }
            humidityLevel = value;
        }
    }


    private double fertilityLevel;

    public double FertilityLevel
    {
        get
        {
            return fertilityLevel;
        }
        set
        {
            if (value < 0 || value > 1)
            {
                throw new ArgumentException("Fertility Level should be between 0 and 1!");
            }
            fertilityLevel = value;
        }
    }

    public Plant(int id, string name, string type, double humidityLevel, double fertilityLevel)
    {
        this.Id = id;
        this.Name = name;
        this.Type = type;
        this.HumidityLevel = humidityLevel;
        this.FertilityLevel = fertilityLevel;
        this.careItems = new List<CareItem>();
    }

    public void AddCareItem(CareItem careItem)
    {
        this.careItems.Add(careItem);
    }

    public int TotalCaresDone()
    {
         int a= this.careItems.Where(x=> x.Status==true).ToArray().Count();
        return a;
    }

    public bool Water(double percent)
    {
        if (this.HumidityLevel + percent > 1)
        {
            return false;
        }
        this.HumidityLevel += percent;
        return true;
    }

    public bool Fertilize(double percent)
    {
        if (this.FertilityLevel + percent > 1)
        {
            return false;
        }
        this.FertilityLevel += percent;
        return true;
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Id: { Id}")
            .AppendLine($"Name: { Name}")
            .AppendLine($"Type: { Type}")
            .AppendLine($"Humidity Level: { HumidityLevel:f2} %")
            .AppendLine($"Fertility Level: { FertilityLevel:f2} %");
    
        return sb.ToString().Trim();
    }
}
