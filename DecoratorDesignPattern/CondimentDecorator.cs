namespace DecoratorDesignPattern;

public abstract class CondimentDecorator(Beverage beverage) : Beverage
{
    protected readonly Beverage Beverage = beverage;

    public abstract override string GetDescription();
}