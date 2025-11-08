using StrategyDesignPattern.DuckExample.DuckBehaviors;

namespace StrategyDesignPattern.DuckExample;

public class MallardDuck : Duck
{
    public MallardDuck()
    {
        FlyBehavior = new FlyWithWings();
        QuackBehavior = new QuackSound();
    }
    
    public override void Display()
    {
        Console.WriteLine("I am a Mallard Duck");
    }
}