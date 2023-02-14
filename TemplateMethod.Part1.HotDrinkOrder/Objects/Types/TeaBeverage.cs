namespace TemplateMethod.HotDrinkOrder.Objects.Types;

public class TeaBeverage : CaffeineBeverage
{
    protected override void AddCondiments()
    {
        Console.WriteLine("Adding lemon");
    }

    protected override bool CustomerWantsCondiments()
    {
        Console.WriteLine("Do you want lemon in your tea? Please write y/n");
        var input = Console.ReadLine();
        if (input!.StartsWith("y"))
            return true;
        
        return false;
    }

    protected override void Brew()
    {
        Console.WriteLine("Steep tea bag in the water.");
    }
}