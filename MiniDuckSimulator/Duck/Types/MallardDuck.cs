using MiniDuckSimulator.Behaviours.DynamicBehaviours.Fly;
using MiniDuckSimulator.Behaviours.DynamicBehaviours.Quack;
using MiniDuckSimulator.Duck.Base;

namespace MiniDuckSimulator.Duck.Types;

public class MallardDuck : Base.Duck
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