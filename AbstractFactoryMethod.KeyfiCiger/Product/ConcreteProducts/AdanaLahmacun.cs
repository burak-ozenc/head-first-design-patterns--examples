using AbstractFactoryMethod.KeyfiCiger.Factory;

namespace AbstractFactoryMethod.KeyfiCiger.Product.ConcreteProducts;

public class AdanaLahmacun : Lahmacun
{
    private readonly LahmacunIngredientFactory _lahmacunIngredientFactory;

    public AdanaLahmacun(LahmacunIngredientFactory lahmacunIngredientFactory)
    {
        _lahmacunIngredientFactory = lahmacunIngredientFactory;
    }

    public override void Prepare()
    {
        SetName("Adana Usulu Acili Lahmacun");
        Console.WriteLine(GetName + " hazirlaniyor.");

        Dough = _lahmacunIngredientFactory.CreateDough();
        Console.WriteLine(Dough.ConvertToString());
        Mincemeat = _lahmacunIngredientFactory.CreateMincemeat();
        Console.WriteLine(Mincemeat.ConvertToString());
        Pepper = _lahmacunIngredientFactory.CreatePepper();
        Console.WriteLine(Pepper.ConvertToString());
    }
}