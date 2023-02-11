using Facade.HomeTheatre.Interfaces;

namespace Facade.HomeTheatre.Objects;

public class DvdPlayer : IDvdPlayer
{
    private bool isOn;
    
    public void On()
    {
        isOn = true;
        Console.WriteLine("DVD player is on");
    }
    
    public void Off()
    {
        isOn = false;
        Console.WriteLine("DVD player is off");
    }
    
    public void SetDVD(string dvd)
    {
        if(isOn)
            Console.WriteLine("DVD player is now playing " + dvd);
    }
}