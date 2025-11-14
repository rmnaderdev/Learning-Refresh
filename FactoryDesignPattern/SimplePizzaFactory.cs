using FactoryDesignPattern.Products;

namespace FactoryDesignPattern;

public class SimplePizzaFactory
{
    public Pizza CreatePizza(string type)
    {
        Pizza pizza;
        
        if (type.Equals("cheese", StringComparison.OrdinalIgnoreCase))
        {
            pizza = new CheesePizza();
        }
        else if (type.Equals("pepperoni", StringComparison.OrdinalIgnoreCase))
        {
            pizza = new PepperoniPizza();
        }
        else if (type.Equals("clam", StringComparison.OrdinalIgnoreCase))
        {
            pizza = new ClamPizza();
        }
        else if (type.Equals("veggie", StringComparison.OrdinalIgnoreCase))
        {
            pizza = new VeggiePizza();
        }
        else
        {
            throw new ArgumentException("Unknown pizza type: " + type);
        }
        
        return pizza;
    }
}
