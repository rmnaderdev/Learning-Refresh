namespace FactoryDesignPattern.Products;

public class CheesePizza : Pizza
{
    private readonly IPizzaIngredientFactory _pizzaIngredientFactory;

    public CheesePizza(IPizzaIngredientFactory pizzaIngredientFactory)
    {
        _pizzaIngredientFactory = pizzaIngredientFactory;
        Name = "Cheese Pizza";
    }

    public override void Prepare()
    {
        Console.WriteLine($"Preparing {Name}");
        Dough = _pizzaIngredientFactory.CreateDough();
        Sauce = _pizzaIngredientFactory.CreateSauce();
        Cheese = _pizzaIngredientFactory.CreateCheese();
    }
}