using System.Collections;
using CH9_2_Composite.AllMenuShop.Menu;

namespace CH9_2_Composite.AllMenuShop.Iterator.ConcreteIterator;

public class PancakeHouseMenuIIterator : IIterator
{
    private ArrayList items;
    private int position = 0;

    public PancakeHouseMenuIIterator(ArrayList items)
    {
        this.items = items;
    }

    public object Next()
    {
        MenuItem menuItem = (MenuItem)items[position]!;
        position++;
        
        return menuItem;
    }
    
    public bool HasNext()
    {
        if (position >= items.Count || items[position] == null)
            return false;
        
        return true;
    }
    
    
}