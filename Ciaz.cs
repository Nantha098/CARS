using System;
public class Ciaz : Engine, ICar
{
    public string Start()
    {
        return string.Format("Car is Started");
    }
    public string Accelerate()
    {
        return string.Format("Car is moving");
    }
    public string Stop()
    {
        return string.Format("Car is Stoped");
    }

    public override void NewEngine()
    {
        Console.WriteLine("Petrol Engine is added");
    }
}