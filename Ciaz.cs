using System;
public class Ciaz : Engine, ICar
{

    public string Start()
    {
        return string.Format("Ciaz is Started");
    }
    public string Accelerate()
    {
        return string.Format("Ciaz is moving");
    }
    public string Stop()
    {
        return string.Format("Ciaz is Stoped");
    }

    public override void NewEngine()
    {
        Console.WriteLine("Petrol Engine is added");
    }
}