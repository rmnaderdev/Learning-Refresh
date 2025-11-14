namespace FactoryDesignPattern.Products;

public class ClamPizza : Pizza
{
    public ClamPizza()
    {
        Name = "Clam Pizza";
        Dough = "Thin Crust";
        Sauce = "White Garlic Sauce";
        Toppings.Add("Fresh Clams");
        Toppings.Add("Grated Parmesan Cheese");
    }
}