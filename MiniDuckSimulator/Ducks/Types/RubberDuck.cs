using MiniDuckSimulator.Behaviours.Abstractions;
using MiniDuckSimulator.Behaviours.DynamicBehaviours.Fly;
using MiniDuckSimulator.Behaviours.DynamicBehaviours.Quack;
using MiniDuckSimulator.Ducks.Base;

namespace MiniDuckSimulator.Ducks.Types;

public class RubberDuck : Duck
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