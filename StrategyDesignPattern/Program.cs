using StrategyDesignPattern.DuckExample;
using StrategyDesignPattern.DuckExample.DuckBehaviors;

namespace OOP_DesignPatterns;

class Program
{
    static void Main(string[] args)
    {
        Duck mallard = new MallardDuck();
        mallard.Display();
        mallard.PerformQuack();
        mallard.PerformFly();
        
        Duck rubberDuck = new RubberDuck();
        rubberDuck.Display();
        rubberDuck.PerformQuack();
        rubberDuck.PerformFly();
        
        Duck modelDuck = new ModelDuck();
        modelDuck.Display();
        modelDuck.PerformQuack();
        modelDuck.PerformFly();
        modelDuck.FlyBehavior = new FlyRocketPowered();
        modelDuck.PerformFly();
    }
}