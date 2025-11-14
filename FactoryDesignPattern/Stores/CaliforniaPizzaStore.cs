using FactoryDesignPattern.Products;

namespace FactoryDesignPattern.Stores;

public class CaliforniaPizzaStore : PizzaStore
{
    protected override Pizza CreatePizza(string type)
    {
        Pizza pizza = null;

        if (type.Equals("cheese", StringComparison.OrdinalIgnoreCase))
        {
            pizza = new CaliforniaStyleCheesePizza();
        }
        else if (type.Equals("pepperoni", StringComparison.OrdinalIgnoreCase))
        {
            pizza = new CaliforniaStylePepperoniPizza();
        }
        else if (type.Equals("clam", StringComparison.OrdinalIgnoreCase))
        {
            pizza = new CaliforniaStyleClamPizza();
        }
        else if (type.Equals("veggie", StringComparison.OrdinalIgnoreCase))
        {
            pizza = new CaliforniaStyleVeggiePizza();
        }
        else
        {
            throw new ArgumentException("Unknown pizza type: " + type);
        }

        return pizza;
    }
}