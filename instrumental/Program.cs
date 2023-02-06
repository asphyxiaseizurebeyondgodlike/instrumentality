interface Instrument
{
    public void play()
    {

    }

}

class Guitar : Instrument
{
    public int numberOfStrings = 8;
    public void play()
    {
        Console.WriteLine($"Играет гитара с количетсвом струн: {numberOfStrings}");
    }
}

class Drum : Instrument
{
    public double Size = 6.7;
    public void play()
    {
        Console.WriteLine($"Игрет барабан с размером: {Size}");
    }
}

class Pipe : Instrument
{
    public double diameter = 4.3;
    public void play()
    {
        Console.WriteLine($"Играет труба с диаметром: {diameter}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Instrument[] instruments = {new Guitar(),new Drum(),new Pipe() };
        foreach(Instrument instr in instruments )
        {
            instr.play();
        }
    }
}
