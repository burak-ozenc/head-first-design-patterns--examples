using Decorator.StarBuzz.Coffee;
using Decorator.StarBuzz.Decorators;

namespace Decorator.StarBuzz.Condiments;

public class Mocha : CondimentDecorator
{
    private readonly Beverage _beverage;

    public Mocha(Beverage beverage)
    {
        _beverage = beverage;
    }

    public override string GetDescription() => _beverage.GetDescription() + ", Mocha";

    public override double Cost() => 0.20 + _beverage.Cost();
}