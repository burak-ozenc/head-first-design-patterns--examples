using AbstractFactoryMethod.KeyfiCiger.Ingredients.ConcreteIngredients;
using AbstractFactoryMethod.KeyfiCiger.Ingredients.AbstractIngredients;

namespace AbstractFactoryMethod.KeyfiCiger.Factory.ConcreteFactory;

public class AdanaIngredientFactory : LahmacunIngredientFactory
{
    public IDough CreateDough() => new Dough();

    public IMincemeat CreateMincemeat() => new Mincemeat();

    public IPepper CreatePepper() => new Isot();
}