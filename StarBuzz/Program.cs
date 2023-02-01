using StarBuzz.Coffee;
using StarBuzz.Coffee.Types;
using StarBuzz.Condiments;


Beverage coffee1 = new DarkRoast();
Console.WriteLine($"{coffee1.GetDescription()} with Price: {coffee1.Cost()}");
Console.WriteLine();
Console.WriteLine();

Beverage coffee2 = new DarkRoast();
{
    coffee2 = new Mocha(coffee2);
    
    Console.WriteLine($"{coffee2.GetDescription()} with Price: {coffee2.Cost()}");
}

Console.WriteLine();
Console.WriteLine();

Beverage coffee3 = new Decaf();
{
    coffee3 = new Milk(coffee3);
    coffee3 = new Whip(coffee3);
    
    Console.WriteLine($"{coffee3.GetDescription()} with Price: {Math.Round(coffee3.Cost(), 3) }");
}