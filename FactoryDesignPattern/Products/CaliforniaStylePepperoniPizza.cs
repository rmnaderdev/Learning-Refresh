namespace FactoryDesignPattern.Products;

public class CaliforniaStylePepperoniPizza : Pizza
{
    public CaliforniaStylePepperoniPizza()
    {
        Name = "California Style Pepperoni Pizza";
        Dough = "Thin Crust Dough";
        Sauce = "White Garlic Sauce";

        Toppings.Add("Fresh Mozzarella");
        Toppings.Add("Parmesan");
        Toppings.Add("Basil");
        Toppings.Add("Sliced Pepperoni");
    }
}