namespace FactoryDesignPattern;

// This class is not tightly coupled to any concrete Pizza classes
// It relies on subclasses to handle the instantiation of the Pizza objects
public abstract class PizzaStore
{
    public Pizza OrderPizza(string type)
    {
        Pizza pizza;
        
        // Call the abstract factory method to create a pizza
        pizza = CreatePizza(type);
        
        // These items stay the same for all pizza stores
        pizza.Prepare();
        pizza.Bake();
        pizza.Cut();
        pizza.Box();
        
        return pizza;
    }
    
    // Subclasses will override this and handle creating the pizza their way
    protected abstract Pizza CreatePizza(string type);
}