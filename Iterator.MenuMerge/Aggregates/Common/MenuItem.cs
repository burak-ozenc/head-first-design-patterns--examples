namespace Iterator.MenuMerge.Aggregates.Common;

public class MenuItem
{
    private string Name;
    private string Desc;
    private bool Vegetarian;
    private double Price;

    public MenuItem(string name, string desc, bool vegetarian, double price)
    {
        Name = name;
        Desc = desc;
        Vegetarian = vegetarian;
        Price = price;
    }

    public string GetName() => Name;
    public string GetDesc() => Desc;
    public double GetPrice() => Price;
    public bool IsVegetarian() => Vegetarian;
}