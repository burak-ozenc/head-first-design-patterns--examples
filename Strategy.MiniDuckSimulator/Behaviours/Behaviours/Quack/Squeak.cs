using MiniDuckSimulator.Behaviours.Abstractions;

namespace MiniDuckSimulator.Behaviours.DynamicBehaviours.Quack;

public class Squeak : QuackBehaviour
{
    public void quack()
    {
        Console.WriteLine("Squeak");
    }
}