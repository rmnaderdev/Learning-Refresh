using StrategyDesignPattern.DuckExample.Interfaces;

namespace StrategyDesignPattern.DuckExample.DuckBehaviors;

public class FlyWithWings : IFlyBehavior
{
    public void Fly()
    {
        Console.WriteLine("Flying with wings");
    }
}