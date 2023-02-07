namespace Command.RemoteLoader.Command.CommandObjects;

public class CeilingFan
{
    public static readonly int off = 0;
    public static readonly int low = 1;
    public static readonly int medium = 2;
    public static readonly int high = 3;

    private string Location;
    private int Speed;
    
    public CeilingFan(string location)
    {
        Location = location;
    }

    public void Off(string location)
    {
        Speed = off;
        Location = location;
        Console.WriteLine("Ceiling fan in " + location + " is on level off.");
    }

    public void Low(string location)
    {
        Speed = low;
        Location = location;
        Console.WriteLine("Ceiling fan in " + location + " is on level low.");
    }

    public void Medium(string location)
    {
        Speed = medium;
        Location = location;
        Console.WriteLine("Ceiling fan in " + location + " is on level medium");
    }

    public void High(string location)
    {
        Speed = high;
        Location = location;
        Console.WriteLine("Ceiling fan in " + location + " is on level high");
    }

    public int GetSpeed()
    {
        return Speed;
    }
}