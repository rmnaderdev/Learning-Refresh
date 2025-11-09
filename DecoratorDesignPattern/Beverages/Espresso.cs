namespace DecoratorDesignPattern.Beverages;

public class Espresso : Beverage
{
    public Espresso(Size size) : base(size)
    {
        Description = "Espresso";
    }
    
    public override double Cost()
    {
        return 1.99;
    }
}