namespace StarBuzz.Coffee.Types;

public class Espresso : Beverage
{
    public Espresso() {}

    public override string GetDescription() => "Espresso";
    
    public override double Cost() => 0.8;
}