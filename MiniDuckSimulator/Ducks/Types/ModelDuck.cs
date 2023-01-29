using MiniDuckSimulator.Behaviours.DynamicBehaviours.Fly;
using MiniDuckSimulator.Behaviours.DynamicBehaviours.Quack;
using MiniDuckSimulator.Ducks.Base;

namespace MiniDuckSimulator.Ducks.Types;

public class ModelDuck : Duck
{
    public ModelDuck()
    {
        _flyBehaviour = new FlyNoWay();
        _quackBehaviour = new MuteQuack();
    }
    public override void Display()
    {
        Console.WriteLine("this is an example duck to society");
    }
}