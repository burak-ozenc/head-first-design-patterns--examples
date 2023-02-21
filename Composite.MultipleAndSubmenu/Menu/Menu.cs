using Composite.MultipleAndSubmenu.Iterator;

namespace Composite.MultipleAndSubmenu.Menu;

public class Menu : MenuComponent
{
    private List<MenuComponent> menuComponents = new();
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

    public override MenuComponent GetChild(int i)
    {
        return menuComponents[i];
    }

    public override string GetName() => Name;
    
    public override string GetDescription() => Description;
    
    public override double GetPrice()
    {
        throw new NotSupportedException();
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

        using var enumerator = menuComponents.GetEnumerator();
        while (enumerator.MoveNext())
        {
            var menuComponent = enumerator.Current;
            menuComponent.Print();
        }
    }
    
    public override IEnumerator<MenuComponent> CreateIterator()
    {
        return new CompositeIterator(menuComponents.GetEnumerator());
        
    }
}