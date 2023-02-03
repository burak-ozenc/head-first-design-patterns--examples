using AbstractFactoryMethod.KeyfiCiger.Ingredients.ConcreteIngredients;
using AbstractFactoryMethod.KeyfiCiger.Ingredients.IngredientAbstractions;

namespace AbstractFactoryMethod.KeyfiCiger.Factory.ConcreteFactory;

public class IstanbulIngredientFactory : LahmacunIngredientFactory
{
    public IDough CreateDough() => new Dough();

    public IMincemeat CreateMincemeat() => new FrozenMincemeat();

    public IPepper CreatePepper() => new GreenPepper();
}