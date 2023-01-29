using MiniDuckSimulator.Behaviours.DynamicBehaviours.Fly;
using MiniDuckSimulator.Behaviours.DynamicBehaviours.Quack;
using MiniDuckSimulator.Ducks.Base;

namespace MiniDuckSimulator.Ducks.Types;

public class MallardDuck : Duck
{
    public MallardDuck()
    {
        _quackBehaviour = new Squeak();
        _flyBehaviour = new FlyWithWings();
    }
    public override void Display()
    {
        Console.WriteLine("this is a mallard duck");
    }
}