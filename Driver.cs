using System;
public class Driver
{
    
    public static void Main()
    {
        Ciaz obj = new Ciaz("It is in Automatic Transmission");
        obj.NewEngine();
        obj.Start();
        obj.Accelerate();
        obj.Stop();
        Console.WriteLine(obj.TransmissionType);
        Console.WriteLine();

        TataNexon nexon = new TataNexon("It is in Manual Transmission");
        nexon.NewEngine();
        nexon.Start();
        nexon.Accelerate();
        nexon.Stop();
        Console.WriteLine(nexon.TransmissionType);
        Console.WriteLine();
        
        ChevyBeat beat = new ChevyBeat("It is in Automatic Transmission");
        beat.NewEngine();
        beat.Start();
        beat.Accelerate();
        beat.Stop();
        Console.WriteLine(beat.TransmissionType);
        Console.WriteLine();
       
    }
}