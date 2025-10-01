using System;

Prices menu = new()
{
    Drink = 10,
    First = 20,
    Second = 30,
};

{
    int client_drink = 200;
    int client_first = 250;
    int client_total = client_drink * menu.Drink + client_first * menu.First;
    Console.WriteLine("Итоговая стоимость " + client_total);
}

{
    int client_drink = 200;
    int client_second = 300;
    int client_total = client_drink * menu.Drink + client_second * menu.Second;
    Console.WriteLine("Итоговая стоимость " + client_total);
}

class Prices
{
    public int Drink;
    public int First;
    public int Second;
}