using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public abstract class Plant
{
    private int id;

    public int Id
    {
        get {
            //TODO: Implement me...
            throw new NotImplementedException();
        }
        set { 
            //TODO: Implement me...
            throw new NotImplementedException();
        }
    }

    private string name;

    public string Name
    {
        get {
            //TODO: Implement me...
            throw new NotImplementedException();
        }
        set
        {
            //TODO: Implement me...
            throw new NotImplementedException();
        }
    }

    private string type;

    public string Type
    {
        get
        {
            //TODO: Implement me...
            throw new NotImplementedException();
        }
        set
        {
            //TODO: Implement me...
            throw new NotImplementedException();
        }
    }

    private List<CareItem> careItems;

    private double humidityLevel;

    public double HumidityLevel
    {
        get
        {
            //TODO: Implement me...
            throw new NotImplementedException();
        }
        set
        {
            //TODO: Implement me...
            throw new NotImplementedException();
        }
    }


    private double fertilityLevel;

    public double FertilityLevel
    {
        get
        {
            //TODO: Implement me...
            throw new NotImplementedException();
        }
        set
        {
            //TODO: Implement me...
            throw new NotImplementedException();
        }
    }

    public Plant(int id, string name, string type, double humidityLevel, double fertilityLevel)
    {
        //TODO: Implement me...
        throw new NotImplementedException();
    }

    public void AddCareItem(CareItem careItem)
    {
        //TODO: Implement me...
        throw new NotImplementedException();
    }

    public int TotalCaresDone()
    {
        //TODO: Implement me...
        throw new NotImplementedException();
    }

    public bool Water(double percent)
    {
        //TODO: Implement me...
        throw new NotImplementedException();
    }

    public bool Fertilize(double percent)
    {
        //TODO: Implement me...
        throw new NotImplementedException();
    }

    public override string ToString()
    {
        //TODO: Implement me...
        throw new NotImplementedException();
    }
}
