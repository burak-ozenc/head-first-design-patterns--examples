using MiniDuckSimulator.Behaviours.Abstractions;

namespace MiniDuckSimulator.Duck.Base;

public abstract class Duck
{
    protected FlyBehaviour _flyBehaviour;
    protected QuackBehaviour _quackBehaviour;

    public Duck(){}
    public abstract void Display();

    public void PerformFly()
    {
        _flyBehaviour.fly();
    }

    public void PerformQuack()
    {
        _quackBehaviour.quack();
    }
    
    public void SetFlyBehaviour(FlyBehaviour fb)
    {
        _flyBehaviour = fb;
    }
    
    public void SetQuackBehaviour(QuackBehaviour qb)
    {
        _quackBehaviour = qb;
    }

    public void Swim()
    {
        Console.WriteLine("ducks likes swimming, right?");
    }
}