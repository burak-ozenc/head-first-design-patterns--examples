using AbstractFactoryMethod.KeyfiCiger.Factory;
using AbstractFactoryMethod.KeyfiCiger.Factory.ConcreteFactory;
using AbstractFactoryMethod.KeyfiCiger.Product;
using AbstractFactoryMethod.KeyfiCiger.Product.ConcreteProducts;

namespace AbstractFactoryMethod.KeyfiCiger.Creator.ConcreteCreator;

public class AdanaLahmacunStore : LahmacunStore
{
    protected override Lahmacun CreateLahmacun(string name)
    {
        Lahmacun lahmacun = null;
        LahmacunIngredientFactory ingredientFactory = new AdanaIngredientFactory();
        
        lahmacun = new AdanaLahmacun(ingredientFactory);

        return lahmacun;

    }
}