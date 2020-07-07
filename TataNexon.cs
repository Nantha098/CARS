using System;
public class TataNexon :Engine, ICar
{
    public string Start()
    {
        return string.Format("Nexon is Started");
    }
    public string Accelerate()
    {
        return string.Format("Nexon is moving");
    }
    public string Stop()
    {
        return string.Format("Nexon is Stoped");
    }
    public override void NewEngine()
    {
        Console.WriteLine("Diesel Engine is added");
    }


}