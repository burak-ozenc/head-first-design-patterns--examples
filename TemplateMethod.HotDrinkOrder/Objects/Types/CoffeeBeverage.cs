namespace TemplateMethod.HotDrinkOrder.Objects.Types;

public class CoffeeBeverage : CaffeineBeverage
{
    protected override void AddCondiments()
    {
        Console.WriteLine("Adding milk and sugar");
    }

    protected override bool CustomerWantsCondiments()
    {
        Console.WriteLine("Do you want milk and sugar in your coffee. Please write y/n");
        var input = Console.ReadLine();
        if (input!.StartsWith("y"))
            return true;
        
        return false;
    }

    protected override void Brew()
    {
        Console.WriteLine("Brewing coffee.");
    }
}