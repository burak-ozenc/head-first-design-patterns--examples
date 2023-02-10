using Adapter.TurkeySimulator.Target;

namespace Adapter.TurkeySimulator.ClassAdapter;

public class ClassAdaptor : Target.Target, ITarget
{
    public ClassAdaptor() { }
    
    public void Gobble()
    {
        Console.WriteLine("gobble gobble");
    }

    public void Fly()
    {
        Console.WriteLine("a turkey flies");
    }
}