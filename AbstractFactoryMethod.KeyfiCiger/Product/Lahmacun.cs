using AbstractFactoryMethod.KeyfiCiger.Ingredients.AbstractIngredients;

namespace AbstractFactoryMethod.KeyfiCiger.Product;

public abstract class Lahmacun
{
    // protected Lahmacun() { }
    
    private string Name;
    protected IDough Dough;
    protected IMincemeat Mincemeat;
    protected IPepper Pepper;

    public abstract void Prepare();

    public void Bake()
    {
        Console.WriteLine("Osman ustamizin huneri, tecrubesi ve nacizane el killariyla hazirlanmis lahmacunumuzu firina veriyoruz.");
    }

    public void Cut()
    {
        Console.WriteLine("Lahmacunu ikiye boluyoruz.");
    }

    public void Box()
    {
        Console.WriteLine("Paketleniyor.");
        Console.WriteLine("Islak mendil istemeyi unutmayin.");
    }

    protected void SetName(string name)
    {
        Name = name;
    }

    public string GetName() => Name;
    
}