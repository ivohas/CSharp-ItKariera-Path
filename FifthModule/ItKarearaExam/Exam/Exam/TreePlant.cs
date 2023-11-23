using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public class TreePlant : Plant
{
    private int height;

    public int Height
    {
        get
        {
            return height;
        }
        set
        {
            if (height < 0)
            {
                throw new ArgumentException("Height should be positive!");
            }
            height = value;
        }
    }

    public TreePlant(int id, string name, double humidityLevel, double fertilityLevel, int height)
        : base(id, name, "tree", humidityLevel, fertilityLevel)
    {
       this.Height = height;
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Id: {Id}")
            .AppendLine($"Name: {Name}")
            .AppendLine($"Type: {Type}")
            .AppendLine($"Humidity Level: {HumidityLevel:F2} %")
            .AppendLine($"Fertility Level: {FertilityLevel:f2} %")
            .AppendLine($"Height: {Height}");
        
        return sb.ToString().Trim();
    }
}

