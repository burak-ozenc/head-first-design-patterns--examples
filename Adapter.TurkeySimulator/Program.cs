using Adapter.TurkeySimulator.Adaptee;
using Adapter.TurkeySimulator.ClassAdapter;
using Adapter.TurkeySimulator.ObjectAdapter;
using Adapter.TurkeySimulator.Target;


Target _someKindOfDuck = new Target();
Adaptee _someKindOfTurkey = new Adaptee();

ITarget _classAdapterOfTurkey = new ClassAdaptor();
ITarget _objectAdapterOfTurkey = new ObjectAdaptor(_someKindOfTurkey);


Console.WriteLine("With standard Target");
testAdapter(_someKindOfDuck);

Console.WriteLine();

Console.WriteLine("With Class Adapter");
testAdapter(_classAdapterOfTurkey);

Console.WriteLine();

Console.WriteLine("With Object Adapter");
testAdapter(_objectAdapterOfTurkey);


static void testAdapter(ITarget target)
{
    target.Fly();
    target.Quack();
}