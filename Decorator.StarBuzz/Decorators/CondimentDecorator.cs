using Decorator.StarBuzz.Coffee;

namespace Decorator.StarBuzz.Decorators;

public abstract class CondimentDecorator : Beverage
{
    public abstract override string GetDescription();
}