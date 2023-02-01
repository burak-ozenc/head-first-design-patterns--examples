using MiniDuckSimulator.Behaviours.Abstractions;

namespace MiniDuckSimulator.Behaviours.DynamicBehaviours.Fly;

public class FlyNoWay : FlyBehaviour
{
    public void fly()
    {
        Console.WriteLine("I am tired, not today.");
    }
}