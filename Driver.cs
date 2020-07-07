using System;
public class Driver
{
    public static void Main()
    {
        Ciaz obj = new Ciaz();
        obj.NewEngine();
        Console.WriteLine(obj.Start());
        Console.WriteLine(obj.Accelerate());
        Console.WriteLine(obj.Stop());
        Console.WriteLine();

        TataNexon nexon = new TataNexon();
        nexon.NewEngine();
        Console.WriteLine(nexon.Start());
        Console.WriteLine(nexon.Accelerate());
        Console.WriteLine(nexon.Stop());
        Console.WriteLine();
        
        ChevyBeat beat = new ChevyBeat();
        beat.NewEngine();
        Console.WriteLine(beat.Start());
        Console.WriteLine(beat.Accelerate());
        Console.WriteLine(beat.Stop());
        Console.WriteLine();
       
    }
}