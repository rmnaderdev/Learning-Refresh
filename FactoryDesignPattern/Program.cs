namespace FactoryDesignPattern;

class Program
{
    static void Main(string[] args)
    {
        PizzaStore nyStore = new Stores.NYPizzaStore();
        PizzaStore chicagoStore = new Stores.ChicagoPizzaStore();

        Pizza pizza = nyStore.OrderPizza("cheese");
        Console.WriteLine("Ethan ordered a " + pizza.Name + "\n");

        pizza = chicagoStore.OrderPizza("veggie");
        Console.WriteLine("Joel ordered a " + pizza.Name + "\n");
    }
}