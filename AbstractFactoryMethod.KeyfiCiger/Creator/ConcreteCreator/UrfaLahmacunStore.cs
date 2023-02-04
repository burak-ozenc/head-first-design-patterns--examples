using AbstractFactoryMethod.KeyfiCiger.Factory;
using AbstractFactoryMethod.KeyfiCiger.Factory.ConcreteFactory;
using AbstractFactoryMethod.KeyfiCiger.Product.ConcreteProducts;

namespace AbstractFactoryMethod.KeyfiCiger.Creator.ConcreteCreator;

public class UrfaLahmacunStore : LahmacunStore
{
    protected override Product.Lahmacun CreateLahmacun(string name)
    {
        Product.Lahmacun lahmacun = null;
        LahmacunIngredientFactory ingredientFactory = new UrfaIngredientFactory();
        
        lahmacun = new UrfaLahmacun(ingredientFactory);

        return lahmacun;
    }
}