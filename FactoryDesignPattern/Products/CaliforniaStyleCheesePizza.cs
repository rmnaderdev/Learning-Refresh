namespace FactoryDesignPattern.Products;

public class CaliforniaStyleCheesePizza : Pizza
{
    public CaliforniaStyleCheesePizza()
    {
        Name = "California Style Cheese Pizza";
        Dough = "Thin Crust Dough";
        Sauce = "White Garlic Sauce";

        Toppings.Add("Fresh Mozzarella");
        Toppings.Add("Parmesan");
        Toppings.Add("Basil");
    }
}