namespace Singleton.ChocolateFactory;

public class ChocolateBoiler
{
    private bool empty;
    private bool boiled;

    private static ChocolateBoiler UniqueInstance;

    private ChocolateBoiler()
    {
        empty = true;
        boiled = false;
    }

    public static ChocolateBoiler GetInstance()
    {
        if (UniqueInstance is null)
            UniqueInstance = new ChocolateBoiler();
        return UniqueInstance;
    }

    public void Fill()
    {
        if (IsEmpty())
        {
            empty = false;
            boiled = false;
        }
    }

    public void Boil()
    {
        if (IsEmpty() && IsBoiled())
        {
            // code to handle boiling
            boiled = true;
        }
    }

    public bool IsEmpty()
    {
        return empty;
    }
    
    public bool IsBoiled()
    {
        return boiled;
    }
}