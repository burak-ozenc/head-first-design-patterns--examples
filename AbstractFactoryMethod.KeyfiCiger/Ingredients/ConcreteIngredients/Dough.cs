using AbstractFactoryMethod.KeyfiCiger.Ingredients.AbstractIngredients;

namespace AbstractFactoryMethod.KeyfiCiger.Ingredients.ConcreteIngredients;

public class Dough : IDough
{
    public string ConvertToString()
    {
        return "Osman abi incecik bi lahmacun hamuru hazirliyor.";
    }
}