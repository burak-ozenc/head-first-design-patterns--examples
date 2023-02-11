using Facade.HomeTheatre.Interfaces;

namespace Facade.HomeTheatre.Objects;

public class Projector : IProjector
{
    private bool isOn;
    public void On()
    {
        isOn = true;
        Console.WriteLine("Projector is on.");
    }
    
    public void WideScreen()
    {
        if(isOn)
            Console.WriteLine("Projector is widescreen. (16x9 aspect ratio)");
    }
    
    public void Off()
    {
        isOn = false;
        Console.WriteLine("Projector is off.");
    }
}