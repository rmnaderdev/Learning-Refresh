namespace DecoratorDesignPattern.Condiments;

public class Soy(Beverage beverage) : CondimentDecorator(beverage)
{
    public override string GetDescription()
    {
        return Beverage.GetDescription() + ", Soy";
    }
    
    public override double Cost()
    {
        return Beverage.Cost() + 0.15 + GetSizeUpcharge();;
    }
}