namespace FactoryDesignPattern.Products;

public class PepperoniPizza : Pizza
{
    public PepperoniPizza()
    {
        Name = "Pepperoni Pizza";
        Dough = "Crust";
        Sauce = "Marinara Sauce";
        Toppings.Add("Sliced Pepperoni");
        Toppings.Add("Grated Parmesan Cheese");
    }
}