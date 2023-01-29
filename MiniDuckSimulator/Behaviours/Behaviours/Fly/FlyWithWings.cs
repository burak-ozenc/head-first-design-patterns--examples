using MiniDuckSimulator.Behaviours.Abstractions;

namespace MiniDuckSimulator.Behaviours.DynamicBehaviours.Fly;

public class FlyWithWings : FlyBehaviour
{
    public void fly()
    {
        Console.WriteLine("Fly!");
    }
}