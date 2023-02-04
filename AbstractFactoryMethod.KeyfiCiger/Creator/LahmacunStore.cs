using AbstractFactoryMethod.KeyfiCiger.Product;

namespace AbstractFactoryMethod.KeyfiCiger.Creator;

public abstract class LahmacunStore
{
    public Lahmacun OrderLahmacun(string name)
    {
        Lahmacun lahmacun;

        lahmacun = CreateLahmacun(name);
        
        lahmacun.Prepare();
        lahmacun.Bake();
        lahmacun.Cut();
        lahmacun.Box();

        return lahmacun;
    }
    
    protected abstract Lahmacun CreateLahmacun(string name);
}