using StarBuzz.Coffee;
using StarBuzz.Decorators;

namespace StarBuzz.Condiments;

public class Soy : CondimentDecorator
{
    readonly Beverage _beverage;

    public Soy(Beverage beverage)
    {
        _beverage = beverage;
    }

    public override string GetDescription() => _beverage.GetDescription() + ", Soy";

    public override double Cost() => 0.28 + _beverage.Cost();
}