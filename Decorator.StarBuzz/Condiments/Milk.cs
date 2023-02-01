using Decorator.StarBuzz.Coffee;
using Decorator.StarBuzz.Decorators;

namespace Decorator.StarBuzz.Condiments;

public class Milk : CondimentDecorator
{
    Beverage _beverage;

    public Milk(Beverage beverage)
    {
        _beverage = beverage;
    }

    public override string GetDescription() => _beverage.GetDescription() + ", Milk";

    public override double Cost() => 0.4 + _beverage.Cost();
}