namespace StarBuzz.Coffee;

public abstract class Beverage
{
    protected string description;
    
    public virtual string GetDescription() => "Unknown description";
    
    public abstract double Cost();
}