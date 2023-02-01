namespace StarBuzz.Coffee.Types;

public class DarkRoast : Beverage
{
    public DarkRoast() { }

    public override string GetDescription() => "Dark Roast Coffee";
    
    public override double Cost() => 1.99;
}