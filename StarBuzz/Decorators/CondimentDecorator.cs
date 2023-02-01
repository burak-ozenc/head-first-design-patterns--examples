using StarBuzz.Coffee;

namespace StarBuzz.Decorators;

public abstract class CondimentDecorator : Beverage
{
    public abstract override string GetDescription();
}