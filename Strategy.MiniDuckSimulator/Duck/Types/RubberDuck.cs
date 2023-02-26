using MiniDuckSimulator.Behaviours.DynamicBehaviours.Fly;
using MiniDuckSimulator.Behaviours.DynamicBehaviours.Quack;

namespace MiniDuckSimulator.Duck.Types;

public class RubberDuck : Base.Duck
{
    public RubberDuck()
    {
        _quackBehaviour = new Quack();
        _flyBehaviour = new FlyNoWay();
    }
    public override void Display()
    {
        Console.WriteLine("this is a rubber yellow duck");
    }

}