

using Composite.MultipleAndSubmenu;
using Composite.MultipleAndSubmenu.Menu;

MenuComponent pancakeHouseMenu = new Menu("PANCAKE HOUSE MENU","Breakfast");
MenuComponent dinerMenu = new Menu("DINER MENU","Diner");
MenuComponent cafeMenu = new Menu("PANCAKE HOUSE MENU","coffee tea desert");


MenuComponent allMenus = new Menu("ALL MENUS", "All menus combined");
allMenus.Add(pancakeHouseMenu);
allMenus.Add(dinerMenu);
allMenus.Add(cafeMenu);

{
    pancakeHouseMenu.Add(new MenuItem(
        name: "1 - pancake ",
        description: "1 - pancake - desc",
        vegetarian: true,
        price: 3d
    ));
    pancakeHouseMenu.Add(new MenuItem(
        name: "2 - pancake ",
        description: "2 - pancake - desc",
        vegetarian: false,
        price: 5.3d
    ));

    dinerMenu.Add(new MenuItem(
        name: "1 - lunch  ",
        description: "1 - lunch - desc",
        vegetarian: false,
        price: 3.3d
    ));
    dinerMenu.Add(new MenuItem(
        name: "2 - lunch  ",
        description: "2 - lunch - desc",
        vegetarian: false,
        price: 2.3d
    ));

    cafeMenu.Add(new MenuItem(
        name: "1 - cafe  ",
        description: "1 - cafe - desc",
        vegetarian: true,
        price: 1.3d
    ));
    cafeMenu.Add(new MenuItem(
        name: "2 - cafe  ",
        description: "2 - cafe - desc",
        vegetarian: true,
        price: 0.3d
    ));
}




Client client = new Client(allMenus);

client.PrintMenu();
Console.WriteLine();
Console.WriteLine();
client.PrintVegetarianMenu();