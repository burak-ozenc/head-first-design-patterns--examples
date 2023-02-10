namespace Adapter.TurkeySimulator.Target;

public class Target : ITarget
{
    public void Quack()
    {
        Console.WriteLine("quack quack");
    }

    public void Fly()
    {
        Console.WriteLine("a duck flies");
    }
}