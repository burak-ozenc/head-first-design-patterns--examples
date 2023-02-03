using FactoryMethod.PizzaStore.Product.ConcreteProducts.ChicagoStylePizzas;

namespace FactoryMethod.PizzaStore.Creator.ConcreteCreators;

public class ChicagoPizzaStore : Creator.PizzaStore
{
    protected override Product.Pizza CreatePizza(string type)
    {
        if (type.Equals("cheese"))
            return new ChicagoStyleCheesePizza();
        else
            return null;
    }
}