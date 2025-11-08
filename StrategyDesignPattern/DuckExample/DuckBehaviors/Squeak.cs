using StrategyDesignPattern.DuckExample.Interfaces;

namespace StrategyDesignPattern.DuckExample.DuckBehaviors;

public class Squeak : IQuackBehavior
{
    public void Quack()
    {
        Console.WriteLine("Squeak");
    }
}