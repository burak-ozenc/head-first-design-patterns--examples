namespace TemplateMethod.HotDrinkOrder.Objects;

public abstract class CaffeineBeverage
{
    public void PrepareBeverage()
    {
        BoilWater();
        Brew();
        PourInCup();
        if (CustomerWantsCondiments())
        {
            AddCondiments();
        }
        Console.WriteLine(this.GetType().Name + " is ready");
    }

    protected abstract void AddCondiments();

    private void PourInCup()
    {
        Console.WriteLine("Pouring into a cup.");
    }

    protected abstract bool CustomerWantsCondiments();

    protected abstract void Brew();

    private void BoilWater()
    {
        Console.WriteLine("Boiling some hot water.");
    }
    
    
}