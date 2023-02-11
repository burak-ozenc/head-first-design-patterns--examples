using Facade.HomeTheatre.Interfaces;

namespace Facade.HomeTheatre.Objects;

public class Light : ILight
{
    public void Dim(int level)
    {
        Console.WriteLine("Dim set to "+ level);
    }
    
    public void Off()
    {
        Console.WriteLine("Light is off.");
    }
}