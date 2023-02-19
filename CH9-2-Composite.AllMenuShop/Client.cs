using CH9_2_Composite.AllMenuShop.Menu;

namespace CH9_2_Composite.AllMenuShop;

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
}