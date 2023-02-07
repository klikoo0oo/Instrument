using System;
interface Instrument
{
    public void play()
    {
        string KEY = "До мажор";
    }
}

class Guitar : Instrument
{
    public byte Strings = 6;
    public void play()
    {
        Console.WriteLine($"Гитара с {Strings} Струнами играет ");
    }
}

class Drum : Instrument
{
    public byte Size = 6;
    public void play()
    {
        Console.WriteLine($"Игрет барабан с размером {Size}");
    }
}

class Pipe : Instrument
{
    public byte Diameter = 6;
    public void play()
    {
        Console.WriteLine($"Играет труба с диаметром {Diameter}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Instrument[] instruments = { new Guitar(), new Pipe(), new Pipe() };
        foreach (Instrument instument in instruments)
        {
            instument.play();
        }
    }
}

