namespace FactoryMethod.PizzaStore.Creator;

public abstract class PizzaStore
{
    public Product.Pizza OrderPizza(string type)
    {
        var pizza = CreatePizza(type);

        pizza.Prepare();
        pizza.Bake();
        pizza.Cut();
        pizza.Box();

        return pizza;
    }

    protected abstract Product.Pizza CreatePizza(string type);
}