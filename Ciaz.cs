using System;
public class Ciaz : Engine, ICar
{
    private string Tname ;
    public Ciaz(string Type){
        this.Tname=Type;

    }
    public string TransmissionType{
        get { return Tname;}
        set { Tname = value;}
    }

    public void Start()
    {
        Console.WriteLine("Ciaz is Started!");
    }
    public void Accelerate()
    {
        Console.WriteLine("Ciaz is moving!");
    }
    public void Stop()
    {
        Console.WriteLine("Ciaz is Stoped!");
    }

    public override void NewEngine()
    {
        Console.WriteLine("Petrol Engine is added...");
    }
}