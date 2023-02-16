
using TemplateMethod.HotDrinkOrder.Objects;
using TemplateMethod.HotDrinkOrder.Objects.Types;

CaffeineBeverage coffee = new CoffeeBeverage();
coffee.PrepareBeverage();

Console.WriteLine();

CaffeineBeverage tea = new TeaBeverage();
tea.PrepareBeverage();
