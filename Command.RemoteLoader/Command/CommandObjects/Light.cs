namespace Command.RemoteLoader.Command.CommandObjects;

public class Light
{
    public Light() {}
    
    public void On(string place)
    {
        Console.WriteLine(place +  " lights on.");
    }
    public void Off(string place)
    {
        Console.WriteLine(place + " lights off.");
    }
}