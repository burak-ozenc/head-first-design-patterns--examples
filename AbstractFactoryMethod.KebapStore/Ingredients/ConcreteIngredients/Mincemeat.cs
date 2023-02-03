using AbstractFactoryMethod.KeyfiCiger.Ingredients.IngredientAbstractions;

namespace AbstractFactoryMethod.KeyfiCiger.Ingredients.ConcreteIngredients;

public class Mincemeat : IMincemeat
{
    public string ConvertToString()
    {
        return "Gecen hafta kesilen Sarikiz'in etleri lahmacuna ekleniyor. aksldjasdkljaskldajskldasd (hic komik degil).";
    }
}