using FactoryMethod.PizzaStore.Product.ConcreteProducts.NYStylePizzas;

namespace FactoryMethod.PizzaStore.Creator.ConcreteCreators;

public  class NYPizzaStore : PizzaStore
{
    protected override Product.Pizza CreatePizza(string type)
    {
        if (type.Equals("cheese"))
            return new NYStyleCheesePizza();
        else
            return null;
    }
}