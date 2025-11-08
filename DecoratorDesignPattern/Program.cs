using DecoratorDesignPattern.Beverages;
using DecoratorDesignPattern.Condiments;

namespace DecoratorDesignPattern;

class Program
{
    static void Main(string[] args)
    {
        // Double Mocha soy latte with whip
        Beverage order = new HouseBlend();
        order = new Soy(order);
        order = new Mocha(order);
        order = new Mocha(order);
        order = new Whip(order);
        
        Console.WriteLine($"{order.GetDescription()} costs {order.Cost():C}");
    }
}