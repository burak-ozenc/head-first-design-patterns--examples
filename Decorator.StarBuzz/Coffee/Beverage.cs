namespace Decorator.StarBuzz.Coffee;

public abstract class Beverage
{
    // this prop can be virtual
    // but need to set a value to be virtual
    public abstract string GetDescription();

    public abstract double Cost();
}