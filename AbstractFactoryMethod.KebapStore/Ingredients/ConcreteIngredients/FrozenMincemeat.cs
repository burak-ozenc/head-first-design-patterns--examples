using AbstractFactoryMethod.KeyfiCiger.Ingredients.IngredientAbstractions;

namespace AbstractFactoryMethod.KeyfiCiger.Ingredients.ConcreteIngredients;

public class FrozenMincemeat : IMincemeat
{
    public string ConvertToString()
    {
        return "Adana'dan gelen dondurulmus etler cozdurulup lahmacuna ekleniyor.";
    }
}