namespace Command.RemoteLoader.Command.CommandObjects;

public class Stereo
{
    public Stereo(){}

    public void On()
    {
        Console.WriteLine("Stereo is on");
    }

    public void Off()
    {
        Console.WriteLine("Stereo is off");
    }

    public void SetCD()
    {
        Console.WriteLine("CD set to stereo.");
    }

    public void SetVolume(int volume)
    {
        Console.WriteLine("Stereo volume is set to " + volume);
    }
}