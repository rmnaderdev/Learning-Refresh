namespace FactoryDesignPattern;

public abstract class Pizza
{
    public string Name { get; set; }
    public Dough Dough { get; set; }
    public Sauce Sauce { get; set; }
    public List<Veggies> Veggies { get; set; } = new();
    public Cheese Cheese { get; set; }
    public Pepperoni Pepperoni { get; set; }
    public Clams Clams { get; set; }

    public abstract void Prepare();
    
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