using FactoryDesignPattern.Products;

namespace FactoryDesignPattern.Stores;

public class NYPizzaStore : PizzaStore
{
    protected override Pizza CreatePizza(string type)
    {
        Pizza pizza = null;
        IPizzaIngredientFactory ingredientFactory = new NYPizzaIndredientFactory();

        if (type.Equals("cheese", StringComparison.OrdinalIgnoreCase))
        {
            pizza = new CheesePizza(ingredientFactory);
            pizza.Name = "New York Style Cheese Pizza";
        }
        else if (type.Equals("pepperoni", StringComparison.OrdinalIgnoreCase))
        {
            pizza = new PepperoniPizza(ingredientFactory);
            pizza.Name = "New York Style Pepperoni Pizza";
        }
        else if (type.Equals("clam", StringComparison.OrdinalIgnoreCase))
        {
            pizza = new ClamPizza(ingredientFactory);
            pizza.Name = "New York Style Clam Pizza";
        }
        else if (type.Equals("veggie", StringComparison.OrdinalIgnoreCase))
        {
            pizza = new VeggiePizza(ingredientFactory);
            pizza.Name = "New York Style Veggie Pizza";
        }
        else
        {
            throw new ArgumentException("Unknown pizza type: " + type);
        }

        return pizza;
    }
}