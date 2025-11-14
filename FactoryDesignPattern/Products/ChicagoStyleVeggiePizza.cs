namespace FactoryDesignPattern.Products;

public class ChicagoStyleVeggiePizza : Pizza
{
    public ChicagoStyleVeggiePizza()
    {
        Name = "Chicago Style Veggie Pizza";
        Dough = "Extra Thick Crust Dough";
        Sauce = "Plum Tomato Sauce";

        Toppings.Add("Shredded Mozzarella Cheese");
        Toppings.Add("Black Olives");
        Toppings.Add("Spinach");
        Toppings.Add("Eggplant");
        Toppings.Add("Sliced Tomatoes");
    }
}