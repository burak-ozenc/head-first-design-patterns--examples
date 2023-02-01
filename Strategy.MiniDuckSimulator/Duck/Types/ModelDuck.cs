using MiniDuckSimulator.Behaviours.DynamicBehaviours.Fly;
using MiniDuckSimulator.Behaviours.DynamicBehaviours.Quack;


namespace MiniDuckSimulator.Duck.Types;

public class ModelDuck : Base.Duck
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