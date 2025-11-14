namespace FactoryDesignPattern.Products;

public class VeggiePizza : Pizza
{
    public VeggiePizza()
    {
        Name = "Veggie Pizza";
        Dough = "Crust";
        Sauce = "Marinara Sauce";
        Toppings.Add("Shredded Mozzarella");
        Toppings.Add("Grated Parmesan");
        Toppings.Add("Diced Onion");
        Toppings.Add("Sliced Mushrooms");
        Toppings.Add("Sliced Red Pepper");
        Toppings.Add("Sliced Black Olives");
    }
}