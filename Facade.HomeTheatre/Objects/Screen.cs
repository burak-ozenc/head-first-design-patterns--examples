using Facade.HomeTheatre.Interfaces;

namespace Facade.HomeTheatre.Objects;

public class Screen : IScreen
{
    public void Down()
    {
        Console.WriteLine("Theatre screen is going down.");
    }
    public void Up()
    {
        Console.WriteLine("Theatre screen is going up.");
    }
}