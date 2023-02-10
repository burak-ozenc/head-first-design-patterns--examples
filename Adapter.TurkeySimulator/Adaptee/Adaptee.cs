namespace Adapter.TurkeySimulator.Adaptee;

public class Adaptee : IAdaptee
{
    public void Gobble()
    {
        Console.WriteLine("gobble gobble");
    }

    public void Fly()
    {
        Console.WriteLine("a turkey flies");
    }
}