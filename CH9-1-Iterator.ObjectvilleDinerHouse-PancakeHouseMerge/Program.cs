// See https://aka.ms/new-console-template for more information

using Iterator.ObjectvilleDinerHouse_PancakeHouseMerge;
using Iterator.ObjectvilleDinerHouse_PancakeHouseMerge.Aggregates.DinerMenu;
using Iterator.ObjectvilleDinerHouse_PancakeHouseMerge.Aggregates.PancakeHouseMenu;

Console.WriteLine("Hello, World!");

DinerMenu dinerMenu = new DinerMenu();
PancakeHouseMenu pancakeHouseMenu = new PancakeHouseMenu();
Client waitress = new Client(pancakeHouseMenu,dinerMenu);

waitress.PrintMenu(); 