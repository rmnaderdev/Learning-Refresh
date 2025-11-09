namespace DecoratorDesignPattern.Beverages;

public class HouseBlend : Beverage
{
    public HouseBlend(Size size) : base(size)
    {
        Description = "House Blend Coffee";
    }
    
    public override double Cost()
    {
        return 0.89;
    }
}