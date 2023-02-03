using AbstractFactoryMethod.KeyfiCiger.Creator;
using AbstractFactoryMethod.KeyfiCiger.Creator.ConcreteCreator;

LahmacunStore adanaLahmacunStore = new AdanaLahmacunStore();

// acili lahmacun
{
    var lahmacun = adanaLahmacunStore.OrderLahmacun("AciliLahmacun");
    
    Console.WriteLine("Adana subemizde, bir adet " + lahmacun.GetName() + "unuz hazir.");
    
}

Console.WriteLine();
Console.WriteLine();

LahmacunStore urfaLahmacunStore = new UrfaLahmacunStore();
{
    var lahmacun = urfaLahmacunStore.OrderLahmacun("AcisizLahmacun");
    
    Console.WriteLine("Urfa subemizde, bir adet " + lahmacun.GetName() + "unuz hazir.");
    
}