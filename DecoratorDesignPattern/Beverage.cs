namespace DecoratorDesignPattern;

public abstract class Beverage
{
    public Size BeverageSize { get; set; }
    protected string Description = "Unknown Beverage";

    protected Beverage(Size size)
    {
        BeverageSize = size;
    }
    
    public virtual string GetDescription()
    {
        return Description;
    }
    
    public abstract double Cost();

    public override string ToString()
    {
        return $"{GetDescription()} costs {Cost():C}";
    }
}

public enum Size
{
    Tall,
    Grande,
    Venti
}