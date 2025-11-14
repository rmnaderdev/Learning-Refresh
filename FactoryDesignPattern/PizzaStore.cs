namespace FactoryDesignPattern;

public class PizzaStore
{
    private SimplePizzaFactory _factory;

    public PizzaStore(SimplePizzaFactory factory)
    {
        _factory = factory;
    }

    public Pizza OrderPizza(string type)
    {
        Pizza pizza;
        
        pizza = _factory.CreatePizza("cheese");
        
        pizza.Prepare();
        pizza.Bake();
        pizza.Cut();
        pizza.Box();
        
        return pizza;
    }

}