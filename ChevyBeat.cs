using System;
public class ChevyBeat : Engine, ICar
{
    private string Tname;
    public ChevyBeat(string Type) {
        this.Tname=Type;
    }
    public string TransmissionType {
       get { return Tname;}
       set { Tname = value;}
    }
    public void Start()
    {
        Console.WriteLine("Beat is Started!");
    }
    public void Accelerate()
    {
        Console.WriteLine("Beat is moving!");
    }
    public void Stop()
    {
        Console.WriteLine("Beat is Stoped!");
    }
    public override void NewEngine()
    {
        Console.WriteLine("Petrol Engine is added...");
    }


}