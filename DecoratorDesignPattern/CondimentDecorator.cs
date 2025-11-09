namespace DecoratorDesignPattern;

public abstract class CondimentDecorator(Beverage beverage) : Beverage(beverage.BeverageSize)
{
    protected readonly Beverage Beverage = beverage;
    
    protected double GetSizeUpcharge()
    {
        return Beverage.BeverageSize switch
        {
            Size.Tall => 0.10,
            Size.Grande => 0.15,
            Size.Venti => 0.20,
            _ => 0.00
        };
    }

    public abstract override string GetDescription();
}