using System.Collections;
using Iterator.ObjectvilleDinerHouse_PancakeHouseMerge.ConcreteAggregates.Common;
using Iterator.ObjectvilleDinerHouse_PancakeHouseMerge.ConcreteAggregates.PancakeHouseMenu;
using Iterator.ObjectvilleDinerHouse_PancakeHouseMerge.Iterator.ConcreteIterator;

namespace Iterator.ObjectvilleDinerHouse_PancakeHouseMerge.ConcreteAggregates.DinerMenu;

public class DinerMenu
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

    private void AddItem(string name, string desc, bool vegetarian, double price)
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