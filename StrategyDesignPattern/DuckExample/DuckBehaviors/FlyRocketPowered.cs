using StrategyDesignPattern.DuckExample.Interfaces;

namespace StrategyDesignPattern.DuckExample.DuckBehaviors;

public class FlyRocketPowered : IFlyBehavior
{
    public void Fly()
    {
        Console.WriteLine("I'm flying with a rocket!");
    }
}