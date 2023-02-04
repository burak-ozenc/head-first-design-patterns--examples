using AbstractFactoryMethod.KeyfiCiger.Factory;

namespace AbstractFactoryMethod.KeyfiCiger.Product.ConcreteProducts;

public class UrfaLahmacun : Lahmacun
{
    private readonly LahmacunIngredientFactory _lahmacunIngredientFactory;

    public UrfaLahmacun(LahmacunIngredientFactory lahmacunIngredientFactory)
    {
        _lahmacunIngredientFactory = lahmacunIngredientFactory;
    }

    public override void Prepare()
    {
        SetName("Urfa Usulu Acisiz Lahmacun");
        Console.WriteLine(GetName + " hazirlaniyor.");

        Dough = _lahmacunIngredientFactory.CreateDough();
        Console.WriteLine(Dough.ConvertToString());
        Mincemeat = _lahmacunIngredientFactory.CreateMincemeat();
        Console.WriteLine(Mincemeat.ConvertToString()); 
        Pepper = _lahmacunIngredientFactory.CreatePepper();
        Console.WriteLine(Pepper.ConvertToString());
    }
}