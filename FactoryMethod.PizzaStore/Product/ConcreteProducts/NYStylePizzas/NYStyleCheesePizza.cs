namespace FactoryMethod.PizzaStore.Product.ConcreteProducts.NYStylePizzas;

public class NYStyleCheesePizza : Pizza
{
    public NYStyleCheesePizza()
    {
        Name = "NY Style Sauce and Cheese Pizza";
        Dough = "Thin Crust Dough";

        Toppings.Add("Grated Reggiano Cheese");
    }
}