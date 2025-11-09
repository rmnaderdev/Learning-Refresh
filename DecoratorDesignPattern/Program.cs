using DecoratorDesignPattern.Beverages;
using DecoratorDesignPattern.Condiments;

namespace DecoratorDesignPattern;

class Program
{
    static void Main(string[] args)
    {
        // Double Mocha soy latte with whip
        Beverage order = new HouseBlend(Size.Venti);
        order = new Soy(order);
        order = new Mocha(order);
        order = new Mocha(order);
        order = new Whip(order);
        Console.WriteLine(order);
        
        // Simple espresso
        Espresso simpleEspresso = new Espresso(Size.Tall);
        Console.WriteLine(simpleEspresso);
        
        // House Blend with whip and mocha
        Beverage anotherOrder = new HouseBlend(Size.Grande);
        anotherOrder = new Whip(anotherOrder);
        anotherOrder = new Mocha(anotherOrder);
        Console.WriteLine(anotherOrder);
    }
}