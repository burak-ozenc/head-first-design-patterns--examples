using Composite.MultipleAndSubmenu.Menu;

namespace Composite.MultipleAndSubmenu;

public class Client
{
    private MenuComponent allMenus;

    public Client(MenuComponent allMenus)
    {
        this.allMenus = allMenus;
    }

    public void PrintMenu()
    {
        allMenus.Print();
    }

    public void PrintVegetarianMenu()
    {
        var iterator = allMenus.CreateIterator();
        Console.WriteLine("Vegetarian Menu");
        while (iterator.MoveNext())
        {
            MenuComponent menuComponent = iterator.Current;
            try
            {
                if(menuComponent.IsVegetarian())
                    menuComponent.Print();
            }
            catch (NotImplementedException)
            {
            }
        }
    }
}