using StrategyDesignPattern.DuckExample.Interfaces;

namespace StrategyDesignPattern.DuckExample.DuckBehaviors;

public class MuteQuack : IQuackBehavior
{
    public void Quack()
    {
        Console.WriteLine("<< Silence >>");
    }
}