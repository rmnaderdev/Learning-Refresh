namespace FactoryDesignPattern.Products;

public class ChicagoStyleClamPizza : Pizza
{
    public ChicagoStyleClamPizza()
    {
        Name = "Chicago Style Deep Dish Clam Pizza";
        Dough = "Extra Thick Crust Dough";
        Sauce = "Plum Tomato Sauce";

        Toppings.Add("Shredded Mozzarella Cheese");
        Toppings.Add("Frozen Clams from Chesapeake Bay");
    }
}