using System.Collections;
using Iterator.MenuMerge.Aggregates.Common;
using Iterator.MenuMerge.Iterator.ConcreteIterator;

namespace Iterator.MenuMerge.Aggregates.PancakeHouseMenu;

public class PancakeHouseMenu : IMenu
{
    private ArrayList menuItems;

    public PancakeHouseMenu()
    {
        menuItems = new ArrayList();

        AddItem("1 - some pancake", "1 - some pancake desc", true, 2.99);
        AddItem("2 - some pancake", "2 - some pancake desc", true, 3.11);
        AddItem("2 - some pancake", "2 - some pancake desc", false, 3.11);
    }

    public void AddItem(string name, string desc, bool vegetarian, double price)
    {
        MenuItem menuItem = new MenuItem(name, desc, vegetarian, price);
        menuItems.Add(menuItem);
    }

    public Iterator.Iterator CreateIterator()
    {
        return new PancakeHouseMenuIterator(menuItems);
    }
}