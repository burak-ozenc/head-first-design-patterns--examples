// See https://aka.ms/new-console-template for more information

using Iterator.ObjectvilleDinerHouse_PancakeHouseMerge;
using Iterator.ObjectvilleDinerHouse_PancakeHouseMerge.ConcreteAggregates.DinerMenu;
using Iterator.ObjectvilleDinerHouse_PancakeHouseMerge.ConcreteAggregates.PancakeHouseMenu;

Console.WriteLine("Hello, World!");

DinerMenu dinerMenu = new DinerMenu();
PancakeHouseMenu pancakeHouseMenu = new PancakeHouseMenu();
Client waitress = new Client(pancakeHouseMenu,dinerMenu);

waitress.PrintMenu(); 