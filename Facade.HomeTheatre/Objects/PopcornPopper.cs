using Facade.HomeTheatre.Interfaces;

namespace Facade.HomeTheatre.Objects;

public class PopcornPopper : IPopcornPopper
{
    private bool isOn;
    public void On()
    {
        Console.WriteLine("Popper is on.");
        isOn = true;
    }
    
    public void Pop()
    {
        if(isOn)
            Console.WriteLine("Popper is popping.");
        
    }
    
    public void Off()
    {
        Console.WriteLine("Popper is off.");
        isOn = false;
    }
}