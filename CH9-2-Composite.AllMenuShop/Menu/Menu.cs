using System.Collections;

namespace CH9_2_Composite.AllMenuShop.Menu;

public class Menu : MenuComponent
{
    private ArrayList menuComponents = new();
    private string Name;
    private string Description;

    public Menu(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public override void Add(MenuComponent menuComponent)
    {
        menuComponents.Add(menuComponent);
    }
    
    public override void Remove(MenuComponent menuComponent)
    {
        menuComponents.Remove(menuComponent);
    }

    public override void GetChild(int i)
    {
        throw new NotImplementedException();
    }

    public override string GetName() => Name;
    
    public override string GetDescription() => Description;
    public override double GetPrice()
    {
        throw new NotImplementedException();
    }

    public override bool IsVegetarian()
    {
        throw new NotImplementedException();
    }

    public override void Print()
    {
        Console.WriteLine(" " + GetName());
        Console.WriteLine("--" + GetDescription());
        Console.WriteLine("----------");

        var enumerator = menuComponents.GetEnumerator();
        while (enumerator.MoveNext())
        {
            var menuComponent = ((MenuComponent)enumerator.Current)!;
            menuComponent.Print();
        }
    }
}