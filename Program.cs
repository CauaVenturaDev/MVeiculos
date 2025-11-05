using MVeiculos.Menus;

var menu = new Menu();

menu.ShowTitle("Welcome to MVeiculos");

var dictionary = new Dictionary<int, Menu>();
dictionary.Add(1, menu);
dictionary.Add(2, menu);
dictionary.Add(3, menu);
dictionary.Add(4, menu);
dictionary.Add(-1, menu);
