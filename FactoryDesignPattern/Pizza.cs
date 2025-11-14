namespace FactoryDesignPattern;

public abstract class Pizza
{
    public string Name { get; set; }
    public string Dough { get; set; }
    public string Sauce { get; set; }
    public List<string> Toppings { get; set; } = new List<string>();
    
    public void Prepare()
    {
        Console.WriteLine($"Preparing {Name}");
        Console.WriteLine("Tossing dough...");
        Console.WriteLine("Adding sauce...");
        Console.WriteLine("Adding toppings:");
        foreach (var topping in Toppings)
        {
            Console.WriteLine($"   {topping}");
        }
    }
    
    public void Bake()
    {
        Console.WriteLine("Baking for 25 minutes at 350");
    }
    
    public void Cut()
    {
        Console.WriteLine("Cutting the pizza into diagonal slices");
    }
    
    public void Box()
    {
        Console.WriteLine("Placing pizza in official PizzaStore box");
    }
    
    public override string ToString()
    {
        return Name;
    }
}