using FactoryDesignPattern.Ingredients;

namespace FactoryDesignPattern;

public class ChicagoPizzaIngredientFactory : IPizzaIngredientFactory
{
    public Dough CreateDough()
    {
        return new ThickCrustDough();
    }

    public Sauce CreateSauce()
    {
        return new PlumTomatoSauce();
    }

    public Cheese CreateCheese()
    {
        return new MozzarellaCheese();
    }

    public List<Veggies> CreateVeggies()
    {
        return
        [
            new EggPlant(),
            new Spinach(),
            new BlackOlives()
        ];
    }

    public Pepperoni CreatePepperoni()
    {
        return new SlicedPepperoni();
    }

    public Clams CreateClam()
    {
        return new FrozenClams();
    }
}