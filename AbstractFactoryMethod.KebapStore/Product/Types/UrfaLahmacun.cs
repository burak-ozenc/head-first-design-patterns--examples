using AbstractFactoryMethod.KeyfiCiger.Factory;

namespace AbstractFactoryMethod.KeyfiCiger.Product.Types;

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

        _dough = _lahmacunIngredientFactory.CreateDough();
        Console.WriteLine(_dough.ConvertToString());
        _mincemeat = _lahmacunIngredientFactory.CreateMincemeat();
        Console.WriteLine(_mincemeat.ConvertToString()); 
        _pepper = _lahmacunIngredientFactory.CreatePepper();
        Console.WriteLine(_pepper.ConvertToString());
    }
}