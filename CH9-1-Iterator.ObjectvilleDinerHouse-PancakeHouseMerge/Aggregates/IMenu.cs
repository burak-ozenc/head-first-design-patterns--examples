namespace Iterator.ObjectvilleDinerHouse_PancakeHouseMerge.Aggregates;

public interface IMenu
{
    void AddItem(string name, string desc, bool vegetarian, double price);
    Iterator.Iterator CreateIterator();
}