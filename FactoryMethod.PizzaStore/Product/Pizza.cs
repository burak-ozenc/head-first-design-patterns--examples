using System.Collections;

namespace FactoryMethod.PizzaStore.Product;

public abstract class Pizza
{
    protected string Name;
    protected string Dough;
    protected readonly  ArrayList Toppings = new ();

    public void Prepare()
    {
        Console.WriteLine("Preparing " + Name);
        Console.WriteLine("Tossing dough ");
        Console.WriteLine("Adding sauce...");
        Console.WriteLine("Adding toppings :");
        foreach (var topping in Toppings)
        {
            Console.WriteLine(topping);
        }
    }

    public void Bake()
    {
        Console.WriteLine("Bake for 25 mins at 350.");
    }
    
    public void Cut()
    {
        Console.WriteLine("Cutting the pizza into diagonal slices.");
    }
    
    public void Box()
    {
        Console.WriteLine("Place pizza into PizzaStore box.");
    }

    public string GetName() => Name;
}