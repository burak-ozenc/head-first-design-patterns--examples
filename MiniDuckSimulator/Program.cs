// MiniDuckSimulator

using MiniDuckSimulator.Behaviours.DynamicBehaviours.Fly;
using MiniDuckSimulator.Ducks.Base;
using MiniDuckSimulator.Ducks.Types;

Duck mallard = new MallardDuck();
{
    mallard.Display();
    mallard.Swim();
    mallard.PerformFly();
    mallard.PerformQuack();
}

Console.WriteLine();
Console.WriteLine();

Duck rubberDuck = new RubberDuck();
{

    rubberDuck.Display();
    rubberDuck.Swim();
    rubberDuck.PerformFly();
    rubberDuck.PerformQuack();
}

Console.WriteLine();
Console.WriteLine();

Duck modelDuck = new ModelDuck();
{

    modelDuck.Display();
    modelDuck.PerformFly();
    modelDuck.SetFlyBehaviour(new FlyRocketPowered());
    modelDuck.PerformFly();
}