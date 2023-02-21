// See https://aka.ms/new-console-template for more information

using Iterator.MenuMerge;
using Iterator.MenuMerge.Aggregates.DinerMenu;
using Iterator.MenuMerge.Aggregates.PancakeHouseMenu;

Console.WriteLine("Hello, World!");

DinerMenu dinerMenu = new DinerMenu();
PancakeHouseMenu pancakeHouseMenu = new PancakeHouseMenu();
Client waitress = new Client(pancakeHouseMenu,dinerMenu);

waitress.PrintMenu(); 