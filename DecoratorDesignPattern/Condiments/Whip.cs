namespace DecoratorDesignPattern.Condiments;

public class Whip(Beverage beverage) : CondimentDecorator(beverage)
{
    public override string GetDescription()
    {
        return Beverage.GetDescription() + ", Whip";
    }

    public override double Cost()
    {
        return Beverage.Cost() + 0.10;
    }
}