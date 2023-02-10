using Adapter.TurkeySimulator.Target;

namespace Adapter.TurkeySimulator.ObjectAdapter;

public class ObjectAdaptor : ITarget
{
    private Adaptee.Adaptee _adaptee;

    public ObjectAdaptor(Adaptee.Adaptee adaptee)
    {
        _adaptee = adaptee;
    }

    public void Quack()
    {
        _adaptee.Gobble();
    }

    public void Fly()
    {
        _adaptee.Fly();
    }
}