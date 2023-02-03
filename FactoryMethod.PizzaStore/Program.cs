using FactoryMethod.PizzaStore.Creator;
using FactoryMethod.PizzaStore.Creator.ConcreteCreators;

PizzaStore nyStore = new NYPizzaStore();
{
    var pizza1 = nyStore.OrderPizza("cheese");

    Console.WriteLine("Ordered an " + pizza1.GetName());
}

Console.WriteLine();
Console.WriteLine();

PizzaStore chStore = new ChicagoPizzaStore();
{
    var pizza2 = chStore.OrderPizza("cheese");
    
    Console.WriteLine("Ordered an " + pizza2.GetName());
}
