using StrategyDesignPattern.DuckExample.DuckBehaviors;

namespace StrategyDesignPattern.DuckExample;

public class ModelDuck : Duck
{
    public ModelDuck()
    {
        FlyBehavior = new NoFly();
        QuackBehavior = new QuackSound();
    }
    
    public override void Display()
    {
        Console.WriteLine("I'm a Model Duck");
    }
}