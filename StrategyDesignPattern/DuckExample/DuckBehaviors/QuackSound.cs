using StrategyDesignPattern.DuckExample.Interfaces;

namespace StrategyDesignPattern.DuckExample.DuckBehaviors;

public class QuackSound : IQuackBehavior
{
    public void Quack()
    {
        Console.WriteLine("Quack");
    }
}