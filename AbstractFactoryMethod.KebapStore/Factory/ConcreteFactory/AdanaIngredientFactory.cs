using AbstractFactoryMethod.KeyfiCiger.Ingredients.ConcreteIngredients;
using AbstractFactoryMethod.KeyfiCiger.Ingredients.IngredientAbstractions;

namespace AbstractFactoryMethod.KeyfiCiger.Factory.ConcreteFactory;

public class AdanaIngredientFactory : LahmacunIngredientFactory
{
    public IDough CreateDough() => new Dough();

    public IMincemeat CreateMincemeat() => new Mincemeat();

    public virtual IPepper CreatePepper() => new Isot();
    // public IPepper CreatePepper(bool isHot) => isHot ? new Isot() : new GreenPepper();
}