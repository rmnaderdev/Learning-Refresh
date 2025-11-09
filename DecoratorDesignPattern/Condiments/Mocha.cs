namespace DecoratorDesignPattern.Condiments;

public class Mocha(Beverage beverage) : CondimentDecorator(beverage)
{
    public override string GetDescription()
    {
        return Beverage.GetDescription() + ", Mocha";
    }

    public override double Cost()
    {
        return Beverage.Cost() + 0.20 + GetSizeUpcharge();
    }
}