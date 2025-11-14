using FactoryDesignPattern.Products;

namespace FactoryDesignPattern.Stores;

public class ChicagoPizzaStore : PizzaStore
{
    protected override Pizza CreatePizza(string type)
    {
        Pizza pizza = null;

        if (type.Equals("cheese", StringComparison.OrdinalIgnoreCase))
        {
            pizza = new ChicagoStyleCheesePizza();
        }
        else if (type.Equals("pepperoni", StringComparison.OrdinalIgnoreCase))
        {
            pizza = new ChicagoStylePepperoniPizza();
        }
        else if (type.Equals("clam", StringComparison.OrdinalIgnoreCase))
        {
            pizza = new ChicagoStyleClamPizza();
        }
        else if (type.Equals("veggie", StringComparison.OrdinalIgnoreCase))
        {
            pizza = new ChicagoStyleVeggiePizza();
        }
        else
        {
            throw new ArgumentException("Unknown pizza type: " + type);
        }

        return pizza;
    }
}