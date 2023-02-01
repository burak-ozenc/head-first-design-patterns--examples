namespace StarBuzz.Coffee.Types;

public class Decaf : Beverage
{
    public Decaf(){}

    public override string GetDescription() => "Decaf";
    
    public override double Cost() => 0.8;
}