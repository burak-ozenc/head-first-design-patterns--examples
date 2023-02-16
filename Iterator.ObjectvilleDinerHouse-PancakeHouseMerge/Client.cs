using Iterator.ObjectvilleDinerHouse_PancakeHouseMerge.ConcreteAggregates.Common;
using Iterator.ObjectvilleDinerHouse_PancakeHouseMerge.ConcreteAggregates.DinerMenu;
using Iterator.ObjectvilleDinerHouse_PancakeHouseMerge.ConcreteAggregates.PancakeHouseMenu;

namespace Iterator.ObjectvilleDinerHouse_PancakeHouseMerge;

public class Client
{
    private PancakeHouseMenu pancakeHouseMenu;
    private DinerMenu _dinerMenu;

    public Client(PancakeHouseMenu pancakeHouseMenu, DinerMenu dinerHouseMenu)
    {
        this.pancakeHouseMenu = pancakeHouseMenu;
        this._dinerMenu = dinerHouseMenu;
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