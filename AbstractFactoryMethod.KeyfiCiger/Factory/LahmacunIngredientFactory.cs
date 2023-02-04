using AbstractFactoryMethod.KeyfiCiger.Ingredients.AbstractIngredients;

namespace AbstractFactoryMethod.KeyfiCiger.Factory;

public interface LahmacunIngredientFactory
{
    public IDough CreateDough();
    public IMincemeat CreateMincemeat();
    public IPepper CreatePepper();
}