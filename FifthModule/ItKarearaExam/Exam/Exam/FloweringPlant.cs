using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public class FloweringPlant : Plant
{
    private string color;

    public string Color
    {
        get
        {
            return color;
        }
        set
        {
            if (value.Length < 3 || value.Length > 30)
            {
                throw new ArgumentException("Color should be between 3 and 30 characters!");
            }
            color = value;
        }
    }

    public FloweringPlant(int id, string name, double humidityLevel, double fertilityLevel, string color) : base(id, name, "flower", humidityLevel, fertilityLevel)
    {
        this.Color = color;
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Id: {Id}")
            .AppendLine($"Name: {Name}")
            .AppendLine($"Type: {Type}")
            .AppendLine($"Humidity Level: {HumidityLevel:f2} %")
            .AppendLine($"Fertility Level: {FertilityLevel:f2} %")
            .AppendLine($"Color: {Color}");

        return sb.ToString().Trim();
    }
}
