using AbstractFactoryMethod.KeyfiCiger.Ingredients.IngredientAbstractions;

namespace AbstractFactoryMethod.KeyfiCiger.Product;

public abstract class Lahmacun
{
    protected Lahmacun() { }
    private string Name;
    protected IDough _dough;
    protected IMincemeat _mincemeat;
    protected IPepper _pepper;

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

    public void SetName(string name)
    {
        Name = name;
    }

    public string GetName() => Name;

    public string ConvertToString()
    {
        // 
        return ";";
    }
}