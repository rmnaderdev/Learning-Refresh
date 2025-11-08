using StrategyDesignPattern.DuckExample.DuckBehaviors;

namespace StrategyDesignPattern.DuckExample;

public class RubberDuck : Duck
{
    public RubberDuck()
    {
        FlyBehavior = new NoFly();
        QuackBehavior = new Squeak();
    }   
    
    public override void Display()
    {
        Console.WriteLine("Looks like a Rubber Duck");
    }
}