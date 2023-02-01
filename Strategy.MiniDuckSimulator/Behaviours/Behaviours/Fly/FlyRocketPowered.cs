using MiniDuckSimulator.Behaviours.Abstractions;

namespace MiniDuckSimulator.Behaviours.DynamicBehaviours.Fly;

public class FlyRocketPowered : FlyBehaviour
{
    public void fly()
    {
        Console.WriteLine("Fly with rocket fiiiiuw!");
    }
}