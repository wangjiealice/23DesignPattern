using System;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage coffee = new Latte();
            Console.WriteLine("Current coffee is: {0}, cost is {1}.", coffee.GetDescription(), coffee.Cost());

            Beverage latteWithMilk = new Milk(coffee);
            Beverage latteWithMilkAndMocha = new Mocha(latteWithMilk);
            Console.WriteLine("Current coffee is: {0}, cost is {1}.", latteWithMilkAndMocha.GetDescription(), latteWithMilkAndMocha.Cost());

            Beverage latteWithMilkAndDoubleMocha = new Mocha(latteWithMilkAndMocha);
            Console.WriteLine("Current coffee is: {0}, cost is {1}.", latteWithMilkAndDoubleMocha.GetDescription(), latteWithMilkAndDoubleMocha.Cost());
        }
    }
}
