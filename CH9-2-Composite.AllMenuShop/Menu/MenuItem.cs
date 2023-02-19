namespace CH9_2_Composite.AllMenuShop.Menu;

public class MenuItem : MenuComponent
{
    private string Name;
    private string Description;
    private bool Vegetarian;
    private double Price;

    public MenuItem(string name, string description, bool vegetarian, double price)
    {
        Name = name;
        Description = description;
        Vegetarian = vegetarian;
        Price = price;
    }

    public override string GetName() => Name;

    public override string GetDescription() => Description;

    public override bool IsVegetarian() => Vegetarian;
    
    public override double GetPrice() => Price;

    public override void Add(MenuComponent menuComponent)
    {
        throw new NotImplementedException();
    }

    public override void Remove(MenuComponent menuComponent)
    {
        throw new NotImplementedException();
    }

    public override void GetChild(int i)
    {
        throw new NotImplementedException();
    }

    public override void Print()
    {
        Console.WriteLine(" " + GetName() + (IsVegetarian() ? ", (v)" : ""));
        Console.WriteLine(GetPrice());
        Console.WriteLine("--" + GetDescription());
    }
}