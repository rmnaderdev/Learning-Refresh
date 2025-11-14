using FactoryDesignPattern.Ingredients;

namespace FactoryDesignPattern;

public class NYPizzaIndredientFactory : IPizzaIngredientFactory
{
    public Dough CreateDough()
    {
        return new ThinCrustDough();
    }

    public Sauce CreateSauce()
    {
        return new MarinaraSauce();
    }

    public Cheese CreateCheese()
    {
        return new ReggianoCheese();
    }

    public List<Veggies> CreateVeggies()
    {
        return
        [
            new Garlic(),
            new Onion(),
            new Mushroom(),
            new RedPepper()
        ];
    }

    public Pepperoni CreatePepperoni()
    {
        return new SlicedPepperoni();
    }

    public Clams CreateClam()
    {
        return new FreshClams();
    }
}