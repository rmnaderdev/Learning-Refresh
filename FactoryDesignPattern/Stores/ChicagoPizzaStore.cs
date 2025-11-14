using FactoryDesignPattern.Products;

namespace FactoryDesignPattern.Stores;

public class ChicagoPizzaStore : PizzaStore
{
    protected override Pizza CreatePizza(string type)
    {
        Pizza pizza = null;
        IPizzaIngredientFactory ingredientFactory = new ChicagoPizzaIngredientFactory();

        if (type.Equals("cheese", StringComparison.OrdinalIgnoreCase))
        {
            pizza = new CheesePizza(ingredientFactory);
            pizza.Name = "Chicago Style Cheese Pizza";
        }
        else if (type.Equals("pepperoni", StringComparison.OrdinalIgnoreCase))
        {
            pizza = new PepperoniPizza(ingredientFactory);
            pizza.Name = "Chicago Style Pepperoni Pizza";
        }
        else if (type.Equals("clam", StringComparison.OrdinalIgnoreCase))
        {
            pizza = new ClamPizza(ingredientFactory);
            pizza.Name = "Chicago Style Clam Pizza";
        }
        else if (type.Equals("veggie", StringComparison.OrdinalIgnoreCase))
        {
            pizza = new VeggiePizza(ingredientFactory);
            pizza.Name = "Chicago Style Veggie Pizza";
        }
        else
        {
            throw new ArgumentException("Unknown pizza type: " + type);
        }

        return pizza;
    }
}