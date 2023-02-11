using Facade.HomeTheatre.Interfaces;

namespace Facade.HomeTheatre.Objects;

public class Amplifier : IAmplifier
{
    private bool isOn;
    
    public void On()
    {
        isOn = true;
        Console.WriteLine("Amplifier is on.");
    }

    public void SetVolume(int volume)
    {
        if(isOn)
            Console.WriteLine("Amplifier volume set to " + volume);
    }
    
    public void Off()
    {
        isOn = false;
        Console.WriteLine("Amplifier is off.");
    }
}