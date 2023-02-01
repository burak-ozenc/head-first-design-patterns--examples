namespace StarBuzz.Coffee.Types;

public class HouseBlend : Beverage
{
    public HouseBlend(){}

    public override string GetDescription() => "House Blend Coffee";
    public override double Cost() => 0.3;
}