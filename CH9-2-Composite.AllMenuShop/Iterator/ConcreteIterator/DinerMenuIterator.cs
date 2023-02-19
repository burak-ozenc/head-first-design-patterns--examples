using CH9_2_Composite.AllMenuShop.Menu;

namespace CH9_2_Composite.AllMenuShop.Iterator.ConcreteIterator;

public class DinerMenuIIterator : IIterator
{
    private MenuItem[] items;
    private int position = 0;

    public DinerMenuIIterator(MenuItem[] items)
    {
        this.items = items;
    }
    
    public object Next()
    {
        MenuItem menuItem = items[position];
        position++;
        
        return menuItem;
    }
    
    public bool HasNext()
    {
        if (position >= items.Length || items[position] == null)
            return false;
        
        return true;
    }
}