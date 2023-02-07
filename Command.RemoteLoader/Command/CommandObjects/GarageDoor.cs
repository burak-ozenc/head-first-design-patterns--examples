namespace Command.RemoteLoader.Command.CommandObjects;

public class GarageDoor
{
    public GarageDoor(){}

    public void On()
    {
        Console.WriteLine("Garage door is open.");
    }
    
    public void Off()
    {
        Console.WriteLine("Garage door is closed.");
    }
}