using FactoryDesignPattern.Products;

namespace FactoryDesignPattern.Stores;

public class NYPizzaStore : PizzaStore
{
    protected override Pizza CreatePizza(string type)
    {
        Pizza pizza = null;

        if (type.Equals("cheese", StringComparison.OrdinalIgnoreCase))
        {
            pizza = new NYStyleCheesePizza();
        }
        else if (type.Equals("pepperoni", StringComparison.OrdinalIgnoreCase))
        {
            pizza = new NYStylePepperoniPizza();
        }
        else if (type.Equals("clam", StringComparison.OrdinalIgnoreCase))
        {
            pizza = new NYStyleClamPizza();
        }
        else if (type.Equals("veggie", StringComparison.OrdinalIgnoreCase))
        {
            pizza = new NYStyleVeggiePizza();
        }
        else
        {
            throw new ArgumentException("Unknown pizza type: " + type);
        }

        return pizza;
    }
}