using System;
public class ChevyBeat : Engine, ICar
{
    public string Start()
    {
        return string.Format("Beat is Started");
    }
    public string Accelerate()
    {
        return string.Format("Beat is moving");
    }
    public string Stop()
    {
        return string.Format("Beat is Stoped");
    }
    public override void NewEngine()
    {
        Console.WriteLine("Petrol Engine is added");
    }


}