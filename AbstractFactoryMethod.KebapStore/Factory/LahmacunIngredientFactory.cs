using AbstractFactoryMethod.KeyfiCiger.Ingredients.ConcreteIngredients;
using AbstractFactoryMethod.KeyfiCiger.Ingredients.IngredientAbstractions;

namespace AbstractFactoryMethod.KeyfiCiger.Factory;

public interface LahmacunIngredientFactory
{
    public IDough CreateDough();
    public IMincemeat CreateMincemeat();
    public IPepper CreatePepper();
}