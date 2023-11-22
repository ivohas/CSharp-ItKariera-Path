using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.InteropServices;

public class Controller
{
    private readonly Dictionary<int, Plant> plants;
    private readonly List<TreePlant> treePlants;
    public Controller()
    {
        plants = new Dictionary<int, Plant>();
        this.treePlants = new List<TreePlant>();
    }

    public string AddCareItem(List<string> args)
    {
        int plantId = int.Parse(args[0]);
        string name = args[1];
        bool status = bool.Parse(args[2]);

        if (!plants.ContainsKey(plantId))
        {
            return $"Plant not found!";
        }
        CareItem careItem = new CareItem(name, status);
        plants[plantId].AddCareItem(careItem);


        return $"Created Care {name} for {plantId}!";

    }

    public string AddPlant(List<string> args)
    {
        int plantId = int.Parse(args[0]);
        string name = args[1];
        double humidityLevel = double.Parse(args[2]);
        double fertilityLevel = double.Parse(args[3]);
        string type = args[4];

        if (plants.ContainsKey(plantId))
        {
            return $" Plant with ID {plantId} already exists!";
        }
        if (type == "flower")
        {
            string color = args[5];
            FloweringPlant fp = new FloweringPlant(plantId, name, humidityLevel, fertilityLevel, color);
            plants[plantId] = fp;
            return $"Created Plant {name} with ID {plantId}!";
        }
        else if (type == "tree")
        {
            int heigth = int.Parse(args[5]);
            TreePlant tp = new TreePlant(plantId, name, humidityLevel, fertilityLevel, heigth);
            plants[plantId] = tp;
            treePlants.Add(tp);
            return $"Created Plant {name} with ID {plantId}!";
        }
        return $" Plant with ID {plantId} already exists!";
    }

    public string GetTotalCaresByPlantId(List<string> args)
    {
        int plantId = int.Parse(args[0]);
        if (!plants.Keys.Contains(plantId))
        {
            return "Plant not found!";
        }
        int cares = plants[plantId].TotalCaresDone();
        return $"Total cares for plant {plantId}: {cares}";
    }

    public string WaterPlantById(List<string> args)
    {
        int plantId = int.Parse(args[0]);
        double percent = double.Parse(args[1]);

        if (!plants.Keys.Contains(plantId))
        {
            return "Plant not found!";
        }
        if (plants[plantId].HumidityLevel + percent > 1 || plants[plantId].HumidityLevel + percent < 0)
        {
            return $"Plant {plantId} could not be watered!";
        }
        plants[plantId].Water(percent);

        return $"Plant {plantId} was watered successfully!";
    }
    public string FertilizePlantById(List<string> args)
    {
        int plantId = int.Parse(args[0]);
        double percent = double.Parse(args[1]);

        if (!plants.Keys.Contains(plantId))
        {
            return "Plant not found!";
        }

        if (plants[plantId].FertilityLevel + percent > 1 || plants[plantId].FertilityLevel + percent < 0)
        {
            return $"Plant {plantId} could not be fertilized!";
        }
        bool a = plants[plantId].Fertilize(percent);
        return $"Plant {plantId} was fertilized successfully!";
    }

    public string GetTallestTree(List<string> args)
    {
        if (plants.Values.Where(x => x.Type == "tree").ToList().Count() <= 0)
        {
            return $"No trees found!";
        }
        return treePlants.OrderByDescending(x => x.Height).First().ToString();

    }
}