namespace FactoryDesignPattern.Products;

public class CaliforniaStyleVeggiePizza : Pizza
{
    public CaliforniaStyleVeggiePizza()
    {
        Name = "California Style Veggie Pizza";
        Dough = "Thin Crust Dough";
        Sauce = "White Garlic Sauce";

        Toppings.Add("Fresh Mozzarella");
        Toppings.Add("Parmesan");
        Toppings.Add("Basil");
        Toppings.Add("Mushrooms");
        Toppings.Add("Red Peppers");
        Toppings.Add("Onions");
        Toppings.Add("Black Olives");
    }
}