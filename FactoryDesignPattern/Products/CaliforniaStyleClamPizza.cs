namespace FactoryDesignPattern.Products;

public class CaliforniaStyleClamPizza : Pizza
{
    public CaliforniaStyleClamPizza()
    {
        Name = "California Style Clam Pizza";
        Dough = "Thin Crust Dough";
        Sauce = "White Garlic Sauce";

        Toppings.Add("Fresh Clams");
        Toppings.Add("Garlic");
        Toppings.Add("Oregano");
        Toppings.Add("Parmesan Cheese");
    }
}