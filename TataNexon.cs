using System;
public class TataNexon :Engine, ICar
{
    private string Tname;
    public TataNexon(string Type) {
        this.Tname=Type;
    }
    public string TransmissionType {
        get { return Tname;}
        set { Tname = value;}
    }
    public void Start()
    {
        Console.WriteLine("Nexon is Started!");
    }
    public void Accelerate()
    {
        Console.WriteLine("Nexon is moving!");
    }
    public void Stop()
    {
        Console.WriteLine("Nexon is Stoped!");
    }
    public override void NewEngine()
    {
        Console.WriteLine("Diesel Engine is added...");
    }


}