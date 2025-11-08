using StrategyDesignPattern.DuckExample.Interfaces;

namespace StrategyDesignPattern.DuckExample.DuckBehaviors;

public class NoFly : IFlyBehavior
{
    public void Fly()
    {
        Console.WriteLine("I can't fly");
    }
}