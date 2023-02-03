namespace FactoryMethod.PizzaStore.Product.ConcreteProducts.ChicagoStylePizzas;

public class ChicagoStyleCheesePizza : Pizza
{
    public ChicagoStyleCheesePizza()
    {
        Name = "Chicago Style  Deep Dish Cheese Pizza";
        Dough = "Extra Thick Crust Dough";
        Toppings.Add("Shredded Reggiano Cheese");
    }

    public void Cut()
    {
        Console.WriteLine("Cutting pizza into square slices.");
    }
    
}