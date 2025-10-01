using System;

Prices menu = new()
{
    Drink = 10,
    First = 20,
    Second = 30,
};

Choices client1 = new()
{
    DrinkQuantity = 200,
    FirstQuantity = 250,
};

Choices client2 = new()
{
    DrinkQuantity = 200,
    SecondQuantity = 300,
};

{
    int client_total = client1.DrinkQuantity * menu.Drink + client1.FirstQuantity * menu.First;
    Console.WriteLine("Итоговая стоимость " + client_total);
}

{
    int client_total = client2.DrinkQuantity * menu.Drink + client2.SecondQuantity * menu.Second;
    Console.WriteLine("Итоговая стоимость " + client_total);
}

class Prices
{
    public int Drink;
    public int First;
    public int Second;
}

class Choices
{
    public int DrinkQuantity;
    public int FirstQuantity;
    public int SecondQuantity;
}