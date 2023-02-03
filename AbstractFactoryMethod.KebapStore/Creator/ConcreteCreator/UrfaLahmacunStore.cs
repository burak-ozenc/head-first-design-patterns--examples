using AbstractFactoryMethod.KeyfiCiger.Factory;
using AbstractFactoryMethod.KeyfiCiger.Factory.ConcreteFactory;
using AbstractFactoryMethod.KeyfiCiger.Product.Types;

namespace AbstractFactoryMethod.KeyfiCiger.Creator.ConcreteCreator;

public class UrfaLahmacunStore : LahmacunStore
{
    protected override Product.Lahmacun CreateLahmacun(string name)
    {
        Product.Lahmacun lahmacun = null;
        LahmacunIngredientFactory ingredientFactory = new IstanbulIngredientFactory();

        
        lahmacun = new UrfaLahmacun(ingredientFactory);

        return lahmacun;
    }
}