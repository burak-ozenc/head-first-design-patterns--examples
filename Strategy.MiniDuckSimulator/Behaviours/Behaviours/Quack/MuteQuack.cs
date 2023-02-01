using MiniDuckSimulator.Behaviours.Abstractions;

namespace MiniDuckSimulator.Behaviours.DynamicBehaviours.Quack;

public class MuteQuack : QuackBehaviour
{
    public void quack()
    {
        Console.WriteLine("***");
    }
}