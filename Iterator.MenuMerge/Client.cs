using Iterator.MenuMerge.Aggregates.Common;
using Iterator.MenuMerge.Aggregates.DinerMenu;
using Iterator.MenuMerge.Aggregates.PancakeHouseMenu;

namespace Iterator.MenuMerge;

public class Client
{
    private PancakeHouseMenu _pancakeHouseMenu;
    private DinerMenu _dinerMenu;

    public Client(PancakeHouseMenu pancakeHouseMenu, DinerMenu dinerHouseMenu)
    {
        _pancakeHouseMenu = pancakeHouseMenu;
        _dinerMenu = dinerHouseMenu;
    }

    public void PrintMenu()
    {
        Console.WriteLine("Pancake House Menu");
        Iterator.Iterator pancakeIterator = new PancakeHouseMenu().CreateIterator();
        PrintMenu(pancakeIterator);
        Console.WriteLine();
        Console.WriteLine("Diner Menu");
        Iterator.Iterator dinerIterator = new DinerMenu().CreateIterator();
        PrintMenu(dinerIterator);
        
    }
    
    private void PrintMenu(Iterator.Iterator iterator)
    {
        while (iterator.HasNext())
        {
            MenuItem menuItem = (MenuItem)iterator.Next();
            Console.WriteLine(menuItem.GetName() + " / " +
                              menuItem.GetDesc() + " / " +
                              menuItem.IsVegetarian() + " / " +
                              menuItem.GetPrice());
        }
    }

   
    public void PrintVegetarianMenu()
    {
        Console.WriteLine("Vegetarian Menu");
        Iterator.Iterator dinerIterator = new DinerMenu().CreateIterator();
        PrintMenu(dinerIterator);     
        Console.WriteLine();
    }
    public bool IsItemVegetarian(string name)
    {
        throw new NotImplementedException();
    }
}