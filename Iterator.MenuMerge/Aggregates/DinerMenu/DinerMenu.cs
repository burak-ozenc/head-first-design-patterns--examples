using Iterator.MenuMerge.Aggregates.Common;
using Iterator.MenuMerge.Iterator.ConcreteIterator;

namespace Iterator.MenuMerge.Aggregates.DinerMenu;

public class DinerMenu : IMenu
{
    private readonly int MAX_ITEMS = 6;
    private int numberOfItems = 0;
    private MenuItem[] menuItems;

    public DinerMenu()
    {
        menuItems = new MenuItem[MAX_ITEMS];

        AddItem("1 - Some Dinner", "1 - Some desc", false, 2.99);
        AddItem("2 - Some Dinner", "2 - Some desc", false, 1.99);
        AddItem("2 - Some Dinner", "2 - Some desc", true, 1.99);
    }

    public void AddItem(string name, string desc, bool vegetarian, double price)
    {
        MenuItem menuItem = new MenuItem(name, desc, vegetarian, price);

        if (numberOfItems > MAX_ITEMS)
        {
            Console.WriteLine("sorry, menu is full");
        }
        else
        {
            menuItems[numberOfItems] = menuItem;
            numberOfItems++;
        }
    }

    public Iterator.Iterator CreateIterator()
    {
        return new DinerMenuIterator(menuItems);
    }
}